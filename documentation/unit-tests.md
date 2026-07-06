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
| Kết quả hiện tại | **208 PASS, 1 SKIP, 0 FAIL** (tổng 209) |

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
| | | `GetAllAsync_WithNonPositivePaging_ShouldUseDefaults` — pageIndex/pageSize ≤0 → mặc định 1/10 (Theory 2 case) | PASS |
| `GET api/blogs/{id:guid}` | `Blog.Service.GetByIdAsync` | `GetByIdAsync_WhenBlogExists_ShouldReturnBlog` | PASS |
| | | `GetByIdAsync_WhenBlogDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WhenBlogIsDeleted_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WhenExists_ShouldReturnBlogWithRecentBlogs` — trả blog + 3 recent | PASS |
| | | `GetByIdAsync_WhenNotFound_ShouldThrowNotFound` | PASS |
| `GET api/blogs/slug/{slug}` | `Blog.Service.GetBySlugAsync` | `GetBySlugAsync_WhenBlogExists_ShouldReturnBlog` | PASS |
| | | `GetBySlugAsync_WhenBlogDoesNotExist_ShouldThrowNotFound` | PASS |
| `POST api/blogs` | `Blog.Service.CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateBlog` — tạo + sinh slug | PASS |
| | | `CreateAsync_WithDuplicateTitle_ShouldAppendSuffix` — trùng tiêu đề → slug thêm `-1` | PASS |
| | | `CreateAsync_WithTitleGeneratingEmptySlug_ShouldFallbackToGuid` — tiêu đề chỉ ký tự đặc biệt → fallback Guid | PASS |
| `PUT api/blogs/{id:guid}` | `Blog.Service.UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdateBlog` — cập nhật title, **giữ slug cũ** | PASS |
| | | `UpdateAsync_WhenBlogDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `UpdateAsync_WhenNotFound_ShouldThrowNotFound` | PASS |
| | | `UpdateAsync_WithTitleExistingElsewhere_ShouldKeepSlugUnchanged` — đổi title trùng blog khác → vẫn giữ slug cũ | PASS |
| `DELETE api/blogs/{id:guid}` | `Blog.Service.DeleteAsync` | `DeleteAsync_WhenBlogExists_ShouldSoftDelete` | PASS |
| | | `DeleteAsync_WhenBlogDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `DeleteAsync_WhenExists_ShouldSoftDeleteAndReturnMessage` — soft-delete + message | PASS |
| | | `DeleteAsync_WhenNotFound_ShouldThrowNotFound` | PASS |

- Pagination: kiểm tra `PageIndex`, `PageSize`, `TotalCount`, `HasNextPage`, `HasPreviousPage`.
- Exception: dùng `FluentAssertions` `.Should().ThrowAsync<TException>()`.
### 2.3. Services (Tour/Combo/Hotel) — `api/services` (`ServicesController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/services` | `Service.Service.GetAllAsync` | `GetAllAsync_ShouldReturnPaginated` | PASS |
| | | `GetAllAsync_InvalidPage_ShouldClamp` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` | PASS |
| | | `GetAllLists_WithNoData_ShouldReturnEmpty` | PASS |
| | | `Slug_ShouldBeUniqueAcrossAllTypes` | PASS |
| `GET api/services/tours` | `GetToursAsync` | `GetToursAsync_ShouldOnlyReturnTours` | PASS |
| | | `GetToursAsync_KeywordFilterByTitle` | PASS |
| | | `GetToursAsync_KeywordFilterByRegion` | PASS |
| `GET api/services/combos` | `GetCombosAsync` | `GetCombosAsync_ShouldOnlyReturnCombos` | PASS |
| | | `GetCombosAsync_WithMultipleFilters_ShouldIntersect` | PASS |
| `GET api/services/hotels` | `GetHotelsAsync` | `GetHotelsAsync_ShouldOnlyReturnHotels` | PASS |
| | | `GetHotelsAsync_WithFilters_ShouldIntersect` | PASS |
| `GET api/services/{key}` | `GetByKeyAsync` | `GetByKeyAsync_BySlug_ShouldReturnService` | PASS |
| | | `GetByKeyAsync_ById_ShouldReturnService` | PASS |
| | | `GetByKeyAsync_WhenNotFound_ShouldThrowNotFound` | PASS |
| | | `GetByKeyAsync_WhenDeleted_ShouldThrowNotFound` | PASS |
| | | `GetByKeyAsync_ForTour_ShouldIncludeRelatedHotels` | PASS |
| | | `GetByKeyAsync_ForTourWithNoRegion_ShouldReturnEmptyRelatedHotels` | PASS |
| | | `GetByKeyAsync_ForNonTour_ShouldNotIncludeRelated` | PASS |
| | | `GetByKeyAsync_ForTour_ShouldRankRelatedToursBySameRegionThenClosestPrice` | PASS |
| | | `GetByKeyAsync_ForTour_ShouldComputePriceFromDepartureSchedule` | PASS |
| | | `GetByKeyAsync_ForHotel_ShouldComputePriceFromRoomCategory` | PASS |
| | | `GetByKeyAsync_ForCombo_ShouldFallbackPriceFromOriginalPrice` — giá cấp gói (OriginalPrice), không lấy hạng phòng | PASS |
| | | `GetByKeyAsync_ShouldIncludeAllChildren` | PASS |
| | | `GetByKeyAsync_DeletedService_ShouldStillBeAccessibleViaIdIfNotDeletedInSameScope` | PASS |
| `POST api/services/tours` | `CreateTourAsync` | `CreateTourAsync_WithValidRequest_ShouldCreateTourWithChildren` | PASS |
| | | `CreateTourAsync_DuplicateTitle_ShouldAppendSuffix` — trùng tiêu đề → slug thêm `-1` | PASS |
| | | `CreateTourAsync_EmptySlugTitle_ShouldFallbackToGuid` | PASS |
| `POST api/services/combos` | `CreateComboAsync` | `CreateComboAsync_WithValidRequest_ShouldCreateComboWithChildren` — hạng phòng KHÔNG mang giá (Price/OriginalPrice/Unit = null) | PASS |
| | | `CreateComboAsync_DuplicateTitle_ShouldAppendSuffix` — combo dùng `GenerateUniqueSlugAsync` như tour/hotel → trùng tiêu đề thêm hậu tố -1 | PASS |
| `POST api/services/hotels` | `CreateHotelAsync` | `CreateHotelAsync_WithValidRequest_ShouldCreateHotelWithChildren` | PASS |
| | | `CreateHotelAsync_DuplicateSlug_ShouldAppendSuffix` | PASS |
| `PUT api/services/{id:guid}` | `UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdateAndReplaceChildren` — đổi title KHÔNG đổi slug (giữ slug cũ) | PASS |
| | | `UpdateAsync_ForHotel_ShouldReplaceRoomCategories` | PASS |
| | | `UpdateAsync_WhenNotFound_ShouldThrow` | PASS |
| | | `UpdateAsync_DuplicateTitle_ShouldKeepSlugUnchanged` — Update không regenerate slug ngay cả khi trùng title khác | PASS |
| | | `UpdateAsync_SameTitle_ShouldRegenerateSameSlug` | PASS |
| `DELETE api/services/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenServiceExists_ShouldSoftDeleteWithChildren` | PASS |
| | | `DeleteAsync_WhenNotFound_ShouldThrow` | PASS |

> **Lưu ý:** `CreateComboAsync` đã được sửa dùng `GenerateUniqueSlugAsync` (như Tour/Hotel) → tạo combo trùng tiêu đề tự thêm hậu tố `-1`, `-2`... không còn `DbUpdateException` khi DB có unique-index. `UpdateAsync` **giữ slug cố định** sau khi tạo (đổi title không đổi URL) — tránh vỡ link/bookmark/ISR đã build.

### 2.4. Forms — `api/forms` (`FormsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/forms` | `Form.Service.GetAllAsync` | `GetAllAsync_ShouldReturnPagedForms` — phân trang theo type | PASS |
| | | `GetAllAsync_WithFilterType_ShouldReturnOnlyMatchingType` — lọc theo FormType | PASS |
| | | `GetAllAsync_WithSearchQuery_ShouldReturnMatchingForms` — tìm kiếm theo email/fullname/phone | PASS |
| | | `GetAllAsync_WithDetails_ShouldIncludeFormDetailsNested` — BookingForm có FormDetails lồng | PASS |
| `GET api/forms/{key}` | `Form.Service.GetByKeyAsync` | `GetByKeyAsync_WithValidId_ShouldReturnCorrectForm` — tìm theo Guid | PASS |
| | | `GetByKeyAsync_WithValidSlug_ShouldReturnCorrectForm` — tìm theo slug | PASS |
| | | `GetByKeyAsync_WhenNotFound_ShouldThrowNotFoundException` — không có → `NotFoundException` | PASS |
| `POST api/forms/advise` | `CreateAdviseAsync` | `CreateAdviseAsync_WithValidRequest_ShouldCreateFormAndSendMail` — tạo FormType.Advise + gửi mail | PASS |
| | | `CreateAdviseAsync_WhenValidationFails_ShouldThrowValidationException` — dùng validator thật, thiếu FullName + sai email → `ValidationException` | PASS |
| `POST api/forms/tour` | `CreateTourAsync` | `CreateTourAsync_WithValidRequest_ShouldCreateForm` — tạo FormType.Tour | PASS |
| | | `CreateTourAsync_WhenServiceNotFound_ShouldThrowNotFound` — ServiceId không có → `NotFoundException` | PASS |
| `POST api/forms/combo` | `CreateComboAsync` | `CreateComboAsync_WithValidRequest_ShouldCreateFormWithDetails` — tạo FormType.Combo + FormDetails | PASS |
| | | `CreateComboAsync_WhenServiceNotComboType_ShouldThrowBadRequest` — service không phải Combo → `BadRequestException` | PASS |
| | | `CreateComboAsync_WithInvalidRoomCategory_ShouldThrowBadRequest` — hạng phòng không tồn tại → `BadRequestException` | PASS |
| `POST api/forms/hotel` | `CreateHotelAsync` | `CreateHotelAsync_WhenServiceNotHotelType_ShouldThrowBadRequest` → `BadRequestException` | PASS |
| | | `CreateBookingAsync_WhenServiceNotFound_ShouldThrowNotFound` → `NotFoundException` | PASS |

### 2.5. PageContents — `api/page-contents` (`PageContentsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/page-contents` | `PageContent.Service.GetAllAsync` | `GetAllAsync_WithNoFilters_ShouldReturnAllOrdered` | PASS |
| | | `GetAllAsync_ByPageKey_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_BySectionKey_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_CombinedFilters_ShouldIntersect` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` | PASS |
| | | `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/page-contents/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenPageContentExists_ShouldReturnPageContent` | PASS |
| | | `GetByIdAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WhenPageContentIsDeleted_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WithChildren_ShouldBuildTree` — trả cây con | PASS |
| `POST api/page-contents` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreatePageContent` | PASS |
| | | `CreateAsync_WithParentId_WhenParentExists_ShouldCreateWithParent` | PASS |
| | | `CreateAsync_WithParentId_WhenParentNotFound_ShouldThrowNotFound` | PASS |
| `PUT api/page-contents/{id:guid}` | `UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdatePageContent` | PASS |
| | | `UpdateAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `UpdateAsync_WithNewParentId_WhenParentNotFound_ShouldThrowNotFound` | PASS |
| `DELETE api/page-contents/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenPageContentExists_ShouldSoftDelete` | PASS |
| | | `DeleteAsync_WhenPageContentDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `DeleteAsync_ShouldCascadeToChildren` — xoá cha → xoá con (cascade) | PASS |
| | | `DeleteAsync_ShouldCascadeSoftDeleteDescendants` — xoá cha → xoá con/cháu (cascade sâu) | PASS |

### 2.6. SiteSettings — `api/site-settings` (`SiteSettingsController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/site-settings` | `SiteSetting.Service.GetAllAsync` | `GetAllAsync_WithNoFilters_ShouldReturnAllNonDeleted` | PASS |
| | | `GetAllAsync_WithIdFilter_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_WithIdFilter_ShouldReturnSingleMatching` | PASS |
| | | `GetAllAsync_WithNameFilter_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_WithTaglineFilter_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` | PASS |
| | | `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/site-settings/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenSiteSettingExists_ShouldReturnSiteSetting` | PASS |
| | | `GetByIdAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WhenSiteSettingIsDeleted_ShouldThrowNotFound` | PASS |
| `POST api/site-settings` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateSiteSetting` | PASS |
| `PUT api/site-settings/{id:guid}` | `UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdateSiteSetting` | PASS |
| | | `UpdateAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound` | PASS |
| `DELETE api/site-settings/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenSiteSettingExists_ShouldSoftDelete` | PASS |
| | | `DeleteAsync_WhenSiteSettingDoesNotExist_ShouldThrowNotFound` | PASS |

### 2.7. Taxonomies — `api/taxonomies` (`TaxonomiesController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `GET api/taxonomies` | `Taxonomy.Service.GetAllAsync` | `GetAllAsync_WithNoFilter_ShouldReturnAllOrdered` | PASS |
| | | `GetAllAsync_WithGroupFilter_ShouldReturnMatching` | PASS |
| | | `GetAllAsync_ShouldExcludeDeleted` | PASS |
| | | `GetAllAsync_WithNoData_ShouldReturnEmpty` | PASS |
| `GET api/taxonomies/{id:guid}` | `GetByIdAsync` | `GetByIdAsync_WhenTaxonomyExists_ShouldReturnTaxonomy` | PASS |
| | | `GetByIdAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `GetByIdAsync_WhenTaxonomyIsDeleted_ShouldThrowNotFound` | PASS |
| `POST api/taxonomies` | `CreateAsync` | `CreateAsync_WithValidRequest_ShouldCreateTaxonomy` — sinh slug `mien-bac` | PASS |
| | | `CreateAsync_WithDuplicateGroupAndName_ShouldThrowConflict` — trùng group+name → `ConflictException` | PASS |
| | | `CreateAsync_SameNameDifferentGroup_ShouldCreate` — cùng name khác group → OK | PASS |
| | | `CreateAsync_WithDuplicateSlug_ShouldAppendSuffix` — trùng slug → thêm `-1` | PASS |
| | | `CreateAsync_WithEmptySlugGeneration_ShouldFallbackToGuid` | PASS |
| `PUT api/taxonomies/{id:guid}` | `UpdateAsync` | `UpdateAsync_WithValidRequest_ShouldUpdateFields` — đổi Color/SortOrder (không đổi name để tránh cascade) | PASS |
| | | `UpdateAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `UpdateAsync_WithNameConflictingInSameGroup_ShouldThrowConflict` | PASS |
| | | `UpdateAsync_SameNameInDifferentGroups_ShouldNotConflict` | PASS |
| | | `UpdateAsync_WhenRenameRegion_ShouldCascadeToServices` — cascade rename vào Service.Region | **SKIP** |
| `DELETE api/taxonomies/{id:guid}` | `DeleteAsync` | `DeleteAsync_WhenTaxonomyExists_ShouldSoftDelete` | PASS |
| | | `DeleteAsync_WhenTaxonomyDoesNotExist_ShouldThrowNotFound` | PASS |
| | | `DeleteAsync_WhenTaxonomyIsReferencedByService_ShouldThrowConflict` — đang được Service dùng → `ConflictException` | PASS |
| | | `DeleteAsync_WhenReferencingServiceIsDeleted_ShouldAllowDelete` — Service đã soft-delete → cho xoá | PASS |

> **SKIP `UpdateAsync_WhenRenameRegion_ShouldCascadeToServices`:** Service dùng `ExecuteUpdateAsync` (bulk update) để cascade rename. EF Core **InMemory provider không hỗ trợ** `ExecuteUpdateAsync` (ném "could not be translated"). Để test nhánh này cần chuyển sang **SQLite in-memory** hoặc **Testcontainers + PostgreSQL**. Logic cascade đã được review mã nguồn.

### 2.8. Cloudinary — `api/cloudinary` (`CloudinaryController`)

| API | Service method | Test cases | Trạng thái |
|---|---|---|---|
| `POST api/cloudinary/upload` | `CloudinaryService.Service.UploadImageAsync` | `UploadImageAsync_WhenCloudinaryNotConfigured_ShouldThrowServerException` — thiếu env CloudName/ApiKey/ApiSecret → `ServerException` (500) rõ ràng | PASS |
| | | `UploadImageAsync_WithNullFile_ShouldThrowBadRequest` — file null → `BadRequestException` (400) | PASS |
| | | `UploadImageAsync_WithEmptyFile_ShouldThrowBadRequest` — file rỗng → `BadRequestException` (400) | PASS |
| | | `UploadImageAsync_WhenFileExceeds10MB_ShouldThrowBadRequest` — file > 10 MB → `BadRequestException` (400) | PASS |

> **Lưu ý:** Upload thật gọi Cloudinary API (network) → không test được trong CI. Các test chỉ phủ phần **validation** (null/empty/oversize/định dạng) và **cấu hình thiếu** (→ `ServerException` 500). Constructor lazy-init: thiếu env không ném ở DI register, chỉ ném rõ ràng khi gọi `UploadImageAsync`. Phần gọi `_cloudinary.UploadAsync` cần mock hoặc test tích hợp với credentials thật.

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
| `MailService.Service.SendMail` | `SendMail_WithValidMailContent_ShouldNotThrow_BestEffort` — host giả (smtp.invalid.example) → MailKit ném khi ConnectAsync, nhưng Service nuốt lỗi (best-effort) → không ném | PASS |
| | `SendMail_WhenConfigMissing_ShouldNotThrow_BestEffort` — thiếu config → Service return sớm, không ném | PASS |
| `constructor` | `Constructor_WithFullConfig_ShouldBindAllOptions` / `Constructor_WithEmptyConfig_ShouldNotThrowAtConstructionTime` | PASS |

> **Lưu ý:** `SendMail` dùng MailKit `SmtpClient` thật → không có SMTP server trong CI. Service theo **best-effort** (nuốt lỗi SMTP, không làm hỏng luồng form đã lưu) nên 2 test xác nhận `SendMail` **không ném** cả khi config đầy đủ (host giả) và khi thiếu config. Để test đầy đủ cần SMTP giả (vd: `netDumbster`/`Papercut`) hoặc mock `ISmtpClient`.

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
| Blog | `Blog\ServiceTests.cs` | 23 | CRUD + paging + slug (create unique, update giữ cố định) |
| Cloudinary | `CloudinaryService\ServiceTests.cs` | 4 | validation + config thiếu (ServerException) |
| Form | `Form\ServiceTests.cs` | 16 | GetAll/GetByKey + 4 Create* (advise/tour/combo/hotel) |
| JwtService | `JwtSvc\ServiceTests.cs` | 10 | GenerateAccessToken |
| MailService | `MailSvc\ServiceTests.cs` | 4 | constructor + SendMail best-effort (NotThrow) |
| PageContent | `PageContent\ServiceTests.cs` | 25 | CRUD + tree + cascade delete |
| Service (Tour/Combo/Hotel) | `Service\ServiceTests.cs` | 39 | CRUD 3 loại + filter + GetByKey (related/price) + update children + slug |
| SiteSetting | `SiteSetting\ServiceTests.cs` | 21 | CRUD + filter id/name/tagline |
| Taxonomy | `Taxonomy\ServiceTests.cs` | 31 | CRUD + conflict + slug + delete-in-use + 1 SKIP (cascade rename) |
| Utils.Slug | `Utils\SlugTests.cs` | 26 | Theory nhiều case (26 test case) |
| **Tổng** | | **209** (208 pass + 1 skip) | |

---

## 4. Các điểm cần cải thiện (phát hiện khi viết test)

1. **`Taxonomy.CascadeRenameAsync` dùng `ExecuteUpdateAsync`** — không tương thích EF Core InMemory. Để test cần SQLite/Postgres. **Gợi ý:** thêm test project dùng SQLite in-memory cho các nhánh bulk-update.

2. **`Slug.GenerateSlug` không trim `-` đầu/cuối** — `"- Đà Nẵng - "` → `"-da-nang-"`. Có thể gây slug lỗi nếu input có space đầu/cuối. **Gợi ý:** thêm `.Trim('-')` cuối.

3. **`CloudinaryService.UploadImageAsync` chỉ kiểm tra đuôi file + content-type** — không kiểm tra magic-bytes, file `.jpg` chứa PDF vẫn qua (nếu content-type là image/*). Đã thêm giới hạn 10 MB và exception rõ ràng (`BadRequestException`/`ServerException`/`BadGatewayException`), constructor lazy-init. **Gợi ý:** kiểm tra magic-bytes để chặn triệt để file giả mạo đuôi.

4. **`MailService.SendMail` hard-depend `SmtpClient`** — khó test đơn vị (đã chuyển sang best-effort, nuốt lỗi để không phá luồng form). **Gợi ý:** bọc `ISmtpClient` abstraction để mock được.

5. **Form validator mock** trong test cũ setup `ValidateAsync(ValidationContext<T>)` nhưng `ValidateAndThrowAsync` có thể gọi overload khác → test validation-fail dùng **validator thật** (`CreateAdviseFormRequestValidator`) để đảm bảo chạy rule.

> **Đã xử lý (cập nhật gần đây):**
> - `CreateComboAsync` giờ dùng `GenerateUniqueSlugAsync` (như Tour/Hotel) → combo trùng tiêu đề tự thêm hậu tố `-1`, `-2`..., không còn `DbUpdateException`.
> - `Blog/Service.UpdateAsync` và `Service.UpdateAsync` **giữ slug cố định** sau tạo (đổi title không đổi URL) → tránh vỡ link/bookmark/ISR đã build.
> - `CloudinaryService` constructor lazy-init (thiếu env không ném khi DI register, chỉ ném `ServerException` rõ ràng khi gọi upload).

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

