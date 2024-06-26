﻿using System;
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
			form.Font = Font;
			//form.IsPassword = true;
			form.Message = "请输入字母或数字：";
			form.Regex = InputFormCommonRules.AlphabetDigits;

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, form.Value, ProductName);
			}
		}

		private void btnTextAreaForm_Click(object sender, EventArgs e)
		{
			InputForm form = new InputForm();
			form.Message = "请输入多行文字：";			
			form.Multiline = true;

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
			TaskForm form = new TaskForm();
			form.TaskProc = TaskProc;
			form.AllowAbort = true;
			form.ProgressMax = 100;
			form.ProgressValue = GetProgressValue;
			form.ProgressFormat = "{value}/{max} ({vps}/s)";

			m_progValue = 0;

			if (form.ShowDialog(this) != DialogResult.OK)
			{
				MessageBox.Show(this, form.Error, ProductName);
			}
		}

		int m_progValue = 0;
		int GetProgressValue()
		{
			return m_progValue;
		}

		void TaskProc()
		{
			while (m_progValue < 100)
			{
				m_progValue++;
				Thread.Sleep(100);
			}
		}

		private void btnLoginForm_Click(object sender, EventArgs e)
		{
			LoginForm form = new LoginForm();
			form.Font = Font;
			form.Authenticator = LoginAuth;
			form.UserName = "Abin";

			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, "登陆成功", ProductName);
			}
		}

		void LoginAuth(string userName, string password)
		{
			Thread.Sleep(2000);
			if (password != "123")
			{
				throw new Exception("Password must be 123");
			}
		}

		private void btnMessageForm_Click(object sender, EventArgs e)
		{
		}		

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			//string name = e.KeyCode.ToString();
			//int value = (int)e.KeyCode;
			//MessageForm.Show(this, name + ", " + value);
		}

		private void btnSwipeForm_Click(object sender, EventArgs e)
		{
			SwipeForm form = new SwipeForm();
			if (form.ShowDialog(this) == DialogResult.OK)
			{
				MessageBox.Show(this, form.Value, ProductName);
			}
		}

		private void btnShutdown_Click(object sender, EventArgs e)
		{
			ShutdownForm form = new ShutdownForm();
			form.CountDown = 3600;

			if (form.ShowDialog(this) != DialogResult.OK)
			{
				MessageBox.Show(this, "User cancelled shutdown.", ProductName);
			}
		}
	}

	class TestObj
	{
		public int ID { get; set; }
		public string Label { get; set; }
	}
}
