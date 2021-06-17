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
		/// 选项列表
		/// </summary>
		public string[] Options { get; set; }		

		/// <summary>
		/// 初始选中项/用户选中项的index，默认为-1
		/// </summary>
		public int SelectedIndex { get; set; } = -1;

		/// <summary>
		/// 用户选择的选项的字符串值
		/// </summary>
		public string SelectedValue => Options != null && Options.Length > SelectedIndex ? Options[SelectedIndex] : null;

		/// <summary>
		/// 窗体提示，默认为已本地化的"Please select an option"
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SelectForm()
		{
			InitializeComponent();
			Text = Localization.Get("Select");
		}

		private void SelectForm_Load(object sender, EventArgs e)
		{			
			lblPrompt.Text = Message ?? Localization.Get("Please select an option");
			btnOK.Text = " " + Localization.Get("OK");
			btnCancel.Text = " " + Localization.Get("Cancel");
			comboBox1.DataSource = Options;

			try
			{
				comboBox1.SelectedIndex = SelectedIndex;
			}
			catch
			{
				SelectedIndex = comboBox1.SelectedIndex;
			}					
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			SelectedIndex = comboBox1.SelectedIndex;
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
