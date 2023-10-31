using System;
using System.Windows.Forms;
using UIToolkits;

namespace ToolkitForms
{
	/// <summary>
	/// 登录框体
	/// </summary>
	public partial class LoginForm : Form
	{
		/// <summary>
		/// 用户名标签文字
		/// </summary>
		public string UserNameLabel { get; set; }

		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 登录密码
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// 登录验证委托（参数1=用户名，参数2=登录密码）
		/// </summary>
		public Action<string, string> Authenticator { get; set; }

		/// <summary>
		/// 验证等待界面文字，默认为已本地化的"Authenticating user, please wait ..."
		/// </summary>
		public string AuthenticatintMessage { get; set; }

		/// <summary>
		/// 验证失败提示框标题文字，默认为已本地化的"Login Failed"
		/// </summary>
		public string FailCaption { get; set; }

		/// <summary>
		/// 登录是否成功
		/// </summary>
		public bool Success { get; private set; }		

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public LoginForm()
		{
			InitializeComponent();
			Text = Localization.Get("User Login");			
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{			
			FailCaption = FailCaption ?? Localization.Get("Login Failed");
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
			
			if (Authenticator == null)
			{
				// 开发者自行处理用户名和密码
				UserName = userName;
				Password = password;
				Success = true;
				DialogResult = DialogResult.OK;
				return;
			}

			LoginAuthUI authUI = new LoginAuthUI();
			authUI.Font = Font;
			authUI.UserName = userName;
			authUI.Password = password;
			authUI.Authenticator = Authenticator;
			authUI.Message = AuthenticatintMessage;
			Success = authUI.ShowDialog(this) == DialogResult.OK;			
			if (Success)
			{
				UserName = userName;
				DialogResult = DialogResult.OK;
			}
			else
			{				
				Messagex.Error(this, authUI.Error ?? "Authentication failed.", FailCaption);
				txtPassword.Focus();
				txtPassword.SelectAll();
			}			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}		
	}
}
