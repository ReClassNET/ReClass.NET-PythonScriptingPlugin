using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using ReClassNET.Forms;
using ReClassNET.UI;

namespace PythonScriptingPlugin.Forms
{
	public partial class ScriptEditorForm : IconForm
	{
		private readonly List<ScriptContent> scripts;
		private readonly BindingSource scriptsBindingSource;

		public ScriptEditorForm(List<ScriptContent> scripts)
		{
			Contract.Requires(scripts != null);

			this.scripts = scripts;

			InitializeComponent();

			scriptsBindingSource = new BindingSource
			{
				DataSource = scripts
			};

			scriptsListBox.DataSource = scriptsBindingSource;
			scriptsListBox.DisplayMember = "Name";

			scriptNameTextBox.DataBindings.Add("Text", scriptsBindingSource, "Name", true, DataSourceUpdateMode.OnPropertyChanged);
			scriptContentTextBox.DataBindings.Add("Text", scriptsBindingSource, "Content", true, DataSourceUpdateMode.OnPropertyChanged);
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			GlobalWindowManager.AddWindow(this);
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			base.OnFormClosed(e);

			GlobalWindowManager.RemoveWindow(this);
		}

		private void addScriptIconButton_Click(object sender, EventArgs e)
		{
			scripts.Add(new ScriptContent { Name = "New Script" });
			scriptsBindingSource.ResetBindings(false);
		}

		private void deleteScriptIconButton_Click(object sender, EventArgs e)
		{
			if (!(scriptsListBox.SelectedItem is ScriptContent script))
			{
				return;
			}

			if (MessageBox.Show($"Do you really want to delete the script '{script.Name}'?", "Script", MessageBoxButtons.YesNo) != DialogResult.Yes)
			{
				return;
			}

			if (scripts.Remove(script))
			{
				scriptsBindingSource.ResetBindings(false);
			}
		}
	}
}
