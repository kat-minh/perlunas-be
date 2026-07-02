# Perlunas CMS — Hệ thống Quản lý Nội dung Du lịch

## 1. Tổng quan hệ thống

### 1.1. Công nghệ
| Thành phần | Công nghệ |
|---|---|
| Runtime | .NET 8 (ASP.NET Core Web API) |
| ORM | Entity Framework Core 8 |
| Database | PostgreSQL (Npgsql) |
| Auth | JWT Bearer (access token) |
| Validation | FluentValidation |
| Solution structure | 3 projects: `Cms.API`, `Cms.Service`, `Cms.Repository` |

### 1.2. Kiến trúc
- **Cms.Repository** — Entities, Configurations (Fluent API), Seeds, Enums, DbContext, Migrations
- **Cms.Service** — Business logic, Validation, DTOs (Request/Response), Models (ApiResponse)
- **Cms.API** — Controllers, Middleware (Exception handling, JWT config), Program.cs

### 1.3. Luồng xử lý chung
```
Client → Controller → Service (Validate → Business Logic → DB) → Response
```
- GET endpoints: **Public** (không cần token)
- POST/PUT/DELETE: **[Authorize]** (yêu cầu JWT Bearer token)
- Mọi response đều bọc trong `ApiResponse` / `BasePaginationResponse` với `TraceId`

### 1.4. Response format

**Success (single object):**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "...",
  "value": { ... }
}
```

**Success (pagination):**
```json
{
  "isSuccess": true,
  "value": {
    "items": [...],
    "pageIndex": 1,
    "pageSize": 10,
    "totalCount": 50,
    "hasNextPage": true,
    "hasPreviousPage": false
  },
  "traceId": "HTP123",
  "timestampUtc": "..."
}
```

**Error:**
```json
{
  "title": "Not Found",
  "status": 404,
  "detail": "Service not found.",
  "messageCode": "NOT_FOUND",
  "errors": null,
  "traceId": "HTP123",
  "timestampUtc": "..."
}
```

**Paginate sanitize:** pageIndex ≤ 0 → 1, pageSize ≤ 0 → 10, clamped `Min(pageSize, 100)`

---

## 2. Entities

### 2.1. Service (Dịch vụ)
`BaseEntity<Guid>`, `IAuditableEntity` — Lưu 3 loại dịch vụ (Tour, Combo, Hotel) trong 1 bảng, dùng cột `Type` (enum) để phân biệt.

| Field | Type | Ghi chú |
|---|---|---|
| Id | Guid (PK) | |
| Title | string? | |
| Introducetion | string? | Chỉ Hotel có |
| Day | int? | Chỉ Tour có |
| Night | int? | Tour + Combo có |
| Label | string? | Chỉ Combo có |
| Album | string? | JSON array of image URLs |
| Region | string? | |
| Description | string? | Tour + Combo có |
| Infor | string? | Tour + Combo có |
| Highlight | string? | Tour + Combo có |
| Code | string? | Tour + Combo có |
| Instruct | string? | Chỉ Hotel có |
| Feature | string? | Chỉ Hotel có |
| **Type** | `ServiceType` (enum) | **Tour / Combo / Hotel** |
| IsPublic | bool | |
| **PurposeOfTrip** | `PurposeOfTrip?` (enum) | Combo + Hotel |
| Destination | string? | Combo + Hotel |
| Form | string? | Combo + Hotel |
| **Classify** | `Classify?` (enum) | Chỉ Combo |
| IsDeleted | bool (BaseEntity) | Soft delete |
| CreatedAt | DateTime | |
| UpdatedAt | DateTime? | |

**Relationships:**
- Service 1→ N Schedule (không check Type)
- Service 1→ N RoomCategory (chỉ Combo & Hotel mới được tạo)
- Service 1→ N DepartureSchedule (chỉ Tour mới được tạo)
- Service 1→ N ImportantInfor (chỉ Tour & Combo mới được tạo)

### 2.2. Schedule (Lịch trình)
| Field | Type |
|---|---|
| Id | Guid |
| ServiceId | Guid (FK → Service) |
| Day | string? |
| Titile | string? |
| Sumary | string? |
| Description | string? |

### 2.3. RoomCategory (Hạng phòng)
| Field | Type | Ghi chú |
|---|---|---|
| Id | Guid | |
| ServiceId | Guid (FK → Service) | |
| Album | string? | JSON array |
| Titile | string? | |
| NumberOfCustomer | int? | |
| Acreage | string? | |
| NumberOfBed | string? | |
| Description | string? | |
| Feature | string? | |
| Price | string? | null nếu service là Combo |
| OriginalPrice | string? | Giá gốc (hiển thị gạch ngang) |
| Unit | string? | Đơn vị (vd: "đêm", "người") |

### 2.4. DepartureSchedule (Lịch khởi hành)
| Field | Type |
|---|---|
| Id | Guid |
| ServiceId | Guid (FK → Service) |
| StartTime | string? |
| Code | string? |
| Price | string? |
| AccommodationStandards | string? |

### 2.5. ImportantInfor (Thông tin quan trọng)
| Field | Type |
|---|---|
| Id | Guid |
| ServiceId | Guid (FK → Service) |
| Title | string? |
| SubTitle | string? |
| Description | string? |

### 2.6. PageContent (Nội dung trang)
**Self-referencing recursive tree** — `ParentId` → `SetNull` on delete (FK tự tham chiếu).
**Composite index:** `(PageKey, SectionKey, Key)`

| Field | Type | Ghi chú |
|---|---|---|
| Id | Guid | |
| ParentId | Guid? | nullable, FK→PageContent, ON DELETE SET NULL |
| PageKey | string? | |
| SectionKey | string? | |
| Key | string? | |
| ContentValue | string? | |
| Label | string? | |
| Kind | string? | |
| SoftOrder | int? | |
| Children | `ICollection<PageContent>` | Navigation (đệ quy) |

### 2.7. Blog
| Field | Type |
|---|---|
| Id | Guid |
| Titile | string? |
| SubTitile | string? |
| Author | string? |
| ReadingTime | string? |
| Description | string? |
| Tag | string? |

### 2.8. SiteSetting (Cấu hình site)
| Field | Type |
|---|---|
| Id | Guid |
| Name | string? |
| LegalName | string? |
| Tagline | string? |
| Manifesto | string? |
| Description | string? |
| Phone | string? |
| Email | string? |
| TaxId | string? |
| OfficesJson | string? |
| SocialJson | string? |

---

## 3. Enums

### `ServiceType` (Lưu DB dưới dạng string)
- `Tour`
- `Combo`
- `Hotel`

### `PurposeOfTrip` (Combo & Hotel)
- `ResortVacation`
- `Sightseeing`
- `BusinessTrip`
- `VisitingRelatives`

### `Classify` (Combo only)
- `Akoya`
- `Ahiti`
- `SouthSea`

### `UserRole` (Auth)
- `Admin`
- `Staff`
- `User`

---

## 4. API Endpoints

### 4.1. Auth
Base: `/api/auth`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| POST | `/login` | ❌ | Đăng nhập, trả JWT | `{ username, password }` | `{ accessToken, tokenType: "Bearer", expiresInMinutes }` |
| POST | `/logout` | ✅ | Đăng xuất | — | `{ message }` |

### 4.2. Services
Base: `/api/services`

| Method | Endpoint | Auth | Mô tả | Request body / Query | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách tất cả service (phân trang) | `?pageIndex&pageSize` | Pagination → `ServiceResponse[]` |
| GET | `/tours` | ❌ | Lọc Tour theo title/region | `?keyword&pageIndex&pageSize` | Pagination → `ServiceResponse[]` |
| GET | `/combos` | ❌ | Lọc Combo (title/destination/form/classify/purposeOfTrip) | `?keyword&destination&form&classify&purposeOfTrip&pageIndex&pageSize` | Pagination → `ServiceResponse[]` |
| GET | `/hotels` | ❌ | Lọc Hotel (title/destination/form/purposeOfTrip) | `?keyword&destination&form&purposeOfTrip&pageIndex&pageSize` | Pagination → `ServiceResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết service | — | `ServiceResponse` |
| POST | `/tours` | ✅ | Tạo Tour | `CreateTourRequest` | `ServiceResponse` |
| POST | `/combos` | ✅ | Tạo Combo | `CreateComboRequest` | `ServiceResponse` |
| POST | `/hotels` | ✅ | Tạo Hotel | `CreateHotelRequest` | `ServiceResponse` |
| PUT | `/{id}` | ✅ | Cập nhật service | `UpdateServiceRequest` | `ServiceResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm service | — | `string` |

#### Request DTOs:
- **CreateTourRequest:** Title, Day, Night, Album[], Region, Description, Infor, Highlight, Code, IsPublic
- **CreateComboRequest:** Title, Night, Label, Album[], Region, Description, Infor, Highlight, Code, PurposeOfTrip, Destination, Form, Classify, IsPublic
- **CreateHotelRequest:** Title, Introducetion, Album[], Region, Instruct, Feature, PurposeOfTrip, Destination, Form, IsPublic
- **UpdateServiceRequest:** tất cả fields (phải gửi Type để xác định logic set fields)

#### ServiceResponse (trả ra):
```
Id, Title, Introducetion, Day, Night, Label, Album[], Region, Description, Infor,
Highlight, Code, Instruct, Feature, Type (enum), IsPublic, PurposeOfTrip? (enum),
Destination?, Form?, Classify? (enum), CreatedAt, UpdatedAt
```

### 4.3. Schedules
Base: `/api/schedules`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `ScheduleResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `ScheduleResponse` |
| POST | `/` | ✅ | Tạo | body | `ScheduleResponse` |
| PUT | `/{id}` | ✅ | Cập nhật | body | `ScheduleResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm | — | `string` |

**CreateScheduleRequest:** ServiceId, Day, Titile, Sumary, Description

**ScheduleResponse:** Id, ServiceId, Day, Titile, Sumary, Description, CreatedAt, UpdatedAt

### 4.4. RoomCategories
Base: `/api/room-categories`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `RoomCategoryResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `RoomCategoryResponse` |
| POST | `/` | ✅ | Tạo (chỉ Combo/Hotel, Combo→Price=null) | body | `RoomCategoryResponse` |
| PUT | `/{id}` | ✅ | Cập nhật | body | `RoomCategoryResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm | — | `string` |

**CreateRoomCategoryRequest:** ServiceId, Album[], Titile, NumberOfCustomer, Acreage, NumberOfBed (string), Description, Feature, Price?, OriginalPrice?, Unit?

**RoomCategoryResponse:** Id, ServiceId, Album[], Titile, NumberOfCustomer, Acreage, NumberOfBed (string), Description, Feature, Price?, OriginalPrice?, Unit?, CreatedAt, UpdatedAt

### 4.5. DepartureSchedules
Base: `/api/departure-schedules`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `DepartureScheduleResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `DepartureScheduleResponse` |
| POST | `/` | ✅ | Tạo (chỉ Tour) | body | `DepartureScheduleResponse` |
| PUT | `/{id}` | ✅ | Cập nhật (chỉ Tour) | body | `DepartureScheduleResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm (chỉ Tour) | — | `string` |

**CreateDepartureScheduleRequest:** ServiceId, StartTime, Code, Price, AccommodationStandards

### 4.6. ImportantInfors
Base: `/api/important-infors`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `ImportantInforResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `ImportantInforResponse` |
| POST | `/` | ✅ | Tạo (chỉ Tour/Combo) | body | `ImportantInforResponse` |
| PUT | `/{id}` | ✅ | Cập nhật (chỉ Tour/Combo) | body | `ImportantInforResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm (chỉ Tour/Combo) | — | `string` |

**CreateImportantInforRequest:** ServiceId, Title, SubTitle, Description

### 4.7. PageContents
Base: `/api/page-contents`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách phẳng (phân trang) | query params | Pagination → `PageContentResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết kèm cây Children | — | `PageContentResponse (có Children)` |
| POST | `/` | ✅ | Tạo (có ParentId) | body | `PageContentResponse` |
| PUT | `/{id}` | ✅ | Cập nhật | body | `PageContentResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm (thu gom hết descendants) | — | `string` |

**CreatePageContentRequest:** ParentId?, PageKey, SectionKey, Key, ContentValue, Label, Kind, SoftOrder

**PageContentResponse:** Id, ParentId, PageKey, SectionKey, Key, ContentValue, Label, Kind, SoftOrder, CreatedAt, UpdatedAt, Children[]

### 4.8. Blogs
Base: `/api/blogs`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `BlogResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `BlogResponse` |
| POST | `/` | ✅ | Tạo | body | `BlogResponse` |
| PUT | `/{id}` | ✅ | Cập nhật | body | `BlogResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm | — | `string` |

**BlogResponse:** Id, Titile, SubTitile, Author, ReadingTime, Description, Tag, CreatedAt, UpdatedAt

### 4.9. SiteSettings
Base: `/api/site-settings`

| Method | Endpoint | Auth | Mô tả | Request | Response |
|---|---|---|---|---|---|
| GET | `/` | ❌ | Danh sách (phân trang) | query params | Pagination → `SiteSettingResponse[]` |
| GET | `/{id}` | ❌ | Chi tiết | — | `SiteSettingResponse` |
| POST | `/` | ✅ | Tạo | body | `SiteSettingResponse` |
| PUT | `/{id}` | ✅ | Cập nhật | body | `SiteSettingResponse` |
| DELETE | `/{id}` | ✅ | Xoá mềm | — | `string` |

**SiteSettingResponse:** Id, Name, LegalName, Tagline, Manifesto, Description, Phone, Email, TaxId, OfficesJson, SocialJson, CreatedAt, UpdatedAt

---

## 5. Business Logic & Constraints

### 5.1. Service Type Rules
Khi **tạo mới** service, mỗi Type có DTO riêng (CreateTourRequest, CreateComboRequest, CreateHotelRequest) — chỉ chứa fields hợp lệ.

Khi **cập nhật** (PUT), dùng `UpdateServiceRequest` chung + `ApplyTypeFields` để reset các field không thuộc Type đó về null và set các field thuộc Type.

| Field | Tour | Combo | Hotel |
|---|---|---|---|
| Introducetion | ❌ | ❌ | ✅ |
| Day | ✅ | ❌ | ❌ |
| Night | ✅ | ✅ | ❌ |
| Label | ❌ | ✅ | ❌ |
| Description | ✅ | ✅ | ❌ |
| Infor | ✅ | ✅ | ❌ |
| Highlight | ✅ | ✅ | ❌ |
| Code | ✅ | ✅ | ❌ |
| Instruct | ❌ | ❌ | ✅ |
| Feature | ❌ | ❌ | ✅ |
| PurposeOfTrip | ❌ | ✅ | ✅ |
| Destination | ❌ | ✅ | ✅ |
| Form | ❌ | ✅ | ✅ |
| Classify | ❌ | ✅ | ❌ |

### 5.2. Child entity constraints theo Service Type

| Entity | Tour | Combo | Hotel | Logic |
|---|---|---|---|---|
| **Schedule** | ✅ | ✅ | ✅ | Không check Type |
| **RoomCategory** | ❌ | ✅ | ✅ | Combo → Price=null |
| **ImportantInfor** | ✅ | ✅ | ❌ | — |
| **DepartureSchedule** | ✅ | ❌ | ❌ | — |

### 5.3. Soft delete
- Tất cả entities kế thừa `BaseEntity<Guid>` → có field `IsDeleted`
- DELETE → set `IsDeleted = true`, `UpdatedAt = now` (không xoá vật lý)
- Mọi query đều filter `WHERE IsDeleted = false`

### 5.4. PageContent — Recursive tree
- Self-referencing FK: `ParentId` → `Id`, `OnDelete(SetNull)`
- GET `{id}` : trả về item + tree `Children` (đệ quy)
- DELETE `{id}` : tìm tất cả descendants (đệ quy) → soft delete toàn bộ
- Composite index: `(PageKey, SectionKey, Key)`

### 5.5. Album
- Lưu DB dạng JSON string: `["url1.jpg", "url2.jpg"]`
- Service/RoomCategory: serialize khi ghi, deserialize khi đọc → `List<string>` trong response

### 5.6. Auth
- JWT Bearer, access token duy nhất
- Login: verify `AdminAuth:Username/Password` trong appsettings.json
- 1 Admin mặc định (configurable)
- `[Authorize]` trên mọi POST/PUT/DELETE, GET public

### 5.7. Enum fields (Service)
- `Type`, `PurposeOfTrip`, `Classify` là enum trong C#, lưu DB dưới dạng string (HasConversion)
- Request/Response dùng enum trực tiếp, không dùng string

---

## 6. Seed data

System được seed với 3 services và các child tương ứng:

**Services:**
- `ServiceMain` — Tour, Code="PLN-001", Region="Vietnam", Day=3, Night=2
- `ServiceResort` — Hotel, Code="PLN-002", Region="Da Nang", PurposeOfTrip=ResortVacation, Destination="Da Nang Beach", Form="Full-board"
- `ServicePrivate` — Combo, Code="PLN-003", Region="Hoi An", PurposeOfTrip=Sightseeing, Destination="Hoi An Ancient Town", Form="Half-board", Classify=Akoya

**Child seeds:**
- Schedule: 4 items (2→Tour, 1→Hotel, 1→Combo) — không SubTitile
- RoomCategory: 3 items — NumberOfBed là string, có OriginalPrice + Unit, RoomSuite (Combo) Price=null
- DepartureSchedule: 3 items (all→Tour)
- ImportantInfor: 3 items (Policy→Tour, Resort→Combo, Private→Combo)
- PageContent: 3 parents + 2 children (đệ quy)
- Blog: 3 items
- SiteSetting: 3 items

---

## 7. Cấu trúc thư mục

```
Cms.API/
├── Controllers/         # Auth, Blogs, PageContents, Services, Schedules, RoomCategories, DepartureSchedules, ImportantInfors, SiteSettings
├── Middlewares/         # Exception handling, JWT
├── Extentions/         # Helper extensions
└── Program.cs

Cms.Service/
├── Auth/               # Login/Logout
├── Blog/               # Blog CRUD
├── PageContent/        # PageContent CRUD + recursive tree
├── Service/            # Service CRUD + ApplyTypeFields + search APIs
│   └── Validations/    # FluentValidation per request
├── Schedule/           # Schedule CRUD
├── RoomCategory/       # RoomCategory CRUD
├── DepartureSchedule/  # DepartureSchedule CRUD
├── ImportantInfor/     # ImportantInfor CRUD
├── SiteSetting/        # SiteSetting CRUD
├── JwtService/         # JWT token generation
└── Models/             # ApiResponse, ApiResponseFactory

Cms.Repository/
├── Entities/           # 8 entity classes
├── Configurations/     # Fluent API configs per entity
│   └── Seeds/          # SeedIds + seed data per entity
├── Enums/              # ServiceType, PurposeOfTrip, Classify, UserRole
├── Abstractions/       # BaseEntity, IAuditableEntity
├── Migrations/         # EF Core migrations
└── AppDbContext.cs
```
