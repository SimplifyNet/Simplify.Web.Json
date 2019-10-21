# Simplify.Web.Json

[![Nuget Version](https://img.shields.io/nuget/v/Simplify.Web.Json)](https://www.nuget.org/packages/Simplify.Web.Json/)
[![Nuget Download](https://img.shields.io/nuget/dt/Simplify.Web.Json)](https://www.nuget.org/packages/Simplify.Web.Json/)
[![AppVeyor branch](https://img.shields.io/appveyor/ci/i4004/simplify-web-json/master)](https://ci.appveyor.com/project/i4004/simplify-web-json)
[![Libraries.io dependency status for latest release](https://img.shields.io/librariesio/release/nuget/Simplify.Web.Json)](https://libraries.io/nuget/Simplify.Web.Json)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/SimplifyNet/Simplify.Web.Json)](https://www.codefactor.io/repository/github/simplifynet/simplify.web.Json)
![Platform](https://img.shields.io/badge/platform-.NET%20Standard%202.0%20%7C%20.NET%204.6.2-lightgrey)

`Simplify.Web.Json` is a package which provides JSON serialization/deserialization for [Simplify.Web](https://github.com/SimplifyNet/Simplify.Web) web-framework controllers.

## Examples

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
public void Configuration(IAppBuilder app)
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
