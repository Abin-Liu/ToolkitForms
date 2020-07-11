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
			this.SuspendLayout();
			// 
			// btnSelectForm
			// 
			this.btnSelectForm.Location = new System.Drawing.Point(115, 12);
			this.btnSelectForm.Name = "btnSelectForm";
			this.btnSelectForm.Size = new System.Drawing.Size(75, 23);
			this.btnSelectForm.TabIndex = 3;
			this.btnSelectForm.Text = "SelectForm";
			this.btnSelectForm.UseVisualStyleBackColor = true;
			this.btnSelectForm.Click += new System.EventHandler(this.btnSelectForm_Click);
			// 
			// btnInputForm
			// 
			this.btnInputForm.Location = new System.Drawing.Point(12, 12);
			this.btnInputForm.Name = "btnInputForm";
			this.btnInputForm.Size = new System.Drawing.Size(75, 23);
			this.btnInputForm.TabIndex = 2;
			this.btnInputForm.Text = "InputForm";
			this.btnInputForm.UseVisualStyleBackColor = true;
			this.btnInputForm.Click += new System.EventHandler(this.btnInputForm_Click);
			// 
			// btnTaskForm
			// 
			this.btnTaskForm.Location = new System.Drawing.Point(12, 51);
			this.btnTaskForm.Name = "btnTaskForm";
			this.btnTaskForm.Size = new System.Drawing.Size(75, 23);
			this.btnTaskForm.TabIndex = 4;
			this.btnTaskForm.Text = "TaskForm";
			this.btnTaskForm.UseVisualStyleBackColor = true;
			this.btnTaskForm.Click += new System.EventHandler(this.btnTaskForm_Click);
			// 
			// btnLoginForm
			// 
			this.btnLoginForm.Location = new System.Drawing.Point(115, 51);
			this.btnLoginForm.Name = "btnLoginForm";
			this.btnLoginForm.Size = new System.Drawing.Size(75, 23);
			this.btnLoginForm.TabIndex = 5;
			this.btnLoginForm.Text = "LoginForm";
			this.btnLoginForm.UseVisualStyleBackColor = true;
			this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 219);
			this.Controls.Add(this.btnLoginForm);
			this.Controls.Add(this.btnTaskForm);
			this.Controls.Add(this.btnSelectForm);
			this.Controls.Add(this.btnInputForm);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSelectForm;
		private System.Windows.Forms.Button btnInputForm;
		private System.Windows.Forms.Button btnTaskForm;
		private System.Windows.Forms.Button btnLoginForm;
	}
}

