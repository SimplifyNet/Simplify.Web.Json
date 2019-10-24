using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1
{
	[Get("/api/v1/testOut")]
	public class TestOutController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Simplify.Web.Json.Responses.Json(new TestViewModel { Prop1 = "Hello" });
		}
	}
}