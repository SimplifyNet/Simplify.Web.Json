using Simplify.DI;
using Simplify.Web.Json.ModelBinding.Binders;

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
		public static IDIRegistrator RegisterJsonModelBinder(this IDIRegistrator registrator)
		{
			registrator.Register<JsonModelBinder>(LifetimeType.Singleton);

			return registrator;
		}
	}
}