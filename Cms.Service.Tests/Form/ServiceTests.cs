using Cms.Repository;
using FormEntity = Cms.Repository.Entities.Form;
using FormDetailsEntity = Cms.Repository.Entities.FormDetails;
using ServiceEntity = Cms.Repository.Entities.Service;
using RoomCategoryEntity = Cms.Repository.Entities.RoomCategory;
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
            var result = await service.GetAllAsync(1, 10, null, null);

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
            var result = await service.GetAllAsync(1, 10, FormType.Hotel, null);

            result.Value.Should().NotBeNull();
            result.Value.Items.Should().HaveCount(1);
            result.Value.TotalCount.Should().Be(1);

            var firstItem = result.Value.Items[0];
            firstItem.Should().BeOfType<Response.BookingFormResponse>();
            ((Response.BookingFormResponse)firstItem).FullName.Should().Be("Hotel User");
        }
    }

    [Fact]
    public async Task GetAllAsync_WithSearchQuery_ShouldReturnMatchingForms()
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
                    FullName = "Nguyen Van A",
                    Email = "nva@example.com",
                    Phone = "0901234567",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-10)
                },
                new FormEntity
                {
                    Id = Guid.NewGuid(),
                    ServiceId = serviceId,
                    Type = FormType.Tour,
                    FullName = "Tran Thi B",
                    Email = "ttb@test.com",
                    Phone = "0911111111",
                    CreatedAt = DateTime.UtcNow.AddMinutes(-5)
                }
            );

            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var service = CreateService(ctx);

            // Test search by name
            var resultName = await service.GetAllAsync(1, 10, null, "van a");
            resultName.Value.Items.Should().HaveCount(1);
            ((Response.TourFormResponse)resultName.Value.Items[0]).FullName.Should().Be("Nguyen Van A");

            // Test search by email
            var resultEmail = await service.GetAllAsync(1, 10, null, "test.com");
            resultEmail.Value.Items.Should().HaveCount(1);
            ((Response.TourFormResponse)resultEmail.Value.Items[0]).FullName.Should().Be("Tran Thi B");

            // Test search by phone
            var resultPhone = await service.GetAllAsync(1, 10, null, "091111");
            resultPhone.Value.Items.Should().HaveCount(1);
            ((Response.TourFormResponse)resultPhone.Value.Items[0]).FullName.Should().Be("Tran Thi B");
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
            var result = await service.GetAllAsync(1, 10, null, null);

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

    // ==================================================================
    //  CreateAdviseAsync
    // ==================================================================

    [Fact]
    public async Task CreateAdviseAsync_WithValidRequest_ShouldCreateFormAndSendMail()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = CreateService(ctx);

        var req = new Request.CreateAdviseFormRequest
        {
            Where = "Đà Nẵng", Slug = "tu-van-1", Month = "7", Year = "2026",
            FullName = "Nguyễn Văn A", Phone = "0901234567", Email = "a@example.com"
        };

        var result = await service.CreateAdviseAsync(req);

        result.Should().Be("CREATE_ADVISE_FORM_SUCCESS");
        var form = await ctx.Forms.FirstAsync();
        form.Type.Should().Be(FormType.Advise);
        form.FullName.Should().Be("Nguyễn Văn A");
    }

    [Fact]
    public async Task CreateAdviseAsync_ShouldSendMailToBothUserAndAdmin()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);

        var mailMock = new Mock<MailService.IService>();
        mailMock.Setup(x => x.SendMail(It.IsAny<MailContent>()))
            .Returns(Task.CompletedTask);

        var service = new Cms.Service.Form.Service(
            ctx,
            AdviseValidatorMock(true).Object,
            TourValidatorMock().Object,
            BookingValidatorMock().Object,
            mailMock.Object
        );

        var req = new Request.CreateAdviseFormRequest
        {
            Where = "Đà Nẵng", Slug = "tu-van-1", Month = "7", Year = "2026",
            FullName = "Nguyễn Văn A", Phone = "0901234567", Email = "customer@example.com"
        };

        await service.CreateAdviseAsync(req);

        // Verify mail sent to customer
        mailMock.Verify(x => x.SendMail(It.Is<MailContent>(m => m.To == "customer@example.com")), Times.Once);
        // Verify mail sent to admin
        mailMock.Verify(x => x.SendMail(It.Is<MailContent>(m => m.To == "duongbilly18012004@gmail.com")), Times.Once);
    }

    [Fact]
    public async Task CreateAdviseAsync_WhenValidationFails_ShouldThrowValidationException()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        // Use the REAL validator so ValidateAndThrowAsync actually runs the rules.
        var service = new Cms.Service.Form.Service(ctx,
            new Cms.Service.Form.Validations.CreateAdviseFormRequestValidator(),
            TourValidatorMock().Object, BookingValidatorMock().Object, MailServiceMock().Object);

        // Request missing FullName + invalid email => validator throws ValidationException.
        var req = new Request.CreateAdviseFormRequest
        {
            Where = "DN", Slug = "s", Month = "7", Year = "2026",
            FullName = "", Phone = "1", Email = "bad"
        };

        var act = () => service.CreateAdviseAsync(req);

        await act.Should().ThrowAsync<FluentValidation.ValidationException>();
    }

    // ==================================================================
    //  CreateTourAsync
    // ==================================================================

    [Fact]
    public async Task CreateTourAsync_WithValidRequest_ShouldCreateForm()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = serviceId, Title = "Tour", Slug = "tour", Type = ServiceType.Tour });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var service = CreateService(ctx2);
        var req = new Request.CreateTourFormRequest
        {
            FullName = "Trần B", Phone = "0909876543", Email = "b@example.com", ServiceId = serviceId
        };

        var result = await service.CreateTourAsync(req);

        result.Should().Be("CREATE_TOUR_FORM_SUCCESS");
        (await ctx2.Forms.FirstAsync()).Type.Should().Be(FormType.Tour);
    }

    [Fact]
    public async Task CreateTourAsync_WhenServiceNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = CreateService(ctx);
        var req = new Request.CreateTourFormRequest
        {
            FullName = "A", Phone = "1", Email = "a@example.com", ServiceId = Guid.NewGuid()
        };

        var act = () => service.CreateTourAsync(req);

        await act.Should().ThrowAsync<Cms.Service.Exceptions.NotFoundException>().WithMessage("Service not found.");
    }


    // ==================================================================
    //  CreateComboAsync / CreateHotelAsync / CreateBookingAsync
    // ==================================================================

    [Fact]
    public async Task CreateComboAsync_WithValidRequest_ShouldCreateFormWithDetails()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = serviceId, Title = "Combo", Slug = "combo", Type = ServiceType.Combo });
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = serviceId, Titile = "Deluxe" });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var service = CreateService(ctx2);
        var req = new Request.CreateBookingFormRequest
        {
            FullName = "C", Phone = "1", Email = "c@example.com", ServiceId = serviceId,
            FormDetails = new List<Request.CreateFormDetailsRequest>
            {
                new() { RoomCategory = new List<string> { "Deluxe" }, Adults = 2, Price = 1500000 }
            }
        };

        var result = await service.CreateComboAsync(req);

        result.Should().Be("CREATE_COMBO_FORM_SUCCESS");
        var form = await ctx2.Forms.Include(f => f.FormDetails).FirstAsync();
        form.Type.Should().Be(FormType.Combo);
        form.FormDetails.Should().ContainSingle(d => d.RoomCategory!.Contains("Deluxe"));
    }

    [Fact]
    public async Task CreateComboAsync_WhenServiceNotComboType_ShouldThrowBadRequest()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = serviceId, Title = "Hotel", Slug = "hotel", Type = ServiceType.Hotel });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var service = CreateService(ctx2);
        var req = new Request.CreateBookingFormRequest
        {
            FullName = "C", Phone = "1", Email = "c@example.com", ServiceId = serviceId,
            FormDetails = new List<Request.CreateFormDetailsRequest> { new() { RoomCategory = new List<string>() } }
        };

        var act = () => service.CreateComboAsync(req);

        await act.Should().ThrowAsync<Cms.Service.Exceptions.BadRequestException>()
            .WithMessage("SERVICE_MUST_BE_COMBO_TYPE");
    }

    [Fact]
    public async Task CreateComboAsync_WithInvalidRoomCategory_ShouldThrowBadRequest()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = serviceId, Title = "Combo", Slug = "combo", Type = ServiceType.Combo });
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = serviceId, Titile = "Deluxe" });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var service = CreateService(ctx2);
        var req = new Request.CreateBookingFormRequest
        {
            FullName = "C", Phone = "1", Email = "c@example.com", ServiceId = serviceId,
            FormDetails = new List<Request.CreateFormDetailsRequest>
            {
                new() { RoomCategory = new List<string> { "Phòng Không Tồn Tại" } }
            }
        };

        var act = () => service.CreateComboAsync(req);

        await act.Should().ThrowAsync<Cms.Service.Exceptions.BadRequestException>()
            .WithMessage("INVALID_ROOM_CATEGORY*Phòng Không Tồn Tại*");
    }

    [Fact]
    public async Task CreateHotelAsync_WhenServiceNotHotelType_ShouldThrowBadRequest()
    {
        var options = NewDb();
        var serviceId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = serviceId, Title = "Tour", Slug = "tour", Type = ServiceType.Tour });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var service = CreateService(ctx2);
        var req = new Request.CreateBookingFormRequest
        {
            FullName = "C", Phone = "1", Email = "c@example.com", ServiceId = serviceId,
            FormDetails = new List<Request.CreateFormDetailsRequest> { new() { RoomCategory = new List<string>() } }
        };

        var act = () => service.CreateHotelAsync(req);

        await act.Should().ThrowAsync<Cms.Service.Exceptions.BadRequestException>()
            .WithMessage("SERVICE_MUST_BE_HOTEL_TYPE");
    }

    [Fact]
    public async Task CreateBookingAsync_WhenServiceNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var service = CreateService(ctx);
        var req = new Request.CreateBookingFormRequest
        {
            FullName = "C", Phone = "1", Email = "c@example.com", ServiceId = Guid.NewGuid(),
            FormDetails = new List<Request.CreateFormDetailsRequest> { new() { RoomCategory = new List<string>() } }
        };

        var act = () => service.CreateHotelAsync(req);

        await act.Should().ThrowAsync<Cms.Service.Exceptions.NotFoundException>().WithMessage("Service not found.");
    }

}
