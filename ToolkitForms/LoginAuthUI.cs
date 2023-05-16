using System;
using System.Threading;
using System.Windows.Forms;

namespace ToolkitForms
{
	partial class LoginAuthUI : Form
	{
		/// <summary>
		/// 登录验证委托（参数1=用户名，参数2=登录密码）
		/// </summary>
		public Action<string, string> Authenticator { get; set; }

		/// <summary>
		/// 窗体文字，默认为已本地化的"Authenticating user, please wait ..."
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 密码
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// 登录是否成功
		/// </summary>
		public bool Success { get; private set; }		

		/// <summary>
		/// 错误信息
		/// </summary>
		public string Error { get; private set; }

		private Thread m_thread = null; // 线程

		public LoginAuthUI()
		{
			InitializeComponent();
		}

		private void LoginAuthUI_Load(object sender, EventArgs e)
		{
			lblMessage.Text = Message ?? Localization.Get("Authenticating user, please wait ..."); ;
			Success = false;
			m_thread = new Thread(ProcessTask);
			m_thread.IsBackground = true;
			m_thread.Start();
			timer1.Enabled = true;
		}

		// 内部处理函数
		private void ProcessTask()
		{
			try
			{
				if (Authenticator == null)
				{
					throw new NullReferenceException("Authenticator is null.");
				}

				Authenticator(UserName, Password);
				Success = true;
			}			
			catch (Exception e)
			{
				Error = e.Message;
				Success = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (m_thread.IsAlive)
			{
				return;
			}

			timer1.Enabled = false;
			if (Success)
			{
				DialogResult = DialogResult.OK;
			}
			else
			{
				DialogResult = DialogResult.Cancel;
			}
		}
	}
}
