using Cms.Repository.Entities;
using Cms.Repository.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class FormSeed
{
    public static void SeedForm(this EntityTypeBuilder<Form> builder)
    {
        builder.HasData(
            new Form
            {
                Id = SeedIds.Form1,
                ServiceId = SeedIds.ServiceMain, // Tour: Perlunas Signature Tour
                FullName = "Nguyen Van A",
                Phone = "0901234567",
                Email = "nguyenvana@gmail.com",
                Type = FormType.Tour,
                Where = "Đà Nẵng",
                Slug = "signature-tour-booking",
                Month = "08",
                Year = "2026",
                LongTime = "3 ngày 2 đêm",
                Note = "Cần phòng hướng biển",
                TotalPrice = 5780000,
                PromotionalInformation = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new Form
            {
                Id = SeedIds.Form2,
                ServiceId = SeedIds.ServiceResort, // Hotel: Beach Resort Package
                FullName = "Tran Thi B",
                Phone = "0912345678",
                Email = "tranthib@gmail.com",
                Type = FormType.Hotel,
                Where = "Đà Nẵng",
                Slug = "beach-resort-booking",
                Month = "09",
                Year = "2026",
                LongTime = "4 ngày 3 đêm",
                Note = "Xin chuẩn bị nôi em bé",
                TotalPrice = 10500000,
                PromotionalInformation = false,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new Form
            {
                Id = SeedIds.Form3,
                ServiceId = SeedIds.ServicePrivate, // Combo: Private Custom Journey
                FullName = "Le Van C",
                Phone = "0923456789",
                Email = "levanc@gmail.com",
                Type = FormType.Combo,
                Where = "Hội An",
                Slug = "private-journey-booking",
                Month = "10",
                Year = "2026",
                LongTime = "2 ngày 1 đêm",
                Note = "Kỷ niệm ngày cưới",
                TotalPrice = 5000000,
                PromotionalInformation = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new Form
            {
                Id = SeedIds.Form4,
                ServiceId = SeedIds.ServiceMain, // Tour: Perlunas Signature Tour
                FullName = "Pham Minh D",
                Phone = "0934567890",
                Email = "phamminhd@gmail.com",
                Type = FormType.Advise,
                Where = "Đà Nẵng",
                Slug = "signature-tour-advise",
                Month = "08",
                Year = "2026",
                LongTime = "3 ngày 2 đêm",
                Note = "Muốn tư vấn tour ghép cho gia đình 4 người lớn",
                TotalPrice = null,
                PromotionalInformation = false,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new Form
            {
                Id = SeedIds.Form5,
                ServiceId = Guid.Parse("11111111-1111-1111-1111-222222222211"), // Hotel: Vietnam Eco Lodge
                FullName = "Hoang Xuan E",
                Phone = "0945678901",
                Email = "hoangxuane@gmail.com",
                Type = FormType.Hotel,
                Where = "Sa Pa Valley",
                Slug = "eco-lodge-booking",
                Month = "11",
                Year = "2026",
                LongTime = "3 ngày 2 đêm",
                Note = "Phòng yên tĩnh hướng núi",
                TotalPrice = 7380000,
                PromotionalInformation = true,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new Form
            {
                Id = SeedIds.Form6,
                ServiceId = Guid.Parse("11111111-1111-1111-1111-222222222212"), // Hotel: Hanoi Royal Palace Hotel
                FullName = "Doan Van F",
                Phone = "0956789012",
                Email = "doanvanf@gmail.com",
                Type = FormType.Hotel,
                Where = "Hanoi Old Quarter",
                Slug = "royal-palace-booking",
                Month = "12",
                Year = "2026",
                LongTime = "2 ngày 1 đêm",
                Note = "Thanh toán trả trước",
                TotalPrice = 3500000,
                PromotionalInformation = false,
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            }
        );
    }

    public static void SeedFormDetails(this EntityTypeBuilder<FormDetails> builder)
    {
        builder.HasData(
            new FormDetails
            {
                Id = SeedIds.FormDetails1,
                FormId = SeedIds.Form1,
                ServiceId = SeedIds.ServiceMain,
                RoomCategory = new List<string> { "Standard Tour Room" },
                NumberOfRooms = 1,
                ReceiveTime = "2026-08-15 14:00",
                EndTime = "2026-08-18 12:00",
                Adults = 2,
                Children = 0,
                Baby = 0,
                Price = 800000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new FormDetails
            {
                Id = SeedIds.FormDetails2,
                FormId = SeedIds.Form2,
                ServiceId = SeedIds.ServiceResort,
                RoomCategory = new List<string> { "Deluxe Room" },
                NumberOfRooms = 1,
                ReceiveTime = "2026-09-10 14:00",
                EndTime = "2026-09-14 12:00",
                Adults = 2,
                Children = 1,
                Baby = 1,
                Price = 1200000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new FormDetails
            {
                Id = SeedIds.FormDetails3,
                FormId = SeedIds.Form3,
                ServiceId = SeedIds.ServicePrivate,
                RoomCategory = new List<string> { "Heritage Suite" },
                NumberOfRooms = 1,
                ReceiveTime = "2026-10-05 14:00",
                EndTime = "2026-10-07 12:00",
                Adults = 2,
                Children = 0,
                Baby = 0,
                Price = 2200000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new FormDetails
            {
                Id = SeedIds.FormDetails4,
                FormId = SeedIds.Form4,
                ServiceId = SeedIds.ServiceMain,
                RoomCategory = new List<string> { "Superior Tour Room" },
                NumberOfRooms = 2,
                ReceiveTime = "2026-08-20 14:00",
                EndTime = "2026-08-23 12:00",
                Adults = 4,
                Children = 0,
                Baby = 0,
                Price = 1000000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new FormDetails
            {
                Id = SeedIds.FormDetails5,
                FormId = SeedIds.Form5,
                ServiceId = Guid.Parse("11111111-1111-1111-1111-222222222211"),
                RoomCategory = new List<string> { "Eco Lodge Room" },
                NumberOfRooms = 2,
                ReceiveTime = "2026-11-12 14:00",
                EndTime = "2026-11-15 12:00",
                Adults = 2,
                Children = 0,
                Baby = 0,
                Price = 950000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            },
            new FormDetails
            {
                Id = SeedIds.FormDetails6,
                FormId = SeedIds.Form6,
                ServiceId = Guid.Parse("11111111-1111-1111-1111-222222222212"),
                RoomCategory = new List<string> { "Royal Suite" },
                NumberOfRooms = 1,
                ReceiveTime = "2026-12-24 14:00",
                EndTime = "2026-12-26 12:00",
                Adults = 2,
                Children = 0,
                Baby = 0,
                Price = 2100000,
                UnitPrice = "VNĐ",
                CreatedAt = SeedIds.CreatedAt,
                UpdatedAt = SeedIds.CreatedAt
            }
        );
    }
}
