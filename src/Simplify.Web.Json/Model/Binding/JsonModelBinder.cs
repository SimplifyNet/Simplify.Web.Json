using System.Threading.Tasks;
using Newtonsoft.Json;
using Simplify.Web.Model.Binding;
using Simplify.Web.Model.Validation;

namespace Simplify.Web.Json.Model.Binding
{
	/// <summary>
	/// Provides HTTP request JSON data to object binding
	/// </summary>
	public class JsonModelBinder : IModelBinder
	{
		private readonly JsonSerializerSettings? _settings;

		/// <summary>
		/// Initializes a new instance of the <see cref="JsonModelBinder"/> class.
		/// </summary>
		/// <param name="settings">The settings.</param>
		public JsonModelBinder(JsonSerializerSettings? settings = null)
		{
			_settings = settings;
		}

		/// <summary>
		/// Binds the model asynchronously.
		/// </summary>
		/// <typeparam name="T">Model type</typeparam>
		/// <param name="args">The <see cref="T:Simplify.Web.Model.Binding.ModelBinderEventArgs`1" /> instance containing the event data.</param>
		/// <returns></returns>
		/// <exception cref="ModelValidationException">JSON request body is null or empty</exception>
		public async Task BindAsync<T>(ModelBinderEventArgs<T> args)
		{
			if (args.Context.Request.ContentType == null || !args.Context.Request.ContentType.Contains("application/json"))
				return;

			await args.Context.ReadRequestBodyAsync();

			if (string.IsNullOrEmpty(args.Context.RequestBody))
				throw new ModelValidationException("JSON request body is null or empty");

			args.SetModel(JsonConvert.DeserializeObject<T>(args.Context.RequestBody, _settings));
		}
	}
}