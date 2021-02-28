using Simplify.DI;
using Simplify.Web.Json;

namespace TesterApp.Setup
{
	public static class IocRegistrations
	{
		public static void Register() => DIContainer.Current.RegisterJsonModelBinder();
	}
}