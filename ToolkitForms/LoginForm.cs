using System;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// LoginForm登录验证委托
	/// </summary>
	/// <param name="userName">用户名</param>
	/// <param name="password">密码</param>
	/// <returns>验证通过返回true，失败返回false</returns>
	public delegate bool LoginFormAuthDelegate(string userName, string password);

	/// <summary>
	/// 登录框体
	/// </summary>
	public partial class LoginForm : Form
	{
		/// <summary>
		/// 窗体标题，默认为已本地化的"User Login"
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 用户名标签文字
		/// </summary>
		public string UserNameLabel { get; set; }

		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 密码
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// 登录验证委托
		/// </summary>
		public LoginFormAuthDelegate Authenticator { get; set; }		

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			Text = Title ?? Localization.Get("User Login");
			lblUserName.Text = UserNameLabel ?? Localization.Get("User Name");
			lblPassword.Text = Localization.Get("Password");
			btnOK.Text = " " + Localization.Get("Login");
			btnCancel.Text = " " + Localization.Get("Cancel");

			if (!string.IsNullOrEmpty(UserName))
			{
				txtUserName.Text = UserName;
			}
		}

		// 如果有初始用户名，输入光标自动转到密码输入框中，提高用户操作流畅度
		private void LoginForm_Activated(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(UserName))
			{
				txtPassword.Focus();
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text.Trim();
			if (userName == "")
			{
				txtUserName.Focus();
				txtUserName.SelectAll();
				return;
			}

			string password = txtPassword.Text;
			if (password == "")
			{
				txtPassword.Focus();
				return;
			}

			if (Authenticator != null && !Authenticator(userName, password))
			{
				txtPassword.Focus();
				txtPassword.SelectAll();
				return;
			}

			UserName = userName;
			Password = password;
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
