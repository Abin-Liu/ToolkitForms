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
	/// 刷卡窗体
	/// </summary>
	public partial class SwipeForm : Form
	{
		/// <summary>
		/// 允许字符间最大输入间隔（毫秒），默认为100
		/// </summary>
		public int Interval { get; set; } = 100;

		/// <summary>
		/// 卡号最小位数，默认为4
		/// </summary>
		public int MinLength { get; set; } = 4;

		/// <summary>
		/// 用户刷出的卡号
		/// </summary>
		public string Value { get; private set; } = "";

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SwipeForm()
		{
			InitializeComponent();
			Text = Localization.Get("Swipe Your Card");
		}

		private void SwipeForm_Load(object sender, EventArgs e)
		{
			Value = "";
		}

		private void SwipeForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			timer1.Enabled = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Value = "";
		}

		private void SwipeForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			timer1.Enabled = false;

			switch ((int)e.KeyChar)
			{
				case 27: // ESC
					DialogResult = DialogResult.Cancel;
					break;

				case 13: // Return					
					if (Value.Length > 0 && Value.Length >= MinLength)
					{
						DialogResult = DialogResult.OK;
					}
					break;

				default:
					Value += e.KeyChar;
					timer1.Interval = Interval;
					timer1.Enabled = true;
					break;
			}			
		}		
	}
}
