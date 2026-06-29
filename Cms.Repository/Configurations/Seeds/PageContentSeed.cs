using Cms.Repository.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cms.Repository.Configurations.Seeds;

public static class PageContentSeed
{
    public static void SeedPageContent(this EntityTypeBuilder<PageContent> builder)
    {
        var now = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        var id = 0;

        // ── Root pages ──
        var homeId = NextId(ref id);
        var aboutId = NextId(ref id);
        var contactId = NextId(ref id);
        var groupPageId = NextId(ref id);
        var privatePageId = NextId(ref id);
        var toursPageId = NextId(ref id);
        var hotelsPageId = NextId(ref id);
        var comboPageId = NextId(ref id);
        var comboTiersId = NextId(ref id);
        var footerId = NextId(ref id);

        builder.HasData(
            // ════════════════════════════════════════════════════════════════
            // ROOT PAGES
            // ════════════════════════════════════════════════════════════════
            Root(now, homeId,        "home",       "Trang chủ",       1),
            Root(now, aboutId,       "about",      "Giới thiệu",      2),
            Root(now, contactId,     "contact",    "Liên hệ",          3),
            Root(now, groupPageId,   "grouppage",  "Tour đoàn",       4),
            Root(now, privatePageId, "privatepage","Tour riêng tư",   5),
            Root(now, toursPageId,   "tourspage",  "Tour trọn gói",   6),
            Root(now, hotelsPageId,  "hotelspage", "Khách sạn",       7),
            Root(now, comboPageId,   "combopage",  "Combo",           8),
            Root(now, comboTiersId,  "combotiers", "Phân loại Combo", 9),
            Root(now, footerId,      "footer",     "Chung",           10),

            // ════════════════════════════════════════════════════════════════
            // TRANG CHỦ
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, homeId, "home.hero.eyebrow",            "Hero · Nhãn",              "text",     "Thiết kế hành trình du lịch trong nước"),
            Item(ref id, now, homeId, "home.hero.title",              "Hero · Tiêu đề",            "textarea", "Mỗi hành trình\nlà một viên ngọc."),
            Item(ref id, now, homeId, "home.hero.subtitle",           "Hero · Đoạn mô tả",         "textarea", "Perlunas thiết kế những chuyến đi trong nước đáng nhớ, tinh tế trong từng chi tiết và trọn vẹn từ đầu đến cuối."),
            Item(ref id, now, homeId, "home.hero.cta.primary",        "Hero · Nút chính",          "text",     "Khám phá hành trình"),
            Item(ref id, now, homeId, "home.hero.cta.secondary",      "Hero · Nút phụ",            "text",     "Liên hệ tư vấn"),
            Item(ref id, now, homeId, "home.hero.video",              "Hero · Video nền (URL)",    "image",    "/hero-vid.mp4"),

            Item(ref id, now, homeId, "home.philosophy.eyebrow",      "Triết lý · Nhãn",           "text",     "Triết lý"),
            Item(ref id, now, homeId, "home.philosophy.text",         "Triết lý · Nội dung",       "textarea", "Một hành trình đẹp bắt đầu từ cảm giác bạn mang theo, không phải điểm đến. Vì thế Perlunas không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe từng người, rồi thiết kế một hành trình vừa vặn, chỉn chu trong từng chi tiết. Với chúng tôi, mỗi vị khách là một viên ngọc."),

            Item(ref id, now, homeId, "home.packagetours.eyebrow",    "Tour trọn gói · Nhãn",      "text",     "Tour trọn gói"),
            Item(ref id, now, homeId, "home.packagetours.title",      "Tour trọn gói · Tiêu đề",   "textarea", "Những hành trình đã thiết kế sẵn."),
            Item(ref id, now, homeId, "home.packagetours.subtitle",   "Tour trọn gói · Mô tả",     "textarea", "Những trải nghiệm chỉn chu, khơi gợi cảm hứng cho mỗi chuyến đi."),
            Item(ref id, now, homeId, "home.packagetours.cta",        "Tour trọn gói · Nút thẻ",   "text",     "Xem chi tiết"),

            Item(ref id, now, homeId, "home.hotels.eyebrow",          "Khách sạn · Nhãn",          "text",     "Khách sạn"),
            Item(ref id, now, homeId, "home.hotels.title",            "Khách sạn · Tiêu đề",       "textarea", "Những chỗ nghỉ được tuyển chọn."),
            Item(ref id, now, homeId, "home.hotels.link",             "Khách sạn · Liên kết xem thêm", "text", "Xem thêm tất cả khách sạn"),

            Item(ref id, now, homeId, "home.combos.eyebrow",          "Combo · Nhãn",              "text",     "Combo du lịch"),
            Item(ref id, now, homeId, "home.combos.title",            "Combo · Tiêu đề",           "textarea", "Chọn một vùng đất để bắt đầu."),
            Item(ref id, now, homeId, "home.combos.text",             "Combo · Mô tả",             "textarea", "Mỗi điểm đến có ba gói combo theo mức độ trải nghiệm: Akoya, Tahiti và South Sea, đặt theo tên ba dòng ngọc trai quý."),
            Item(ref id, now, homeId, "home.combos.link",             "Combo · Liên kết",          "text",     "Tìm hiểu ba gói ngọc"),
            Item(ref id, now, homeId, "home.combos.viewall",          "Combo · Ô xem tất cả",      "text",     "Xem tất cả"),

            Item(ref id, now, homeId, "home.grouptours.title",        "Tour đoàn · Tiêu đề",        "textarea", "Đoàn đông tới mấy, vẫn trọn vẹn từng người"),
            Item(ref id, now, homeId, "home.grouptours.p1",           "Tour đoàn · Đoạn 1",         "textarea", "Một chuyến đi đoàn không bắt đầu từ số lượng người, mà từ cảm giác mọi người cùng thuộc về một hành trình. Điều khó nhất không phải là đưa nhiều người đi cùng nhau, mà là giữ cho ai cũng thấy mình được quan tâm."),
            Item(ref id, now, homeId, "home.grouptours.p2",           "Tour đoàn · Đoạn 2",         "textarea", "Đó là lý do Perlunas tìm hiểu từng đoàn trước khi lên lịch: mục tiêu, độ tuổi, ngân sách và nhịp đi riêng. Chúng tôi lo trọn từ vận chuyển, lưu trú, ăn uống đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt."),
            Item(ref id, now, homeId, "home.grouptours.p3",           "Tour đoàn · Đoạn 3",         "textarea", "Hãy kể cho chúng tôi về đoàn của bạn."),
            Item(ref id, now, homeId, "home.grouptours.cta",          "Tour đoàn · Nút",            "text",     "Liên hệ tư vấn"),

            Item(ref id, now, homeId, "home.privatetour.eyebrow",     "Tour riêng tư · Nhãn",       "text",     "Tour riêng tư"),
            Item(ref id, now, homeId, "home.privatetour.title",       "Tour riêng tư · Tiêu đề",    "textarea", "Hành trình may đo cho riêng bạn."),
            Item(ref id, now, homeId, "home.privatetour.cta",         "Tour riêng tư · Nút",        "text",     "Đề xuất chi tiết"),

            Item(ref id, now, homeId, "home.about.eyebrow",           "Về chúng tôi · Nhãn",        "text",     "Về chúng tôi"),
            Item(ref id, now, homeId, "home.about.image",             "Về chúng tôi · Ảnh",        "image",    "/about.png"),
            Item(ref id, now, homeId, "home.about.salutation",        "Về chúng tôi · Lời chào",    "text",     "Thân gửi bạn,"),
            Item(ref id, now, homeId, "home.about.p1",                "Về chúng tôi · Đoạn 1",      "textarea", "Cảm ơn bạn đã ghé Perlunas. Chúng tôi tin rằng một hành trình đẹp không bắt đầu từ điểm đến, mà từ cảm giác bạn mang theo trên suốt chặng đường."),
            Item(ref id, now, homeId, "home.about.p2",                "Về chúng tôi · Đoạn 2",      "textarea", "Vì thế, chúng tôi không tạo ra những chuyến đi rập khuôn. Chúng tôi lắng nghe câu chuyện của từng người, rồi thiết kế một lịch trình vừa vặn — chỉn chu trong từng chi tiết, tinh tế và trọn vẹn từ đầu đến cuối."),
            Item(ref id, now, homeId, "home.about.p3",                "Về chúng tôi · Đoạn 3",      "textarea", "Với chúng tôi, mỗi vị khách là một viên ngọc. Và Perlunas xin được là ánh trăng lặng lẽ dõi theo, đồng hành cùng bạn qua thật nhiều hành trình."),
            Item(ref id, now, homeId, "home.about.signoff",           "Về chúng tôi · Lời kết",     "text",     "Hẹn gặp bạn trên những cung đường,"),
            Item(ref id, now, homeId, "home.about.signature",         "Về chúng tôi · Chữ ký",      "text",     "Perlunas"),

            Item(ref id, now, homeId, "home.partners.eyebrow",        "Đối tác · Nhãn",             "text",     "Đối tác đồng hành"),
            Item(ref id, now, homeId, "home.partners.list",           "Đối tác · Danh sách",        "textarea", "Vietnam Airlines\nVietravel\nSaigontourist\nMường Thanh\nVinpearl\nBamboo Airways\nAccor Hotels\nSun World\nVietjet Air\nMarriott"),

            Item(ref id, now, homeId, "home.whyus.title",             "Tại sao chọn · Tiêu đề",     "text",     "Tại sao chọn Perlunas?"),
            Item(ref id, now, homeId, "home.whyus.1.title",           "Lý do 1 · Tiêu đề",          "text",     "Giá minh bạch"),
            Item(ref id, now, homeId, "home.whyus.2.title",           "Lý do 2 · Tiêu đề",          "text",     "Tư vấn miễn phí"),
            Item(ref id, now, homeId, "home.whyus.3.title",           "Lý do 3 · Tiêu đề",          "text",     "Lịch trình may đo"),
            Item(ref id, now, homeId, "home.whyus.4.title",           "Lý do 4 · Tiêu đề",          "text",     "Hỗ trợ tận nơi"),
            Item(ref id, now, homeId, "home.whyus.5.title",           "Lý do 5 · Tiêu đề",          "text",     "Trải nghiệm địa phương"),

            // ════════════════════════════════════════════════════════════════
            // GIỚI THIỆU
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, aboutId, "about.eyebrow",                "Hero · Nhãn",               "text",     "Về chúng tôi"),
            Item(ref id, now, aboutId, "about.hero.intro",             "Hero · Câu tuyên ngôn",      "textarea", "Perlunas không bán những chuyến đi rập khuôn. Chúng tôi thiết kế những hành trình hợp với từng con người: tử tế, tinh tế và trọn vẹn."),
            Item(ref id, now, aboutId, "about.hero.image",             "Hero · Ảnh lớn",            "image",    "https://images.unsplash.com/photo-1528127269322-539801943592?fm=jpg&q=60&w=2000"),

            Item(ref id, now, aboutId, "about.pearl.eyebrow",          "Pearl · Nhãn",              "text",     "Tên thương hiệu"),
            Item(ref id, now, aboutId, "about.pearl.title",            "Pearl · Tiêu đề",           "text",     "Pearl"),
            Item(ref id, now, aboutId, "about.pearl.body",             "Pearl · Nội dung",          "textarea", "Viên ngọc là bạn, vị khách của chúng tôi. Mỗi người một câu chuyện, nên chuyến đi cũng phải độc bản và của riêng bạn."),
            Item(ref id, now, aboutId, "about.pearl.image",            "Pearl · Ảnh",              "image",    "https://images.unsplash.com/photo-1595345705177-ffe090eb0784?fm=jpg&q=60&w=1200"),

            Item(ref id, now, aboutId, "about.luna.eyebrow",           "Luna · Nhãn",               "text",     "Tên thương hiệu"),
            Item(ref id, now, aboutId, "about.luna.title",             "Luna · Tiêu đề",            "text",     "Luna(s)"),
            Item(ref id, now, aboutId, "about.luna.body",              "Luna · Nội dung",           "textarea", "Ánh trăng là Perlunas, lặng lẽ dõi theo và chăm chút từng chi tiết. Chữ “s” nhỏ ở cuối là lời hứa đồng hành bền lâu."),
            Item(ref id, now, aboutId, "about.luna.image",             "Luna · Ảnh",               "image",    "https://images.unsplash.com/photo-1581886573745-4487c55d95f8?fm=jpg&q=60&w=1200"),

            Item(ref id, now, aboutId, "about.vision.eyebrow",         "Tầm nhìn · Nhãn",           "text",     "Tầm nhìn"),
            Item(ref id, now, aboutId, "about.vision.body",            "Tầm nhìn · Nội dung",       "textarea", "Trở thành người đồng hành du lịch trong nước được tin yêu nhất tại Việt Nam."),
            Item(ref id, now, aboutId, "about.vision.image",           "Tầm nhìn · Ảnh",           "image",    "https://images.unsplash.com/photo-1585970661791-9cec67470281?fm=jpg&q=60&w=1200"),

            Item(ref id, now, aboutId, "about.mission.eyebrow",        "Sứ mệnh · Nhãn",            "text",     "Sứ mệnh"),
            Item(ref id, now, aboutId, "about.mission.body",           "Sứ mệnh · Nội dung",        "textarea", "Mang những hành trình tử tế, chỉn chu đến gần hơn với mỗi người, để ai cũng có thể đi và trở về trọn vẹn."),
            Item(ref id, now, aboutId, "about.mission.image",          "Sứ mệnh · Ảnh",            "image",    "https://images.unsplash.com/photo-1592903204858-e288251ad9cc?fm=jpg&q=60&w=1200"),

            Item(ref id, now, aboutId, "about.values.eyebrow",         "Giá trị cốt lõi · Nhãn",    "text",     "Giá trị cốt lõi"),
            Item(ref id, now, aboutId, "about.values.1.title",         "Giá trị 1 · Tiêu đề",       "text",     "Chân thành"),
            Item(ref id, now, aboutId, "about.values.1.desc",          "Giá trị 1 · Mô tả",         "textarea", "Tư vấn thật lòng, đúng nhu cầu và ngân sách của bạn."),
            Item(ref id, now, aboutId, "about.values.2.title",         "Giá trị 2 · Tiêu đề",       "text",     "Tận tâm"),
            Item(ref id, now, aboutId, "about.values.2.desc",          "Giá trị 2 · Mô tả",         "textarea", "Chăm chút từng chi tiết, theo sát đến khi bạn trở về."),
            Item(ref id, now, aboutId, "about.values.3.title",         "Giá trị 3 · Tiêu đề",       "text",     "Minh bạch"),
            Item(ref id, now, aboutId, "about.values.3.desc",          "Giá trị 3 · Mô tả",         "textarea", "Báo giá trọn gói rõ ràng, nói được làm được."),
            Item(ref id, now, aboutId, "about.values.4.title",         "Giá trị 4 · Tiêu đề",       "text",     "Bền lâu"),
            Item(ref id, now, aboutId, "about.values.4.desc",          "Giá trị 4 · Mô tả",         "textarea", "Một người đồng hành đi cùng bạn qua nhiều hành trình."),

            Item(ref id, now, aboutId, "about.cta.title",              "Khối kêu gọi · Tiêu đề",    "textarea", "Cùng Perlunas bắt đầu hành trình của bạn."),
            Item(ref id, now, aboutId, "about.cta.button",             "Khối kêu gọi · Nút",        "text",     "Liên hệ tư vấn"),

            // ════════════════════════════════════════════════════════════════
            // LIÊN HỆ
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, contactId, "contact.eyebrow",              "Hero · Nhãn",                "text",     "Yêu cầu tư vấn"),
            Item(ref id, now, contactId, "contact.hero.title",           "Hero · Tiêu đề",             "textarea", "Kể cho chúng tôi về chuyến đi của bạn."),
            Item(ref id, now, contactId, "contact.hero.intro",           "Hero · Đoạn mở đầu",         "textarea", "Sau khi bạn gửi yêu cầu, Perlunas sẽ liên hệ sớm để tư vấn và lên kế hoạch qua Zalo, điện thoại hoặc gặp trực tiếp. Mọi tư vấn và báo giá đều hoàn toàn miễn phí."),
            Item(ref id, now, contactId, "contact.call.label",           "Gọi · Nhãn",                "text",     "Gọi ngay hôm nay"),
            Item(ref id, now, contactId, "contact.call.note",            "Gọi · Ghi chú",              "text",     "Tư vấn nhanh trong giờ làm việc."),
            Item(ref id, now, contactId, "contact.message.label",        "Nhắn tin · Nhãn",            "text",     "Nhắn tin"),
            Item(ref id, now, contactId, "contact.hours.label",          "Giờ làm việc · Nhãn",        "text",     "Giờ làm việc"),
            Item(ref id, now, contactId, "contact.hours.1.day",          "Giờ làm việc · Dòng 1 Ngày",  "text",     "Thứ 2 - Thứ 6"),
            Item(ref id, now, contactId, "contact.hours.1.time",         "Giờ làm việc · Dòng 1 Giờ",  "text",     "8:00 - 21:00"),
            Item(ref id, now, contactId, "contact.hours.2.day",          "Giờ làm việc · Dòng 2 Ngày",  "text",     "Thứ 7"),
            Item(ref id, now, contactId, "contact.hours.2.time",         "Giờ làm việc · Dòng 2 Giờ",  "text",     "8:00 - 20:00"),
            Item(ref id, now, contactId, "contact.hours.3.day",          "Giờ làm việc · Dòng 3 Ngày",  "text",     "Chủ nhật"),
            Item(ref id, now, contactId, "contact.hours.3.time",         "Giờ làm việc · Dòng 3 Giờ",  "text",     "9:00 - 18:00"),

            // ════════════════════════════════════════════════════════════════
            // TOUR ĐOÀN
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, groupPageId, "grouppage.eyebrow",            "Hero · Nhãn",                "text",     "Tour đoàn"),
            Item(ref id, now, groupPageId, "grouppage.hero.title",         "Hero · Tiêu đề",             "textarea", "Đoàn đông tới mấy, vẫn trọn vẹn từng người."),
            Item(ref id, now, groupPageId, "grouppage.hero.intro",         "Hero · Đoạn mở đầu",         "textarea", "Team building, gala dinner, hội nghị kết hợp tham quan — Perlunas lo trọn từ vận chuyển, lưu trú đến kịch bản gắn kết, với một đầu mối duy nhất xuyên suốt hành trình."),
            Item(ref id, now, groupPageId, "grouppage.hero.image",         "Hero · Ảnh lớn",             "image",    "https://images.unsplash.com/photo-1768881618157-2cc24f7493c6?fm=jpg&q=60&w=2000"),
            Item(ref id, now, groupPageId, "grouppage.block1.eyebrow",     "Khối 1 · Nhãn",              "text",     "Trước chuyến đi"),
            Item(ref id, now, groupPageId, "grouppage.block1.title",       "Khối 1 · Tiêu đề",           "text",     "Hiểu đoàn trước khi lên lịch"),
            Item(ref id, now, groupPageId, "grouppage.block1.body",        "Khối 1 · Nội dung",          "textarea", "Chúng tôi tìm hiểu mục tiêu, độ tuổi, ngân sách và nhịp đi riêng của từng đoàn để thiết kế lịch trình phù hợp nhất."),
            Item(ref id, now, groupPageId, "grouppage.block1.image",       "Khối 1 · Ảnh",              "image",    "https://images.unsplash.com/photo-1774599661329-d9a2f999d1c4?fm=jpg&q=60&w=1000"),
            Item(ref id, now, groupPageId, "grouppage.block2.eyebrow",     "Khối 2 · Nhãn",              "text",     "Trong chuyến đi"),
            Item(ref id, now, groupPageId, "grouppage.block2.title",       "Khối 2 · Tiêu đề",           "text",     "Một đầu mối lo trọn"),
            Item(ref id, now, groupPageId, "grouppage.block2.body",        "Khối 2 · Nội dung",          "textarea", "Vận chuyển, lưu trú, ăn uống, hướng dẫn và các hoạt động gắn kết — tất cả được điều phối bởi một đội ngũ duy nhất."),
            Item(ref id, now, groupPageId, "grouppage.block2.image",       "Khối 2 · Ảnh",              "image",    "https://images.unsplash.com/photo-1539635278303-d4002c07eae3?fm=jpg&q=60&w=1000"),
            Item(ref id, now, groupPageId, "grouppage.cta.title",          "Khối kêu gọi · Tiêu đề",     "textarea", "Hãy kể cho chúng tôi về đoàn của bạn."),
            Item(ref id, now, groupPageId, "grouppage.cta.button",         "Khối kêu gọi · Nút",         "text",     "Liên hệ tư vấn"),

            // ════════════════════════════════════════════════════════════════
            // TOUR RIÊNG TƯ
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, privatePageId, "privatepage.eyebrow",          "Hero · Nhãn",              "text",     "Tour riêng tư"),
            Item(ref id, now, privatePageId, "privatepage.hero.title",       "Hero · Tiêu đề",           "textarea", "Hành trình may đo cho riêng bạn."),
            Item(ref id, now, privatePageId, "privatepage.hero.intro",       "Hero · Đoạn mở đầu",       "textarea", "Mỗi nhóm khách có một nhịp đi riêng. Perlunas thiết kế lịch trình, lưu trú và trải nghiệm theo đúng mong muốn của bạn — linh hoạt từ ngày khởi hành đến từng điểm dừng."),
            Item(ref id, now, privatePageId, "privatepage.block.eyebrow",    "Khối · Nhãn",              "text",     "Cách chúng tôi làm việc"),
            Item(ref id, now, privatePageId, "privatepage.block.title",      "Khối · Tiêu đề",           "text",     "Lắng nghe, đề xuất, rồi tinh chỉnh."),
            Item(ref id, now, privatePageId, "privatepage.block.body",       "Khối · Nội dung",          "textarea", "Bạn chia sẻ mong muốn và ngân sách, chúng tôi đề xuất một hành trình chi tiết và điều chỉnh cùng bạn cho đến khi vừa ý."),
            Item(ref id, now, privatePageId, "privatepage.block.button",     "Khối · Nút",               "text",     "Đề xuất chi tiết"),
            Item(ref id, now, privatePageId, "privatepage.block.image",      "Khối · Ảnh",              "image",    "https://images.unsplash.com/photo-1566759996874-04d713cc224a?fm=jpg&q=60&w=1000"),
            Item(ref id, now, privatePageId, "privatepage.cta.title",        "Khối kêu gọi · Tiêu đề",   "textarea", "Bắt đầu thiết kế hành trình của riêng bạn."),
            Item(ref id, now, privatePageId, "privatepage.cta.button",       "Khối kêu gọi · Nút",       "text",     "Liên hệ tư vấn"),

            // ════════════════════════════════════════════════════════════════
            // TOUR TRỌN GÓI
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, toursPageId, "tourspage.eyebrow",            "Hero · Nhãn",              "text",     "Tour trọn gói"),
            Item(ref id, now, toursPageId, "tourspage.hero.title",         "Hero · Tiêu đề",           "textarea", "Xách balo lên và đi, phần còn lại để Perlunas lo."),
            Item(ref id, now, toursPageId, "tourspage.hero.intro",         "Hero · Đoạn mở đầu",       "textarea", "Lịch khởi hành đều đặn, giá trọn gói rõ ràng, không phát sinh."),

            // ════════════════════════════════════════════════════════════════
            // KHÁCH SẠN
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, hotelsPageId, "hotelspage.eyebrow",           "Hero · Nhãn",                "text",     "Khách sạn"),
            Item(ref id, now, hotelsPageId, "hotelspage.hero.title",        "Hero · Tiêu đề",             "textarea", "Chỗ nghỉ trên khắp Việt Nam."),
            Item(ref id, now, hotelsPageId, "hotelspage.hero.intro",        "Hero · Đoạn mở đầu",         "textarea", "Mặc định là những chỗ nghỉ Perlunas tuyển chọn."),
            Item(ref id, now, hotelsPageId, "hotelspage.upsell.eyebrow",    "Upsell · Nhãn",              "text",     "Nâng tầm trải nghiệm"),
            Item(ref id, now, hotelsPageId, "hotelspage.upsell.title",      "Upsell · Tiêu đề",           "textarea", "Không chỉ là đặt phòng, hãy đi cùng một combo trọn vẹn."),
            Item(ref id, now, hotelsPageId, "hotelspage.upsell.body",       "Upsell · Nội dung",          "textarea", "Combo du lịch kết hợp lưu trú, di chuyển và trải nghiệm theo ba mức: Akoya, Tahiti và South Sea."),
            Item(ref id, now, hotelsPageId, "hotelspage.upsell.button",     "Upsell · Nút",               "text",     "Khám phá Combo du lịch"),

            // ════════════════════════════════════════════════════════════════
            // COMBO
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, comboPageId, "combopage.eyebrow",            "Hero · Nhãn",                "text",     "Combo du lịch"),
            Item(ref id, now, comboPageId, "combopage.hero.title",         "Hero · Tiêu đề",             "textarea", "Combo trọn gói khắp Việt Nam."),
            Item(ref id, now, comboPageId, "combopage.hero.intro",         "Hero · Đoạn mở đầu",         "textarea", "Mỗi combo kết hợp lưu trú, di chuyển và trải nghiệm theo một trong ba chuẩn dịch vụ."),
            Item(ref id, now, comboPageId, "combopage.cta.title",          "Khối kêu gọi · Tiêu đề",    "text",     "Chưa biết chọn combo nào?"),
            Item(ref id, now, comboPageId, "combopage.cta.body",           "Khối kêu gọi · Nội dung",    "textarea", "Để lại thông tin, Perlunas tư vấn gói phù hợp với bạn, miễn phí."),
            Item(ref id, now, comboPageId, "combopage.cta.button",         "Khối kêu gọi · Nút",        "text",     "Nhận tư vấn"),

            // ════════════════════════════════════════════════════════════════
            // PHÂN LOẠI COMBO
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, comboTiersId, "combotiers.eyebrow",           "Hero · Nhãn",            "text",     "Phân loại Combo"),
            Item(ref id, now, comboTiersId, "combotiers.hero.title",        "Hero · Tiêu đề",         "textarea", "Ba viên ngọc, ba chuẩn dịch vụ."),
            Item(ref id, now, comboTiersId, "combotiers.hero.intro",        "Hero · Đoạn mở đầu",     "textarea", "Akoya, Tahiti và South Sea là ba chuẩn dịch vụ Perlunas đặt ra."),
            Item(ref id, now, comboTiersId, "combotiers.choose.eyebrow",    "Cách chọn gói · Nhãn",   "text",     "Cách chọn gói"),
            Item(ref id, now, comboTiersId, "combotiers.choose.title",      "Cách chọn gói · Tiêu đề", "textarea", "Chọn gói phù hợp với nhu cầu của bạn."),
            Item(ref id, now, comboTiersId, "combotiers.choose.body",       "Cách chọn gói · Nội dung", "textarea", "Mỗi gói phù hợp với một kiểu chuyến đi khác nhau."),
            Item(ref id, now, comboTiersId, "combotiers.choose.button",     "Cách chọn gói · Nút",     "text",     "Nhận tư vấn chọn gói"),

            // ════════════════════════════════════════════════════════════════
            // CHUNG
            // ════════════════════════════════════════════════════════════════
            Item(ref id, now, footerId, "footer.tagline",               "Footer · Mô tả thương hiệu",    "textarea", "Mỗi hành trình là một viên ngọc dưới ánh trăng. Thiết kế những hành trình du lịch trong nước tinh tế và trọn vẹn."),
            Item(ref id, now, footerId, "footer.newsletter.eyebrow",    "Footer · Newsletter nhãn",      "text",     "Nhận tư vấn từ Perlunas"),
            Item(ref id, now, footerId, "footer.newsletter.note",       "Footer · Newsletter ghi chú",   "text",     "Để lại email, Perlunas sẽ liên hệ tư vấn miễn phí."),
            Item(ref id, now, footerId, "footer.legal.tagline",         "Footer · Câu cuối",            "text",     "Mỗi hành trình là một viên ngọc dưới ánh trăng.")
        );
    }

    private static Guid NextId(ref int id)
    {
        id++;
        return Guid.Parse($"00000000-0000-0000-0000-{id:D12}");
    }

    private static PageContent Root(DateTime now, Guid id, string key, string label, int sortOrder)
    {
        return new PageContent
        {
            Id = id,
            Key = key,
            Label = label,
            Kind = "page",
            SortOrder = sortOrder,
            CreatedAt = now,
            IsDeleted = false,
        };
    }

    private static PageContent Item(ref int id, DateTime now, Guid parentId, string key, string label, string kind, string value)
    {
        id++;
        return new PageContent
        {
            Id = Guid.Parse($"00000000-0000-0000-0000-{id:D12}"),
            Key = key, ParentId = parentId, Label = label, Kind = kind, Value = value,
            SortOrder = id, CreatedAt = now, IsDeleted = false,
        };
    }
}
