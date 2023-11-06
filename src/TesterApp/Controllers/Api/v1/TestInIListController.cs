using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Simplify.Web;
using Simplify.Web.Attributes;
using TesterApp.ViewModels;

namespace TesterApp.Controllers.Api.v1;

[Post("/api/v1/test-in-ilist")]
public class TestInIListController : AsyncController<IList<TestViewModel>>
{
	public override async Task<ControllerResponse> Invoke()
	{
		await ReadModelAsync();

		Console.WriteLine($"Objects count: {Model.Count}");

		for (var i = 0; i < Model.Count; i++)
			Console.WriteLine($"Object {i} prop1: {Model[i].Prop1}");

		return NoContent();
	}
}