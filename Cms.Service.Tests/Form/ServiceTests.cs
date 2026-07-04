using Cms.Repository;
using FormEntity = Cms.Repository.Entities.Form;
using FormDetailsEntity = Cms.Repository.Entities.FormDetails;
using ServiceEntity = Cms.Repository.Entities.Service;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Form;
using Cms.Service.MailService;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace Cms.Service.Tests.Form;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreateAdviseFormRequest>> AdviseValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateAdviseFormRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.CreateAdviseFormRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? new List<ValidationFailure>() : new List<ValidationFailure> { new("FullName", "FULL_NAME_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.CreateTourFormRequest>> TourValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateTourFormRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.CreateTourFormRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? new List<ValidationFailure>() : new List<ValidationFailure>()));
        return mock;
    }

    private static Mock<IValidator<Request.CreateBookingFormRequest>> BookingValidatorMock()
    {
        var mock = new Mock<IValidator<Request.CreateBookingFormRequest>>();
        mock.Setup(x => x.ValidateAsync(
                It.IsAny<ValidationContext<Request.CreateBookingFormRequest>>(),
                It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(new List<ValidationFailure>()));
        return mock;
    }

    private static Mock<MailService.IService> MailServiceMock()
    {
        var mock = new Mock<MailService.IService>();
        mock.Setup(x => x.SendMail(It.IsAny<MailContent>()))
            .Returns(Task.CompletedTask);
        return mock;
    }

    private static Cms.Service.Form.Service CreateService(AppDbContext ctx, bool valid = true)
    {
        var adviseValidatorMock = AdviseValidatorMock(valid);
        var tourValidatorMock = TourValidatorMock();
        var bookingValidatorMock = BookingValidatorMock();
        var mailMock = MailServiceMock();
        return new Cms.Service.Form.Service(ctx, adviseValidatorMock.Object, tourValidatorMock.Object, bookingValidatorMock.Object, mailMock.Object);
    }

    [Fact]
    public async Task GetAllAsync_ShouldReturnPagedForms()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = serviceId,
                Title = "Test Service",
                Slug = "test-service",
                Type = ServiceType.Tour
            });

            ctx.Forms.AddRange(
                new FormEntity
                {
                    Id = Guid.NewGuid(),
                    ServiceId = serviceId,
                    Type = FormType.Tour,
                    FullName = "User A",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-10)
                },
                new FormEntity
                {
                    Id = Guid.NewGuid(),
                    ServiceId = serviceId,
                    Type = FormType.Advise,
                    FullName = "User B",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-5)
                }
            );

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var result = await service.GetAllAsync(1, 10, null);

            result.Value.Should().NotBeNull();
            result.Value.Items.Should().HaveCount(2);
            result.Value.TotalCount.Should().Be(2);

            var firstItem = result.Value.Items[0];
            firstItem.Should().BeOfType<Response.AdviseFormResponse>();
            ((Response.AdviseFormResponse)firstItem).FullName.Should().Be("User B");

            var secondItem = result.Value.Items[1];
            secondItem.Should().BeOfType<Response.TourFormResponse>();
            ((Response.TourFormResponse)secondItem).FullName.Should().Be("User A");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithFilterType_ShouldReturnOnlyMatchingType()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = serviceId,
                Title = "Test Service",
                Slug = "test-service",
                Type = ServiceType.Hotel
            });

            ctx.Forms.AddRange(
                new FormEntity
                {
                    Id = Guid.NewGuid(),
                    ServiceId = serviceId,
                    Type = FormType.Tour,
                    FullName = "Tour User",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-10)
                },
                new FormEntity
                {
                    Id = Guid.NewGuid(),
                    ServiceId = serviceId,
                    Type = FormType.Hotel,
                    FullName = "Hotel User",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-5)
                }
            );

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var result = await service.GetAllAsync(1, 10, FormType.Hotel);

            result.Value.Should().NotBeNull();
            result.Value.Items.Should().HaveCount(1);
            result.Value.TotalCount.Should().Be(1);

            var firstItem = result.Value.Items[0];
            firstItem.Should().BeOfType<Response.BookingFormResponse>();
            ((Response.BookingFormResponse)firstItem).FullName.Should().Be("Hotel User");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithDetails_ShouldIncludeFormDetailsNested()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        var formId = Guid.NewGuid();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = serviceId,
                Title = "Test Hotel",
                Slug = "test-hotel",
                Type = ServiceType.Hotel
            });

            var form = new FormEntity
            {
                Id = formId,
                ServiceId = serviceId,
                Type = FormType.Hotel,
                FullName = "Hotel Guest",
                CreatedAt = DateTime.UtcNow
            };

            var details = new FormDetailsEntity
            {
                Id = Guid.NewGuid(),
                FormId = formId,
                ServiceId = serviceId,
                RoomCategory = new List<string> { "Suite Room" },
                NumberOfRooms = 1,
                Price = 150000,
                Adults = 2
            };

            ctx.Forms.Add(form);
            ctx.FormDetails.Add(details);

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var result = await service.GetAllAsync(1, 10, null);

            result.Value.Items.Should().HaveCount(1);
            var item = result.Value.Items[0].Should().BeOfType<Response.BookingFormResponse>().Subject;

            item.FullName.Should().Be("Hotel Guest");
            item.FormDetails.Should().HaveCount(1);

            var detailDto = item.FormDetails.First();
            detailDto.RoomCategory.Should().ContainSingle(x => x == "Suite Room");
            detailDto.Adults.Should().Be(2);
            detailDto.Price.Should().Be(150000);
        }
    }

    [Fact]
    public async Task GetByKeyAsync_WithValidId_ShouldReturnCorrectForm()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        var formId = Guid.NewGuid();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = serviceId,
                Title = "Test Service",
                Slug = "test-service",
                Type = ServiceType.Tour
            });

            ctx.Forms.Add(new FormEntity
            {
                Id = formId,
                ServiceId = serviceId,
                Type = FormType.Tour,
                FullName = "Find Me By ID",
                CreatedAt = DateTime.UtcNow
            });

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var result = await service.GetByKeyAsync(formId.ToString());

            result.Should().NotBeNull();
            result.Should().BeOfType<Response.TourFormResponse>();
            ((Response.TourFormResponse)result).FullName.Should().Be("Find Me By ID");
        }
    }

    [Fact]
    public async Task GetByKeyAsync_WithValidSlug_ShouldReturnCorrectForm()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();

        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = serviceId,
                Title = "Test Service",
                Slug = "test-service",
                Type = ServiceType.Tour
            });

            ctx.Forms.Add(new FormEntity
            {
                Id = Guid.NewGuid(),
                ServiceId = serviceId,
                Type = FormType.Advise,
                FullName = "Find Me By Slug",
                Slug = "my-awesome-slug",
                CreatedAt = DateTime.UtcNow
            });

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var result = await service.GetByKeyAsync("my-awesome-slug");

            result.Should().NotBeNull();
            result.Should().BeOfType<Response.AdviseFormResponse>();
            ((Response.AdviseFormResponse)result).FullName.Should().Be("Find Me By Slug");
        }
    }

    [Fact]
    public async Task GetByKeyAsync_WhenNotFound_ShouldThrowNotFoundException()
    {
        var options = NewDb();

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);
            var act = () => service.GetByKeyAsync("non-existent-key");

            await act.Should().ThrowAsync<Cms.Service.Exceptions.NotFoundException>()
                .WithMessage("Form not found.");
        }
    }
}
