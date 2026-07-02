# Perlunas CMS — API Reference

> Base URL: `https://your-domain.com/api`
>
> Auth: JWT Bearer token — header `Authorization: Bearer <token>`
>
> Mọi response từ controller/service được wrap bởi `ApiResponse`. Riêng 401 thiếu token và 403 từ ASP.NET Authorization có thể trả default ASP.NET response nếu request bị chặn trước middleware custom.

---

## Global Response Formats

### ✅ Success (single object) — `BaseResponse`
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": { ... }
}
```

### ✅ Success (pagination) — `BasePaginationResponse`
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "items": [...],
    "pageIndex": 1,
    "pageSize": 10,
    "totalCount": 50,
    "hasNextPage": true,
    "hasPreviousPage": false
  }
}
```

### ❌ Error — `ErrorResponse`
```json
{
  "title": "Not Found",
  "status": 404,
  "detail": "Service not found.",
  "messageCode": "NOT_FOUND",
  "errors": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z"
}
```

### ❌ Validation Error (400)
```json
{
  "title": "Validation Failed",
  "status": 400,
  "detail": "Validation failed message",
  "messageCode": "VALIDATION_ERROR",
  "errors": {
    "Title": "TITLE_REQUIRED",
    "Region": "REGION_REQUIRED"
  },
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z"
}
```

### Pagination sanitize
| Input | Kết quả |
|---|---|
| `pageIndex ≤ 0` | → 1 |
| `pageSize ≤ 0` | → 10 |
| `pageSize > 100` | → 100 |

---

## Enums

### ServiceType
| Value | Mô tả |
|---|---|
| `Tour` | Dịch vụ tour du lịch |
| `Combo` | Dịch vụ combo (tour + khách sạn) |
| `Hotel` | Dịch vụ khách sạn |

### PurposeOfTrip
| Value | Mô tả |
|---|---|
| `ResortVacation` | Nghỉ dưỡng |
| `Sightseeing` | Tham quan |
| `BusinessTrip` | Công tác |
| `VisitingRelatives` | Thăm thân |

### Classify
| Value | Mô tả |
|---|---|
| `Akoya` | Hạng Akoya |
| `Ahiti` | Hạng Ahiti |
| `SouthSea` | Hạng South Sea |

---

## 1. Auth

---

### POST `/api/auth/login`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Xác thực username/password với thông tin cấu hình trong `appsettings.json` (`AdminAuth:Username` / `AdminAuth:Password`). Nếu đúng, trả về JWT access token dùng cho các request [Authorize] sau này.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `username` | string | ✅ | Admin username |
| `password` | string | ✅ | Admin password |

```json
{
  "username": "admin",
  "password": "yourpassword"
}
```

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "accessToken": "eyJhbGciOiJIUzI1NiIs...",
    "tokenType": "Bearer",
    "expiresInMinutes": 120
  }
}
```

| Response field | Type | Mô tả |
|---|---|---|
| `accessToken` | string | JWT token |
| `tokenType` | string | Luôn là `"Bearer"` |
| `expiresInMinutes` | int | Thời gian hết hạn token (cấu hình trong `JwtOption:AccessTokenExpireMin`, mặc định 120 phút) |

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 401 | UNAUTHORIZED | `"Invalid username or password."` |

---

### POST `/api/auth/logout`

**Auth:** `[Authorize]` — cần JWT Bearer token

**Mô tả:** Thông báo đăng xuất. Phía client tự xoá token lưu trữ.

**Request body:** Không có body.

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "message": "Logged out successfully."
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 401 | Default ASP.NET 401 | Thiếu token — request có thể bị chặn trước custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | `"Access token has expired."` — token hết hạn, trả custom `ErrorResponse` |
| 403 | Default ASP.NET 403 | Token không có quyền Admin — request có thể bị chặn trước custom `ErrorResponse` |

---

## 2. Services

Dưới đây là toàn bộ API cho Service.

---

### GET `/api/services`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả services (Tour + Combo + Hotel) có phân trang, sắp xếp theo `CreatedAt` giảm dần. Mặc định chỉ lấy các service chưa bị xoá mềm (`IsDeleted = false`).

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | Trang hiện tại (≤ 0 → tự động về 1) |
| `pageSize` | int | 10 | Số item mỗi trang (≤ 0 → 10, > 100 → 100) |

**Response 200 — thành công (pagination):**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "items": [
      {
        "id": "a1b2c3d4-...",
        "title": "Explorer Tour",
        "introducetion": "",
        "day": 3,
        "night": 2,
        "label": "",
        "album": ["https://example.com/image1.jpg"],
        "region": "Vietnam",
        "description": "A wonderful tour...",
        "infor": "Includes meals...",
        "highlight": "Beach visit, mountain trek",
        "code": "PLN-001",
        "instruct": "",
        "feature": "",
        "type": "Tour",
        "isPublic": true,
        "purposeOfTrip": null,
        "destination": null,
        "form": null,
        "classify": null,
        "createdAt": "2026-07-02T10:00:00Z",
        "updatedAt": "2026-07-02T10:00:00Z"
      }
    ],
    "pageIndex": 1,
    "pageSize": 10,
    "totalCount": 1,
    "hasNextPage": false,
    "hasPreviousPage": false
  }
}
```

**Mỗi item trong `items` là `ServiceResponse` với cấu trúc:**
| Field | Type | Ghi chú |
|---|---|---|
| `id` | string (guid) | |
| `title` | string | |
| `introducetion` | string | Chỉ Hotel mới có giá trị |
| `day` | int | Chỉ Tour mới != 0 |
| `night` | int | Tour + Combo mới != 0 |
| `label` | string | Chỉ Combo mới có giá trị |
| `album` | array string | Danh sách URL ảnh |
| `region` | string | |
| `description` | string | Tour + Combo mới có giá trị |
| `infor` | string | Tour + Combo mới có giá trị |
| `highlight` | string | Tour + Combo mới có giá trị |
| `code` | string | Tour + Combo mới có giá trị |
| `instruct` | string | Chỉ Hotel mới có giá trị |
| `feature` | string | Chỉ Hotel mới có giá trị |
| `type` | string (enum) | `Tour` / `Combo` / `Hotel` |
| `isPublic` | bool | |
| `purposeOfTrip` | string (enum) or null | Combo + Hotel mới có |
| `destination` | string or null | Combo + Hotel mới có |
| `form` | string or null | Combo + Hotel mới có |
| `classify` | string (enum) or null | Chỉ Combo mới có |
| `schedules` | array | Danh sách `ScheduleResponse` — chỉ có trong response của POST tạo Tour/Combo |
| `importantInfors` | array | Danh sách `ImportantInforResponse` — chỉ có trong response của POST tạo Tour/Combo |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt (nếu không có data thì trả về mảng rỗng).

---

### GET `/api/services/tours`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách service có `Type = Tour` với phân trang và hỗ trợ lọc theo từ khoá (`keyword`). Từ khoá được tìm kiếm trong cả `Title` và `Region` (không phân biệt hoa thường, tìm kiếm chứa chuỗi con).

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `keyword` | string | null (optional) | Tìm trong Title hoặc Region (contains, case-insensitive). Nếu null/trống → bỏ qua filter |
| `pageIndex` | int | 1 | Trang hiện tại |
| `pageSize` | int | 10 | Số item mỗi trang |

**Logic filter:**
```
query = WHERE Type = 'Tour' AND IsDeleted = false
if keyword != null:
    query = query AND (Title ILIKE '%keyword%' OR Region ILIKE '%keyword%')
order by CreatedAt desc
```

**Response 200 — thành công (pagination):** Mỗi item là `ServiceResponse` (chỉ có field Tour mới có giá trị, các field Hotel/Combo = 0 hoặc rỗng).

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/services/combos`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách service có `Type = Combo` với phân trang và hỗ trợ lọc theo nhiều tiêu chí: từ khoá, destination, form, classify, purposeOfTrip.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `keyword` | string | null (optional) | Tìm trong Title (contains, case-insensitive) |
| `destination` | string | null (optional) | Tìm trong Destination (contains, case-insensitive) |
| `form` | string | null (optional) | Tìm trong Form (contains, case-insensitive) |
| `classify` | string | null (optional) | Enum `Classify`: `Akoya`, `Ahiti`, `SouthSea`. Parse case-insensitive. Nếu parse sai → bỏ qua filter |
| `purposeOfTrip` | string | null (optional) | Enum `PurposeOfTrip`: `ResortVacation`, `Sightseeing`, `BusinessTrip`, `VisitingRelatives`. Parse case-insensitive. Nếu parse sai → bỏ qua filter |
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Logic filter:**
```
query = WHERE Type = 'Combo' AND IsDeleted = false
if keyword != null:    query AND Title ILIKE '%keyword%'
if destination != null: query AND Destination ILIKE '%destination%'
if form != null:        query AND Form ILIKE '%form%'
if classify != null:    parse → query AND Classify = parsed_enum
if purposeOfTrip != null: parse → query AND PurposeOfTrip = parsed_enum
order by CreatedAt desc
```

**Response 200 — thành công (pagination):** Mỗi item là `ServiceResponse` với các field Combo được điền đầy đủ.

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/services/hotels`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách service có `Type = Hotel` với phân trang và hỗ trợ lọc theo từ khoá, destination, form, purposeOfTrip.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `keyword` | string | null (optional) | Tìm trong Title (contains, case-insensitive) |
| `destination` | string | null (optional) | Tìm trong Destination (contains, case-insensitive) |
| `form` | string | null (optional) | Tìm trong Form (contains, case-insensitive) |
| `purposeOfTrip` | string | null (optional) | Enum `PurposeOfTrip`. Parse case-insensitive. Nếu parse sai → bỏ qua filter |
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Logic filter:**
```
query = WHERE Type = 'Hotel' AND IsDeleted = false
if keyword != null:    query AND Title ILIKE '%keyword%'
if destination != null: query AND Destination ILIKE '%destination%'
if form != null:        query AND Form ILIKE '%form%'
if purposeOfTrip != null: parse → query AND PurposeOfTrip = parsed_enum
order by CreatedAt desc
```

**Response 200 — thành công (pagination):** Mỗi item là `ServiceResponse` với các field Hotel được điền đầy đủ.

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/services/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một service theo ID. ID phải là GUID hợp lệ. Trả về `ServiceResponse` đầy đủ. Nếu không tìm thấy hoặc đã bị soft delete → trả về lỗi 404.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của service |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "a1b2c3d4-...",
    "title": "Explorer Tour",
    "introducetion": "",
    "day": 3,
    "night": 2,
    "label": "",
    "album": ["https://example.com/image1.jpg"],
    "region": "Vietnam",
    "description": "A wonderful tour...",
    "infor": "Includes meals, hotel...",
    "highlight": "Beach visit, mountain trek",
    "code": "PLN-001",
    "instruct": "",
    "feature": "",
    "type": "Tour",
    "isPublic": true,
    "purposeOfTrip": null,
    "destination": null,
    "form": null,
    "classify": null,
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Service not found."` |

---

### POST `/api/services/tours`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một service loại Tour, **kèm schedules và importantInfors** trong cùng request. Các field thuộc về Combo/Hotel sẽ tự động được bỏ qua (không cần gửi). Album là danh sách URL ảnh, lưu dạng JSON trong DB.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Tên tour |
| `day` | int | ✅ | Số ngày (> 0) |
| `night` | int | ✅ | Số đêm (> 0) |
| `album` | array string | ✅ | Danh sách URL ảnh (tối thiểu 1 phần tử) |
| `region` | string | ✅ | Khu vực |
| `description` | string | ✅ | Mô tả chi tiết |
| `infor` | string | ✅ | Thông tin thêm |
| `highlight` | string | ✅ | Điểm nổi bật |
| `code` | string | ✅ | Mã tour (ví dụ: PLN-001) |
| `isPublic` | bool | ❌ (optional, default false nếu không gửi) | Công khai hay không |
| `schedules` | array | ✅ | Danh sách lịch trình (tối thiểu 1 item). Mỗi item gồm: `day`, `titile`, `sumary`, `description` |
| `importantInfors` | array | ✅ | Danh sách thông tin quan trọng (tối thiểu 1 item). Mỗi item gồm: `title`, `subTitle`, `description` |

```json
{
  "title": "Explorer Tour",
  "day": 3,
  "night": 2,
  "album": ["https://example.com/image1.jpg"],
  "region": "Vietnam",
  "description": "Khám phá vẻ đẹp Việt Nam...",
  "infor": "Bao gồm ăn sáng, khách sạn 3 sao",
  "highlight": "Tham quan vịnh, leo núi",
  "code": "PLN-001",
  "isPublic": true,
  "schedules": [
    {
      "day": "Day 1",
      "titile": "Khởi hành",
      "sumary": "Đón khách tại sân bay",
      "description": "Đón khách, nhận phòng khách sạn, ăn tối chào mừng."
    },
    {
      "day": "Day 2",
      "titile": "Tham quan",
      "sumary": "Khám phá danh lam thắng cảnh",
      "description": "Tham quan vịnh, leo núi, ăn trưa tại nhà hàng địa phương."
    }
  ],
  "importantInfors": [
    {
      "title": "Chính sách hủy",
      "subTitle": "Hủy miễn phí trước 24h",
      "description": "Nếu hủy trước 24 giờ khởi hành, bạn sẽ được hoàn lại toàn bộ chi phí."
    },
    {
      "title": "Lưu ý sức khỏe",
      "subTitle": "Yêu cầu sức khỏe tốt",
      "description": "Tour này bao gồm leo núi, yêu cầu sức khỏe thể chất tốt."
    }
  ]
}
```

**Cấu trúc item trong `schedules`:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `day` | string | ❌ | Ví dụ: "Day 1", "Ngày 1" |
| `titile` | string | ✅ | Tiêu đề lịch trình |
| `sumary` | string | ❌ | Tóm tắt |
| `description` | string | ✅ | Mô tả chi tiết |

**Cấu trúc item trong `importantInfors`:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Tiêu đề |
| `subTitle` | string | ❌ | Tiêu đề phụ |
| `description` | string | ✅ | Mô tả chi tiết |

**Validation rules:**

| Field | Rule | MessageCode |
|---|---|---|
| `Title` | NotEmpty | `TITLE_REQUIRED` |
| `Day` | GreaterThan(0) | `DAY_MUST_BE_GREATER_THAN_ZERO` |
| `Night` | GreaterThan(0) | `NIGHT_MUST_BE_GREATER_THAN_ZERO` |
| `Album` | NotEmpty | `ALBUM_REQUIRED` |
| `Region` | NotEmpty | `REGION_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |
| `Infor` | NotEmpty | `INFOR_REQUIRED` |
| `Highlight` | NotEmpty | `HIGHLIGHT_REQUIRED` |
| `Code` | NotEmpty | `CODE_REQUIRED` |
| `Schedules` | NotEmpty | `SCHEDULES_REQUIRED` |
| `Schedules[*].Titile` | NotEmpty | `SCHEDULE_TITLE_REQUIRED` |
| `Schedules[*].Description` | NotEmpty | `SCHEDULE_DESCRIPTION_REQUIRED` |
| `ImportantInfors` | NotEmpty | `IMPORTANT_INFORS_REQUIRED` |
| `ImportantInfors[*].Title` | NotEmpty | `IMPORTANT_INFOR_TITLE_REQUIRED` |
| `ImportantInfors[*].Description` | NotEmpty | `IMPORTANT_INFOR_DESCRIPTION_REQUIRED` |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid-mới",
    "title": "Explorer Tour",
    "introducetion": "",
    "day": 3,
    "night": 2,
    "label": "",
    "album": ["https://example.com/image1.jpg"],
    "region": "Vietnam",
    "description": "Khám phá vẻ đẹp Việt Nam...",
    "infor": "Bao gồm ăn sáng, khách sạn 3 sao",
    "highlight": "Tham quan vịnh, leo núi",
    "code": "PLN-001",
    "instruct": "",
    "feature": "",
    "type": "Tour",
    "isPublic": true,
    "purposeOfTrip": null,
    "destination": null,
    "form": null,
    "classify": null,
    "schedules": [
      {
        "id": "guid",
        "serviceId": "guid",
        "day": "Day 1",
        "titile": "Khởi hành",
        "sumary": "Đón khách tại sân bay",
        "description": "Đón khách, nhận phòng khách sạn, ăn tối chào mừng.",
        "createdAt": "2026-07-02T10:00:00Z",
        "updatedAt": "2026-07-02T10:00:00Z"
      }
    ],
    "importantInfors": [
      {
        "id": "guid",
        "serviceId": "guid",
        "title": "Chính sách hủy",
        "subTitle": "Hủy miễn phí trước 24h",
        "description": "Nếu hủy trước 24 giờ khởi hành, bạn sẽ được hoàn lại toàn bộ chi phí.",
        "createdAt": "2026-07-02T10:00:00Z",
        "updatedAt": "2026-07-02T10:00:00Z"
      }
    ],
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ (kèm chi tiết từng field trong errors) |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### POST `/api/services/combos`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một service loại Combo, **kèm schedules và importantInfors** trong cùng request. Các field Tour/Hotel không thuộc Combo sẽ tự động bỏ qua.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Tên combo |
| `night` | int | ✅ | Số đêm (> 0) |
| `label` | string | ✅ | Nhãn |
| `album` | array string | ✅ | Danh sách URL ảnh |
| `region` | string | ✅ | Khu vực |
| `description` | string | ✅ | Mô tả |
| `infor` | string | ✅ | Thông tin thêm |
| `highlight` | string | ✅ | Điểm nổi bật |
| `code` | string | ✅ | Mã combo |
| `purposeOfTrip` | string (enum) | ✅ | `ResortVacation`, `Sightseeing`, `BusinessTrip`, `VisitingRelatives` |
| `destination` | string | ✅ | Điểm đến |
| `form` | string | ✅ | Hình thức (vd: Half-board, Full-board) |
| `classify` | string (enum) | ✅ | `Akoya`, `Ahiti`, `SouthSea` |
| `isPublic` | bool | ❌ (optional, default false nếu không gửi) | Công khai |
| `schedules` | array | ✅ | Danh sách lịch trình (tối thiểu 1 item). Mỗi item gồm: `day`, `titile`, `sumary`, `description` |
| `importantInfors` | array | ✅ | Danh sách thông tin quan trọng (tối thiểu 1 item). Mỗi item gồm: `title`, `subTitle`, `description` |

```json
{
  "title": "Hoi An Heritage Combo",
  "night": 2,
  "label": "Best Seller",
  "album": ["https://example.com/image1.jpg"],
  "region": "Hoi An",
  "description": "Trọn gói khám phá Hội An...",
  "infor": "Bao gồm hướng dẫn viên, ăn sáng",
  "highlight": "Phố cổ, ẩm thực đường phố",
  "code": "PLN-003",
  "purposeOfTrip": "Sightseeing",
  "destination": "Hoi An Ancient Town",
  "form": "Half-board",
  "classify": "Akoya",
  "isPublic": true,
  "schedules": [
    {
      "day": "Day 1",
      "titile": "Đến Hội An",
      "sumary": "Nhận phòng và tham quan phố cổ",
      "description": "Đón khách, nhận phòng, dạo phố cổ về đêm."
    }
  ],
  "importantInfors": [
    {
      "title": "Chính sách hoàn hủy",
      "subTitle": "Hoàn tiền 50% nếu hủy trước 48h",
      "description": "Vui lòng liên hệ hotline để được hỗ trợ."
    }
  ]
}
```

**Cấu trúc item trong `schedules`:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `day` | string | ❌ | Ví dụ: "Day 1", "Ngày 1" |
| `titile` | string | ✅ | Tiêu đề lịch trình |
| `sumary` | string | ❌ | Tóm tắt |
| `description` | string | ✅ | Mô tả chi tiết |

**Cấu trúc item trong `importantInfors`:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Tiêu đề |
| `subTitle` | string | ❌ | Tiêu đề phụ |
| `description` | string | ✅ | Mô tả chi tiết |

**Validation rules:**

| Field | Rule | MessageCode |
|---|---|---|
| `Title` | NotEmpty | `TITLE_REQUIRED` |
| `Night` | GreaterThan(0) | `NIGHT_MUST_BE_GREATER_THAN_ZERO` |
| `Label` | NotEmpty | `LABEL_REQUIRED` |
| `Album` | NotEmpty | `ALBUM_REQUIRED` |
| `Region` | NotEmpty | `REGION_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |
| `Infor` | NotEmpty | `INFOR_REQUIRED` |
| `Highlight` | NotEmpty | `HIGHLIGHT_REQUIRED` |
| `Code` | NotEmpty | `CODE_REQUIRED` |
| `PurposeOfTrip` | IsInEnum | `PURPOSE_OF_TRIP_INVALID` |
| `Destination` | NotEmpty | `DESTINATION_REQUIRED` |
| `Form` | NotEmpty | `FORM_REQUIRED` |
| `Classify` | IsInEnum | `CLASSIFY_INVALID` |
| `Schedules` | NotEmpty | `SCHEDULES_REQUIRED` |
| `Schedules[*].Titile` | NotEmpty | `SCHEDULE_TITLE_REQUIRED` |
| `Schedules[*].Description` | NotEmpty | `SCHEDULE_DESCRIPTION_REQUIRED` |
| `ImportantInfors` | NotEmpty | `IMPORTANT_INFORS_REQUIRED` |
| `ImportantInfors[*].Title` | NotEmpty | `IMPORTANT_INFOR_TITLE_REQUIRED` |
| `ImportantInfors[*].Description` | NotEmpty | `IMPORTANT_INFOR_DESCRIPTION_REQUIRED` |

**Response 200 — thành công:** `ServiceResponse` với `type = "Combo"`, các field Tour/Hotel = rỗng/null, kèm `schedules` và `importantInfors` như Tour.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### POST `/api/services/hotels`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một service loại Hotel. Các field Tour/Combo không thuộc Hotel sẽ tự động bỏ qua.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Tên khách sạn |
| `introducetion` | string | ✅ | Giới thiệu (field riêng của Hotel) |
| `album` | array string | ✅ | Danh sách URL ảnh |
| `region` | string | ✅ | Khu vực |
| `instruct` | string | ✅ | Hướng dẫn (field riêng của Hotel) |
| `feature` | string | ✅ | Tiện nghi (field riêng của Hotel) |
| `purposeOfTrip` | string (enum) | ✅ | `ResortVacation`, `Sightseeing`, `BusinessTrip`, `VisitingRelatives` |
| `destination` | string | ✅ | Điểm đến |
| `form` | string | ✅ | Hình thức |
| `isPublic` | bool | ❌ (optional, default false nếu không gửi) | Công khai |

```json
{
  "title": "Da Nang Beach Resort",
  "introducetion": "Khu nghỉ dưỡng 5 sao tại Đà Nẵng",
  "album": ["https://example.com/image1.jpg"],
  "region": "Da Nang",
  "instruct": "Nhận phòng từ 14:00, trả phòng trước 12:00",
  "feature": "Hồ bơi vô cực, spa, nhà hàng",
  "purposeOfTrip": "ResortVacation",
  "destination": "Da Nang Beach",
  "form": "Full-board",
  "isPublic": true
}
```

**Validation rules:**

| Field | Rule | MessageCode |
|---|---|---|
| `Title` | NotEmpty | `TITLE_REQUIRED` |
| `Introducetion` | NotEmpty | `INTRODUCTION_REQUIRED` |
| `Album` | NotEmpty | `ALBUM_REQUIRED` |
| `Region` | NotEmpty | `REGION_REQUIRED` |
| `Instruct` | NotEmpty | `INSTRUCT_REQUIRED` |
| `Feature` | NotEmpty | `FEATURE_REQUIRED` |
| `PurposeOfTrip` | IsInEnum | `PURPOSE_OF_TRIP_INVALID` |
| `Destination` | NotEmpty | `DESTINATION_REQUIRED` |
| `Form` | NotEmpty | `FORM_REQUIRED` |

**Response 200 — thành công:** `ServiceResponse` với `type = "Hotel"`, các field Tour/Combo = rỗng/null.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/services/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật service bất kỳ (Tour, Combo, Hotel) theo ID. Dùng chung một request body cho cả 3 loại.

**Hỗ trợ cập nhật một phần (partial update):** Chỉ cần gửi các field muốn thay đổi; các field không gửi sẽ giữ nguyên giá trị cũ. Tuy nhiên, các field không thuộc Type mới sẽ tự động bị reset về null khi gửi kèm `type`. Các field bắt buộc chung: `title`, `album`, `region`, `type`.

**Đối với Tour/Combo:** Nếu gửi `schedules` hoặc `importantInfors`, hệ thống sẽ **xoá mềm** toàn bộ schedules/importantInfors cũ và tạo mới từ request. Nếu không gửi, giữ nguyên dữ liệu cũ.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của service cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `title` | string | ✅ | Luôn bắt buộc |
| `introducetion` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Hotel) | Nếu không gửi → giữ nguyên |
| `day` | int | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Tour) | |
| `night` | int | ❌ (chỉ update nếu gửi, chỉ áp dụng khi Type≠Hotel) | |
| `label` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Combo) | |
| `album` | array string | ✅ | Luôn bắt buộc |
| `region` | string | ✅ | Luôn bắt buộc |
| `description` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng khi Type≠Hotel) | |
| `infor` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng khi Type≠Hotel) | |
| `highlight` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng khi Type≠Hotel) | |
| `code` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng khi Type≠Hotel) | |
| `instruct` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Hotel) | |
| `feature` | string | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Hotel) | |
| `type` | string (enum) | ✅ | `Tour` / `Combo` / `Hotel` |
| `isPublic` | bool | ❌ (optional, default false nếu không gửi) | |
| `purposeOfTrip` | string (enum) or null | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Combo/Hotel) | |
| `destination` | string or null | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Combo/Hotel) | |
| `form` | string or null | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Combo/Hotel) | |
| `classify` | string (enum) or null | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Combo) | |
| `schedules` | array | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Tour/Combo) | Nếu gửi → xoá mềm cũ, tạo mới. Mỗi item gồm: `day`, `titile`, `sumary`, `description` |
| `importantInfors` | array | ❌ (chỉ update nếu gửi, chỉ áp dụng cho Tour/Combo) | Nếu gửi → xoá mềm cũ, tạo mới. Mỗi item gồm: `title`, `subTitle`, `description` |

```json
{
  "title": "Explorer Tour Updated",
  "introducetion": "",
  "day": 4,
  "night": 3,
  "label": "",
  "album": ["https://example.com/image1.jpg"],
  "region": "Vietnam",
  "description": "Mô tả cập nhật...",
  "infor": "Thông tin cập nhật...",
  "highlight": "Điểm nổi bật cập nhật",
  "code": "PLN-001",
  "instruct": "",
  "feature": "",
  "type": "Tour",
  "isPublic": true,
  "purposeOfTrip": null,
  "destination": null,
  "form": null,
  "classify": null,
  "schedules": [
    {
      "day": "Day 1",
      "titile": "Khởi hành",
      "sumary": "Đón khách tại sân bay",
      "description": "Đón khách, nhận phòng khách sạn, ăn tối chào mừng."
    }
  ],
  "importantInfors": [
    {
      "title": "Chính sách hủy",
      "subTitle": "Hủy miễn phí trước 24h",
      "description": "Hoàn lại toàn bộ chi phí nếu hủy trước 24 giờ."
    }
  ]
}
```

**Validation rules (`UpdateServiceRequestValidator`):**

| Field | Rule | MessageCode | Áp dụng khi |
|---|---|---|---|
| `Title` | NotEmpty | `TITLE_REQUIRED` | Luôn |
| `Type` | NotEmpty, IsInEnum | `TYPE_REQUIRED`, `TYPE_MUST_BE_TOUR_COMBO_OR_HOTEL` | Luôn |
| `Album` | NotEmpty | `ALBUM_REQUIRED` | Luôn |
| `Region` | NotEmpty | `REGION_REQUIRED` | Luôn |
| `Introducetion` | NotEmpty | `INTRODUCTION_REQUIRED` | Có gửi và Type = Hotel |
| `Day` | GreaterThan(0) | `DAY_MUST_BE_GREATER_THAN_ZERO` | Có gửi và Type = Tour |
| `Night` | GreaterThan(0) | `NIGHT_MUST_BE_GREATER_THAN_ZERO` | Có gửi và Type ≠ Hotel |
| `Label` | NotEmpty | `LABEL_REQUIRED` | Có gửi và Type = Combo |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` | Có gửi và Type ≠ Hotel |
| `Infor` | NotEmpty | `INFOR_REQUIRED` | Có gửi và Type ≠ Hotel |
| `Highlight` | NotEmpty | `HIGHLIGHT_REQUIRED` | Có gửi và Type ≠ Hotel |
| `Code` | NotEmpty | `CODE_REQUIRED` | Có gửi và Type ≠ Hotel |
| `Instruct` | NotEmpty | `INSTRUCT_REQUIRED` | Có gửi và Type = Hotel |
| `Feature` | NotEmpty | `FEATURE_REQUIRED` | Có gửi và Type = Hotel |
| `PurposeOfTrip` | NotEmpty, IsInEnum | `PURPOSE_OF_TRIP_REQUIRED`, `PURPOSE_OF_TRIP_INVALID` | Có gửi và Type = Combo/Hotel |
| `Destination` | NotEmpty | `DESTINATION_REQUIRED` | Có gửi và Type = Combo/Hotel |
| `Form` | NotEmpty | `FORM_REQUIRED` | Có gửi và Type = Combo/Hotel |
| `Classify` | NotEmpty, IsInEnum | `CLASSIFY_REQUIRED`, `CLASSIFY_INVALID` | Có gửi và Type = Combo |
| `Schedules` | NotEmpty | `SCHEDULES_REQUIRED` | Có gửi và Type = Tour/Combo |
| `Schedules[*].Titile` | NotEmpty | `SCHEDULE_TITLE_REQUIRED` | Có gửi và Type = Tour/Combo |
| `Schedules[*].Description` | NotEmpty | `SCHEDULE_DESCRIPTION_REQUIRED` | Có gửi và Type = Tour/Combo |
| `ImportantInfors` | NotEmpty | `IMPORTANT_INFORS_REQUIRED` | Có gửi và Type = Tour/Combo |
| `ImportantInfors[*].Title` | NotEmpty | `IMPORTANT_INFOR_TITLE_REQUIRED` | Có gửi và Type = Tour/Combo |
| `ImportantInfors[*].Description` | NotEmpty | `IMPORTANT_INFOR_DESCRIPTION_REQUIRED` | Có gửi và Type = Tour/Combo |

**Logic `ApplyTypeFields` — các field tự động bị set null khi đổi Type, và chỉ set lại nếu có gửi:**

| Field | Tour | Combo | Hotel |
|---|---|---|---|
| `Introducetion` | → null | → null | giữ nguyên (nếu có gửi) |
| `Day` | giữ nguyên (nếu có gửi) | → null | → null |
| `Night` | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) | → null |
| `Label` | → null | giữ nguyên (nếu có gửi) | → null |
| `Description` | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) | → null |
| `Infor` | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) | → null |
| `Highlight` | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) | → null |
| `Code` | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) | → null |
| `Instruct` | → null | → null | giữ nguyên (nếu có gửi) |
| `Feature` | → null | → null | giữ nguyên (nếu có gửi) |
| `PurposeOfTrip` | → null | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) |
| `Destination` | → null | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) |
| `Form` | → null | giữ nguyên (nếu có gửi) | giữ nguyên (nếu có gửi) |
| `Classify` | → null | giữ nguyên (nếu có gửi) | → null |

**Response 200 — thành công:** `ServiceResponse` với các field tương ứng Type đã được cập nhật. Nếu Type là Tour/Combo, response kèm `schedules` và `importantInfors` hiện tại (dù có gửi hay không).

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Service not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/services/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm (soft delete) service. Không xoá vật lý khỏi DB, chỉ set `IsDeleted = true` và `UpdatedAt = now`. Service đã xoá sẽ không xuất hiện trong các GET list/detail.

**Cascade soft delete:** Tất cả child entities thuộc service (Schedule, ImportantInfor, RoomCategory, DepartureSchedule) cũng bị soft delete theo.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của service cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Service deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Service not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 3. Schedules

---

### GET `/api/schedules`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả schedules (lịch trình) có phân trang, sắp xếp theo `CreatedAt` giảm dần. Schedule được tạo cho mọi loại service (Tour, Combo, Hotel) — không check Type.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `ScheduleResponse`.

**Cấu trúc `ScheduleResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `serviceId` | string (guid) | FK → Service |
| `day` | string | Ví dụ: "Day 1", "Day 2" |
| `titile` | string | Tiêu đề lịch trình |
| `sumary` | string | Tóm tắt |
| `description` | string | Mô tả chi tiết |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/schedules/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một schedule theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của schedule |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "serviceId": "guid",
    "day": "Day 1",
    "titile": "Arrival",
    "sumary": "Arrive and settle in.",
    "description": "Airport pickup and welcome dinner.",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Schedule not found."` |

---

### POST `/api/schedules`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một schedule cho service. Hệ thống kiểm tra service tồn tại và chưa bị xoá. Không check Service Type — mọi service đều có thể có schedule.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service |
| `day` | string | ✅ | Ngày thứ mấy (vd: "Day 1", "Ngày 1") |
| `titile` | string | ✅ | Tiêu đề |
| `sumary` | string | ✅ | Tóm tắt |
| `description` | string | ✅ | Mô tả chi tiết |

```json
{
  "serviceId": "a1b2c3d4-...",
  "day": "Day 1",
  "titile": "Arrival",
  "sumary": "Arrive and settle in.",
  "description": "Airport pickup and welcome dinner."
}
```

**Validation rules:**

| Field | Rule | MessageCode |
|---|---|---|
| `ServiceId` | NotEmpty | `SERVICE_ID_REQUIRED` |
| `Day` | NotEmpty | `DAY_REQUIRED` |
| `Titile` | NotEmpty | `TITLE_REQUIRED` |
| `Sumary` | NotEmpty | `SUMARY_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |

**Business logic:** Trước khi tạo, kiểm tra `ServiceId` có tồn tại trong bảng Services và `IsDeleted = false`. Nếu không → 404.

**Response 200 — thành công:** `ScheduleResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Service not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/schedules/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật schedule theo ID. Kiểm tra schedule tồn tại, kiểm tra service mới có tồn tại không.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của schedule cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (có thể thay đổi) |
| `day` | string | ✅ | |
| `titile` | string | ✅ | |
| `sumary` | string | ✅ | |
| `description` | string | ✅ | |

```json
{
  "serviceId": "b2c3d4e5-...",
  "day": "Day 2",
  "titile": "Experience",
  "sumary": "Explore the destination.",
  "description": "Guided tour and local activities."
}
```

**Validation rules:** Giống hệt POST.

**Business logic:**
- Kiểm tra schedule tồn tại → nếu không → 404
- Kiểm tra ServiceId mới tồn tại → nếu không → 404

**Response 200 — thành công:** `ScheduleResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Schedule not found."` |
| 404 | NOT_FOUND | `"Service not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/schedules/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm schedule. Set `IsDeleted = true`, `UpdatedAt = now`.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của schedule cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Schedule deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Schedule not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 4. RoomCategories

---

### GET `/api/room-categories`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả room categories (hạng phòng) có phân trang. Sắp xếp theo `CreatedAt` giảm dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `RoomCategoryResponse`.

**Cấu trúc `RoomCategoryResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `serviceId` | string (guid) | FK → Service |
| `album` | array string | Danh sách URL ảnh |
| `titile` | string | Tên hạng phòng |
| `numberOfCustomer` | int | Số lượng khách tối đa |
| `acreage` | string | Diện tích (vd: "35m2") |
| `numberOfBed` | string | Số giường (kiểu string, vd: "1", "2", "1 double") |
| `description` | string | Mô tả |
| `feature` | array string | Tiện nghi |
| `price` | string or null | Giá (string, null nếu service là Combo) |
| `originalPrice` | string or null | Giá gốc (hiển thị gạch ngang) |
| `unit` | string or null | Đơn vị (vd: "đêm", "người") |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/room-categories/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một room category theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của room category |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "serviceId": "guid",
    "album": ["https://example.com/room1.jpg"],
    "titile": "Deluxe Room",
    "numberOfCustomer": 2,
    "acreage": "35m2",
    "numberOfBed": "1",
    "description": "Phòng deluxe với ban công",
    "feature": ["Ban công", "bữa sáng", "view biển"],
    "price": "1200000",
    "originalPrice": "1500000",
    "unit": "đêm",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Room category not found."` |

---

### POST `/api/room-categories`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một room category cho service. Chỉ cho phép tạo cho service có Type = `Combo` hoặc `Hotel`. Nếu service là `Combo` → `price` tự động set null dù request có gửi price.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (Combo hoặc Hotel) |
| `album` | array string | ✅ | Danh sách URL ảnh |
| `titile` | string | ✅ | Tên hạng phòng |
| `numberOfCustomer` | int | ✅ | Số khách (> 0) |
| `acreage` | string | ✅ | Diện tích |
| `numberOfBed` | string | ✅ | Số giường (vd: "1", "2", "1 double") |
| `description` | string | ✅ | Mô tả |
| `feature` | array string | ✅ | Tiện nghi |
| `price` | string or null | ❌ (optional) | Giá (sẽ bị ignore nếu service là Combo) |
| `originalPrice` | string or null | ❌ (optional) | Giá gốc |
| `unit` | string or null | ❌ (optional) | Đơn vị |

```json
{
  "serviceId": "guid",
  "album": ["https://example.com/room1.jpg"],
  "titile": "Deluxe Room",
  "numberOfCustomer": 2,
  "acreage": "35m2",
  "numberOfBed": "1",
  "description": "Phòng deluxe với ban công view biển",
  "feature": ["Ban công", "bữa sáng", "minibar"],
  "price": "1200000",
  "originalPrice": "1500000",
  "unit": "đêm"
}
```

**Validation rules (`CreateRoomCategoryRequestValidator`):**

| Field | Rule | MessageCode |
|---|---|---|
| `ServiceId` | NotEmpty | `SERVICE_ID_REQUIRED` |
| `Album` | NotEmpty | `ALBUM_REQUIRED` |
| `Titile` | NotEmpty | `TITLE_REQUIRED` |
| `NumberOfCustomer` | GreaterThan(0) | `NUMBER_OF_CUSTOMER_MUST_BE_GREATER_THAN_ZERO` |
| `Acreage` | NotEmpty | `ACREAGE_REQUIRED` |
| `NumberOfBed` | NotEmpty | `NUMBER_OF_BED_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |
| `Feature` | NotEmpty | `FEATURE_REQUIRED` |

**Business logic:**
1. Kiểm tra `ServiceId` tồn tại và `IsDeleted = false`
2. Kiểm tra `Service.Type` phải là `Combo` hoặc `Hotel`
3. Nếu `Service.Type == Combo` → `Price` tự động set null (bất kể request gửi gì)

**Response 200 — thành công:** `RoomCategoryResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Room categories are only allowed for Combo or Hotel services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/room-categories/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật room category. Kiểm tra room category tồn tại, kiểm tra service mới thuộc Combo/Hotel, tự động set Price = null nếu service là Combo.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của room category cần cập nhật |

**Request body:** Giống hệt POST.

**Validation rules:** Giống hệt POST.

**Business logic:**
1. Kiểm tra room category tồn tại → nếu không → 404
2. Kiểm tra `ServiceId` mới tồn tại và Type = Combo/Hotel
3. Nếu service mới là Combo → `Price = null`

**Response 200 — thành công:** `RoomCategoryResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Room category not found."` |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Room categories are only allowed for Combo or Hotel services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/room-categories/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm room category. Set `IsDeleted = true`, `UpdatedAt = now`.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của room category cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Room category deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Room category not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 5. DepartureSchedules

---

### GET `/api/departure-schedules`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả departure schedules (lịch khởi hành) có phân trang. Sắp xếp theo `CreatedAt` giảm dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `DepartureScheduleResponse`.

**Cấu trúc `DepartureScheduleResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `serviceId` | string (guid) | FK → Service |
| `startTime` | string | Giờ khởi hành (vd: "07:00", "08:30") |
| `code` | string | Mã chuyến (vd: "DEP-001") |
| `price` | string | Giá (string) |
| `accommodationStandards` | string | Tiêu chuẩn lưu trú |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/departure-schedules/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một departure schedule theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của departure schedule |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "serviceId": "guid",
    "startTime": "07:00",
    "code": "DEP-001",
    "price": "1500000",
    "accommodationStandards": "4-star hotel",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Departure schedule not found."` |

---

### POST `/api/departure-schedules`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một departure schedule. Chỉ cho phép tạo cho service có Type = `Tour`. Nếu service không phải Tour → từ chối.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (phải là Tour) |
| `startTime` | string | ✅ | Giờ khởi hành |
| `code` | string | ✅ | Mã chuyến |
| `price` | string | ✅ | Giá |
| `accommodationStandards` | string | ✅ | Tiêu chuẩn lưu trú |

```json
{
  "serviceId": "guid",
  "startTime": "07:00",
  "code": "DEP-001",
  "price": "1500000",
  "accommodationStandards": "4-star hotel"
}
```

**Validation rules (`CreateDepartureScheduleRequestValidator`):**

| Field | Rule | MessageCode |
|---|---|---|
| `ServiceId` | NotEmpty | `SERVICE_ID_REQUIRED` |
| `StartTime` | NotEmpty | `START_TIME_REQUIRED` |
| `Code` | NotEmpty | `CODE_REQUIRED` |
| `Price` | NotEmpty | `PRICE_REQUIRED` |
| `AccommodationStandards` | NotEmpty | `ACCOMMODATION_STANDARDS_REQUIRED` |

**Business logic:**
1. Kiểm tra `ServiceId` tồn tại và chưa xoá
2. Kiểm tra `Service.Type == Tour`

**Response 200 — thành công:** `DepartureScheduleResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Departure schedules are only allowed for Tour services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/departure-schedules/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật departure schedule. Kiểm tra tồn tại, kiểm tra service mới là Tour.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của departure schedule cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (phải là Tour) |
| `startTime` | string | ✅ | |
| `code` | string | ✅ | |
| `price` | string | ✅ | |
| `accommodationStandards` | string | ✅ | |

**Validation rules:** Giống hệt POST.

**Business logic:**
1. Kiểm tra departure schedule tồn tại → nếu không → 404
2. Kiểm tra `ServiceId` mới tồn tại và Type = Tour

**Response 200 — thành công:** `DepartureScheduleResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Departure schedule not found."` |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Departure schedules are only allowed for Tour services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/departure-schedules/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm departure schedule. Set `IsDeleted = true`, `UpdatedAt = now`. Trước khi xoá, kiểm tra Service.Type phải là Tour (cần Include Service từ DB).

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của departure schedule cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Departure schedule deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Departure schedule not found."` |
| 400 | BAD_REQUEST | `"Departure schedules are only allowed for Tour services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 6. ImportantInfors

---

### GET `/api/important-infors`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả important infors (thông tin quan trọng) có phân trang. Sắp xếp theo `CreatedAt` giảm dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `ImportantInforResponse`.

**Cấu trúc `ImportantInforResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `serviceId` | string (guid) | FK → Service |
| `title` | string | Tiêu đề (vd: "Cancellation Policy") |
| `subTitle` | string | Tiêu đề phụ (vd: "Free cancellation") |
| `description` | string | Mô tả chi tiết |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/important-infors/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một important infor theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của important infor |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "serviceId": "guid",
    "title": "Cancellation Policy",
    "subTitle": "Free cancellation",
    "description": "Cancel up to 24 hours before departure for a full refund.",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Important information not found."` |

---

### POST `/api/important-infors`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một important infor cho service. Chỉ cho phép tạo cho service có Type = `Tour` hoặc `Combo`.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (Tour hoặc Combo) |
| `title` | string | ✅ | Tiêu đề |
| `subTitle` | string | ✅ | Tiêu đề phụ |
| `description` | string | ✅ | Mô tả |

```json
{
  "serviceId": "guid",
  "title": "Cancellation Policy",
  "subTitle": "Free cancellation",
  "description": "Cancel up to 24 hours before departure for a full refund."
}
```

**Validation rules (`CreateImportantInforRequestValidator`):**

| Field | Rule | MessageCode |
|---|---|---|
| `ServiceId` | NotEmpty | `SERVICE_ID_REQUIRED` |
| `Title` | NotEmpty | `TITLE_REQUIRED` |
| `SubTitle` | NotEmpty | `SUB_TITLE_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |

**Business logic:**
1. Kiểm tra `ServiceId` tồn tại và chưa xoá
2. Kiểm tra `Service.Type == Tour` hoặc `Service.Type == Combo`

**Response 200 — thành công:** `ImportantInforResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Important information is only allowed for Tour or Combo services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/important-infors/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật important infor. Kiểm tra tồn tại, kiểm tra service mới là Tour hoặc Combo.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của important infor cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `serviceId` | string (guid) | ✅ | ID của service (phải là Tour/Combo) |
| `title` | string | ✅ | |
| `subTitle` | string | ✅ | |
| `description` | string | ✅ | |

**Validation rules:** Giống hệt POST.

**Business logic:**
1. Kiểm tra important infor tồn tại → nếu không → 404
2. Kiểm tra `ServiceId` mới tồn tại và Type = Tour/Combo

**Response 200 — thành công:** `ImportantInforResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Important information not found."` |
| 404 | NOT_FOUND | `"Service not found."` |
| 400 | BAD_REQUEST | `"Important information is only allowed for Tour or Combo services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/important-infors/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm important infor. Set `IsDeleted = true`, `UpdatedAt = now`. Trước khi xoá, kiểm tra Service.Type phải là Tour/Combo (cần Include Service từ DB).

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của important infor cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Important information deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Important information not found."` |
| 400 | BAD_REQUEST | `"Important information is only allowed for Tour or Combo services."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 7. PageContents

---

### GET `/api/page-contents`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả page contents (nội dung trang) dạng **phẳng** (không có cây children) có phân trang. Sắp xếp theo `PageKey` → `SectionKey` → `SoftOrder` tăng dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `PageContentResponse`; danh sách phẳng vẫn có `children: []` do DTO khởi tạo mặc định.

**Cấu trúc `PageContentResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `parentId` | string (guid) or null | FK tự tham chiếu, null nếu là node gốc |
| `pageKey` | string | Key của trang (vd: "home", "about") |
| `sectionKey` | string | Key của section (vd: "hero", "footer") |
| `key` | string | Key của nội dung (vd: "banner-title") |
| `contentValue` | string | Giá trị nội dung (có thể chứa HTML) |
| `label` | string | Nhãn hiển thị |
| `kind` | string | Loại nội dung (vd: "text", "image", "html") |
| `softOrder` | int | Thứ tự sắp xếp |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |
| `children` | array | Danh sách phẳng vẫn serialize `children: []`; GET `{id}` mới build cây children đệ quy |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/page-contents/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một page content theo ID, kèm theo cây `children` đệ quy. Hệ thống load tất cả page contents từ DB, tìm item theo id, sau đó build cây children bằng cách tìm tất cả các item có `ParentId` trùng với id hiện tại (đệ quy).

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của page content |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "parentId": null,
    "pageKey": "home",
    "sectionKey": "hero",
    "key": "banner-title",
    "contentValue": "<h1>Welcome to Perlunas</h1>",
    "label": "Banner Title",
    "kind": "html",
    "softOrder": 1,
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z",
    "children": [
      {
        "id": "guid",
        "parentId": "guid",
        "pageKey": "home",
        "sectionKey": "hero",
        "key": "banner-subtitle",
        "contentValue": "<p>Explore Vietnam</p>",
        "label": "Banner Subtitle",
        "kind": "html",
        "softOrder": 2,
        "createdAt": "2026-07-02T10:00:00Z",
        "updatedAt": "2026-07-02T10:00:00Z",
        "children": []
      }
    ]
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Page content not found."` |

---

### POST `/api/page-contents`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một page content. Có thể tạo node gốc (`parentId = null`) hoặc node con (`parentId` có giá trị). Nếu có `parentId`, kiểm tra parent tồn tại và chưa bị xoá.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `parentId` | string (guid) or null | ❌ (optional) | ID của node cha. null = node gốc |
| `pageKey` | string | ✅ | Key của trang |
| `sectionKey` | string | ✅ | Key của section |
| `key` | string | ✅ | Key của nội dung |
| `contentValue` | string | ✅ | Giá trị nội dung |
| `label` | string | ✅ | Nhãn |
| `kind` | string | ✅ | Loại nội dung |
| `softOrder` | int | ✅ | Thứ tự (≥ 0) |

```json
{
  "parentId": null,
  "pageKey": "home",
  "sectionKey": "hero",
  "key": "banner-title",
  "contentValue": "<h1>Welcome to Perlunas</h1>",
  "label": "Banner Title",
  "kind": "html",
  "softOrder": 1
}
```

**Validation rules (`CreatePageContentRequestValidator`):**

| Field | Rule | MessageCode |
|---|---|---|
| `PageKey` | NotEmpty | `PAGE_KEY_REQUIRED` |
| `SectionKey` | NotEmpty | `SECTION_KEY_REQUIRED` |
| `Key` | NotEmpty | `KEY_REQUIRED` |
| `ContentValue` | NotEmpty | `CONTENT_VALUE_REQUIRED` |
| `Label` | NotEmpty | `LABEL_REQUIRED` |
| `Kind` | NotEmpty | `KIND_REQUIRED` |
| `SoftOrder` | GreaterThanOrEqual(0) | `SOFT_ORDER_MUST_BE_GREATER_THAN_OR_EQUAL_ZERO` |

**Business logic:** Nếu `parentId` có giá trị, kiểm tra parent tồn tại trong DB và chưa bị xoá.

**Response 200 — thành công:** `PageContentResponse` (single, không có children).

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Parent page content not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/page-contents/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật page content. Kiểm tra item tồn tại. Nếu đổi `parentId`, kiểm tra parent mới tồn tại.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của page content cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `parentId` | string (guid) or null | ❌ | ID của node cha |
| `pageKey` | string | ✅ | |
| `sectionKey` | string | ✅ | |
| `key` | string | ✅ | |
| `contentValue` | string | ✅ | |
| `label` | string | ✅ | |
| `kind` | string | ✅ | |
| `softOrder` | int | ✅ | |

**Validation rules:** Giống hệt POST.

**Business logic:**
1. Kiểm tra page content tồn tại → nếu không → 404
2. Nếu `parentId` có giá trị, kiểm tra parent tồn tại

**Response 200 — thành công:** `PageContentResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Page content not found."` |
| 404 | NOT_FOUND | `"Parent page content not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/page-contents/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm page content **và tất cả descendants** (cây đệ quy). Hệ thống tìm tất cả các node con, cháu, chắt... của node này bằng đệ quy theo `ParentId`, sau đó soft delete toàn bộ.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của page content cần xoá |

**Logic:**
1. Load tất cả PageContent từ DB (chưa bị xoá)
2. Gọi `CollectDescendants(all, id, result)` — đệ quy tìm tất cả node có ParentId = id, rồi ParentId = các id con đó...
3. Nếu không tìm thấy node nào (kể cả chính nó) → 404
4. Set `IsDeleted = true` và `UpdatedAt = now` cho toàn bộ danh sách

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Page content deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Page content not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 8. Blogs

---

### GET `/api/blogs`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả blogs có phân trang. Sắp xếp theo `CreatedAt` giảm dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `BlogResponse`.

**Cấu trúc `BlogResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `titile` | string | Tiêu đề |
| `subTitile` | string | Tiêu đề phụ |
| `author` | string | Tác giả |
| `readingTime` | string | Thời gian đọc (vd: "5 min") |
| `description` | string | Mô tả / nội dung |
| `tag` | string | Tag (vd: "travel", "news") |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/blogs/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một blog theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của blog |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "titile": "Khám Phá Đà Nẵng",
    "subTitile": "Thành phố đáng sống nhất Việt Nam",
    "author": "Perlunas Travel",
    "readingTime": "5 min",
    "description": "Đà Nẵng là một trong những điểm đến hấp dẫn nhất Việt Nam...",
    "tag": "travel",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Blog not found."` |

---

### POST `/api/blogs`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một blog.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `titile` | string | ✅ | Tiêu đề |
| `subTitile` | string | ✅ | Tiêu đề phụ |
| `author` | string | ✅ | Tác giả |
| `readingTime` | string | ✅ | Thời gian đọc |
| `description` | string | ✅ | Nội dung |
| `tag` | string | ✅ | Tag |

```json
{
  "titile": "Khám Phá Đà Nẵng",
  "subTitile": "Thành phố đáng sống nhất Việt Nam",
  "author": "Perlunas Travel",
  "readingTime": "5 min",
  "description": "Đà Nẵng là một trong những điểm đến hấp dẫn nhất Việt Nam...",
  "tag": "travel"
}
```

**Validation rules (`CreateBlogRequestValidator`):**

| Field | Rule | MessageCode |
|---|---|---|
| `Titile` | NotEmpty | `TITLE_REQUIRED` |
| `SubTitile` | NotEmpty | `SUB_TITLE_REQUIRED` |
| `Author` | NotEmpty | `AUTHOR_REQUIRED` |
| `ReadingTime` | NotEmpty | `READING_TIME_REQUIRED` |
| `Description` | NotEmpty | `DESCRIPTION_REQUIRED` |
| `Tag` | NotEmpty | `TAG_REQUIRED` |

**Response 200 — thành công:** `BlogResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/blogs/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật blog. Kiểm tra blog tồn tại.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của blog cần cập nhật |

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `titile` | string | ✅ | |
| `subTitile` | string | ✅ | |
| `author` | string | ✅ | |
| `readingTime` | string | ✅ | |
| `description` | string | ✅ | |
| `tag` | string | ✅ | |

**Validation rules:** Giống hệt POST.

**Business logic:** Kiểm tra blog tồn tại và chưa bị xoá → nếu không → 404.

**Response 200 — thành công:** `BlogResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Blog not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/blogs/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm blog. Set `IsDeleted = true`, `UpdatedAt = now`.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của blog cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Blog deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Blog not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## 9. SiteSettings

---

### GET `/api/site-settings`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy danh sách tất cả site settings (cấu hình site) có phân trang. Sắp xếp theo `CreatedAt` giảm dần.

**Query parameters:**
| Param | Type | Default | Mô tả |
|---|---|---|---|
| `pageIndex` | int | 1 | |
| `pageSize` | int | 10 | |

**Response 200 — thành công (pagination):** Mỗi item là `SiteSettingResponse`.

**Cấu trúc `SiteSettingResponse`:**
| Field | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | |
| `name` | string | Tên site |
| `legalName` | string | Tên pháp lý |
| `tagline` | string | Tagline / slogan |
| `manifesto` | string | Tuyên ngôn |
| `description` | string | Mô tả |
| `phone` | string | Số điện thoại |
| `email` | string | Email |
| `taxId` | string | Mã số thuế |
| `officesJson` | string | JSON array văn phòng (lưu dạng string, client tự parse) |
| `socialJson` | string | JSON array mạng xã hội (lưu dạng string, client tự parse) |
| `createdAt` | string (datetime) | |
| `updatedAt` | string (datetime) or null | |

**Errors:** Không có lỗi đặc biệt.

---

### GET `/api/site-settings/{id}`

**Auth:** `[AllowAnonymous]` — không cần token

**Mô tả:** Lấy chi tiết một site setting theo ID.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của site setting |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": {
    "id": "guid",
    "name": "Perlunas Travel",
    "legalName": "Perlunas Co., Ltd.",
    "tagline": "Explore Vietnam",
    "manifesto": "Khám phá vẻ đẹp Việt Nam...",
    "description": "Công ty du lịch hàng đầu Việt Nam",
    "phone": "+84 123 456 789",
    "email": "info@perlunas.com",
    "taxId": "1234567890",
    "officesJson": "[{\"name\":\"Hanoi\",\"address\":\"123 Pho Hue\"}]",
    "socialJson": "[{\"platform\":\"facebook\",\"url\":\"https://facebook.com/perlunas\"}]",
    "createdAt": "2026-07-02T10:00:00Z",
    "updatedAt": "2026-07-02T10:00:00Z"
  }
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Site setting not found."` |

---

### POST `/api/site-settings`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Tạo mới một site setting.

**Request body:**
| Field | Type | Bắt buộc | Mô tả |
|---|---|---|---|
| `name` | string | ✅ | Tên site |
| `legalName` | string | ✅ | Tên pháp lý |
| `tagline` | string | ✅ | Slogan |
| `manifesto` | string | ✅ | Tuyên ngôn |
| `description` | string | ✅ | Mô tả |
| `phone` | string | ✅ | Số điện thoại |
| `email` | string | ✅ | Email |
| `taxId` | string | ✅ | Mã số thuế |
| `officesJson` | string | ✅ | JSON văn phòng (dạng string) |
| `socialJson` | string | ✅ | JSON mạng xã hội (dạng string) |

```json
{
  "name": "Perlunas Travel",
  "legalName": "Perlunas Co., Ltd.",
  "tagline": "Explore Vietnam",
  "manifesto": "Khám phá vẻ đẹp Việt Nam...",
  "description": "Công ty du lịch hàng đầu Việt Nam",
  "phone": "+84 123 456 789",
  "email": "info@perlunas.com",
  "taxId": "1234567890",
  "officesJson": "[{\"name\":\"Hanoi\",\"address\":\"123 Pho Hue\"}]",
  "socialJson": "[{\"platform\":\"facebook\",\"url\":\"https://facebook.com/perlunas\"}]"
}
```

**Validation rules (`CreateSiteSettingRequestValidator`):** Tất cả 10 fields đều NotEmpty.

| Field | MessageCode |
|---|---|
| `Name` | `NAME_REQUIRED` |
| `LegalName` | `LEGAL_NAME_REQUIRED` |
| `Tagline` | `TAGLINE_REQUIRED` |
| `Manifesto` | `MANIFESTO_REQUIRED` |
| `Description` | `DESCRIPTION_REQUIRED` |
| `Phone` | `PHONE_REQUIRED` |
| `Email` | `EMAIL_REQUIRED` |
| `TaxId` | `TAX_ID_REQUIRED` |
| `OfficesJson` | `OFFICES_JSON_REQUIRED` |
| `SocialJson` | `SOCIAL_JSON_REQUIRED` |

**Response 200 — thành công:** `SiteSettingResponse`.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### PUT `/api/site-settings/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Cập nhật site setting. Kiểm tra tồn tại.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của site setting cần cập nhật |

**Request body:** Giống hệt POST (10 fields).

**Validation rules:** Giống hệt POST.

**Business logic:** Kiểm tra site setting tồn tại và chưa bị xoá → nếu không → 404.

**Response 200 — thành công:** `SiteSettingResponse` đã cập nhật.

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 400 | VALIDATION_ERROR | Field không hợp lệ |
| 404 | NOT_FOUND | `"Site setting not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

### DELETE `/api/site-settings/{id}`

**Auth:** `[Authorize]` — cần JWT Bearer token (role Admin)

**Mô tả:** Xoá mềm site setting. Set `IsDeleted = true`, `UpdatedAt = now`.

**Path parameters:**
| Param | Type | Mô tả |
|---|---|---|
| `id` | string (guid) | ID của site setting cần xoá |

**Response 200 — thành công:**
```json
{
  "isSuccess": true,
  "isFailed": false,
  "error": null,
  "traceId": "HTP123",
  "timestampUtc": "2026-07-02T10:00:00Z",
  "value": "Site setting deleted successfully."
}
```

**Errors:**
| Status | MessageCode | detail |
|---|---|---|
| 404 | NOT_FOUND | `"Site setting not found."` |
| 401 | Default ASP.NET 401 | Thiếu token — có thể không theo custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token hết hạn |
| 403 | Default ASP.NET 403 | Không phải Admin — có thể không theo custom `ErrorResponse` |

---

## Global Error Codes (tổng hợp)

| Status | MessageCode | Nguyên nhân |
|---|---|---|
| 400 | BAD_REQUEST | Request vi phạm business logic (vd: sai Service Type cho child entity) |
| 400 | VALIDATION_ERROR | FluentValidation thất bại — field bắt buộc thiếu, enum sai, số không hợp lệ |
| 401 | UNAUTHORIZED | Sai username/password ở login |
| 401 | Default ASP.NET 401 | Gọi API [Authorize] mà không gửi `Authorization: Bearer <token>`; hiện tại có thể không trả custom `ErrorResponse` |
| 401 | EXPIRED_ACCESS_TOKEN | Token đã hết hạn (cần login lại), trả custom `ErrorResponse` |
| 403 | Default ASP.NET 403 | Token hợp lệ nhưng không có role Admin; hiện tại có thể không trả custom `ErrorResponse` |
| 404 | NOT_FOUND | Entity không tồn tại hoặc đã bị soft delete |
| 409 | CONFLICT | Reserved — exception có định nghĩa nhưng code hiện tại chưa throw |
| 422 | VALIDATION_ERROR | Reserved — exception có định nghĩa nhưng code hiện tại chưa throw; FluentValidation hiện trả 400 |
| 429 | TOO_MANY_REQUEST | Reserved — exception có định nghĩa nhưng code hiện tại chưa throw |
| 500 | INTERNAL_SERVER_ERROR | Lỗi hệ thống không xác định (chi tiết chỉ hiện trong Development mode) |
| 502 | BAD_GATEWAY | Reserved — exception có định nghĩa nhưng code hiện tại chưa throw |

---

## Entity Relationship

```
Service (Tour|Combo|Hotel)
  ├── Schedule[]              ─ mọi service type đều có
  ├── RoomCategory[]          ─ chỉ Combo + Hotel (Combo → Price = null)
  ├── DepartureSchedule[]     ─ chỉ Tour
  └── ImportantInfor[]        ─ chỉ Tour + Combo

PageContent (self-referencing tree)
  ParentId → Id (ON DELETE SET NULL)
  Composite index: (PageKey, SectionKey, Key)
  
Blog      (độc lập, không FK)
SiteSetting (độc lập, không FK)
```
