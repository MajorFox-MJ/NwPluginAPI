using System.Collections.Generic;

namespace TemplatePlugin.Configs
{
	public class AnotherConfig
	{
		public string Test { get; set; } = "Another Value";
		public List<string> TestList { get; set; } = new List<string>()
		{
			"Item1", "Item2"
		};
	}
}
