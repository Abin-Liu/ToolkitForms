namespace Demo
{
	partial class Form1
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
			this.btnSelectForm = new System.Windows.Forms.Button();
			this.btnInputForm = new System.Windows.Forms.Button();
			this.btnTaskForm = new System.Windows.Forms.Button();
			this.btnLoginForm = new System.Windows.Forms.Button();
			this.btnMessageForm = new System.Windows.Forms.Button();
			this.btnTextAreaForm = new System.Windows.Forms.Button();
			this.btnSwipeForm = new System.Windows.Forms.Button();
			this.btnShutdown = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSelectForm
			// 
			this.btnSelectForm.Location = new System.Drawing.Point(153, 110);
			this.btnSelectForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnSelectForm.Name = "btnSelectForm";
			this.btnSelectForm.Size = new System.Drawing.Size(150, 45);
			this.btnSelectForm.TabIndex = 2;
			this.btnSelectForm.Text = "Select";
			this.btnSelectForm.UseVisualStyleBackColor = true;
			this.btnSelectForm.Click += new System.EventHandler(this.btnSelectForm_Click);
			// 
			// btnInputForm
			// 
			this.btnInputForm.Location = new System.Drawing.Point(153, 55);
			this.btnInputForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnInputForm.Name = "btnInputForm";
			this.btnInputForm.Size = new System.Drawing.Size(150, 45);
			this.btnInputForm.TabIndex = 0;
			this.btnInputForm.Text = "Input";
			this.btnInputForm.UseVisualStyleBackColor = true;
			this.btnInputForm.Click += new System.EventHandler(this.btnInputForm_Click);
			// 
			// btnTaskForm
			// 
			this.btnTaskForm.Location = new System.Drawing.Point(153, 166);
			this.btnTaskForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnTaskForm.Name = "btnTaskForm";
			this.btnTaskForm.Size = new System.Drawing.Size(150, 45);
			this.btnTaskForm.TabIndex = 4;
			this.btnTaskForm.Text = "Task";
			this.btnTaskForm.UseVisualStyleBackColor = true;
			this.btnTaskForm.Click += new System.EventHandler(this.btnTaskForm_Click);
			// 
			// btnLoginForm
			// 
			this.btnLoginForm.Location = new System.Drawing.Point(380, 110);
			this.btnLoginForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnLoginForm.Name = "btnLoginForm";
			this.btnLoginForm.Size = new System.Drawing.Size(150, 45);
			this.btnLoginForm.TabIndex = 3;
			this.btnLoginForm.Text = "Login";
			this.btnLoginForm.UseVisualStyleBackColor = true;
			this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
			// 
			// btnMessageForm
			// 
			this.btnMessageForm.Enabled = false;
			this.btnMessageForm.Location = new System.Drawing.Point(380, 166);
			this.btnMessageForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnMessageForm.Name = "btnMessageForm";
			this.btnMessageForm.Size = new System.Drawing.Size(150, 45);
			this.btnMessageForm.TabIndex = 5;
			this.btnMessageForm.Text = "Message";
			this.btnMessageForm.UseVisualStyleBackColor = true;
			this.btnMessageForm.Click += new System.EventHandler(this.btnMessageForm_Click);
			// 
			// btnTextAreaForm
			// 
			this.btnTextAreaForm.Location = new System.Drawing.Point(380, 55);
			this.btnTextAreaForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnTextAreaForm.Name = "btnTextAreaForm";
			this.btnTextAreaForm.Size = new System.Drawing.Size(150, 45);
			this.btnTextAreaForm.TabIndex = 1;
			this.btnTextAreaForm.Text = "Text Area";
			this.btnTextAreaForm.UseVisualStyleBackColor = true;
			this.btnTextAreaForm.Click += new System.EventHandler(this.btnTextAreaForm_Click);
			// 
			// btnSwipeForm
			// 
			this.btnSwipeForm.Location = new System.Drawing.Point(153, 221);
			this.btnSwipeForm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnSwipeForm.Name = "btnSwipeForm";
			this.btnSwipeForm.Size = new System.Drawing.Size(150, 45);
			this.btnSwipeForm.TabIndex = 6;
			this.btnSwipeForm.Text = "Swipe";
			this.btnSwipeForm.UseVisualStyleBackColor = true;
			this.btnSwipeForm.Click += new System.EventHandler(this.btnSwipeForm_Click);
			// 
			// btnShutdown
			// 
			this.btnShutdown.Location = new System.Drawing.Point(380, 221);
			this.btnShutdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnShutdown.Name = "btnShutdown";
			this.btnShutdown.Size = new System.Drawing.Size(150, 45);
			this.btnShutdown.TabIndex = 6;
			this.btnShutdown.Text = "Shutdown";
			this.btnShutdown.UseVisualStyleBackColor = true;
			this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 312);
			this.Controls.Add(this.btnShutdown);
			this.Controls.Add(this.btnSwipeForm);
			this.Controls.Add(this.btnMessageForm);
			this.Controls.Add(this.btnLoginForm);
			this.Controls.Add(this.btnTaskForm);
			this.Controls.Add(this.btnSelectForm);
			this.Controls.Add(this.btnTextAreaForm);
			this.Controls.Add(this.btnInputForm);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TookitForms Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSelectForm;
		private System.Windows.Forms.Button btnInputForm;
		private System.Windows.Forms.Button btnTaskForm;
		private System.Windows.Forms.Button btnLoginForm;
		private System.Windows.Forms.Button btnMessageForm;
		private System.Windows.Forms.Button btnTextAreaForm;
		private System.Windows.Forms.Button btnSwipeForm;
		private System.Windows.Forms.Button btnShutdown;
	}
}

