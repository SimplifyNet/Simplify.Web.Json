using Newtonsoft.Json;

namespace TesterApp.ViewModels;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public class TestViewModel
{
	public string Prop1 { get; set; }
	public string Prop2 { get; set; }
}