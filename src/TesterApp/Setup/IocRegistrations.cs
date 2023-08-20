﻿using Simplify.DI;
using Simplify.Web;
using Simplify.Web.Json;

namespace TesterApp.Setup;

public static class IocRegistrations
{
	public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
	{
		provider
			.RegisterSimplifyWeb()
			.RegisterJsonModelBinder();

		return provider;
	}
}
