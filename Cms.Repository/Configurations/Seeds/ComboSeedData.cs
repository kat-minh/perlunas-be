using System;
using System.Collections.Generic;

namespace Cms.Repository.Configurations.Seeds;

/// <summary>
/// Metadata 14 combo (dùng chung cho seed phòng/lịch trình/điều khoản combo).
/// Days = số ngày theo slug (…-2d/3d/4d). Ci = chỉ số 1..14 để dựng GUID con:
///   phòng   caaa00{ci:D2}, lịch trình cbbb00{ci:D2}, điều khoản cccf00{ci:D2}.
/// </summary>
public static class ComboSeedData
{
    public record Combo(int Ci, Guid Id, string Tier, int Days, string City, string Hotel);

    public static readonly IReadOnlyList<Combo> All = new List<Combo>
    {
        new(1,  Guid.Parse("6fc490b0-6501-7066-2716-f195529f23d3"), "Akoya",     2, "Đà Nẵng",  "Intercontinental Đà Nẵng"),
        new(2,  Guid.Parse("7cd58789-1ecc-9fb2-3546-a5e509fad35d"), "Tahiti",    3, "Hà Nội",   "Sheraton Hà Nội"),
        new(3,  Guid.Parse("14ed53c2-55ae-229f-7de2-15307bd0766a"), "Akoya",     2, "Hà Nội",   "Sheraton Hà Nội"),
        new(4,  Guid.Parse("2892e90c-a3ca-c2b6-9d01-4933ec1fbcb6"), "Tahiti",    4, "Hà Nội",   "Sheraton Hà Nội"),
        new(5,  Guid.Parse("a846c103-c841-b1a6-3479-a7299029ca67"), "South Sea", 3, "Phú Quốc", "InterContinental Phú Quốc"),
        new(6,  Guid.Parse("84aeb32e-aa27-580d-57e9-3c60dd150c81"), "Tahiti",    3, "Phú Quốc", "JW Marriott Phú Quốc"),
        new(7,  Guid.Parse("ffe5e382-0178-4c54-63ca-68bad28cf20a"), "South Sea", 4, "Phú Quốc", "JW Marriott Phú Quốc"),
        new(8,  Guid.Parse("abca9795-459e-619e-fac5-12763e8182cf"), "Akoya",     2, "Nha Trang","Vinpearl Nha Trang"),
        new(9,  Guid.Parse("16d5bd3e-f290-82fa-601c-1866e2698c4b"), "Tahiti",    3, "Nha Trang","Vinpearl Nha Trang"),
        new(10, Guid.Parse("9e8f187b-5655-53e3-3073-0ab2cd5c1db6"), "South Sea", 3, "Đà Lạt",   "Ana Mandara Đà Lạt"),
        new(11, Guid.Parse("083e6b00-8171-b03d-acd6-bcb2698ba71a"), "Akoya",     2, "Đà Lạt",   "Terracotta Đà Lạt"),
        new(12, Guid.Parse("cdb4217d-cea0-1eb8-d64b-f9137e42e049"), "Tahiti",    3, "Hạ Long",  "Sheraton Hạ Long"),
        new(13, Guid.Parse("6189998c-638c-5c9d-f3f6-1f1e1d0ebfac"), "Akoya",     2, "Sa Pa",    "Hôtel de la Coupole Sa Pa"),
        new(14, Guid.Parse("2b6f684a-ed09-2301-0c9f-a8a8fcf0bd0b"), "South Sea", 3, "Đà Nẵng",  "Naman Retreat Đà Nẵng"),
    };

    /// <summary>Mẫu hạng phòng theo hạng ngọc trai (1 phòng cố định / combo).</summary>
    public record RoomTpl(string Name, int Guests, string Size, string Bed, string Feature, string Desc, string Price, string OriginalPrice);

    private static readonly string AlbumStd = @"[""https://images.unsplash.com/photo-1590490360182-c33d57733427?w=1400&q=70"",""https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1400&q=70"",""https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1400&q=70""]";

    public static readonly string RoomAlbum = AlbumStd;

    public static RoomTpl RoomOf(string tier) => tier switch
    {
        "Tahiti" => new("Phòng Premier", 2, "42 m²", "1 giường King",
            @"[""Ban công view"",""Bồn tắm"",""Wifi miễn phí"",""Bàn làm việc"",""Minibar""]",
            "Hạng phòng Premier rộng rãi với ban công hướng cảnh và tiện nghi cao cấp, lý tưởng cho cặp đôi tận hưởng kỳ nghỉ.",
            "4000000", "5000000"),
        "South Sea" => new("Suite hướng biển", 3, "58 m²", "1 giường King + sofa",
            @"[""Phòng khách riêng"",""View đẹp"",""Bồn tắm nằm"",""Đưa đón sân bay"",""Minibar""]",
            "Suite cao cấp nhất với phòng khách riêng và tầm nhìn đẹp, dành cho gia đình hoặc kỳ nghỉ thật đặc biệt.",
            "6000000", "7500000"),
        _ => new("Phòng Deluxe", 2, "32 m²", "1 giường đôi lớn",
            @"[""Wifi miễn phí"",""Điều hòa"",""Ban công"",""Minibar""]",
            "Phòng Deluxe ấm cúng với ban công riêng, đầy đủ tiện nghi cho một kỳ nghỉ đôi thoải mái.",
            "2500000", "3000000"),
    };
}
