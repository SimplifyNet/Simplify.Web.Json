using System.Diagnostics;
using System.Threading.Tasks;
using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1;

[Post("/api/v1/test-in")]
public class TestInController : AsyncController<TestViewModel>
{
	public override async Task<ControllerResponse> Invoke()
	{
		await ReadModelAsync();

		Trace.TraceInformation($"Object prop1: {Model.Prop1}");
		Trace.TraceInformation($"Object prop2: {Model.Prop2}");

		return NoContent();
	}
}