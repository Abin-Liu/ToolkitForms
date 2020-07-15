using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ToolkitForms;

namespace Demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnInputForm_Click(object sender, EventArgs e)
		{
			InputForm form = new InputForm();
			form.Message = "请输入字母或数字：";
			form.Regex = InputFormCommonRules.AlphabetDigits;

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, form.Value, ProductName);
			}
		}

		private void btnSelectForm_Click(object sender, EventArgs e)
		{
			SelectForm form = new SelectForm();
			form.SelectedIndex = 0;
			form.Options = new string[] { "A", "B", "C" };			

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, string.Format("{0}", form.SelectedValue), ProductName);
			}
		}

		private void btnTaskForm_Click(object sender, EventArgs e)
		{
			TaskForm form = new TaskForm(false);
			form.TaskProc = TaskProc;
			//form.TimeLimit = 1500;

			if (form.ShowDialog(this) != DialogResult.OK)
			{
				MessageBox.Show(this, form.Error, ProductName);
			}
		}

		void TaskProc()
		{
			Thread.Sleep(3000);
		}

		private void btnLoginForm_Click(object sender, EventArgs e)
		{
			LoginForm form = new LoginForm();
			form.Authenticator = LoginAuth;
			form.UserName = "Abin";

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, "登陆成功", ProductName);
			}
		}

		bool LoginAuth(string userName, string password)
		{
			if (password != "123")
			{
				MessageBox.Show("Password must be 123", "Error");
				return false;
			}

			return true;
		}
	}

	class TestObj
	{
		public int ID { get; set; }
		public string Label { get; set; }
	}
}
