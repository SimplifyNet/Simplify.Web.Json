using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Simplify.DI;
using Simplify.Web;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Model;
using TesterApp.Setup;

namespace TesterApp
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

		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<KestrelServerOptions>(options => { options.AllowSynchronousIO = true; });
			services.Configure<IISServerOptions>(options => { options.AllowSynchronousIO = true; });
		}
	}
}