# Simplify.Web.Json

[![Nuget Version](https://img.shields.io/nuget/v/Simplify.Web.Json)](https://www.nuget.org/packages/Simplify.Web.Json/)
[![Nuget Download](https://img.shields.io/nuget/dt/Simplify.Web.Json)](https://www.nuget.org/packages/Simplify.Web.Json/)
[![Build Package](https://github.com/SimplifyNet/Simplify.Web.Json/actions/workflows/build.yml/badge.svg)](https://github.com/SimplifyNet/Simplify.Web.Json/actions/workflows/build.yml)[![Libraries.io dependency status for latest release](https://img.shields.io/librariesio/release/nuget/Simplify.Web.Json)](https://libraries.io/nuget/Simplify.Web.Json)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/SimplifyNet/Simplify.Web.Json)](https://www.codefactor.io/repository/github/simplifynet/simplify.web.Json)
![Platform](https://img.shields.io/badge/platform-.NET%206.0%20%7C%20.NET%205.0%20%7C%20.NET%20Standard%202.0%20%7C%20.NET%204.6.2%20%7C%20.NET%20Core%203.1-lightgrey)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen)](http://makeapullrequest.com)

[Simplify.Web.Json](https://www.nuget.org/packages/Simplify.Web.Json/) is a package which provides JSON serialization/deserialization for [Simplify.Web](https://github.com/SimplifyNet/Simplify.Web) web-framework controllers.

## Quick Start

### Sending JSON to client

If the controller returns `Json` response class object, then the Framework execution will be stopped, object will be parsed to JSON string and sent to client

```csharp
public class MyController : Controller
{
    public override ControllerResponse Invoke()
    {
        ...
        return new Json(myObj);
    }
}
```

### Getting JSON from client

#### Registering binder

```csharp
public void Configuration(IApplicationBuilder app)
{
    ...
    HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

    app.UseSimplifyWeb();
}

public void ConfigureServices(IServiceCollection services)
{
    ...
    DIContainer.Current.RegisterJsonModelBinder();
    ...
}
```

#### Accessing model

##### Asynchronous

```csharp
public class MyController : ControllerAsync<MyModel>
{
    public override async Task<ControllerResponse> Invoke()
    {
        await ReadModelAsync();

        Model.
    }
}
```

##### Synchronous

JSON string will be deserialized to the controller model on first model access

```csharp
public class MyController : Controller<MyModel>
{
    public override ControllerResponse Invoke()
    {
        Model.
    }
}
```

## Contributing

There are many ways in which you can participate in the project. Like most open-source software projects, contributing code is just one of many outlets where you can help improve. Some of the things that you could help out with are:

- Documentation (both code and features)
- Bug reports
- Bug fixes
- Feature requests
- Feature implementations
- Test coverage
- Code quality
- Sample applications

## Related Projects

Additional extensions to Simplify.Web live in their own repositories on GitHub. For example:

- [Simplify.Web.Postman](https://github.com/SimplifyNet/Simplify.Web.Postman) - Postman collection and environment generation
- [Simplify.Web.Swagger](https://github.com/SimplifyNet/Simplify.Web.Swagger) - Swagger generation for controllers
- [Simplify.Web.Multipart](https://github.com/SimplifyNet/Simplify.Web.Multipart) - multipart form model binder
- [Simplify.Web.MessageBox](https://github.com/SimplifyNet/Simplify.Web.MessageBox) - non-interactive server side message box
- [Simplify.Web.Templates](https://github.com/SimplifyNet/Simplify.Web.Templates) - .NET projects templates

## License

Licensed under the GNU LESSER GENERAL PUBLIC LICENSE
