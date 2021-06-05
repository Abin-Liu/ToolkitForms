using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// 快捷键选择窗体
	/// </summary>
	public partial class HotkeyForm : Form
	{
		/// <summary>
		/// 当前数据
		/// </summary>
		public HotkeyData Hotkey { get; set; }		

		private List<KeyEntry> m_keyList = new List<KeyEntry>();

		/// <summary>
		/// 构造函数
		/// </summary>
		public HotkeyForm()
		{
			InitializeComponent();
			Hotkey = new HotkeyData();
		}		

		private void HotkeyForm_Load(object sender, EventArgs e)
		{
			lblModifiers.Text = Localization.Get("Modifiers:");
			lblKey.Text = Localization.Get("Key:");
			btnOK.Text = Localization.Get("OK");
			btnCancel.Text = Localization.Get("Cancel");

			chkCtrl.Checked = Hotkey.Ctrl;
			chkShift.Checked = Hotkey.Shift;
			chkAlt.Checked = Hotkey.Alt;

			Keys[] availableKeys = HotkeyData.GetAvailableKeys();

			foreach (Keys key in availableKeys)
			{
				m_keyList.Add(new KeyEntry(key));
			}

			cmbKey.DataSource = m_keyList;
			cmbKey.DisplayMember = "Name";
			cmbKey.ValueMember = "Key";

			int index = Math.Max(0, Array.IndexOf(availableKeys, Hotkey.Key));			
			cmbKey.SelectedIndex = index;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			int index = Math.Max(0, cmbKey.SelectedIndex);
			HotkeyData data = new HotkeyData(HotkeyData.GetAvailableKeys()[index], chkCtrl.Checked, chkShift.Checked, chkAlt.Checked);
			if (data.Equals(Hotkey))
			{
				DialogResult = DialogResult.Cancel;
			}
			else
			{
				Hotkey.Copy(data);
				DialogResult = DialogResult.OK;
			}			
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
	
	class KeyEntry
	{
		public Keys Key { get; set; }
		public string Name { get; set; }

		public KeyEntry(Keys key)
		{
			Key = key;
			Name = HotkeyData.GetKeyName(Key);
		}
	}
}
