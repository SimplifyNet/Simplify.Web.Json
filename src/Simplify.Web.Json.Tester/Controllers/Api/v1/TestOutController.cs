using Simplify.Web.Attributes;
using Simplify.Web.Json.Tester.ViewModels;

namespace Simplify.Web.Json.Tester.Controllers.Api.v1
{
	[Get("/api/v1/testOut")]
	public class TestOutController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Responses.Json(new TestViewModel { Prop1 = "Hello" });
		}
	}
}