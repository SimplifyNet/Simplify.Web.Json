using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1;

[Get("/api/v1/test-out")]
public class TestOutController : Controller
{
	public override ControllerResponse Invoke() => new Simplify.Web.Json.Responses.Json(new TestViewModel { Prop1 = "Hello" });
}
