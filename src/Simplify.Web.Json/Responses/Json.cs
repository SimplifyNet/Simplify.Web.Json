using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Simplify.Web.Json.Responses;

/// <summary>
/// Provides controller JSON response (send only JSON string to response)
/// </summary>
/// <seealso cref="ControllerResponse" />
/// <remarks>
/// Initializes a new instance of the <see cref="Json"/> class.
/// </remarks>
/// <param name="objectToConvert">The object to convert to JSON.</param>
/// <param name="statusCode">The HTTP response status code.</param>
public class Json(object objectToConvert, int statusCode = 200) : ControllerResponse
{
	private readonly object _objectToConvert = objectToConvert;

	/// <summary>
	/// Gets the HTTP response status code.
	/// </summary>
	/// <value>
	/// The HTTP response status code.
	/// </value>
	private readonly int _statusCode = statusCode;

	/// <summary>
	/// Executes this response asynchronously.
	/// </summary>
	public override async Task<ResponseBehavior> ExecuteAsync()
	{
		Context.Response.ContentType = "application/json";
		Context.Response.StatusCode = _statusCode;

		await ResponseWriter.WriteAsync(Context.Response, JsonConvert.SerializeObject(_objectToConvert));

		return ResponseBehavior.RawOutput;
	}
}