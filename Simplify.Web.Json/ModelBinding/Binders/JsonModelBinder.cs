using System.IO;
using Newtonsoft.Json;
using Simplify.Web.ModelBinding;

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
				args.SetModel(JsonConvert.DeserializeObject<T>(new StreamReader(args.Context.Request.Body).ReadToEnd()));
		}
	}
}