# Perlunas — Tổng hợp thay đổi Backend (giải thích cho bạn code BE)

> Mục tiêu tổng thể: **toàn bộ chữ và ảnh trên website đều do admin chỉnh được**, không có
> gì hardcode ở frontend. FE (Next.js) giờ lấy 100% nội dung từ BE. Tài liệu này liệt kê
> những gì đã đổi ở BE và những gì bạn cần rà soát lại cho chuẩn.

Ngày tổng hợp: 2026-07-03. Toàn bộ thay đổi nằm trong repo `be-v2` (đã có sẵn migration).

> **Bổ sung 2026-07-03 (chiều) — Combo có GIÁ GÓI riêng:** thêm 2 cột `Services.Price` +
> `Services.OriginalPrice` (string, nullable) — combo bán theo GÓI nên giá nằm ở cấp dịch vụ,
> KHÔNG ở hạng phòng. Migration viết tay `20260703130000_AddComboPackagePrice` (đã cập nhật
> snapshot). Thay đổi kèm theo trong `Cms.Service/Service`:
> - `Request`: `CreateComboRequest` + `UpdateServiceRequest` thêm `Price`, `OriginalPrice`.
> - `Service.cs`: CreateCombo/Update set `service.Price/OriginalPrice`; **hạng phòng của combo
>   ép `Price=OriginalPrice=Unit=null`** (chỉ mô tả, không giá); `ApplyTypeFields` combo set giá
>   gói, tour/hotel null 2 cột này; `ComputePriceFrom` với combo = `Price` (fallback `OriginalPrice`)
>   thay vì gộp từ hạng phòng; `ToResponse` trả thêm 2 field.
> - "Gói gồm có" của combo tái dụng field sẵn có: `Label` = tagline, `Highlight[]` = danh sách mục
>   (KHÔNG cần đổi BE — Create/Update đã lưu sẵn).
>
> **Bổ sung 2 — Thời lượng là CHUỖI TỰ DO:** thêm cột `Services.DurationText` (string, nullable)
> — admin nhập tự do ("3 ngày 2 đêm", "1 tuần", "cuối tuần"), hiển thị nguyên văn. Migration
> `20260703140000_AddServiceDurationText`. `Day/Night` giờ chỉ parse phụ trợ. **ĐÃ BỎ ràng buộc
> `Day/Night > 0`** ở CreateTour/CreateCombo + UpdateService validator (cho phép night=0). Request
> (Create tour/combo + Update) + Response + ToResponse + ApplyTypeFields (tour/combo set, hotel null)
> đều thêm DurationText. Combo cũng bật lại `HighlightContent` (Điểm nổi bật) + giữ `Day`.

---

## 0. Tóm tắt nhanh (TL;DR)

| Nhóm | Việc đã làm | Bạn cần làm gì |
|---|---|---|
| **Service (entity)** | Thêm field mới; đổi 2 enum → string tham chiếu danh mục | Xem lại, đồng ý cách bỏ enum |
| **Taxonomy (mới)** | Entity + controller + seed cho các "danh mục" (vùng miền, loại hình, tier, mục đích) | Rà soát, có thể thêm CRUD admin |
| **PageContent** | Là "kho CMS" chứa mọi text/ảnh của site (406 bản ghi) | Đảm bảo API GET/PUT chạy ổn |
| **SiteSetting** | Rút về **đúng 1 dòng** (thông tin công ty) | Giữ quy ước 1 dòng |
| **Response DTO** | Thêm `PriceFrom` (giá từ), `Destinations`, `Facilities`, `HighlightContent`, `PriceText` | Xem lại `ComputePriceFrom` |
| **Validator** | Bỏ `IsInEnum` cho Purpose/Classify → `NotEmpty` | Xác nhận |
| **Config (QUAN TRỌNG)** | JWT key + AdminAuth đang phải override bằng ENV mới chạy | **Sửa lại binding cho đúng** (mục 8) |

---

## 1. Entity `Service` — thêm field, bỏ enum

File: `Cms.Repository/Entities/Service.cs`

**Field mới:**
- `List<string> Destinations` — Tour: danh sách điểm đến (tên/slug tỉnh). Cột Postgres `text[] NOT NULL DEFAULT '{}'`.
- `List<string> Facilities` — Hotel: tiện nghi cấp khách sạn (Wifi, Hồ bơi…). `text[] NOT NULL DEFAULT '{}'`.
- `string? HighlightContent` — Tour: nội dung **"Điểm nổi bật"** dạng **richtext (HTML)** admin tự soạn.
- `string? PriceText` — Giá hiển thị dạng chuỗi (vd `"từ 2.890.000đ"`) dùng cho thẻ/vé.

**Đổi kiểu (enum → string):**
- `PurposeOfTrip`: trước là `enum PurposeOfTrip?` → giờ `string?` (tham chiếu danh mục nhóm `"purpose"` theo `Name`).
- `Classify`: trước là `enum Classify?` → giờ `string?` (tham chiếu danh mục nhóm `"tier"` theo `Name`).

**Lý do bỏ enum:** các lựa chọn này giờ do admin quản lý qua **Taxonomy** (thêm/sửa/xoá vùng
miền, loại hình, tier, mục đích chuyến đi) nên không thể cứng thành enum trong code.

> ⚠️ **Lưu ý migration `text[] NOT NULL`:** khi thêm cột mảng NOT NULL vào bảng đã có data,
> phải set `defaultValue: new List<string>()` trong `AddColumn`, nếu không Postgres báo lỗi
> `23502 (column contains null values)`. Các migration trong repo đã xử lý sẵn.

---

## 2. Taxonomy — tính năng mới (danh mục admin quản lý)

Các file mới:
- `Cms.Repository/Entities/Taxonomy.cs`
- `Cms.Repository/Configurations/TaxonomyConfiguration.cs`
- `Cms.Repository/Configurations/Seeds/TaxonomySeed.cs`
- `Cms.API/Controllers/TaxonomiesController.cs`
- `Cms.Service/Taxonomy/` (service + DTO)

**Entity `Taxonomy`:**
```
Group      string   // "region" | "city" | "stay-type" | "tier" | "purpose"
Name       string   // tên hiển thị: "Miền Bắc", "Akoya", "Nghỉ dưỡng"…
Slug       string?  // slug để lọc trên URL
Color      string?  // dùng cho "mục đích chuyến đi" (chấm màu logo)
SortOrder  int
```

**API:** `GET /api/taxonomies?group=<group>` → trả danh sách theo nhóm.
FE dùng để đổ vào các bộ lọc (vùng miền, nơi đến, loại hình, tier, mục đích).

> Gợi ý: nên bổ sung CRUD (POST/PUT/DELETE) cho Taxonomy để admin tự thêm danh mục.

---

## 3. PageContent — kho CMS của toàn site (quan trọng nhất)

`PageContent` giờ là nơi chứa **mọi đoạn text và đường dẫn ảnh** không thuộc field của
Service. Hiện có **406 bản ghi** (seed sẵn), phủ: nav, footer, form, trang chính sách,
trang giới thiệu, các trang listing, chi tiết tour/khách sạn/combo, v.v.

**API FE đang dùng:**
- `GET /api/page-contents` → trả mảng phẳng `{ value: [...] }`.

**Mỗi bản ghi gồm:**
```
key           string   // khoá phẳng, vd "nav.tour", "policy.body", "hotelspage.why.title"
contentValue  string   // giá trị (text / html / url ảnh / list ngăn bởi \n)
label         string   // nhãn tiếng Việt mô tả cho admin
kind          string   // "text" | "textarea" | "richtext" | "list" | "image"
pageKey       string   // nhóm trang để admin gom nhóm (vd "Footer", "Trang Khách sạn")
sectionKey    string
softOrder     int
```

**`kind` FE quy ước:**
- `text` — 1 dòng
- `textarea` — nhiều dòng
- `richtext` — HTML (vd `policy.body`, tour `HighlightContent`) → admin nên dùng editor
- `list` — nhiều mục, mỗi mục 1 dòng (FE `split("\n")`)
- `image` — URL ảnh

**Hợp đồng PUT (đã gặp lỗi 400 lúc test):** validator yêu cầu `PageKey`, `SectionKey`,
`Label`, `Kind` **không được rỗng**. Khi update phải gửi đủ các field này (không để `""`).

---

## 4. SiteSetting — quy ước đúng 1 dòng

File: `Cms.Repository/Configurations/Seeds/SiteSettingSeed.cs`

Trước đây seed **3 dòng** khiến `GET /api/site-settings` trả nhầm dòng đầu ("Perlunas
Support"). Đã rút về **đúng 1 dòng** `SiteMain` với dữ liệu công ty thật:
- `LegalName = "Công ty TNHH Du lịch Perlunas"`
- `Phone = "0900 000 000"`, `Email = "xinchao@perlunas.vn"`, `TaxId = "0123456789"`

FE (`getSite()`) đọc dòng này để đổ vào Navbar/Footer (tên công ty, MST, hotline, email).

> Quy ước: **site-settings luôn chỉ 1 dòng.** Nếu sau này làm CRUD, nên khoá về 1 bản ghi
> (hoặc lấy `SiteMain`).

---

## 5. Response / Request DTO

File: `Cms.Service/Service/Response.cs`, `Request.cs`

**Response thêm field:**
- `List<string> Destinations`, `List<string> Facilities`
- `string HighlightContent`, `string PriceText`
- `string? PurposeOfTrip`, `string? Classify` (string thay vì enum)
- **`decimal? PriceFrom`** — "giá từ" (giá thấp nhất), tính trong `ToResponse()` bằng
  `ComputePriceFrom(service)` (`Cms.Service/Service/Service.cs` ~dòng 912–922).

> Bạn xem lại `ComputePriceFrom`: hiện lấy giá thấp nhất từ lịch khởi hành / hạng phòng.
> Nếu logic giá của bạn khác, chỉnh ở đây là FE tự cập nhật.

---

## 6. Validator — bỏ IsInEnum

File: `Cms.Service/Service/Validations/*`

- `PurposeOfTrip`: `IsInEnum()` → `NotEmpty()` (msg `PURPOSE_OF_TRIP_REQUIRED`)
- `Classify`: `IsInEnum()` → `NotEmpty()` (msg `CLASSIFY_REQUIRED`)

Vì 2 field này giờ là string tham chiếu Taxonomy, không còn ràng buộc enum.

---

## 7. Danh sách migration (theo thứ tự)

Các migration liên quan đợt này (đã apply vào DB đang chạy):
```
20260702165012_AddTaxonomyAndStringSelections     // Taxonomy + đổi Purpose/Classify sang string
20260702173042_AddTourDestinationsAndHotelFacilities
20260702175657_AddTourHighlightContent
20260702181257_SeedFromLiveCatalog                // seed 34 service từ catalog site thật
20260702183436_SeedTourDetailContent              // page-content chi tiết tour
20260702185045_SeedHotelComboDetailContent
20260702192950_SeedContentBatch2
20260702201155_SeedContentBatch3                  // batch mới nhất: nav/footer/form/policy/listing (→ 406 bản ghi) + SiteSetting 1 dòng
```

Lệnh apply (qua container SDK, network `be-v2_cms_network`):
```bash
ConnectionStrings__DefaultConnection='Host=postgres_db;Port=5432;Database=perlunas_db;Username=perlunas_user;Password=perlunas_password' \
  dotnet-ef database update --project Cms.Repository --startup-project Cms.API
```

---

## 8. ⚠️ Config đang phải override bằng ENV — bạn cần sửa cho đúng

Đây là **lỗi cấu hình thật**, không phải lỗi FE. Hiện đang vá tạm bằng biến môi trường để
chạy được; bạn nên sửa cho gọn:

**a) JWT key không bind được → BE trả 500 toàn bộ khi bật auth.**
- Code đọc: `builder.Configuration.GetSection(nameof(JwtOption))` → cần các key
  `JwtOption:Issuer`, `JwtOption:Audience`, `JwtOption:AccessTokenKey`.
- `docker-compose.yml` lại set `Jwt__*` (sai tiền tố) → `AccessTokenKey` rỗng →
  `SymmetricSecurityKey(Encoding.UTF8.GetBytes(""))` ném lỗi → 500.
- **Vá tạm:** set `JwtOption__Issuer`, `JwtOption__Audience`, `JwtOption__AccessTokenKey`
  (đủ dài, ≥ 32 ký tự cho HS256) qua ENV.
- **Nên làm:** đưa `JwtOption` vào `appsettings.json`, hoặc sửa compose cho đúng tiền tố
  `JwtOption__*`.

**b) AdminAuth chưa cấu hình → không đăng nhập admin được.**
- Cần `AdminAuth:Username` / `AdminAuth:Password`.
- **Vá tạm:** ENV `AdminAuth__Username=admin`, `AdminAuth__Password=perlunas123`.
- **Nên làm:** đặt trong config chuẩn, đổi mật khẩu thật.

---

## 9. Hợp đồng API mà FE đang phụ thuộc

| Endpoint | Dùng cho |
|---|---|
| `GET /api/services/{tour\|hotel\|combo}?...` | List có phân trang + lọc |
| `GET /api/services/{slug}` | Chi tiết |
| `GET /api/taxonomies?group=...` | Bộ lọc (vùng miền, nơi đến, loại hình, tier, mục đích) |
| `GET /api/page-contents` | Toàn bộ text/ảnh CMS |
| `GET /api/site-settings` | Thông tin công ty (1 dòng) |
| `GET /api/blogs` | Blog |

**Quy ước response:** bọc trong `{ value: [...] }` (BasePaginationResponse/BaseResponse),
enum serialize thành số, JSON camelCase. FE đã map đúng theo quy ước này.

---

## 10. Blog — ĐÃ ENRICH (2026-07-03)

Entity `Blog` đã thêm 3 field để FE dùng được: **`Slug`**, **`Cover`**, **`Content`**
(richtext HTML). Kèm:
- `BlogResponse` / `CreateBlogRequest` / `UpdateBlogRequest`: thêm Slug/Cover/Content.
- `BlogService`: map 3 field + method **`GetBySlugAsync`**.
- `BlogsController`: route mới **`GET /api/blogs/slug/{slug}`** (trả kèm `recentBlogs` 3 bài).
- `BlogConfiguration`: `HasMaxLength` cho Slug/Cover + `HasIndex(Slug)`.
- Migration `EnrichBlogSlugCoverContent` (đã apply). Seed 6 blog đủ slug/cover/content HTML.

FE trang blog (`/blog`, `/blog/{slug}`) giờ đọc 100% từ đây.

## 11. Việc BE nên làm tiếp

1. **CRUD Taxonomy + PageContent + SiteSetting + Blog** ổn định cho admin (GET/PUT/POST/DELETE).
2. Sửa dứt điểm config JWT/AdminAuth (mục 8) — hiện chạy nhờ ENV override `jwt-fix.local.yml` (local, đừng commit).
3. Xem lại `ComputePriceFrom` cho khớp business giá.
4. (Tuỳ) thêm `MessagesController` nếu muốn lead vào CMS thay vì webhook FE.
