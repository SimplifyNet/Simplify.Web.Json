using Simplify.Web.ModelBinding;
using System.Text.Json;

namespace Simplify.Web.Json.ModelBinding.Binders
{
	/// <summary>
	/// Provides HTTP request JSON data to object binding
	/// </summary>
	public class JsonModelBinder : IModelBinder
	{
		/// <summary>
		/// Binds the specified JSON data to object.
		/// </summary>
		/// <typeparam name="T">Model type</typeparam>
		/// <param name="args">The <see cref="ModelBinderEventArgs{T}"/> instance containing the event data.</param>
		public void Bind<T>(ModelBinderEventArgs<T> args)
		{
			if (args.Context.Request.ContentType.Contains("application/json"))
			{
				args.SetModel(JsonSerializer.Deserialize<T>(args.Context.RequestBody));
			}
		}
	}
}