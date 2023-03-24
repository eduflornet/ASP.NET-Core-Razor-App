## [Build real world Razor application using Repository Pattern, N-Tier Architecture, API's in ASP.NET Core Razor Pages](https://github.com/eduflornet/ASP.NET-Core-Razor-App/tree/main/Abby)

### Implementation details
- [Data Access Layer library](https://github.com/eduflornet/ASP.NET-Core-Razor-App/tree/main/Abby/Abby.DAL)
	- [Entity Framework Core migrations](https://github.com/eduflornet/ASP.NET-Core-Razor-App/tree/main/Abby/Abby.DAL/Migrations)
	- [Repository pattern implementation detail](https://github.com/eduflornet/ASP.NET-Core-Razor-App/tree/main/Abby/Abby.DAL/Repository)
	- [UnitOfWork pattern implementation detail](https://github.com/eduflornet/ASP.NET-Core-Razor-App/blob/main/Abby/Abby.DAL/Repository/UnitOfWork.cs)

- [Razor Web Client](https://github.com/eduflornet/ASP.NET-Core-Razor-App/tree/main/Abby/AbbyWeb)

### Tools
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [NET6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Entity Framework Core 6](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-6.0/whatsnew)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Serilog.AspNetCore version 6.1.0](https://www.nuget.org/packages/Serilog.AspNetCore/)
- [Serilog.Expressions version 3.4.1](https://github.com/serilog/serilog-expressions)
- [Serilog.Sinks.Debug version 2.0.0](https://github.com/serilog/serilog-sinks-debug)
- [Microsoft.AspNetCore.Diagnostics.HealthChecks](https://learn.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-7.0)
- [Docker](https://www.docker.com/)


### Third party libraries
- [Bootswatch, Darkly, LUX Navbar by Bootstrap](https://bootswatch.com)
- [Bootstrap CSS, Icons - include via CDN](https://getbootstrap.com)
- [Toastr](https://codeseven.github.io/toastr/)
- [DataTables](https://datatables.net)


### References
- [Razor Pages Intro](https://learn.microsoft.com/es-mx/aspnet/core/razor-pages/?view=aspnetcore-6.0&tabs=visual-studio)
- [BindPropertyAttribute](https://learn.microsoft.com/es-mx/dotnet/api/microsoft.aspnetcore.mvc.bindpropertyattribute?view=aspnetcore-7.0)
- [Asistentes de tags integradas de ASP.NET Core](https://learn.microsoft.com/es-es/aspnet/core/mvc/views/tag-helpers/built-in/?source=recommendations&view=aspnetcore-7.0)
- [Crear asistentes de tags en ASP.NET Core](https://learn.microsoft.com/es-es/aspnet/core/mvc/views/tag-helpers/authoring?source=recommendations&view=aspnetcore-7.0)
- [Componentes del asistente de tags en ASP.NET Core](https://learn.microsoft.com/es-es/aspnet/core/mvc/views/tag-helpers/th-components?source=recommendations&view=aspnetcore-7.0)
- [Layout in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/layout?view=aspnetcore-7.0)
- [Model validation in ASP.NET Core MVC and Razor Pages](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-7.0)
- [DataAnnotations](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-7.0) 
- [Razor file compilation in ASP.NET Core](https://learn.microsoft.com/es-mx/aspnet/core/mvc/views/view-compilation?view=aspnetcore-6.0&tabs=visual-studio)
- [Partial views in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/mvc/views/partial?view=aspnetcore-7.0)
- [Implementing the Repository and Unit of Work Patterns in an ASP.NET MVC Application](https://learn.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
- [blog-Add logging to ASP.NET Core using Serilog .NET6](https://blog.christian-schou.dk/use-serilog-with-asp-net-core-net6/)
