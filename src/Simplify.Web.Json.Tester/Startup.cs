using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Simplify.DI;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Json.Tester.Setup;
using Simplify.Web.Model;

namespace Simplify.Web.Json.Tester
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			IocRegistrations.Register();

			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

			app.UseSimplifyWeb();

			DIContainer.Current.Verify();
		}
	}
}