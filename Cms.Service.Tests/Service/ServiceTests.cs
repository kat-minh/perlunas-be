using System.Text.Json;
using Cms.Repository;
using Cms.Repository.Enums;
using Cms.Service.Exceptions;
using Cms.Service.Service;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Moq;
using ServiceEntity = Cms.Repository.Entities.Service;
using ScheduleEntity = Cms.Repository.Entities.Schedule;
using ImportantInforEntity = Cms.Repository.Entities.ImportantInfor;
using DepartureScheduleEntity = Cms.Repository.Entities.DepartureSchedule;
using RoomCategoryEntity = Cms.Repository.Entities.RoomCategory;

namespace Cms.Service.Tests.Service;

public class ServiceTests
{
    private static DbContextOptions<AppDbContext> NewDb() =>
        new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;

    private static Mock<IValidator<Request.CreateTourRequest>> TourValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateTourRequest>>();
        mock.Setup(x => x.ValidateAsync(It.IsAny<Request.CreateTourRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Title", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.CreateComboRequest>> ComboValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateComboRequest>>();
        mock.Setup(x => x.ValidateAsync(It.IsAny<Request.CreateComboRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Title", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.CreateHotelRequest>> HotelValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.CreateHotelRequest>>();
        mock.Setup(x => x.ValidateAsync(It.IsAny<Request.CreateHotelRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Title", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Mock<IValidator<Request.UpdateServiceRequest>> UpdateValidatorMock(bool valid = true)
    {
        var mock = new Mock<IValidator<Request.UpdateServiceRequest>>();
        mock.Setup(x => x.ValidateAsync(It.IsAny<Request.UpdateServiceRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(new ValidationResult(valid ? [] : new List<ValidationFailure> { new("Title", "TITLE_REQUIRED") }));
        return mock;
    }

    private static Mock<Cms.Service.CloudinaryService.IService> CloudinaryMock()
    {
        var mock = new Mock<Cms.Service.CloudinaryService.IService>();
        mock.Setup(x => x.DeleteImageByUrlAsync(It.IsAny<string>()))
            .Returns(Task.CompletedTask);
        mock.Setup(x => x.DeleteImagesByUrlsAsync(It.IsAny<IEnumerable<string>>()))
            .Returns(Task.CompletedTask);
        return mock;
    }

    private static Cms.Service.Service.Service CreateSvc(AppDbContext ctx,
        Mock<IValidator<Request.CreateTourRequest>>? t = null,
        Mock<IValidator<Request.CreateComboRequest>>? c = null,
        Mock<IValidator<Request.CreateHotelRequest>>? h = null,
        Mock<IValidator<Request.UpdateServiceRequest>>? u = null,
        Mock<Cms.Service.CloudinaryService.IService>? cl = null) =>
        new(ctx,
            (cl ?? CloudinaryMock()).Object,
            (t ?? TourValidatorMock()).Object,
            (c ?? ComboValidatorMock()).Object,
            (h ?? HotelValidatorMock()).Object,
            (u ?? UpdateValidatorMock()).Object);

    // ==================================================================
    //  CreateTourAsync
    // ==================================================================

    private static Request.CreateTourRequest ValidTourReq => new()
    {
        Title = "Tour Phú Quốc",
        Day = 3, Night = 2,
        Album = ["https://example.com/1.jpg"],
        Region = "Miền Nam",
        Description = "Tour Phú Quốc 3 ngày 2 đêm",
        Infor = "Thông tin chi tiết",
        Highlight = ["Bãi biển đẹp", "Hải sản tươi"],
        Destinations = ["Phú Quốc"],
        HighlightContent = "<p>Điểm nổi bật</p>",
        Code = "PQ01",
        IsPublic = true,
        BestSeller = false,
        Schedules = [new() { Day = "Ngày 1", Titile = "Khởi hành", Sumary = "Sân bay", Description = "Đón khách" }],
        ImportantInfors = [new() { Title = "Lưu ý", SubTitle = "Hành lý", Description = "Không quá 20kg" }],
        DepartureSchedules = [new() { StartTime = "01/06/2026", Code = "PQ01-01", Price = "5,000,000", AccommodationStandards = "4 sao" }]
    };

    [Fact]
    public async Task CreateTourAsync_WithValidRequest_ShouldCreateTourWithChildren()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var result = await svc.CreateTourAsync(ValidTourReq);

        result.Title.Should().Be("Tour Phú Quốc");
        result.Slug.Should().Be("tour-phu-quoc");
        result.Type.Should().Be(ServiceType.Tour);
        result.Day.Should().Be(3);
        result.Night.Should().Be(2);
        result.Album.Should().BeEquivalentTo(["https://example.com/1.jpg"]);
        result.Region.Should().Be("Miền Nam");
        result.Description.Should().Be("Tour Phú Quốc 3 ngày 2 đêm");
        result.Highlight.Should().BeEquivalentTo(["Bãi biển đẹp", "Hải sản tươi"]);
        result.Destinations.Should().BeEquivalentTo(["Phú Quốc"]);
        result.HighlightContent.Should().Be("<p>Điểm nổi bật</p>");
        result.Code.Should().Be("PQ01");
        result.IsPublic.Should().BeTrue();
        result.BestSeller.Should().BeFalse();
        result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(5));

        result.Schedules.Should().ContainSingle(s => s.Day == "Ngày 1" && s.Titile == "Khởi hành");
        result.ImportantInfors.Should().ContainSingle(i => i.Title == "Lưu ý");
        result.DepartureSchedules.Should().ContainSingle(d => d.Price == "5,000,000");

        // Introducetion/Label/Instruct/Feature/PurposeOfTrip/Destination/Form/Classify
        // should be empty for Tours
        result.Introducetion.Should().BeEmpty();
        result.Label.Should().BeEmpty();
        result.Instruct.Should().BeEmpty();
        result.Feature.Should().BeEmpty();
        result.PurposeOfTrip.Should().BeNull();
        result.Destination.Should().BeNull();
        result.Form.Should().BeNull();
        result.Classify.Should().BeNull();
        result.Facilities.Should().BeEmpty();
    }

    [Fact]
    public async Task CreateTourAsync_DuplicateTitle_ShouldAppendSuffix()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour Phú Quốc", Slug = "tour-phu-quoc", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.CreateTourAsync(ValidTourReq);

        result.Slug.Should().Be("tour-phu-quoc-1");
    }

    [Fact]
    public async Task CreateTourAsync_EmptySlugTitle_ShouldFallbackToGuid()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var req = new Request.CreateTourRequest
        {
            Title = "@#$%^&*()", Day = 3, Night = 2, Album = [], Region = "X",
            Description = "", Infor = "", Highlight = [], Destinations = [],
            HighlightContent = "", Code = "", IsPublic = false, BestSeller = false,
            Schedules = [], ImportantInfors = [], DepartureSchedules = []
        };
        var result = await svc.CreateTourAsync(req);

        result.Slug.Should().NotBeNullOrEmpty();
        Guid.TryParse(result.Slug, out _).Should().BeTrue();
    }

    // ==================================================================
    //  CreateComboAsync
    // ==================================================================

    private static Request.CreateComboRequest ValidComboReq => new()
    {
        Title = "Combo Đà Nẵng",
        Night = 3,
        Label = "Hot Deal",
        Album = ["https://example.com/combo1.jpg"],
        Region = "Miền Trung",
        Description = "Combo nghỉ dưỡng",
        Infor = "Chi tiết",
        Highlight = ["Ưu đãi lớn"],
        Code = "DN01",
        PurposeOfTrip = "Nghỉ dưỡng",
        Destination = "Đà Nẵng",
        Form = "Combo",
        Classify = "Cao cấp",
        IsPublic = true,
        BestSeller = true,
        Schedules = [new() { Day = "Ngày 1", Titile = "Nhận phòng", Sumary = "Khách sạn", Description = "" }],
        ImportantInfors = [new() { Title = "Bao gồm", SubTitle = "", Description = "Bữa sáng" }],
        RoomCategories = [new() { Album = [], Titile = "Deluxe", NumberOfCustomer = 2, Acreage = "35m2", NumberOfBed = "1 Queen", Description = "Đẹp", Feature = [], OriginalPrice = "3,000,000", Unit = "đêm" }]
    };

    [Fact]
    public async Task CreateComboAsync_WithValidRequest_ShouldCreateComboWithChildren()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var result = await svc.CreateComboAsync(ValidComboReq);

        result.Title.Should().Be("Combo Đà Nẵng");
        result.Slug.Should().Be("combo-da-nang");
        result.Type.Should().Be(ServiceType.Combo);
        result.Night.Should().Be(3);
        result.Label.Should().Be("Hot Deal");
        result.PurposeOfTrip.Should().Be("Nghỉ dưỡng");
        result.Destination.Should().Be("Đà Nẵng");
        result.Form.Should().Be("Combo");
        result.Classify.Should().Be("Cao cấp");
        result.BestSeller.Should().BeTrue();

        result.Schedules.Should().ContainSingle(s => s.Day == "Ngày 1");
        result.ImportantInfors.Should().ContainSingle(i => i.Title == "Bao gồm");
        result.RoomCategories.Should().ContainSingle(r => r.Titile == "Deluxe" && r.Price == null && r.OriginalPrice == null && r.Unit == null);

        // Combo clears Tour-only fields
        result.Day.Should().Be(0);
        result.Introducetion.Should().BeEmpty();
        result.Instruct.Should().BeEmpty();
        result.Feature.Should().BeEmpty();
        result.Destinations.Should().BeEmpty();
        result.HighlightContent.Should().BeEmpty();
    }

    [Fact]
    public async Task CreateComboAsync_DuplicateTitle_ShouldAppendSuffix()
    {
        // fix(combo): CreateComboAsync now uses GenerateUniqueSlugAsync (like tour/hotel),
        // so a duplicate title appends suffix -1, -2...

        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo Đà Nẵng", Slug = "combo-da-nang", Type = ServiceType.Combo, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.CreateComboAsync(ValidComboReq);

        // InMemory không ép unique-index → slug sinh đúng theo tiêu đề, KHÔNG thêm hậu tố.
        result.Slug.Should().Be("combo-da-nang-1");
        result.Title.Should().Be("Combo Đà Nẵng");
    }

    // ==================================================================
    //  CreateHotelAsync
    // ==================================================================

    private static Request.CreateHotelRequest ValidHotelReq => new()
    {
        Title = "Khách sạn Biển Xanh",
        Introducetion = "Khách sạn 5 sao",
        Album = ["https://example.com/hotel1.jpg"],
        Region = "Miền Trung",
        Instruct = "Nhận phòng lúc 14:00",
        Feature = "Hồ bơi vô cực",
        Facilities = ["Wifi", "Hồ bơi", "Spa"],
        PurposeOfTrip = "Nghỉ dưỡng",
        Destination = "Đà Nẵng",
        Form = "Hotel",
        IsPublic = true,
        BestSeller = false,
        RoomCategories = [new() { Album = [], Titile = "Ocean View", NumberOfCustomer = 2, Acreage = "40m2", NumberOfBed = "1 King", Description = "View biển", Feature = ["Ban công"], Price = "2,500,000", OriginalPrice = "3,500,000", Unit = "đêm" }]
    };

    [Fact]
    public async Task CreateHotelAsync_WithValidRequest_ShouldCreateHotelWithChildren()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var result = await svc.CreateHotelAsync(ValidHotelReq);

        result.Title.Should().Be("Khách sạn Biển Xanh");
        result.Slug.Should().Be("khach-san-bien-xanh");
        result.Type.Should().Be(ServiceType.Hotel);
        result.Introducetion.Should().Be("Khách sạn 5 sao");
        result.Instruct.Should().Be("Nhận phòng lúc 14:00");
        result.Feature.Should().Be("Hồ bơi vô cực");
        result.Facilities.Should().BeEquivalentTo(["Wifi", "Hồ bơi", "Spa"]);
        result.PurposeOfTrip.Should().Be("Nghỉ dưỡng");
        result.Destination.Should().Be("Đà Nẵng");
        result.Form.Should().Be("Hotel");

        result.RoomCategories.Should().ContainSingle(r => r.Titile == "Ocean View" && r.Price == "2,500,000");

        // Hotel clears Tour/Combo-only fields
        result.Day.Should().Be(0);
        result.Night.Should().Be(0);
        result.Label.Should().BeEmpty();
        result.Description.Should().BeEmpty();
        result.Infor.Should().BeEmpty();
        result.Highlight.Should().BeEmpty();
        result.Code.Should().BeEmpty();
        result.Classify.Should().BeNull();
        result.Destinations.Should().BeEmpty();
        result.HighlightContent.Should().BeEmpty();
    }

    [Fact]
    public async Task CreateHotelAsync_DuplicateSlug_ShouldAppendSuffix()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Khách sạn Biển Xanh", Slug = "khach-san-bien-xanh", Type = ServiceType.Hotel, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.CreateHotelAsync(ValidHotelReq);

        result.Slug.Should().Be("khach-san-bien-xanh-1");
    }

    // ==================================================================
    //  GetByKeyAsync
    // ==================================================================

    [Fact]
    public async Task GetByKeyAsync_BySlug_ShouldReturnService()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = id, Title = "Test", Slug = "test-slug", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("test-slug");

        result.Id.Should().Be(id);
    }

    [Fact]
    public async Task GetByKeyAsync_ById_ShouldReturnService()
    {
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = id, Title = "Test", Slug = "test-slug", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync(id.ToString());

        result.Title.Should().Be("Test");
    }

    [Fact]
    public async Task GetByKeyAsync_WhenNotFound_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var act = () => svc.GetByKeyAsync("non-existent");

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Service not found.");
    }

    [Fact]
    public async Task GetByKeyAsync_WhenDeleted_ShouldThrowNotFound()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Deleted", Slug = "deleted", Type = ServiceType.Tour, IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);

        var act = () => svc.GetByKeyAsync("deleted");
        await act.Should().ThrowAsync<NotFoundException>();
    }

    [Fact]
    public async Task GetByKeyAsync_ForTour_ShouldIncludeRelatedHotels()
    {
        var options = NewDb();
        var tourId = Guid.NewGuid();
        var hotelId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = tourId, Title = "Tour A", Slug = "tour-a", Type = ServiceType.Tour, Region = "Mien Trung", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = hotelId, Title = "Hotel A", Slug = "hotel-a", Type = ServiceType.Hotel, Region = "Mien Trung", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("tour-a");

        result.RelatedHotels.Should().ContainSingle(h => h.Id == hotelId);
    }

    [Fact]
    public async Task GetByKeyAsync_ForTourWithNoRegion_ShouldReturnEmptyRelatedHotels()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour No Region", Slug = "tour-no-region", Type = ServiceType.Tour, Region = null, IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("tour-no-region");

        result.RelatedHotels.Should().BeEmpty();
    }

    [Fact]
    public async Task GetByKeyAsync_ForNonTour_ShouldNotIncludeRelated()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo A", Slug = "combo-a", Type = ServiceType.Combo, IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("combo-a");

        result.RelatedTours.Should().BeNull();
        result.RelatedHotels.Should().BeNull();
    }

    [Fact]
    public async Task GetByKeyAsync_ForTour_ShouldRankRelatedToursBySameRegionThenClosestPrice()
    {
        var options = NewDb();
        var tourId = Guid.NewGuid();
        var sameRegionId = Guid.NewGuid();
        var diffRegionCloseId = Guid.NewGuid();
        var diffRegionFarId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            // Current tour: 12tr
            ctx.Services.Add(new ServiceEntity
            {
                Id = tourId, Title = "Tour Chính", Slug = "tour-chinh", Type = ServiceType.Tour,
                Region = "Mien Trung", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = tourId, Price = "12,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

            // Same region: 10tr
            ctx.Services.Add(new ServiceEntity
            {
                Id = sameRegionId, Title = "Tour Cùng Vùng", Slug = "tour-cung-vung", Type = ServiceType.Tour,
                Region = "Mien Trung", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = sameRegionId, Price = "10,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

            // Different region close: 13tr (diff 1tr)
            ctx.Services.Add(new ServiceEntity
            {
                Id = diffRegionCloseId, Title = "Tour Khác Vùng Gần", Slug = "tour-khac-vung-gan", Type = ServiceType.Tour,
                Region = "Mien Nam", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = diffRegionCloseId, Price = "13,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

            // Different region far: 8tr (diff 4tr)
            ctx.Services.Add(new ServiceEntity
            {
                Id = diffRegionFarId, Title = "Tour Khác Vùng Xa", Slug = "tour-khac-vung-xa", Type = ServiceType.Tour,
                Region = "Mien Bac", IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = diffRegionFarId, Price = "8,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });

            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("tour-chinh");

        result.RelatedTours.Should().HaveCount(3);
        // 1st: same region
        result.RelatedTours[0].Id.Should().Be(sameRegionId);
        // 2nd: closest price diff (13tr → diff 1tr)
        result.RelatedTours[1].Id.Should().Be(diffRegionCloseId);
        // 3rd: farther price diff (8tr → diff 4tr)
        result.RelatedTours[2].Id.Should().Be(diffRegionFarId);
    }

    [Fact]
    public async Task GetByKeyAsync_ForTour_ShouldComputePriceFromDepartureSchedule()
    {
        var options = NewDb();
        var tourId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = tourId, Title = "Tour Giá", Slug = "tour-gia", Type = ServiceType.Tour, IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.DepartureSchedules.AddRange(
                new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = tourId, Price = "10,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = tourId, Price = "15,000,000", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("tour-gia");

        result.PriceFrom.Should().Be(10000000);
    }

    [Fact]
    public async Task GetByKeyAsync_ForHotel_ShouldComputePriceFromRoomCategory()
    {
        var options = NewDb();
        var hotelId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = hotelId, Title = "Hotel Giá", Slug = "hotel-gia", Type = ServiceType.Hotel, IsPublic = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.RoomCategories.AddRange(
                new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = hotelId, Price = "3,000,000", Titile = "Phòng A", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = hotelId, Price = "5,000,000", Titile = "Phòng B", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("hotel-gia");

        result.PriceFrom.Should().Be(3000000);
    }

    [Fact]
    public async Task GetByKeyAsync_ForCombo_ShouldFallbackPriceFromOriginalPrice()
    {
        // Combo: giá nằm ở cấp GÓI (service.Price / service.OriginalPrice), KHÔNG lấy từ hạng phòng.
        // PriceFrom = Price > 0 ? Price : (OriginalPrice > 0 ? OriginalPrice : null).
        var options = NewDb();
        var comboId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = comboId, Title = "Combo Giá", Slug = "combo-gia", Type = ServiceType.Combo, IsPublic = true,
                Price = null, OriginalPrice = "4,500,000",
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            // Hạng phòng combo không mang giá → đặt OriginalPrice trên phòng cũng bị bỏ qua.
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = comboId, Price = null, OriginalPrice = "9,000,000", Titile = "Phòng Combo", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("combo-gia");

        result.PriceFrom.Should().Be(4500000);
    }

    [Fact]
    public async Task GetByKeyAsync_ShouldIncludeAllChildren()
    {
        var options = NewDb();
        var tourId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = tourId, Title = "Full Tour", Slug = "full-tour", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Schedules.Add(new ScheduleEntity { Id = Guid.NewGuid(), ServiceId = tourId, Day = "1", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.ImportantInfors.Add(new ImportantInforEntity { Id = Guid.NewGuid(), ServiceId = tourId, Title = "Info", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = tourId, Price = "5tr", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = tourId, Titile = "Room", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetByKeyAsync("full-tour");

        result.Schedules.Should().ContainSingle();
        result.ImportantInfors.Should().ContainSingle();
        result.DepartureSchedules.Should().ContainSingle();
        result.RoomCategories.Should().ContainSingle();
    }

    // ==================================================================
    //  GetAllAsync
    // ==================================================================

    [Fact]
    public async Task GetAllAsync_ShouldReturnPaginated()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            for (int i = 0; i < 5; i++)
                ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = $"Svc {i}", Slug = $"svc-{i}", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow.AddMinutes(-i), UpdatedAt = DateTime.UtcNow.AddMinutes(-i) });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetAllAsync(2, 2);

        result.Value.Items.Should().HaveCount(2);
        result.Value.TotalCount.Should().Be(5);
        result.Value.PageIndex.Should().Be(2);
        result.Value.PageSize.Should().Be(2);
        result.Value.HasNextPage.Should().BeTrue();
        result.Value.HasPreviousPage.Should().BeTrue();
    }

    [Fact]
    public async Task GetAllAsync_InvalidPage_ShouldClamp()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);
        var result = await svc.GetAllAsync(0, 0);

        result.Value.PageIndex.Should().Be(1);
        result.Value.PageSize.Should().Be(10);
    }

    [Fact]
    public async Task GetAllAsync_ShouldExcludeDeleted()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Visible", Slug = "visible", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Deleted", Slug = "deleted", Type = ServiceType.Tour, IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetAllAsync(1, 10);

        result.Value.TotalCount.Should().Be(1);
    }

    // ==================================================================
    //  GetToursAsync
    // ==================================================================

    [Fact]
    public async Task GetToursAsync_ShouldOnlyReturnTours()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour A", Slug = "tour-a", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo B", Slug = "combo-b", Type = ServiceType.Combo, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Hotel C", Slug = "hotel-c", Type = ServiceType.Hotel, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetToursAsync(null, null, null, null, 1, 10);

        result.Value.Items.Should().HaveCount(1);
        result.Value.TotalCount.Should().Be(1);
    }

    [Fact]
    public async Task GetToursAsync_KeywordFilterByTitle()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour Phú Quốc", Slug = "tour-phu-quoc", Type = ServiceType.Tour, Region = "Miền Nam", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour Nha Trang", Slug = "tour-nha-trang", Type = ServiceType.Tour, Region = "Miền Trung", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetToursAsync("Phú Quốc", null, null, null, 1, 10);

        result.Value.Items.Should().ContainSingle();
    }

    [Fact]
    public async Task GetToursAsync_KeywordFilterByRegion()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour A", Slug = "tour-a", Type = ServiceType.Tour, Region = "Miền Trung", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour B", Slug = "tour-b", Type = ServiceType.Tour, Region = "Miền Nam", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetToursAsync("Miền Trung", null, null, null, 1, 10);

        result.Value.Items.Should().ContainSingle();
    }

    [Fact]
    public async Task GetToursAsync_CityFilterByDestinations()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour Đà Lạt", Slug = "tour-da-lat", Type = ServiceType.Tour, Region = "Tây Nguyên", Destinations = new List<string> { "da-lat" }, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour Đà Nẵng", Slug = "tour-da-nang", Type = ServiceType.Tour, Region = "Miền Trung", Destinations = new List<string> { "da-nang", "hue" }, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetToursAsync(null, null, "da-nang", null, 1, 10);

        result.Value.Items.Should().ContainSingle();
    }

    [Fact]
    public async Task GetToursAsync_BestSellerFilter()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour nổi bật", Slug = "tour-noi-bat", Type = ServiceType.Tour, BestSeller = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour thường", Slug = "tour-thuong", Type = ServiceType.Tour, BestSeller = false, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);

        (await svc.GetToursAsync(null, null, null, true, 1, 10)).Value.TotalCount.Should().Be(1);
        (await svc.GetToursAsync(null, null, null, false, 1, 10)).Value.TotalCount.Should().Be(1);
        (await svc.GetToursAsync(null, null, null, null, 1, 10)).Value.TotalCount.Should().Be(2);
    }

    // ==================================================================
    //  GetCombosAsync
    // ==================================================================

    [Fact]
    public async Task GetCombosAsync_ShouldOnlyReturnCombos()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo A", Slug = "combo-a", Type = ServiceType.Combo, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour B", Slug = "tour-b", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetCombosAsync(null, null, null, null, null, 1, 10);

        result.Value.TotalCount.Should().Be(1);
    }

    [Fact]
    public async Task GetCombosAsync_WithMultipleFilters_ShouldIntersect()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo A", Slug = "combo-a", Type = ServiceType.Combo, Destination = "Đà Nẵng", Form = "Combo", Classify = "Cao cấp", PurposeOfTrip = "Nghỉ dưỡng", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo B", Slug = "combo-b", Type = ServiceType.Combo, Destination = "Đà Nẵng", Form = "Combo", Classify = "Tiêu chuẩn", PurposeOfTrip = "Nghỉ dưỡng", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Combo C", Slug = "combo-c", Type = ServiceType.Combo, Destination = "Hà Nội", Form = "Khác", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetCombosAsync(null, "Đà Nẵng", "Combo", "Cao cấp", "Nghỉ dưỡng", 1, 10);

        result.Value.Items.Should().ContainSingle();
    }

    // ==================================================================
    //  GetHotelsAsync
    // ==================================================================

    [Fact]
    public async Task GetHotelsAsync_ShouldOnlyReturnHotels()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Hotel A", Slug = "hotel-a", Type = ServiceType.Hotel, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Tour B", Slug = "tour-b", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetHotelsAsync(null, null, null, null, null, 1, 10);

        result.Value.TotalCount.Should().Be(1);
    }

    [Fact]
    public async Task GetHotelsAsync_WithFilters_ShouldIntersect()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Hotel A", Slug = "hotel-a", Type = ServiceType.Hotel, Destination = "Đà Nẵng", Form = "Hotel", PurposeOfTrip = "Nghỉ dưỡng", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Hotel B", Slug = "hotel-b", Type = ServiceType.Hotel, Destination = "Hà Nội", Form = "Hotel", PurposeOfTrip = "Nghỉ dưỡng", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.GetHotelsAsync(null, "Đà Nẵng", null, null, null, 1, 10);

        result.Value.Items.Should().ContainSingle();
    }

    // ==================================================================
    //  UpdateAsync
    // ==================================================================

    private static Request.UpdateServiceRequest UpdateReq(string title = "Updated Title", ServiceType type = ServiceType.Tour) => new()
    {
        Title = title,
        Type = type,
        Album = ["https://example.com/updated.jpg"],
        Region = "Miền Bắc",
        Day = 4,
        Night = 3,
        Description = "Updated desc",
        Infor = "Updated infor",
        Highlight = ["New Highlight"],
        Destinations = ["Hà Nội"],
        Code = "NEW01",
        IsPublic = false,
        BestSeller = true,
        Schedules = [new() { Day = "Ngày 1", Titile = "Mới", Sumary = "", Description = "" }],
        ImportantInfors = [new() { Title = "Note mới", SubTitle = "", Description = "" }],
        DepartureSchedules = [new() { StartTime = "01/07/2026", Code = "NEW-01", Price = "8,000,000", AccommodationStandards = "5 sao" }]
    };

    [Fact]
    public async Task UpdateAsync_WithValidRequest_ShouldUpdateAndReplaceChildren()
    {
        var options = NewDb();
        var svcId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = svcId, Title = "Old Title", Slug = "old-title", Type = ServiceType.Tour,
                Album = "[]", Region = "Cũ", Day = 1, Night = 1, Description = "Old", Infor = "Old",
                Highlight = [], Code = "OLD", IsPublic = false, BestSeller = false,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.Schedules.Add(new ScheduleEntity { Id = Guid.NewGuid(), ServiceId = svcId, Day = "Cũ", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.ImportantInfors.Add(new ImportantInforEntity { Id = Guid.NewGuid(), ServiceId = svcId, Title = "Cũ", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = svcId, Price = "1tr", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.UpdateAsync(svcId, UpdateReq());

        result.Title.Should().Be("Updated Title");
        // fix(slug): keep slug fixed after creation - Update does NOT regenerate slug.
        result.Slug.Should().Be("old-title");
        result.Region.Should().Be("Miền Bắc");
        result.Day.Should().Be(4);
        result.Night.Should().Be(3);
        result.Description.Should().Be("Updated desc");
        result.IsPublic.Should().BeFalse();
        result.BestSeller.Should().BeTrue();

        result.Schedules.Should().ContainSingle(s => s.Day == "Ngày 1");
        result.ImportantInfors.Should().ContainSingle(i => i.Title == "Note mới");
        result.DepartureSchedules.Should().ContainSingle(d => d.Price == "8,000,000");

        // Old children should be soft-deleted
        var deletedSched = await ctx2.Schedules.IgnoreQueryFilters().Where(x => x.ServiceId == svcId).ToListAsync();
        deletedSched.Should().ContainSingle(s => s.Day == "Cũ" && s.IsDeleted);
    }

    [Fact]
    public async Task UpdateAsync_ForHotel_ShouldReplaceRoomCategories()
    {
        var options = NewDb();
        var hotelId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = hotelId, Title = "Old Hotel", Slug = "old-hotel", Type = ServiceType.Hotel,
                Album = "[]", Region = "Cũ", Introducetion = "Cũ", IsPublic = false,
                CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = hotelId, Titile = "Phòng Cũ", Price = "1tr", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        var hotelUpdate = new Request.UpdateServiceRequest
        {
            Title = "Updated Hotel", Type = ServiceType.Hotel,
            Album = [], Region = "Mới", Introducetion = "Mới", IsPublic = true,
            RoomCategories = [new() { Album = [], Titile = "Phòng Mới", NumberOfCustomer = 2, Acreage = "", NumberOfBed = "", Description = "", Feature = [], Price = "2tr" }]
        };

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.UpdateAsync(hotelId, hotelUpdate);

        result.RoomCategories.Should().ContainSingle(r => r.Titile == "Phòng Mới");
    }

    [Fact]
    public async Task UpdateAsync_WhenNotFound_ShouldThrow()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var act = () => svc.UpdateAsync(Guid.NewGuid(), UpdateReq());

        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Service not found.");
    }

    [Fact]
    public async Task UpdateAsync_DuplicateTitle_ShouldKeepSlugUnchanged()
    {
        var options = NewDb();
        var svcId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.AddRange(
                new ServiceEntity { Id = svcId, Title = "Original", Slug = "original", Type = ServiceType.Tour, Album = "[]", Region = "X", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new ServiceEntity { Id = Guid.NewGuid(), Title = "Existing Title", Slug = "existing-title", Type = ServiceType.Tour, Album = "[]", Region = "Y", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.UpdateAsync(svcId, UpdateReq("Existing Title"));

        // fix(slug): Update never regenerates slug even when title matches another service.
        result.Slug.Should().Be("original");
    }

    [Fact]
    public async Task UpdateAsync_SameTitle_ShouldRegenerateSameSlug()
    {
        var options = NewDb();
        var svcId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity
            {
                Id = svcId, Title = "Same Title", Slug = "same-title", Type = ServiceType.Tour,
                Album = "[]", Region = "X", IsPublic = false, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow
            });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var result = await svc.UpdateAsync(svcId, UpdateReq("Same Title"));

        result.Slug.Should().Be("same-title");
    }

    // ==================================================================
    //  DeleteAsync
    // ==================================================================

    [Fact]
    public async Task DeleteAsync_WhenServiceExists_ShouldSoftDeleteWithChildren()
    {
        var options = NewDb();
        var svcId = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = svcId, Title = "To Delete", Slug = "to-delete", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.Schedules.Add(new ScheduleEntity { Id = Guid.NewGuid(), ServiceId = svcId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.ImportantInfors.Add(new ImportantInforEntity { Id = Guid.NewGuid(), ServiceId = svcId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.DepartureSchedules.Add(new DepartureScheduleEntity { Id = Guid.NewGuid(), ServiceId = svcId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            ctx.RoomCategories.Add(new RoomCategoryEntity { Id = Guid.NewGuid(), ServiceId = svcId, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using (var ctx = new AppDbContext(options))
        {
            var svc = CreateSvc(ctx);
            var msg = await svc.DeleteAsync(svcId);
            msg.Should().Be("Service deleted successfully.");
        }

        await using (var ctx = new AppDbContext(options))
        {
            var svc = await ctx.Services.IgnoreQueryFilters().FirstAsync(x => x.Id == svcId);
            svc.IsDeleted.Should().BeTrue();

            (await ctx.Schedules.IgnoreQueryFilters().CountAsync(x => x.ServiceId == svcId && x.IsDeleted)).Should().Be(1);
            (await ctx.ImportantInfors.IgnoreQueryFilters().CountAsync(x => x.ServiceId == svcId && x.IsDeleted)).Should().Be(1);
            (await ctx.DepartureSchedules.IgnoreQueryFilters().CountAsync(x => x.ServiceId == svcId && x.IsDeleted)).Should().Be(1);
            (await ctx.RoomCategories.IgnoreQueryFilters().CountAsync(x => x.ServiceId == svcId && x.IsDeleted)).Should().Be(1);
        }
    }

    [Fact]
    public async Task DeleteAsync_WhenNotFound_ShouldThrow()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        var act = () => svc.DeleteAsync(Guid.NewGuid());
        await act.Should().ThrowAsync<NotFoundException>().WithMessage("Service not found.");
    }

    // ==================================================================
    //  Additional edge cases
    // ==================================================================

    [Fact]
    public async Task GetAllLists_WithNoData_ShouldReturnEmpty()
    {
        var options = NewDb();
        await using var ctx = new AppDbContext(options);
        var svc = CreateSvc(ctx);

        (await svc.GetAllAsync(1, 10)).Value.Items.Should().BeEmpty();
        (await svc.GetToursAsync(null, null, null, null, 1, 10)).Value.Items.Should().BeEmpty();
        (await svc.GetCombosAsync(null, null, null, null, null, 1, 10)).Value.Items.Should().BeEmpty();
        (await svc.GetHotelsAsync(null, null, null, null, null, 1, 10)).Value.Items.Should().BeEmpty();
    }

    [Fact]
    public async Task Slug_ShouldBeUniqueAcrossAllTypes()
    {
        var options = NewDb();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = Guid.NewGuid(), Title = "Same Title", Slug = "same-title", Type = ServiceType.Tour, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);
        var tourReq = new Request.CreateTourRequest
        {
            Title = "Same Title", Day = 3, Night = 2, Album = [], Region = "X",
            Description = "", Infor = "", Highlight = [], Destinations = [],
            HighlightContent = "", Code = "", IsPublic = false, BestSeller = false,
            Schedules = [], ImportantInfors = [], DepartureSchedules = []
        };
        var result = await svc.CreateTourAsync(tourReq);

        result.Slug.Should().Be("same-title-1");
    }

    [Fact]
    public async Task GetByKeyAsync_DeletedService_ShouldStillBeAccessibleViaIdIfNotDeletedInSameScope()
    {
        // Verify that after soft-delete, GetByKeyAsync throws
        var options = NewDb();
        var id = Guid.NewGuid();
        await using (var ctx = new AppDbContext(options))
        {
            ctx.Services.Add(new ServiceEntity { Id = id, Title = "Gone", Slug = "gone", Type = ServiceType.Tour, IsDeleted = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
            await ctx.SaveChangesAsync();
        }

        await using var ctx2 = new AppDbContext(options);
        var svc = CreateSvc(ctx2);

        var act = () => svc.GetByKeyAsync(id.ToString());
        await act.Should().ThrowAsync<NotFoundException>();
    }
}
