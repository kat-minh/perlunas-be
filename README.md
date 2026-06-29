# Perlunas CMS — Backend (.NET 8 · PostgreSQL · Docker)

Layered (N-tier) .NET 8 Web API powering the **Perlunas** Vietnamese travel
website and its Next.js admin dashboard. It manages tours, hotels, combos and
the site's editable copy.
**No local .NET SDK required** — builds and runs entirely in Docker.

## Structure

```
be/
├── .docker/
│   └── Dockerfile               # multi-stage build (SDK -> aspnet runtime)
├── .github/workflows/
│   └── ci.yml                   # build + docker image on push/PR
├── Cms.API/                     # presentation: controllers, Program.cs, config
├── Cms.Service/                 # business: auth, JWT, DTOs, seeder
├── Cms.Repository/              # data: DbContext, entities, repos
├── documentation/
│   └── architecture.md
├── docker-compose.yml           # webapi + postgres_db
├── global.json                  # pins .NET 8 SDK
└── Shopcms.sln
```

## Run

```bash
cd be
docker compose up --build
```

On startup the API waits for PostgreSQL, **creates the schema directly from the
EF Core model** (`EnsureCreated`, no migrations are committed), and seeds a
default admin plus sample travel content.

- API:     http://localhost:5080
- Swagger: http://localhost:5080/swagger
- Postgres: localhost:5432 (`perlunas_user` / `perlunas_password` / `perlunas_db`)

## Default admin

| Username | Password    |
|----------|-------------|
| `admin`  | `Admin@123` |

> Change this after first login. (email: `admin@perlunas.local`)

## Endpoints

JSON is serialized in **camelCase** (ASP.NET Core System.Text.Json default).
List/`GET {slug}` reads are anonymous; mutations require a Bearer JWT.

| Method | Route | Auth | Notes |
|--------|-------|------|-------|
| POST   | `/api/auth/login` | Anonymous | `{ "username", "password" }` → `{ token, tokenType, expiresInMinutes }` |
| GET    | `/api/auth/me`    | Bearer    | → `{ id, username, email, role }` |
| —      | `/api/users`      | Bearer    | User CRUD |
| GET    | `/api/tours`, `/api/tours/{slug}` | Anonymous | List / detail |
| POST/PUT/DELETE | `/api/tours`, `/api/tours/{slug}` | Bearer | Mutations |
| GET    | `/api/hotels`, `/api/hotels/{slug}` | Anonymous | List / detail |
| POST/PUT/DELETE | `/api/hotels`, `/api/hotels/{slug}` | Bearer | Mutations |
| GET    | `/api/combos`, `/api/combos/{slug}` | Anonymous | List / detail |
| POST/PUT/DELETE | `/api/combos`, `/api/combos/{slug}` | Bearer | Mutations |
| GET    | `/api/group-tours` | Anonymous | "Tour đoàn" cards |
| POST/PUT/DELETE | `/api/group-tours`, `/api/group-tours/{id}` | Bearer | Mutations |
| GET    | `/api/private-tours` | Anonymous | "Tour riêng tư" cards |
| POST/PUT/DELETE | `/api/private-tours`, `/api/private-tours/{id}` | Bearer | Mutations |
| POST   | `/api/messages` | Anonymous | Public enquiry/lead form |
| GET    | `/api/messages`, `/api/messages/unread-count` | Bearer | Admin inbox |
| PATCH/DELETE | `/api/messages/{id}/read`, `/api/messages/{id}` | Bearer | Manage leads |
| GET    | `/api/settings` | Anonymous | Site config (Perlunas brand) |
| PUT    | `/api/settings` | Bearer | Update config |
| GET    | `/api/page-content` | Anonymous | Editable page copy/images |
| PUT    | `/api/page-content` | Bearer | Bulk update values |

## Calling from Next.js (http://localhost:3000)

```ts
const res = await fetch("http://localhost:5080/api/auth/login", {
  method: "POST",
  headers: { "Content-Type": "application/json" },
  body: JSON.stringify({ username: "admin", password: "Admin@123" }),
});
const { token } = await res.json();
```

CORS allows `http://localhost:3000` and `http://localhost:3001`.

## Useful commands

```bash
docker compose up --build        # build + run
docker compose up --build -d     # detached
docker compose logs -f webapi    # follow API logs
docker compose down              # stop
docker compose down -v           # stop + wipe the database volume
```

## Switching to EF Core migrations

The schema is currently created with `EnsureCreated()`. To adopt migrations,
scaffold them with a throwaway SDK container (run from the repo root), then
restore `await db.Database.MigrateAsync();` in `Program.cs`:

```bash
docker run --rm -v "$(pwd):/src" -w /src mcr.microsoft.com/dotnet/sdk:8.0 bash -c "\
  dotnet tool install --global dotnet-ef && export PATH=\$PATH:/root/.dotnet/tools && \
  dotnet ef migrations add InitialCreate --project Cms.Repository --startup-project Cms.API"
```
