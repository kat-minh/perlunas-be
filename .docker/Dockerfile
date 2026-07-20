FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
RUN apt-get update && \
    apt-get install -y tzdata && \
    rm -rf /var/lib/apt/lists/*
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["global.json", "./"]
COPY ["Cms.API/Cms.API.csproj", "Cms.API/"]
COPY ["Cms.Service/Cms.Service.csproj", "Cms.Service/"]
COPY ["Cms.Repository/Cms.Repository.csproj", "Cms.Repository/"]
RUN dotnet restore "Cms.API/Cms.API.csproj"
COPY . .
WORKDIR "/src/Cms.API"
RUN dotnet build "Cms.API.csproj" -c $BUILD_CONFIGURATION -o /app/build /p:TreatWarningsAsErrors=false

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Cms.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false /p:TreatWarningsAsErrors=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cms.API.dll"]
