using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// 自动关机对话框
	/// </summary>
	public partial class ShutdownForm : Form
	{
		/// <summary>
		/// 关机倒计时（秒），0代表立即关机，默认为180秒
		/// </summary>
		public int CountDown { get; set; } = 180;

		/// <summary>
		/// 提示信息，默认为本地化的"System will shutdown in:"
		/// </summary>
		public string Message { get; set; }

		private DateTime m_shutdownTime;

		/// <summary>
		/// 构造函数
		/// </summary>
		public ShutdownForm()
		{
			InitializeComponent();
			Text = Localization.Get("Auto Shutdown");					
		}

		private void ShutdownForm_Load(object sender, EventArgs e)
		{
			lblPrompt.Text = Message ?? Localization.Get("System will shutdown in:");
			btnShutdown.Text = " " + Localization.Get("Shutdown");
			btnCancel.Text = " " + Localization.Get("Cancel");

			m_shutdownTime = DateTime.Now.AddSeconds(CountDown);
			timer1.Enabled = true;
		}

		private void ShutdownForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			int remain = (int)(m_shutdownTime - DateTime.Now).TotalSeconds;
			if (remain < 0)
			{
				remain = 0;
			}

			int hh = remain / 3600;
			int mm = (remain - hh * 3600) / 60;
			int ss = remain % 60;

			string text = string.Format("{0}:{1:00}:{2:00}", hh, mm, ss);
			lblTime.Text = text;

			if (remain == 0)
			{				
				DoShutdown();
			}
		}

		private void DoShutdown()
		{
			timer1.Enabled = false;
			Process.Start("shutdown.exe", "-s -f -t 3");
		}

		private void btnShutdown_Click(object sender, EventArgs e)
		{
			DoShutdown();
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
