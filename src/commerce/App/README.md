## Reference
- https://learn.microsoft.com/en-us/azure/architecture/web-apps/idea/scalable-ecommerce-web-app\
- https://learn.microsoft.com/en-us/azure/architecture/web-apps/guides/networking/automation-application-gateway
- https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio#over-post
- https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/advanced?view=aspnetcore-8.0
- https://learn.microsoft.com/en-us/aspnet/core/data/ef-mvc/concurrency?view=aspnetcore-8.0
- https://learn.microsoft.com/en-us/ef/core/modeling/relationships/conventions

## Migrate and Scaffold
1. migration database
- dotnet add package Microsoft.EntityFrameworkCore.Design 
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- add migration: dotnet ef migrations add <tenmigration> 
- update database: dotnet ef database update
- reset database: dotnet ef database update 0  -> dotnet ef database update
- drop: dotnet ef database drop

2. scaffold controllers
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.Design 
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
- dotnet add package Microsoft.EntityFrameworkCore.Tools
- dotnet tool uninstall -g dotnet-aspnet-codegenerator
- dotnet tool install -g dotnet-aspnet-codegenerator
- dotnet tool update -g dotnet-aspnet-codegenerator
- dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers
