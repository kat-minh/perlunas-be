# Perlunas CMS — System Documentation

## 1. Tổng quan

Perlunas CMS là ASP.NET Core Web API (.NET 8) dùng quản lý nội dung du lịch: Tour, Combo, Hotel, Blog, PageContent, SiteSetting và các child data liên quan.

| Layer | Project | Vai trò |
|---|---|---|
| API | `Cms.API` | Controllers, middleware, auth config, Swagger |
| Service | `Cms.Service` | Business logic, DTO request/response, validation |
| Repository | `Cms.Repository` | DbContext, entities, configurations, seeds, migrations |

Database: PostgreSQL qua Npgsql. ORM: EF Core. Auth: JWT Bearer. Validation: FluentValidation.

Luồng chung:
```
Client -> Controller -> Service -> AppDbContext/PostgreSQL -> Response wrapper
```

GET endpoints public. POST/PUT/DELETE yêu cầu Bearer token, trừ `/api/auth/login`.

---

## 2. Response model

- Single object: `ApiResponseFactory.Base(...)`.
- Pagination: `ApiResponseFactory.BasePagination(...)`.
- Error: middleware trả `ErrorResponse` với `title`, `status`, `detail`, `messageCode`, `errors`, `traceId`, `timestampUtc`.

Pagination sanitize:
- `pageIndex <= 0` -> `1`
- `pageSize <= 0` -> `10`
- `pageSize > 100` -> `100`

---

## 3. Entity chính

### Service
Một bảng `Services` chứa cả `Tour`, `Combo`, `Hotel`, phân biệt bằng enum `Type`.

| Field | Type | Ghi chú |
|---|---|---|
| `Id` | Guid | PK |
| `Title` | string? | |
| `Slug` | string | tự sinh từ Title, unique index |
| `BestSeller` | bool | áp dụng mọi type |
| `Introducetion` | string? | Hotel |
| `Day` | int? | Tour |
| `Night` | int? | Tour/Combo |
| `Label` | string? | Combo |
| `Album` | string? | JSON string, response là `string[]` |
| `Region` | string? | dùng filter + related data |
| `Description` | string? | Tour/Combo |
| `Infor` | string? | Tour/Combo |
| `Highlight` | `List<string>` | PostgreSQL `text[]`, Tour/Combo |
| `Code` | string? | Tour/Combo |
| `Instruct` | string? | Hotel |
| `Feature` | string? | Hotel |
| `Type` | ServiceType | string enum in DB |
| `IsPublic` | bool | |
| `PurposeOfTrip` | PurposeOfTrip? | Combo/Hotel |
| `Destination` | string? | Combo/Hotel |
| `Form` | string? | Combo/Hotel |
| `Classify` | Classify? | Combo |
| `IsDeleted` | bool | soft delete |
| `CreatedAt` | DateTime | audit |
| `UpdatedAt` | DateTime? | audit |

Relationships:
- Service 1-N Schedule
- Service 1-N RoomCategory
- Service 1-N DepartureSchedule
- Service 1-N ImportantInfor

Business type rules trong Service layer:

| Field | Tour | Combo | Hotel |
|---|---|---|---|
| Introducetion | no | no | yes |
| Day | yes | no | no |
| Night | yes | yes | no |
| Label | no | yes | no |
| Description | yes | yes | no |
| Infor | yes | yes | no |
| Highlight | yes | yes | no |
| Code | yes | yes | no |
| Instruct | no | no | yes |
| Feature | no | no | yes |
| PurposeOfTrip | no | yes | yes |
| Destination | no | yes | yes |
| Form | no | yes | yes |
| Classify | no | yes | no |

### Child entities

#### Schedule
`ServiceId`, `Day`, `Titile`, `Sumary`, `Description`, audit + soft delete.

#### RoomCategory
`ServiceId`, `Album` JSON string, `Titile`, `NumberOfCustomer`, `Acreage`, `NumberOfBed`, `Description`, `Feature` JSON string, `Price`, `OriginalPrice`, `Unit`, audit + soft delete.

#### DepartureSchedule
`ServiceId`, `StartTime`, `Code`, `Price`, `AccommodationStandards`, audit + soft delete.

#### ImportantInfor
`ServiceId`, `Title`, `SubTitle`, `Description`, audit + soft delete.

### PageContent
Self-referencing tree:
- `ParentId` nullable FK -> `PageContent.Id`
- delete behavior: `SetNull`
- `GET /api/page-contents/{id}` trả subtree `children[]`
- `DELETE` soft delete node + descendants
- composite index `(PageKey, SectionKey, Key)`

### Blog
Fields: `Titile`, `SubTitile`, `Author`, `ReadingTime`, `Description`, `Tag`, audit + soft delete.

Blog detail response có `recentBlogs`: tối đa 3 blog khác mới tạo gần nhất.

### SiteSetting
Fields: `Name`, `LegalName`, `Tagline`, `Manifesto`, `Description`, `Phone`, `Email`, `TaxId`, `OfficesJson`, `SocialJson`, audit + soft delete.

---

## 4. Service detail enrichments

### Tour related data
`GET /api/services/{id}` nếu service là Tour:
- `relatedTours`: tối đa 3 Tour khác.
  - lấy Tour cùng `Region` trước, sort newest first.
  - nếu chưa đủ 3, lấy Tour khác region có giá gần nhất với Tour hiện tại.
  - giá tính từ số nhỏ nhất extract được trong `DepartureSchedules.Price`.
- `relatedHotels`: tối đa 3 Hotel cùng `Region`, sort newest first.

### Blog related data
`GET /api/blogs/{id}`:
- `recentBlogs`: tối đa 3 blog khác, sort `CreatedAt DESC`.

---

## 5. API endpoint map

### Auth — `/api/auth`
| Method | Endpoint | Auth |
|---|---|---|
| POST | `/login` | public |
| POST | `/logout` | Bearer |

### Services — `/api/services`
| Method | Endpoint | Auth |
|---|---|---|
| GET | `/` | public |
| GET | `/tours` | public |
| GET | `/combos` | public |
| GET | `/hotels` | public |
| GET | `/{id:guid}` | public |
| POST | `/tours` | Bearer |
| POST | `/combos` | Bearer |
| POST | `/hotels` | Bearer |
| PUT | `/{id:guid}` | Bearer |
| DELETE | `/{id:guid}` | Bearer |

### Child CRUD
| Resource | Base |
|---|---|
| Schedules | `/api/schedules` |
| RoomCategories | `/api/room-categories` |
| DepartureSchedules | `/api/departure-schedules` |
| ImportantInfors | `/api/important-infors` |

Each supports: `GET /`, `GET /{id}`, `POST /`, `PUT /{id}`, `DELETE /{id}`.

### Content/Settings
| Resource | Base | Notes |
|---|---|---|
| PageContents | `/api/page-contents` | detail includes tree; delete descendants |
| Blogs | `/api/blogs` | detail includes `recentBlogs` |
| SiteSettings | `/api/site-settings` | standard CRUD |

---

## 6. DTO highlights

### ServiceResponse additions
- `slug`: generated URL-friendly title.
- `bestSeller`: boolean flag.
- `highlight`: `string[]`.
- `relatedTours`: Tour detail only.
- `relatedHotels`: Tour detail only.

### Create/Update service
- CreateTourRequest/CreateComboRequest: `highlight: string[]`, `bestSeller: bool`.
- CreateHotelRequest: `bestSeller: bool`.
- UpdateServiceRequest: `highlight?: string[]`, `bestSeller?: bool`, `type` required by validation.

### BlogResponse additions
- `recentBlogs?: BlogResponse[]` only populated by blog detail endpoint.

---

## 7. Seed data hiện tại

Seed chính gồm:
- Tour chính: `Perlunas Signature Tour`, region `Vietnam`, slug `perlunas-signature-tour`, bestseller true.
- Combo: `Private Custom Journey`.
- Hotel gốc: `Beach Resort Package`.
- 4 hotel mới region `Vietnam` để test `relatedHotels`.
- 2 tour mới cùng region `Vietnam` + 1 tour region `Thailand` để test `relatedTours` và fallback theo giá.
- 10 RoomCategories gắn với Tour chính để test relationship.
- RoomCategories cho các hotel seed.
- DepartureSchedules cho tour chính và tour mới.
- Schedule, ImportantInfor, PageContent, Blog, SiteSetting seed mặc định.

Migrations đã cập nhật DB:
- slug/bestSeller.
- extra seed data.
- `Highlight` từ `text` sang PostgreSQL `text[]`.

---

## 8. Notes triển khai

- `Slug.GenerateSlug(title)` nằm trong `Cms.Service/Utils/Slug.cs`.
- `Album` và `RoomCategory.Feature` vẫn lưu DB dạng JSON string, service serialize/deserialize sang `List<string>`.
- `Highlight` khác `Album`: entity lưu trực tiếp `List<string>`, DB type `text[]`.
- Soft delete không xoá vật lý; query lọc `IsDeleted = false`.
