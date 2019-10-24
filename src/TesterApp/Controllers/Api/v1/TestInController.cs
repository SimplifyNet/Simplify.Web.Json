using System.Diagnostics;
using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1
{
	[Post("/api/v1/testIn")]
	public class TestInController : Controller<TestViewModel>
	{
		public override ControllerResponse Invoke()
		{
			Trace.WriteLine($"Object prop1: {Model.Prop1}");
			Trace.WriteLine($"Object prop2: {Model.Prop2}");

			return NoContent();
		}
	}
}