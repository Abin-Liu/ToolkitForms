using System;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// 选择输入框
	/// </summary>
	public partial class SelectForm : Form
	{
		/// <summary>
		/// 字符串选项列表
		/// </summary>
		public string[] TextArray { get; set; }

		/// <summary>
		/// 结构选项列表，仅当TextArray为null时才起作用
		/// </summary>
		public SelectFormItem[] ObjectArray { get; set; }

		/// <summary>
		/// 初始选中项/用户选中项的index，默认为-1
		/// </summary>
		public int SelectedIndex { get; set; } = -1;

		/// <summary>
		/// 初始选中项/用户选中项的Value，默认为null
		/// </summary>
		public object SelectedValue { get; set; }

		/// <summary>
		/// 窗体标题，默认为"Input"
		/// </summary>
		public string Title { get; set; } = "Select";

		/// <summary>
		/// 窗体提示，默认为"Please type a value:"
		/// </summary>
		public string Message { get; set; } = "Please select an option:";

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SelectForm()
		{
			InitializeComponent();
		}

		private void SelectForm_Load(object sender, EventArgs e)
		{
			Text = Title;
			lblPrompt.Text = Message;

			if (TextArray != null)
			{
				comboBox1.DataSource = TextArray;
				if (SelectedIndex < 0 && SelectedValue != null)
				{
					SelectedIndex = Array.IndexOf(TextArray, SelectedValue);
				}
			}
			else if (ObjectArray != null)
			{
				comboBox1.DisplayMember = "Label";
				comboBox1.ValueMember = "Value";
				comboBox1.DataSource = ObjectArray;
				comboBox1.SelectedValue = SelectedValue;
			}

			if (SelectedIndex > -1)
			{
				comboBox1.SelectedIndex = SelectedIndex;
			}						
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SelectedIndex = comboBox1.SelectedIndex;
			SelectedValue = comboBox1.SelectedValue;
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}

	/// <summary>
	/// 选择项
	/// </summary>
	public class SelectFormItem
	{
		/// <summary>
		/// 选项值
		/// </summary>
		public object Value { get; set; }

		/// <summary>
		/// 选项文本
		/// </summary>
		public string Label { get; set; }
	}

}
