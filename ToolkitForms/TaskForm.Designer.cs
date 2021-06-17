namespace ToolkitForms
{
	partial class TaskForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
			this.lblPrompt = new System.Windows.Forms.Label();
			this.btnAbort = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lblProgress = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPrompt
			// 
			this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPrompt.Location = new System.Drawing.Point(12, 10);
			this.lblPrompt.Name = "lblPrompt";
			this.lblPrompt.Size = new System.Drawing.Size(308, 20);
			this.lblPrompt.TabIndex = 0;
			this.lblPrompt.Text = "label1";
			this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAbort
			// 
			this.btnAbort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAbort.Image = global::ToolkitForms.Properties.Resources.Cancel;
			this.btnAbort.Location = new System.Drawing.Point(127, 97);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.Size = new System.Drawing.Size(80, 28);
			this.btnAbort.TabIndex = 3;
			this.btnAbort.Text = "Abort";
			this.btnAbort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAbort.UseVisualStyleBackColor = true;
			this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(15, 35);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(305, 23);
			this.progressBar1.TabIndex = 1;
			// 
			// lblProgress
			// 
			this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblProgress.Location = new System.Drawing.Point(15, 63);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(305, 20);
			this.lblProgress.TabIndex = 2;
			this.lblProgress.Text = "label1";
			this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnAbort;
			this.ClientSize = new System.Drawing.Size(332, 144);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnAbort);
			this.Controls.Add(this.lblPrompt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TaskForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
			this.Load += new System.EventHandler(this.TaskForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblPrompt;
		private System.Windows.Forms.Button btnAbort;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lblProgress;
	}
}