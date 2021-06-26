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
			this.btnHotkeyForm = new System.Windows.Forms.Button();
			this.btnTextAreaForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSelectForm
			// 
			this.btnSelectForm.Location = new System.Drawing.Point(92, 63);
			this.btnSelectForm.Name = "btnSelectForm";
			this.btnSelectForm.Size = new System.Drawing.Size(90, 26);
			this.btnSelectForm.TabIndex = 2;
			this.btnSelectForm.Text = "Select";
			this.btnSelectForm.UseVisualStyleBackColor = true;
			this.btnSelectForm.Click += new System.EventHandler(this.btnSelectForm_Click);
			// 
			// btnInputForm
			// 
			this.btnInputForm.Location = new System.Drawing.Point(92, 31);
			this.btnInputForm.Name = "btnInputForm";
			this.btnInputForm.Size = new System.Drawing.Size(90, 26);
			this.btnInputForm.TabIndex = 0;
			this.btnInputForm.Text = "Input";
			this.btnInputForm.UseVisualStyleBackColor = true;
			this.btnInputForm.Click += new System.EventHandler(this.btnInputForm_Click);
			// 
			// btnTaskForm
			// 
			this.btnTaskForm.Location = new System.Drawing.Point(92, 95);
			this.btnTaskForm.Name = "btnTaskForm";
			this.btnTaskForm.Size = new System.Drawing.Size(90, 26);
			this.btnTaskForm.TabIndex = 4;
			this.btnTaskForm.Text = "Task";
			this.btnTaskForm.UseVisualStyleBackColor = true;
			this.btnTaskForm.Click += new System.EventHandler(this.btnTaskForm_Click);
			// 
			// btnLoginForm
			// 
			this.btnLoginForm.Location = new System.Drawing.Point(228, 63);
			this.btnLoginForm.Name = "btnLoginForm";
			this.btnLoginForm.Size = new System.Drawing.Size(90, 26);
			this.btnLoginForm.TabIndex = 3;
			this.btnLoginForm.Text = "Login";
			this.btnLoginForm.UseVisualStyleBackColor = true;
			this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
			// 
			// btnMessageForm
			// 
			this.btnMessageForm.Location = new System.Drawing.Point(228, 95);
			this.btnMessageForm.Name = "btnMessageForm";
			this.btnMessageForm.Size = new System.Drawing.Size(90, 26);
			this.btnMessageForm.TabIndex = 5;
			this.btnMessageForm.Text = "Message";
			this.btnMessageForm.UseVisualStyleBackColor = true;
			this.btnMessageForm.Click += new System.EventHandler(this.btnMessageForm_Click);
			// 
			// btnHotkeyForm
			// 
			this.btnHotkeyForm.Location = new System.Drawing.Point(92, 127);
			this.btnHotkeyForm.Name = "btnHotkeyForm";
			this.btnHotkeyForm.Size = new System.Drawing.Size(90, 26);
			this.btnHotkeyForm.TabIndex = 6;
			this.btnHotkeyForm.Text = "Hotkey";
			this.btnHotkeyForm.UseVisualStyleBackColor = true;
			this.btnHotkeyForm.Click += new System.EventHandler(this.btnHotkeyForm_Click);
			// 
			// btnTextAreaForm
			// 
			this.btnTextAreaForm.Location = new System.Drawing.Point(228, 31);
			this.btnTextAreaForm.Name = "btnTextAreaForm";
			this.btnTextAreaForm.Size = new System.Drawing.Size(90, 26);
			this.btnTextAreaForm.TabIndex = 1;
			this.btnTextAreaForm.Text = "Text Area";
			this.btnTextAreaForm.UseVisualStyleBackColor = true;
			this.btnTextAreaForm.Click += new System.EventHandler(this.btnTextAreaForm_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 178);
			this.Controls.Add(this.btnHotkeyForm);
			this.Controls.Add(this.btnMessageForm);
			this.Controls.Add(this.btnLoginForm);
			this.Controls.Add(this.btnTaskForm);
			this.Controls.Add(this.btnSelectForm);
			this.Controls.Add(this.btnTextAreaForm);
			this.Controls.Add(this.btnInputForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
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
		private System.Windows.Forms.Button btnHotkeyForm;
		private System.Windows.Forms.Button btnTextAreaForm;
	}
}

