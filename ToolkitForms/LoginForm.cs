using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// LoginForm登录验证委托
	/// </summary>
	/// <param name="userID">用户名</param>
	/// <param name="password">密码</param>
	/// <returns>验证通过返回true，失败返回false</returns>
	public delegate bool LoginFormAuthDelegate(string userID, string password);

	/// <summary>
	/// 登录框体
	/// </summary>
	public partial class LoginForm : Form
	{
		/// <summary>
		/// 窗体标题，默认为"Please Wait"
		/// </summary>
		public string Title { get; set; } = "User Login";

		/// <summary>
		/// 用户名
		/// </summary>
		public string UserID { get; set; }

		/// <summary>
		/// 登录验证委托
		/// </summary>
		public LoginFormAuthDelegate Authenticator { get; set; }

		/// <summary>
		/// 用户名标题，默认为"User ID:"
		/// </summary>
		public string UserIDLabel { get; set; } = "User ID:";

		/// <summary>
		/// 密码标题，默认为"Password:"
		/// </summary>
		public string PasswordLabel { get; set; } = "Password:";

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			Text = Title;
			lblUserID.Text = UserIDLabel;
			lblPassword.Text = PasswordLabel;

			if (!string.IsNullOrEmpty(UserID))
			{
				txtUserID.Text = UserID;
			}
		}

		private void LoginForm_Activated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(UserID))
			{
				txtPassword.Focus();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string userID = txtUserID.Text.Trim();
			if (userID == "")
			{
				txtUserID.Focus();
				txtUserID.SelectAll();
				return;
			}

			string password = txtPassword.Text;
			if (password == "")
			{
				txtPassword.Focus();
				return;
			}

			if (Authenticator != null && !Authenticator(userID, password))
			{
				txtPassword.Focus();
				txtPassword.SelectAll();
				return;
			}

			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}		
	}
}
