$Migration = Read-Host -Prompt 'Input your Migration name'
dotnet ef migrations add $Migration -s ./NoteTonRu.Api.Api.csproj -p ../NoteTonRu.Api.Infrastructure/NoteTonRu.Api.Infrastructure.csproj --context ApplicationDbContext -v
pause