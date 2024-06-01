using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Simplify.Web.Model.Binding;
using Simplify.Web.Model.Validation;

namespace Simplify.Web.Json.Model.Binding;

/// <summary>
/// Provides HTTP request JSON data to object binding.
/// </summary>
/// <seealso cref="IModelBinder" />
/// <remarks>
/// Initializes a new instance of the <see cref="JsonModelBinder" /> class.
/// </remarks>
/// <param name="settings">The settings.</param>
public class JsonModelBinder(JsonSerializerSettings? settings = null) : IModelBinder
{
	/// <summary>
	/// Binds the model asynchronously.
	/// </summary>
	/// <typeparam name="T">Model type</typeparam>
	/// <param name="args">The <see cref="T:Simplify.Web.Model.Binding.ModelBinderEventArgs`1" /> instance containing the event data.</param>
	/// <exception cref="ModelValidationException">JSON request body is null or empty</exception>
	public async Task BindAsync<T>(ModelBinderEventArgs<T> args)
	{
		if (args.Context.Request.ContentType == null || !args.Context.Request.ContentType.Contains("application/json"))
			return;

		await args.Context.ReadRequestBodyAsync();

		if (string.IsNullOrEmpty(args.Context.RequestBody))
			throw new ModelValidationException("JSON request body is null or empty");

		try
		{
			args.SetModel(JsonConvert.DeserializeObject<T>(args.Context.RequestBody, settings) ?? throw new InvalidOperationException("Deserialized model is null"));
		}
		catch (JsonReaderException e)
		{
			throw new ModelValidationException("Error deserializing JSON model. " + e.Message);
		}
		catch (JsonSerializationException e)
		{
			throw new ModelValidationException("Error deserializing JSON model. " + e.Message);
		}
	}
}