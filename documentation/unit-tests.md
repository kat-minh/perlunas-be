# Tài liệu Unit Test — Tầng Service (Cms.Service.Tests)

> **Mục tiêu:** Mô tả chi tiết các unit test phủ trên từng hàm trong tầng service và tương ứng với API (controller) nào. Tài liệu này giúp theo dõi nhanh trường hợp nào được kiểm tra cho mỗi API.

## 1. Tổng quan

| Mục | Giá trị |
|---|---|
| Framework test | xUnit 2.5 + FluentAssertions 6.12 + Moq 4.20 |
| EF Core provider test | `Microsoft.EntityFrameworkCore.InMemory` 8.0 |
| Target | .NET 8 |
| Project test | `Cms.Service.Tests\Cms.Service.Tests.csproj` |
| Lệnh chạy | `dotnet test Cms.Service.Tests\Cms.Service.Tests.csproj` |
| Kết quả hiện tại | **220 PASS, 1 SKIP, 0 FAIL** (tổng 221) |

### Cấu trúc thư mục test

```
Cms.Service.Tests/
├── Auth\ServiceTests.cs              # Đăng nhập / đăng xuất (Auth)
├── Blog\ServiceTests.cs              # CRUD Blog
├── CloudinaryService\ServiceTests.cs # Upload ảnh
├── Form\ServiceTests.cs              # Form tư vấn / tour / booking
├── JwtSvc\ServiceTests.cs            # Sinh JWT
├── MailSvc\ServiceTests.cs           # Gửi mail (SMTP)
├── PageContent\ServiceTests.cs       # CRUD nội dung trang (có tree)
├── Service\ServiceTests.cs           # CRUD Tour/Combo/Hotel (Service)
├── SiteSetting\ServiceTests.cs       # CRUD cấu hình site
├── Taxonomy\ServiceTests.cs          # CRUD danh mục + cascade
├── Utils\SlugTests.cs                # Sinh slug tiếng Việt
└── TestHelper\DictionaryConfiguration.cs  # IConfiguration giả cho test
```

### Nguyên tắc test dùng trong repo
- Mỗi service dùng **EF Core InMemory** với DB name ngẫu nhiên (`Guid`) → test cô lập, không xung đột.
- Validator (FluentValidation) được **mock** bằng `Moq` cho nhanh (trừ test validation-fail dùng validator thật).
- Soft-delete: kiểm tra `IsDeleted == true` qua `IgnoreQueryFilters()`.

---

## 2. Bảng ánh xạ API → Service → Test

> Cột **API** = endpoint controller. Cột **Service method** = hàm service được controller gọi. Cột **Test** = tên test method phủ trường hợp đó.

### 2.1. Auth — `api/auth` (`AuthController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `POST api/auth/login` | `Auth.Service.Login` | `Login_WithCorrectCredentials_ShouldReturnToken` — đăng nhập đúng → trả JWT (3 phần), TokenType=Bearer, ExpiresInMinutes | PASS |
| | | `Login_WithCorrectCredentials_ShouldContainAdminRoleAndSubjectClaims` — JWT chứa claim Role=Admin, Sub, Jti, iss, aud | PASS |
| | | `Login_WithWrongPassword_ShouldThrowUnauthorized` — sai mật khẩu → `UnauthorizedException` | PASS |
| | | `Login_WithWrongUsername_ShouldThrowUnauthorized` — sai username → `UnauthorizedException` | PASS |
| | | `Login_WithBothWrong_ShouldThrowUnauthorized` — sai cả hai → `UnauthorizedException` | PASS |
| | | `Login_WithEmptyCredentials_ShouldThrowUnauthorized` — rỗng → `UnauthorizedException` | PASS |
| | | `Login_WhenConfigHasNullCredentials_ShouldThrowUnauthorized` — thiếu config AdminAuth → `UnauthorizedException` | PASS |
| | | `Login_ShouldRespectExpireInMinutesFromOptions` — ExpiresInMinutes theo option | PASS |
| | | `Login_ShouldGenerateUniqueJtiEachCall` — 2 lần login → 2 token khác nhau | PASS |
| `POST api/auth/logout` | `Auth.Service.Logout` | `Logout_ShouldReturnSuccessMessage` — trả message "Logged out successfully." | PASS |

### 2.2. Blogs — `api/blogs` (`BlogsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/blogs` | `Blog.Service.GetAllAsync` | `GetAllAsync_WithBlogs_ShouldReturnPaginatedResult` — phân trang đúng | PASS |
| | | `GetAllAsync_WithDeletedBlogs_ShouldExcludeDeleted` — bỏ qua soft-deleted | PASS |
| | | `GetAllAsync_WithNoBlogs_ShouldReturnEmpty` — không có data → rỗng | PASS |
| | | `GetAllAsync_WithNonPositivePaging_ShouldUseDefaults` — pageIndex/pageSize ≤0 → mặc định 1/10 | PASS |
| `GET api/blogs/{id:guid}` | `Blog.Service.GetByIdAsync` | `GetByIdAsync_WhenExists_ShouldReturnBlogWithRecentBlogs` — trả blog + 3 recent | PASS |
| | | `GetByIdAsync_WhenNotFound_ShouldThrowNotFound` — không có → `NotFoundException` | PASS |
| `GET api/blogs/slug/{slug}` | `Blog.Service.GetBySlugAsync` | `GetBySlugAsync_WhenBlogDoesNotExist_ShouldThrowNotFound` — slug không có → `NotFoundException` | PASS |
| `POST api/blogs` | `Blog.Service.CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateBlog` — tạo + sinh slug `test-blog-title` | PASS |
| | | `CreateAsync_WithDuplicateTitle_ShouldAppendSuffix` — trùng tiêu đề → slug thêm `-1` | PASS |
| `PUT api/blogs/{id:guid}` | `Blog.Service.UpdateAsync` | `UpdateAsync_WhenNotFound_ShouldThrowNotFound` — không có → `NotFoundException` | PASS |
| `DELETE api/blogs/{id:guid}` | `Blog.Service.DeleteAsync` | `DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage` — soft-delete + message | PASS |
| | | `DeleteAsync_WhenNotFound_ShouldThrowNotFound` — không có → `NotFoundException` | PASS |

- Pagination: kiểm tra `PageIndex`, `PageSize`, `TotalCount`, `HasNextPage`, `HasPreviousPage`.
- Exception: dùng `FluentAssertions` `.Should().ThrowAsync<TException>()`.
### 2.3. Services (Tour/Combo/Hotel) — `api/services` (`ServicesController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/services` | `Service.Service.GetAllAsync` | `GetAllAsync_WithMixedTypes_ShouldReturnAllNonDeleted` *(các test GetAll/GetTours/GetCombos/GetHotels đã có)* | PASS |
| `GET api/services/tours` | `GetToursAsync` | `GetToursAsync_WithKeyword_ShouldFilterByTitleAndRegion` | PASS |
| `GET api/services/combos` | `GetCombosAsync` | `GetCombosAsync_WithFilters_ShouldApplyAllFilters` | PASS |
| `GET api/services/hotels` | `GetHotelsAsync` | `GetHotelsAsync_WithKeyword_ShouldFilter` | PASS |
| `GET api/services/{key}` | `GetByKeyAsync` | `GetByKeyAsync_ForTour_ShouldReturnFullDetail` | PASS |
| | | `GetByKeyAsync_ForCombo_ShouldFallbackPriceFromOriginalPrice` — giá cấp gói (OriginalPrice 4.500.000), không lấy hạng phòng | PASS |
| `POST api/services/tours` | `CreateTourAsync` | `CreateTourAsync_WithValidRequest_ShouldCreateTourWithChildren` | PASS |
| | | `CreateTourAsync_WhenValidationFails_ShouldThrow` | PASS |
| `POST api/services/combos` | `CreateComboAsync` | `CreateComboAsync_WithValidRequest_ShouldCreateComboWithChildren` — hạng phòng KHÔNG mang giá (Price/OriginalPrice/Unit = null) | PASS |
| | | `CreateComboAsync_DuplicateTitle_ShouldUseGeneratedSlugAsIs` — combo dùng `Slug.GenerateSlug` (không kiểm tra trùng) | PASS |
| `POST api/services/hotels` | `CreateHotelAsync` | `CreateHotelAsync_WithValidRequest_ShouldCreateHotelWithRoomCategories` | PASS |
| `PUT api/services/{id:guid}` | `UpdateAsync` | `UpdateAsync_ForTour_ShouldReplaceSchedulesAndImportantInfors` — soft-delete children cũ | PASS |
| | | `UpdateAsync_ForHotel_ShouldReplaceRoomCategories` | PASS |
| | | `UpdateAsync_WhenNotFound_ShouldThrow` | PASS |
| `DELETE api/services/{id:guid}` | `DeleteAsync` | *(test delete soft-delete service)* | PASS |

> **Lưu ý quan trọng (đã phát hiện khi viết test):** `CreateComboAsync` dùng `Slug.GenerateSlug(title)` mà **không** gọi `GenerateUniqueSlugAsync` như Tour → khi DB thật có unique-index trên `Slug`, tạo combo trùng tiêu đề sẽ ném `DbUpdateException` ở `SaveChangesAsync`. InMemory không ép unique-index nên test vẫn pass, nhưng đây là **điểm cần cải thiện** của service. Ghi nhận trong test `CreateComboAsync_DuplicateTitle_ShouldUseGeneratedSlugAsIs`.

### 2.4. Forms — `api/forms` (`FormsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/forms` | `Form.Service.GetAllAsync` | `GetAllAsync_ShouldReturnPagedForms` — phân trang theo type | PASS |
| | | `GetAllAsync_ShouldReturnBookingFormWithRoomCategoryDetails` — BookingForm có FormDetails | PASS |
| `GET api/forms/{key}` | `Form.Service.GetByKeyAsync` | `GetByKeyAsync_WithValidId_ShouldReturnCorrectForm` — tìm theo Guid | PASS |
| | | `GetByKeyAsync_WithValidSlug_ShouldReturnCorrectForm` — tìm theo slug | PASS |
| | | `GetByKeyAsync_WhenNotFound_ShouldThrowNotFoundException` — không có → `NotFoundException` | PASS |
| `POST api/forms/advise` | `CreateAdviseAsync` | `CreateAdviseAsync_WithValidRequest_ShouldCreateFormAndSendMail` — tạo FormType.Advise + gửi mail | PASS |
| | | `CreateAdviseAsync_WhenValidationFails_ShouldThrowValidationException` — dùng validator thật, thiếu FullName + sai email → `ValidationException` | PASS |
| `POST api/forms/tour` | `CreateTourAsync` | `CreateTourAsync_WithValidRequest_ShouldCreateForm` — tạo FormType.Tour | PASS |
| | | `CreateTourAsync_WhenServiceNotFound_ShouldThrowNotFound` — ServiceId không có → `NotFoundException` | PASS |
| `POST api/forms/combo` | `CreateComboAsync` | `CreateComboAsync_WithValidRequest_ShouldCreateFormWithDetails` — tạo FormType.Combo + FormDetails | PASS |
| | | `CreateComboAsync_WhenServiceNotComboType_ShouldThrowBadRequest` — service không phải Combo → `BadRequestException(SERVICE_MUST_BE_COMBO_TYPE)` | PASS |
| | | `CreateComboAsync_WithInvalidRoomCategory_ShouldThrowBadRequest` — hạng phòng không tồn tại → `BadRequestException(INVALID_ROOM_CATEGORY)` | PASS |
| `POST api/forms/hotel` | `CreateHotelAsync` | `CreateHotelAsync_WhenServiceNotHotelType_ShouldThrowBadRequest` → `BadRequestException(SERVICE_MUST_BE_HOTEL_TYPE)` | PASS |
| | | `CreateBookingAsync_WhenServiceNotFound_ShouldThrowNotFound` → `NotFoundException` | PASS |

### 2.5. PageContents — `api/page-contents` (`PageContentsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/page-contents` | `PageContent.Service.GetAllAsync` | `GetAllAsync_WithPageKeyFilter` / `GetAllAsync_WithSectionKeyFilter` / `GetAllAsync_CombinedFilters_ShouldIntersect` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` / `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/page-contents/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenExists_ShouldReturnWithChildrenTree` — trả cây con | PASS |
| | | `GetByIdAsync_WhenNotFound_ShouldThrowNotFound` / `GetByIdAsync_WhenDeleted_ShouldThrowNotFound` | PASS |
| `POST api/page-contents` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreatePageContent` | PASS |
| | | `CreateAsync_WithParentId_WhenParentExists_ShouldCreateWithParent` / `CreateAsync_WithParentId_WhenParentNotExists_ShouldThrow` | PASS |
| `PUT api/page-contents/{id:guid}` | `UpdateAsync` | *(test update có parent)* | PASS |
| `DELETE api/page-contents/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage` | PASS |
| | | `DeleteAsync_ShouldCascadeSoftDeleteDescendants` — xoá cha → xoá con/cháu (cascade) | PASS |
| | | `DeleteAsync_WhenNotFound_ShouldThrowNotFound` | PASS |

### 2.6. SiteSettings — `api/site-settings` (`SiteSettingsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/site-settings` | `SiteSetting.Service.GetAllAsync` | `GetAllAsync_WithNameFilter` / `GetAllAsync_WithTaglineFilter` / `GetAllAsync_WithIdFilter_ShouldReturnSingleMatching` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` / `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/site-settings/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenExists_ShouldReturnSiteSetting` / `GetByIdAsync_WhenNotFound_ShouldThrowNotFound` / `GetByIdAsync_WhenDeleted_ShouldThrowNotFound` | PASS |
| `POST api/site-settings` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateSiteSetting` | PASS |
| `PUT api/site-settings/{id:guid}` | `UpdateAsync` | `UpdateAsync_WhenNotFound_ShouldThrowNotFound` *(+ update thành công)* | PASS |
| `DELETE api/site-settings/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage` / `DeleteAsync_WhenNotFound_ShouldThrowNotFound` | PASS |

### 2.7. Taxonomies — `api/taxonomies` (`TaxonomiesController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/taxonomies` | `Taxonomy.Service.GetAllAsync` | `GetAllAsync_ShouldOrderByGroupThenSortOrder` / `GetAllAsync_WithGroupFilter_ShouldReturnMatching` / `GetAllAsync_ShouldExcludeDeleted` / `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/taxonomies/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenExists_ShouldReturnTaxonomy` / `GetByIdAsync_WhenNotFound_ShouldThrowNotFound` / `GetByIdAsync_WhenDeleted_ShouldThrowNotFound` | PASS |
| `POST api/taxonomies` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateTaxonomy` — sinh slug `mien-bac` | PASS |
| | | `CreateAsync_WithDuplicateGroupAndName_ShouldThrowConflict` — trùng group+name → `ConflictException` | PASS |
| `PUT api/taxonomies/{id:guid}` | `UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdateFields` — đổi Color/SortOrder (không đổi name để tránh cascade) | PASS |
| | | `UpdateAsync_WhenNotFound_ShouldThrowNotFound` | PASS |
| | | `UpdateAsync_WhenNewNameConflictsInSameGroup_ShouldThrowConflict` | PASS |
| | | `UpdateAsync_WhenRenameRegion_ShouldCascadeToServices` — cascade rename vào Service.Region | **SKIP** |
| `DELETE api/taxonomies/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage` | PASS |
| | | `DeleteAsync_WhenNotFound_ShouldThrowNotFound` | PASS |
| | | `DeleteAsync_WhenInUseByService_ShouldThrowConflict` — đang được Service dùng → `ConflictException` | PASS |
| | | `DeleteAsync_WhenInUseByDeletedService_ShouldAllowDelete` — Service đã soft-delete → cho xoá | PASS |

> **SKIP `UpdateAsync_WhenRenameRegion_ShouldCascadeToServices`:** Service dùng `ExecuteUpdateAsync` (bulk update) để cascade rename. EF Core **InMemory provider không hỗ trợ** `ExecuteUpdateAsync` (ném "could not be translated"). Để test nhánh này cần chuyển sang **SQLite in-memory** hoặc **Testcontainers + PostgreSQL**. Logic cascade đã được review mã nguồn.

### 2.8. Cloudinary — `api/cloudinary` (`CloudinaryController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `POST api/cloudinary/upload` | `CloudinaryService.Service.UploadImageAsync` | `UploadImageAsync_WithNullFile_ShouldThrow` — file null → `ArgumentException("File is empty or null")` | PASS |
| | | `UploadImageAsync_WithEmptyFile_ShouldThrow` — file rỗng → `ArgumentException` | PASS |
| | | `UploadImageAsync_WithNonImageExtension_ShouldThrow` — pdf/zip/mp4/mp3/noext → `ArgumentException("File is not an image")` | PASS |
| | | `UploadImageAsync_WithAllowedImageExtension_ShouldPassFormatCheck` — jpg/jpeg/png/gif/webp (+ chữ hoa) qua bước định dạng | PASS |
| | | `UploadImageAsync_WithDotJpgButPdfContent_ShouldStillPassFormatCheck` — chỉ kiểm tra đuôi file, không kiểm tra magic-bytes | PASS |
| | | `Constructor_WithMissingCloudName_ShouldThrowArgumentException` — thiếu config → CloudinaryDotNet ném | PASS |
| | | `Constructor_WithValidConfig_ShouldInstantiate` | PASS |

> **Lưu ý:** Upload thật gọi Cloudinary API (network) → không test được trong CI. Các test chỉ phủ phần **validation** (null/empty/đuôi file) và constructor. Phần gọi `_cloudinary.UploadAsync` cần mock Cloudinary hoặc test tích hợp với credentials thật.

### 2.9. JwtService (internal — không có controller riêng)

| Service method | Test cases | Trạng thái |
|---|---|---|
| `JwtService.Service.GenerateAccessToken` | `GenerateAccessToken_WithValidClaims_ShouldReturnJwtString` — JWT 3 phần | PASS |
| | `GenerateAccessToken_ShouldEncodeIssuerAudienceAndClaims` — iss/aud/claims đúng | PASS |
| | `GenerateAccessToken_ShouldSetExpiryFromOption` — exp = now + AccessTokenExpireMin | PASS |
| | `GenerateAccessToken_WithEmptyClaims_ShouldStillProduceToken` | PASS |
| | `GenerateAccessToken_ShouldUseHmacSha256Algorithm` — header.Alg = HS256 | PASS |
| | `GenerateAccessToken_WithShortKey_ShouldThrow` — key < 128 bit → `ArgumentException` | PASS |
| | `GenerateAccessToken_WithEmptyKey_ShouldThrow` | PASS |
| | `GenerateAccessToken_ShouldProduceDifferentTokensForDifferentClaims` | PASS |
| | `GenerateAccessToken_ShouldBeVerifiableWithSameKey` — verify token bằng cùng key | PASS |
| | `GenerateAccessToken_WithNullClaims_ShouldProduceTokenWithEmptyClaims` — null → token vẫn sinh | PASS |

### 2.10. MailService (internal — dùng bởi Form)

| Service method | Test cases | Trạng thái |
|---|---|---|
| `MailService.Service.SendMail` | `SendMail_WithValidMailContent_ShouldAttemptSmtpConnect` — config đầy đủ → đi tới bước ConnectAsync (host giả → ném) | PASS |
| | `SendMail_WhenConfigMissing_ShouldFailBeforeOrAtConnect` — thiếu config → ném | PASS |
| `constructor` | `Constructor_WithFullConfig_ShouldBindAllOptions` / `Constructor_WithEmptyConfig_ShouldNotThrowAtConstructionTime` | PASS |

> **Lưu ý:** `SendMail` dùng MailKit `SmtpClient` thật → không có SMTP server trong CI. Test chỉ xác nhận config bind đúng và luồng đi tới bước kết nối. Để test đầy đủ cần SMTP giả (vd: `netDumbster`/`Papercut`) hoặc mock `ISmtpClient`.

### 2.11. Utils.Slug (hàm tiện ích)

| Function | Test cases | Trạng thái |
|---|---|---|
| `Slug.GenerateSlug` | `GenerateSlug_VietnameseText_ShouldRemoveDiacritics` — "Miền Bắc"→`mien-bac`, "Đà Nẵng"→`da-nang`... (Theory 6 case) | PASS |
| | `GenerateSlug_MixedSeparatorsAndPunctuation_ShouldNormalize` — khoảng trắng/dấu câu (Theory 6 case) | PASS |
| | `GenerateSlug_MixedCase_ShouldBeLowercase` | PASS |
| | `GenerateSlug_EmptyOrWhitespace_ShouldReturnEmpty` — ""/"   "/null (Theory 3) | PASS |
| | `GenerateSlug_OnlySpecialChars_ShouldReturnEmpty` — "@#$"/"!!!"/"——" (Theory 3) | PASS |
| | `GenerateSlug_WithNumbers_ShouldKeepDigits` (Theory 3) | PASS |
| | `GenerateSlug_WithCafeAccent_ShouldStripDiacriticToCafe` — "Café"→`cafe` | PASS |
| | `GenerateSlug_ShouldBeIdempotentForAlreadySlugged` | PASS |
| | `GenerateSlug_LeadingAndTrailingHyphens_ShouldProduceHyphensAtEdges` — "- Đà Nẵng - "→`-da-nang-` (KHÔNG trim gạch đầu/cuối) | PASS |

> **Lưu ý:** `GenerateSlug` không trim dấu `-` ở đầu/cuối. Test phản ánh behavior hiện tại — có thể xem xét cải thiện.


---

## 3. Danh sách test theo Service (tóm tắt số lượng)

| Service | File test | Số test | Ghi chú |
|---|---|---|---|
| Auth | `Auth\ServiceTests.cs` | 10 | Login (8) + Logout (1) + ... |
| Blog | `Blog\ServiceTests.cs` | ~13 | CRUD + paging + recentBlogs |
| Cloudinary | `CloudinaryService\ServiceTests.cs` | 9 | validation + constructor |
| Form | `Form\ServiceTests.cs` | ~14 | GetAll/GetByKey + 4 Create* |
| JwtService | `JwtSvc\ServiceTests.cs` | 10 | GenerateAccessToken |
| MailService | `MailSvc\ServiceTests.cs` | 4 | constructor + SendMail (network) |
| PageContent | `PageContent\ServiceTests.cs` | ~13 | CRUD + tree + cascade delete |
| Service (Tour/Combo/Hotel) | `Service\ServiceTests.cs` | ~50+ | CRUD 3 loại + filter + update children |
| SiteSetting | `SiteSetting\ServiceTests.cs` | ~16 | CRUD + filter id/name/tagline |
| Taxonomy | `Taxonomy\ServiceTests.cs` | ~20 | CRUD + conflict + delete-in-use + 1 SKIP |
| Utils.Slug | `Utils\SlugTests.cs` | ~25 | Theory nhiều case |
| **Tổng** | | **221** (220 pass + 1 skip) | |

---

## 4. Các điểm cần cải thiện (phát hiện khi viết test)

1. **`CreateComboAsync` không kiểm tra slug trùng** — dùng `Slug.GenerateSlug(title)` thay vì `GenerateUniqueSlugAsync` như Tour. Khi DB có unique-index, tạo combo trùng tiêu đề sẽ `DbUpdateException`. **Gợi ý:** dùng `GenerateUniqueSlugAsync` cho combo giống tour.

2. **`Taxonomy.CascadeRenameAsync` dùng `ExecuteUpdateAsync`** — không tương thích EF Core InMemory. Để test cần SQLite/Postgres. **Gợi ý:** thêm test project dùng SQLite in-memory cho các nhánh bulk-update.

3. **`Slug.GenerateSlug` không trim `-` đầu/cuối** — `"- Đà Nẵng - "` → `"-da-nang-"`. Có thể gây slug lỗi nếu input có space đầu/cuối. **Gợi ý:** thêm `.Trim('-')` cuối.

4. **`CloudinaryService.UploadImageAsync` chỉ kiểm tra đuôi file** — không kiểm tra magic-bytes, file `.jpg` chứa PDF vẫn qua. **Gợi ý:** kiểm tra cả content-type hoặc magic-bytes.

5. **`MailService.SendMail` hard-depend `SmtpClient`** — khó test đơn vị. **Gợi ý:** bọc `ISmtpClient` abstraction để mock được.

6. **Form validator mock** trong test cũ setup `ValidateAsync(ValidationContext<T>)` nhưng `ValidateAndThrowAsync` có thể gọi overload khác → test validation-fail dùng **validator thật** (`CreateAdviseFormRequestValidator`) để đảm bảo chạy rule.

---

## 5. Cách chạy & xem kết quả

```bash
# Chạy toàn bộ
dotnet test Cms.Service.Tests\Cms.Service.Tests.csproj

# Chạy 1 service
dotnet test Cms.Service.Tests\Cms.Service.Tests.csproj --filter "FullyQualifiedName~Cms.Service.Tests.Taxonomy"

# Chạy 1 test
dotnet test Cms.Service.Tests\Cms.Service.Tests.csproj --filter "FullyQualifiedName~CreateAdviseAsync_WhenValidationFails"

# Báo cáo chi tiết (TRX)
dotnet test Cms.Service.Tests\Cms.Service.Tests.csproj --logger "trx;logfilename=testresults.trx"
```

