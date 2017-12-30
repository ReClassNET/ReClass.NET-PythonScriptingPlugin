using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using ReClassNET.Util;

namespace PythonScriptingPlugin
{
	public class ScriptContent
	{
		public string Name { get; set; }

		public string Content { get; set; }

		public Keys HotKey { get; set; }

		public void WriteTo(TextWriter writer)
		{
			var document = new XDocument(
				new XElement("script",
					XElementSerializer.ToXml(nameof(Name), Name),
					XElementSerializer.ToXml(nameof(Content), Content),
					XElementSerializer.ToXml(nameof(HotKey), (int)HotKey)
				)
			);
			document.Save(writer);
		}

		public static ScriptContent ReadFrom(TextReader reader)
		{
			var document = XDocument.Load(reader);

			var script = new ScriptContent();

			XElementSerializer.TryRead(document.Root, nameof(Name), e => script.Name = XElementSerializer.ToString(e));
			XElementSerializer.TryRead(document.Root, nameof(Content), e => script.Content = XElementSerializer.ToString(e));
			XElementSerializer.TryRead(document.Root, nameof(HotKey), e => script.HotKey = (Keys)XElementSerializer.ToInt(e));

			return script;
		}
	}
}
