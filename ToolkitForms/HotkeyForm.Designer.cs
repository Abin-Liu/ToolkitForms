namespace ToolkitForms
{
	partial class HotkeyForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyForm));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblModifiers = new System.Windows.Forms.Label();
			this.lblKey = new System.Windows.Forms.Label();
			this.chkCtrl = new System.Windows.Forms.CheckBox();
			this.chkShift = new System.Windows.Forms.CheckBox();
			this.chkAlt = new System.Windows.Forms.CheckBox();
			this.cmbKey = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
			// 
			// testToolStripMenuItem
			// 
			this.testToolStripMenuItem.Name = "testToolStripMenuItem";
			this.testToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.testToolStripMenuItem.Text = "Test";
			// 
			// lblModifiers
			// 
			this.lblModifiers.AutoSize = true;
			this.lblModifiers.Location = new System.Drawing.Point(12, 9);
			this.lblModifiers.Name = "lblModifiers";
			this.lblModifiers.Size = new System.Drawing.Size(65, 12);
			this.lblModifiers.TabIndex = 0;
			this.lblModifiers.Text = "Modifiers:";
			// 
			// lblKey
			// 
			this.lblKey.AutoSize = true;
			this.lblKey.Location = new System.Drawing.Point(12, 64);
			this.lblKey.Name = "lblKey";
			this.lblKey.Size = new System.Drawing.Size(29, 12);
			this.lblKey.TabIndex = 4;
			this.lblKey.Text = "Key:";
			// 
			// chkCtrl
			// 
			this.chkCtrl.AutoSize = true;
			this.chkCtrl.Location = new System.Drawing.Point(26, 31);
			this.chkCtrl.Name = "chkCtrl";
			this.chkCtrl.Size = new System.Drawing.Size(48, 16);
			this.chkCtrl.TabIndex = 1;
			this.chkCtrl.Text = "Ctrl";
			this.chkCtrl.UseVisualStyleBackColor = true;
			// 
			// chkShift
			// 
			this.chkShift.AutoSize = true;
			this.chkShift.Location = new System.Drawing.Point(104, 31);
			this.chkShift.Name = "chkShift";
			this.chkShift.Size = new System.Drawing.Size(54, 16);
			this.chkShift.TabIndex = 2;
			this.chkShift.Text = "Shift";
			this.chkShift.UseVisualStyleBackColor = true;
			// 
			// chkAlt
			// 
			this.chkAlt.AutoSize = true;
			this.chkAlt.Location = new System.Drawing.Point(194, 31);
			this.chkAlt.Name = "chkAlt";
			this.chkAlt.Size = new System.Drawing.Size(42, 16);
			this.chkAlt.TabIndex = 3;
			this.chkAlt.Text = "Alt";
			this.chkAlt.UseVisualStyleBackColor = true;
			// 
			// cmbKey
			// 
			this.cmbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbKey.FormattingEnabled = true;
			this.cmbKey.Location = new System.Drawing.Point(26, 90);
			this.cmbKey.Name = "cmbKey";
			this.cmbKey.Size = new System.Drawing.Size(230, 20);
			this.cmbKey.TabIndex = 5;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnOK.Image = global::ToolkitForms.Properties.Resources.OK;
			this.btnOK.Location = new System.Drawing.Point(51, 130);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(80, 26);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Image = global::ToolkitForms.Properties.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(156, 130);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 26);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// HotkeyForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(287, 171);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cmbKey);
			this.Controls.Add(this.chkAlt);
			this.Controls.Add(this.chkShift);
			this.Controls.Add(this.chkCtrl);
			this.Controls.Add(this.lblKey);
			this.Controls.Add(this.lblModifiers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HotkeyForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "HotkeyForm";
			this.Load += new System.EventHandler(this.HotkeyForm_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
		private System.Windows.Forms.Label lblModifiers;
		private System.Windows.Forms.Label lblKey;
		private System.Windows.Forms.CheckBox chkCtrl;
		private System.Windows.Forms.CheckBox chkShift;
		private System.Windows.Forms.CheckBox chkAlt;
		private System.Windows.Forms.ComboBox cmbKey;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
	}
}