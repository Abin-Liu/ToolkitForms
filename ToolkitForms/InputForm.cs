using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// 校验InputForm的用户输入值
	/// </summary>
	/// <param name="text">用户输入的文字</param>
	/// <returns>校验通过返回true，否则返回false</returns>
	public delegate bool InputFormValidateDelegate(string text);

	/// <summary>
	/// 输入对话框
	/// </summary>
	public partial class InputForm : Form
	{
		/// <summary>
		/// 初始值/用户输入值
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// 是否自动去除两端空格，默认为true
		/// </summary>
		public bool AutoTrim { get; set; } = true;

		/// <summary>
		/// 用以校验输入值的正则，优先于Validator被执行
		/// </summary>
		public string Regex { get; set; }

		/// <summary>
		/// 自定义校验委托，后于Regex被执行
		/// </summary>
		public InputFormValidateDelegate Validator { get; set; }

		/// <summary>
		/// 窗体标题，默认为已本地化的"Input"
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 窗体提示，默认为已本地化的"Please type a value"
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public InputForm()
		{
			InitializeComponent();
		}

		private void InputForm_Load(object sender, EventArgs e)
		{
			Text = Title ?? Localization.Get("Input");
			lblPrompt.Text = Message ?? Localization.Get("Please type a value");
			btnOK.Text = Localization.Get("OK");
			btnCancel.Text = Localization.Get("Cancel");

			if (!string.IsNullOrEmpty(Value))
			{
				txtValue.Text = Value;
			}
		}

		// 点击OK按钮
		private void btnOK_Click(object sender, EventArgs e)
		{
			string text = txtValue.Text;
			if (AutoTrim)
			{
				text = text.Trim(); // 去除两端空格
			}

			if (text == "")
			{
				txtValue.Focus();
				txtValue.SelectAll();
				return;
			}

			if (!string.IsNullOrEmpty(Regex))
			{
				bool pass = false;
				Regex reg = new Regex(Regex);
				try
				{
					Match match = reg.Match(text);
					pass = match.Success;					
				}
				catch
				{
				}

				if (!pass)
				{
					txtValue.Focus();
					txtValue.SelectAll();
					return;
				}
			}

			// 自定义校验
			if (Validator != null && !Validator(text))
			{
				txtValue.Focus();
				txtValue.SelectAll();
				return;
			}

			Value = text;
			DialogResult = DialogResult.OK;
			Close();
		}

		// 点击Cancel按钮
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}

	/// <summary>
	/// 常用输入校验正则集合
	/// </summary>
	public static class InputFormCommonRules
	{
		/// <summary>
		/// 校验规则：英文字母
		/// </summary>
		public const string Alphabet = @"^[A-Za-z]+$";

		/// <summary>
		/// 校验规则：数字0-9
		/// </summary>
		public const string Digits = @"^[0-9]*$";

		/// <summary>
		/// 校验规则：英文字母和数字
		/// </summary>
		public const string AlphabetDigits = @"^[A-Za-z0-9]+$";

		/// <summary>
		/// 校验规则：整数
		/// </summary>
		public const string Int = @"^(\-)?[0-9]*$";

		/// <summary>
		/// 校验规则：非负整数
		/// </summary>
		public const string UInt = Digits;

		/// <summary>
		/// 校验规则：浮点数
		/// </summary>
		public const string Float = @"^(-?\d+)(\.\d+)?$";

		/// <summary>
		/// 校验规则：非负浮点数
		/// </summary>
		public const string UFloat = @"^((-\d+(\.\d+)?)|(0+(\.0+)?))$";		

		/// <summary>
		/// 校验规则：Email地址
		/// </summary>
		public const string Email = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

		/// <summary>
		/// 校验规则：IP地址
		/// </summary>
		public const string IP = @"\d+\.\d+\.\d+\.\d+";
	}
}
