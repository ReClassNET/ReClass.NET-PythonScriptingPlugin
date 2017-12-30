namespace PythonScriptingPlugin.Forms
{
	partial class ScriptEditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.scriptsListBox = new System.Windows.Forms.ListBox();
			this.scriptNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.scriptContentTextBox = new System.Windows.Forms.TextBox();
			this.addScriptIconButton = new ReClassNET.UI.IconButton();
			this.bannerBox = new ReClassNET.UI.BannerBox();
			this.deleteScriptIconButton = new ReClassNET.UI.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.bannerBox)).BeginInit();
			this.SuspendLayout();
			// 
			// scriptsListBox
			// 
			this.scriptsListBox.FormattingEnabled = true;
			this.scriptsListBox.Location = new System.Drawing.Point(12, 70);
			this.scriptsListBox.Name = "scriptsListBox";
			this.scriptsListBox.Size = new System.Drawing.Size(171, 329);
			this.scriptsListBox.TabIndex = 4;
			// 
			// scriptNameTextBox
			// 
			this.scriptNameTextBox.Location = new System.Drawing.Point(233, 70);
			this.scriptNameTextBox.Name = "scriptNameTextBox";
			this.scriptNameTextBox.Size = new System.Drawing.Size(382, 20);
			this.scriptNameTextBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Scripts:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(189, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(189, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Hotkey:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(233, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(382, 20);
			this.textBox1.TabIndex = 9;
			// 
			// scriptContentTextBox
			// 
			this.scriptContentTextBox.AcceptsReturn = true;
			this.scriptContentTextBox.AcceptsTab = true;
			this.scriptContentTextBox.Location = new System.Drawing.Point(192, 122);
			this.scriptContentTextBox.Multiline = true;
			this.scriptContentTextBox.Name = "scriptContentTextBox";
			this.scriptContentTextBox.Size = new System.Drawing.Size(423, 277);
			this.scriptContentTextBox.TabIndex = 11;
			// 
			// addScriptIconButton
			// 
			this.addScriptIconButton.Image = global::PythonScriptingPlugin.Properties.Resources.B16x16_Button_Add;
			this.addScriptIconButton.Location = new System.Drawing.Point(138, 48);
			this.addScriptIconButton.Name = "addScriptIconButton";
			this.addScriptIconButton.Pressed = false;
			this.addScriptIconButton.Selected = false;
			this.addScriptIconButton.Size = new System.Drawing.Size(23, 22);
			this.addScriptIconButton.TabIndex = 12;
			this.addScriptIconButton.Click += new System.EventHandler(this.addScriptIconButton_Click);
			// 
			// bannerBox
			// 
			this.bannerBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.bannerBox.Icon = global::PythonScriptingPlugin.Properties.Resources.B32x32_Logo;
			this.bannerBox.Location = new System.Drawing.Point(0, 0);
			this.bannerBox.Name = "bannerBox";
			this.bannerBox.Size = new System.Drawing.Size(627, 48);
			this.bannerBox.TabIndex = 3;
			this.bannerBox.Text = "Edit the available Python scripts.";
			this.bannerBox.Title = "Python Script Editor";
			// 
			// deleteScriptIconButton
			// 
			this.deleteScriptIconButton.Image = global::PythonScriptingPlugin.Properties.Resources.B16x16_Button_Delete;
			this.deleteScriptIconButton.Location = new System.Drawing.Point(160, 48);
			this.deleteScriptIconButton.Name = "deleteScriptIconButton";
			this.deleteScriptIconButton.Pressed = false;
			this.deleteScriptIconButton.Selected = false;
			this.deleteScriptIconButton.Size = new System.Drawing.Size(23, 22);
			this.deleteScriptIconButton.TabIndex = 13;
			this.deleteScriptIconButton.Click += new System.EventHandler(this.deleteScriptIconButton_Click);
			// 
			// ScriptEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 411);
			this.Controls.Add(this.deleteScriptIconButton);
			this.Controls.Add(this.addScriptIconButton);
			this.Controls.Add(this.scriptContentTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.scriptNameTextBox);
			this.Controls.Add(this.scriptsListBox);
			this.Controls.Add(this.bannerBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScriptEditorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ReClass.NET - Python Script Editor";
			((System.ComponentModel.ISupportInitialize)(this.bannerBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReClassNET.UI.BannerBox bannerBox;
		private System.Windows.Forms.ListBox scriptsListBox;
		private System.Windows.Forms.TextBox scriptNameTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox scriptContentTextBox;
		private ReClassNET.UI.IconButton addScriptIconButton;
		private ReClassNET.UI.IconButton deleteScriptIconButton;
	}
}