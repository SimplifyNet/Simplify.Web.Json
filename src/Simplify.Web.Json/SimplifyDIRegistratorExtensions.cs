using Newtonsoft.Json;
using Simplify.DI;
using Simplify.Web.Json.Model.Binding;

namespace Simplify.Web.Json
{
	/// <summary>
	/// Provides Simplify.Web.Json default registration
	/// </summary>
	public static class SimplifyDIRegistratorExtensions
	{
		/// <summary>
		/// Registers Simplify.Web.Json JsonModelBinder.
		/// </summary>
		/// <param name="registrator">The registrator.</param>
		/// <param name="settings">The settings.</param>
		/// <returns></returns>
		public static IDIRegistrator RegisterJsonModelBinder(this IDIRegistrator registrator, JsonSerializerSettings? settings = null)
		{
			registrator.Register(r => new JsonModelBinder(settings), LifetimeType.Singleton);

			return registrator;
		}

		/// <summary>
		/// Registers Simplify.Web.Json JsonModelBinder which will search for `JsonSerializerSettings` registered in container (JsonSerializerSettings should be manually registered in container).
		/// </summary>
		/// <param name="registrator">The registrator.</param>
		/// <returns></returns>
		public static IDIRegistrator RegisterJsonModelBinderWithSettingsFromContainer(this IDIRegistrator registrator)
		{
			registrator.Register(r => new JsonModelBinder(r.Resolve<JsonSerializerSettings>()), LifetimeType.Singleton);

			return registrator;
		}
	}
}