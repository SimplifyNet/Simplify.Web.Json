using Simplify.DI;

namespace Simplify.Web.Json.Tester.Setup
{
	public static class IocRegistrations
	{
		public static void Register()
		{
			DIContainer.Current.RegisterJsonModelBinder();
		}
	}
}