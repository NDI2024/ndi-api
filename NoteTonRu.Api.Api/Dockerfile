FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NoteTonRu.Api.Api/NoteTonRu.Api.Api.csproj", "NoteTonRu.Api.Api/"]
COPY ["NoteTonRu.Api.Application/NoteTonRu.Api.Application.csproj", "NoteTonRu.Api.Application/"]
COPY ["NoteTonRu.Api.Infrastructure/NoteTonRu.Api.Infrastructure.csproj", "NoteTonRu.Api.Infrastructure/"]
RUN dotnet restore "NoteTonRu.Api.Api/NoteTonRu.Api.Api.csproj"
COPY . .
WORKDIR "/src/NoteTonRu.Api.Api"
RUN dotnet build "NoteTonRu.Api.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NoteTonRu.Api.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NoteTonRu.Api.Api.dll"]
