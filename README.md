Simplify.Web.Json
===

`Simplify.Web.Json` is a package which provides JSON controller response for controllers and JSON view model binder for [Simplify.Web web-framework](https://github.com/i4004/Simplify.Web).

## Package status

| Latest version | [![Nuget version](http://img.shields.io/badge/nuget-v0-blue.png)](https://www.nuget.org/packages/Simplify.Web.Json/) |
| :------ | :------: |
| **Dependencies** | [![NuGet Status](http://nugetstatus.com/Simplify.Web.Json.png)](http://nugetstatus.com/packages/Simplify.Web.Json) |

## Build status

| | **.NET (4.5.2)** | **Mono (Latest)** |
| :------ | :------ | :------: |
| **master** | [![AppVeyor Build status](https://ci.appveyor.com/api/projects/status/dfi53jjk9klcc4bx/branch/master?svg=true)](https://ci.appveyor.com/project/i4004/simplify-web-json/branch/master) | [![Travis Build Status](https://travis-ci.org/i4004/Simplify.Web.Json.svg?branch=master)](https://travis-ci.org/i4004/Simplify.Web.Json) |

## Examples

#### Using JSON controller response

Framework execution will be stopped and object will be parsed to JSON string and sent to client
```csharp
	public class MyController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Json(myObj);
		}
	}
```

#### Using JSON view model binder

Registering binder:
```csharp
public void Configuration(IAppBuilder app)
{
	...
	HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

	app.UseSimplifyWeb();
}
```
