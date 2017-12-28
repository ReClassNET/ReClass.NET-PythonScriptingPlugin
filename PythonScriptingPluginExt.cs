using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ReClassNET.Plugins;

namespace PythonScriptingPlugin
{
	public class PythonScriptingPluginExt : Plugin
	{
		private IPluginHost host;

		public override Image Icon => Properties.Resources.B16x16_Logo;

		public override bool Initialize(IPluginHost pluginHost)
		{
			System.Diagnostics.Debugger.Launch();

			if (host != null)
			{
				Terminate();
			}

			if (pluginHost == null)
			{
				throw new ArgumentNullException(nameof(pluginHost));
			}

			host = pluginHost;

			var scriptingMenuItem = new ToolStripMenuItem("Scripts");

			var editorMenuItem = new ToolStripMenuItem("Editor");
			scriptingMenuItem.DropDownItems.Add(editorMenuItem);

			host.MainWindow.MainMenu.Items.Insert(3, scriptingMenuItem);

			return true;
		}

		public override void Terminate()
		{
			host = null;
		}
	}
}
