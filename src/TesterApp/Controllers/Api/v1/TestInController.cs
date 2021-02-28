using System.Diagnostics;
using System.Threading.Tasks;
using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1
{
	[Post("/api/v1/testIn")]
	public class TestInController : AsyncController<TestViewModel>
	{
		public override async Task<ControllerResponse> Invoke()
		{
			await ReadModelAsync();

			Trace.WriteLine($"Object prop1: {Model.Prop1}");
			Trace.WriteLine($"Object prop2: {Model.Prop2}");

			return NoContent();
		}
	}
}