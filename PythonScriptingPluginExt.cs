using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using ReClassNET;
using ReClassNET.Plugins;

namespace PythonScriptingPlugin
{
	public class PythonScriptingPluginExt : Plugin
	{
		private IPluginHost host;
		private ScriptEngine engine;

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

			engine = Python.CreateEngine();
			engine.Runtime.LoadAssembly(typeof(IntPtr).Assembly);
			engine.Runtime.LoadAssembly(typeof(Program).Assembly);

			var scriptingMenuItem = new ToolStripMenuItem("Scripts");

			var editorMenuItem = new ToolStripMenuItem("Editor");
			scriptingMenuItem.DropDownItems.Add(editorMenuItem);

			var testMenuItem = new ToolStripMenuItem("Test");
			testMenuItem.Click += (sender, args) =>
			{
				/*var expression = @"data = process.ReadRemoteMemory(IntPtr(0xFFD20000), 4)

logger.Log(LogLevel.Error, str(data[0]))
logger.Log(LogLevel.Error, str(data[1]))";*/

				var expression = @"for m in process.Modules:
	logger.Log(LogLevel.Error, m.Name)";

				try
				{
					ExecuteScript(expression);
				}
				catch (Exception e)
				{
					Program.ShowException(e);
				}
			};
			scriptingMenuItem.DropDownItems.Add(testMenuItem);

			host.MainWindow.MainMenu.Items.Insert(3, scriptingMenuItem);

			return true;
		}

		public override void Terminate()
		{
			engine = null;

			host = null;
		}

		private ScriptScope CreateReClassScope()
		{
			var scope = engine.CreateScope();

			dynamic s = scope;

			s.Is64Bit = false;

			s.ReClassName = Constants.ApplicationName;
			s.ReClassVersion = Constants.ApplicationVersion;

			s.logger = host.Logger;
			s.process = host.Process;

			return scope;
		}

		private static string CreateExpressionPreamble()
		{
			return "from System import *\n"
				 + "from ReClassNET import *\n"
				 + "from ReClassNET.Logger import *\n"
				 + "from ReClassNET.Memory import *\n"
				 + "from ReClassNET.MemoryScanner import *\n"
				 + "from ReClassNET.Nodes import *\n"
				 + "from ReClassNET.Util import *\n";
		}

		private object ExecuteScript(string code)
		{
			var scope = CreateReClassScope();

			code = CreateExpressionPreamble() + code;

			return engine.Execute(code, scope);
		}
	}
}
