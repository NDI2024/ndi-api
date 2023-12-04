$Migration = Read-Host -Prompt 'Input your Migration name'
dotnet ef migrations add $Migration -s ./NDI.Api.Api.csproj -p ../NDI.Api.Infrastructure/NDI.Api.Infrastructure.csproj --context ApplicationDbContext -v
pause