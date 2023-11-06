using System;
using System.Threading.Tasks;
using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1;

[Post("/api/v1/test-in-array")]
public class TestInArrayController : AsyncController<TestViewModel[]>
{
	public override async Task<ControllerResponse> Invoke()
	{
		await ReadModelAsync();

		Console.WriteLine($"Objects count: {Model.Length}");

		for (var i = 0; i < Model.Length; i++)
			Console.WriteLine($"Object {i} prop1: {Model[i].Prop1}");

		return NoContent();
	}
}