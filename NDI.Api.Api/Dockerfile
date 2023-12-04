FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NDI.Api.Api/NDI.Api.Api.csproj", "NDI.Api.Api/"]
COPY ["NDI.Api.Application/NDI.Api.Application.csproj", "NDI.Api.Application/"]
COPY ["NDI.Api.Infrastructure/NDI.Api.Infrastructure.csproj", "NDI.Api.Infrastructure/"]
RUN dotnet restore "NDI.Api.Api/NDI.Api.Api.csproj"
COPY . .
WORKDIR "/src/NDI.Api.Api"
RUN dotnet build "NDI.Api.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NDI.Api.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NDI.Api.Api.dll"]
