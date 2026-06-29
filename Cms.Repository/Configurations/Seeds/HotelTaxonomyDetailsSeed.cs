using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class HotelTaxonomyDetailsSeed
{
    private static readonly Guid HaNoi = Guid.Parse("70000000-0000-0000-0000-000000000001");
    private static readonly Guid HaLong = Guid.Parse("70000000-0000-0000-0000-000000000003");
    private static readonly Guid SaPa = Guid.Parse("70000000-0000-0000-0000-000000000004");
    private static readonly Guid DaNang = Guid.Parse("70000000-0000-0000-0000-000000000005");
    private static readonly Guid HoiAn = Guid.Parse("70000000-0000-0000-0000-000000000006");
    private static readonly Guid DaLat = Guid.Parse("70000000-0000-0000-0000-000000000008");
    private static readonly Guid NhaTrang = Guid.Parse("70000000-0000-0000-0000-000000000009");
    private static readonly Guid PhuQuoc = Guid.Parse("70000000-0000-0000-0000-00000000000a");

    private static readonly Guid TyHotel = Guid.Parse("70000000-0000-0000-0000-00000000000b");
    private static readonly Guid TyResort = Guid.Parse("70000000-0000-0000-0000-00000000000c");
    private static readonly Guid TyRetreat = Guid.Parse("70000000-0000-0000-0000-00000000000d");
    private static readonly Guid TyWellness = Guid.Parse("70000000-0000-0000-0000-00000000000e");
    private static readonly Guid TyBoutique = Guid.Parse("70000000-0000-0000-0000-00000000000f");

    private static readonly Guid H1 = Guid.Parse("40000000-0000-0000-0000-000000000001");
    private static readonly Guid H2 = Guid.Parse("40000000-0000-0000-0000-000000000002");
    private static readonly Guid H3 = Guid.Parse("40000000-0000-0000-0000-000000000003");
    private static readonly Guid H4 = Guid.Parse("40000000-0000-0000-0000-000000000004");
    private static readonly Guid H5 = Guid.Parse("40000000-0000-0000-0000-000000000005");
    private static readonly Guid H6 = Guid.Parse("40000000-0000-0000-0000-000000000006");
    private static readonly Guid H7 = Guid.Parse("40000000-0000-0000-0000-000000000007");
    private static readonly Guid H8 = Guid.Parse("40000000-0000-0000-0000-000000000008");
    private static readonly Guid H9 = Guid.Parse("40000000-0000-0000-0000-000000000009");
    private static readonly Guid H10 = Guid.Parse("40000000-0000-0000-0000-00000000000a");
    private static readonly Guid H11 = Guid.Parse("40000000-0000-0000-0000-00000000000b");
    private static readonly Guid H12 = Guid.Parse("40000000-0000-0000-0000-00000000000c");
    private static readonly Guid H13 = Guid.Parse("40000000-0000-0000-0000-00000000000d");
    private static readonly Guid H14 = Guid.Parse("40000000-0000-0000-0000-00000000000e");
    private static readonly Guid H15 = Guid.Parse("40000000-0000-0000-0000-00000000000f");
    private static readonly Guid H16 = Guid.Parse("40000000-0000-0000-0000-000000000010");
    private static readonly Guid H17 = Guid.Parse("40000000-0000-0000-0000-000000000011");
    private static readonly Guid H18 = Guid.Parse("40000000-0000-0000-0000-000000000012");
    private static readonly Guid H19 = Guid.Parse("40000000-0000-0000-0000-000000000013");
    private static readonly Guid H20 = Guid.Parse("40000000-0000-0000-0000-000000000014");
    private static readonly Guid H21 = Guid.Parse("40000000-0000-0000-0000-000000000015");
    private static readonly Guid H22 = Guid.Parse("40000000-0000-0000-0000-000000000016");
    private static readonly Guid H23 = Guid.Parse("40000000-0000-0000-0000-000000000017");
    private static readonly Guid H24 = Guid.Parse("40000000-0000-0000-0000-000000000018");
    private static readonly Guid H25 = Guid.Parse("40000000-0000-0000-0000-000000000019");

    public static void SeedHotelTaxonomyDetails(this EntityTypeBuilder<HotelTaxonomyDetails> builder)
    {
        builder.HasData(
            // --- Phú Quốc ---
            new HotelTaxonomyDetails { HotelId = H1, TaxonomyId = PhuQuoc },
            new HotelTaxonomyDetails { HotelId = H1, TaxonomyId = TyResort },
            new HotelTaxonomyDetails { HotelId = H2, TaxonomyId = PhuQuoc },
            new HotelTaxonomyDetails { HotelId = H2, TaxonomyId = TyResort },
            // --- Hội An ---
            new HotelTaxonomyDetails { HotelId = H3, TaxonomyId = HoiAn },
            new HotelTaxonomyDetails { HotelId = H3, TaxonomyId = TyBoutique },
            new HotelTaxonomyDetails { HotelId = H4, TaxonomyId = HoiAn },
            new HotelTaxonomyDetails { HotelId = H4, TaxonomyId = TyBoutique },
            // --- Đà Lạt ---
            new HotelTaxonomyDetails { HotelId = H5, TaxonomyId = DaLat },
            new HotelTaxonomyDetails { HotelId = H5, TaxonomyId = TyRetreat },
            new HotelTaxonomyDetails { HotelId = H6, TaxonomyId = DaLat },
            new HotelTaxonomyDetails { HotelId = H6, TaxonomyId = TyWellness },
            new HotelTaxonomyDetails { HotelId = H7, TaxonomyId = DaLat },
            new HotelTaxonomyDetails { HotelId = H7, TaxonomyId = TyHotel },
            // --- Nha Trang ---
            new HotelTaxonomyDetails { HotelId = H8, TaxonomyId = NhaTrang },
            new HotelTaxonomyDetails { HotelId = H8, TaxonomyId = TyResort },
            new HotelTaxonomyDetails { HotelId = H9, TaxonomyId = NhaTrang },
            new HotelTaxonomyDetails { HotelId = H9, TaxonomyId = TyHotel },
            new HotelTaxonomyDetails { HotelId = H20, TaxonomyId = NhaTrang },
            new HotelTaxonomyDetails { HotelId = H20, TaxonomyId = TyResort },
            // --- Hạ Long ---
            new HotelTaxonomyDetails { HotelId = H10, TaxonomyId = HaLong },
            new HotelTaxonomyDetails { HotelId = H10, TaxonomyId = TyHotel },
            new HotelTaxonomyDetails { HotelId = H11, TaxonomyId = HaLong },
            new HotelTaxonomyDetails { HotelId = H11, TaxonomyId = TyWellness },
            new HotelTaxonomyDetails { HotelId = H23, TaxonomyId = HaLong },
            new HotelTaxonomyDetails { HotelId = H23, TaxonomyId = TyHotel },
            // --- Hà Nội ---
            new HotelTaxonomyDetails { HotelId = H12, TaxonomyId = HaNoi },
            new HotelTaxonomyDetails { HotelId = H12, TaxonomyId = TyHotel },
            new HotelTaxonomyDetails { HotelId = H13, TaxonomyId = HaNoi },
            new HotelTaxonomyDetails { HotelId = H13, TaxonomyId = TyBoutique },
            new HotelTaxonomyDetails { HotelId = H17, TaxonomyId = HaNoi },
            new HotelTaxonomyDetails { HotelId = H17, TaxonomyId = TyHotel },
            // --- Sa Pa ---
            new HotelTaxonomyDetails { HotelId = H14, TaxonomyId = SaPa },
            new HotelTaxonomyDetails { HotelId = H14, TaxonomyId = TyRetreat },
            new HotelTaxonomyDetails { HotelId = H24, TaxonomyId = SaPa },
            new HotelTaxonomyDetails { HotelId = H24, TaxonomyId = TyHotel },
            // --- Đà Nẵng ---
            new HotelTaxonomyDetails { HotelId = H15, TaxonomyId = DaNang },
            new HotelTaxonomyDetails { HotelId = H15, TaxonomyId = TyHotel },
            new HotelTaxonomyDetails { HotelId = H16, TaxonomyId = DaNang },
            new HotelTaxonomyDetails { HotelId = H16, TaxonomyId = TyResort },
            new HotelTaxonomyDetails { HotelId = H25, TaxonomyId = DaNang },
            new HotelTaxonomyDetails { HotelId = H25, TaxonomyId = TyRetreat },
            // --- Phú Quốc (thêm) ---
            new HotelTaxonomyDetails { HotelId = H18, TaxonomyId = PhuQuoc },
            new HotelTaxonomyDetails { HotelId = H18, TaxonomyId = TyResort },
            new HotelTaxonomyDetails { HotelId = H19, TaxonomyId = PhuQuoc },
            new HotelTaxonomyDetails { HotelId = H19, TaxonomyId = TyResort },
            // --- Đà Lạt (thêm) ---
            new HotelTaxonomyDetails { HotelId = H21, TaxonomyId = DaLat },
            new HotelTaxonomyDetails { HotelId = H21, TaxonomyId = TyRetreat },
            new HotelTaxonomyDetails { HotelId = H22, TaxonomyId = DaLat },
            new HotelTaxonomyDetails { HotelId = H22, TaxonomyId = TyResort }
        );
    }
}
