using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToolkitForms
{
	/// <summary>
	/// 快捷键配置类
	/// </summary>
	public class HotkeyData
	{
		/// <summary>
		/// 是否包含组合键Ctrl
		/// </summary>
		public bool Ctrl { get; set; }		

		/// <summary>
		/// 是否包含组合键Shift
		/// </summary>
		public bool Shift { get; set; }

		/// <summary>
		/// 是否包含组合键Alt
		/// </summary>
		public bool Alt { get; set; }

		/// <summary>
		/// 组合键
		/// </summary>
		public int Modifiers
		{
			get
			{
				int value = 0;
				if (Ctrl)
				{
					value |= (int)Keys.Control;
				}

				if (Shift)
				{
					value |= (int)Keys.Shift;
				}

				if (Alt)
				{
					value |= (int)Keys.Alt;
				}
				return value;
			}

			set
			{
				Ctrl = (value & (int)Keys.Control) == (int)Keys.Control;
				Shift = (value & (int)Keys.Shift) == (int)Keys.Shift;
				Alt = (value & (int)Keys.Alt) == (int)Keys.Alt;
			}
		}

		/// <summary>
		/// 键值
		/// </summary>
		public Keys Key { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public HotkeyData()
		{
			Key = Keys.None;
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="key">键值</param>
		public HotkeyData(Keys key)
		{
			Key = key;
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="key">键值</param>
		/// <param name="modifiers">组合键</param>
		public HotkeyData(Keys key, int modifiers)
		{
			Key = key;
			Modifiers = modifiers;
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="key">键值</param>
		/// <param name="ctrl">是否包含组合键Ctrl</param>
		/// <param name="shift">是否包含组合键Shift</param>
		/// <param name="alt">是否包含组合键Alt</param>
		public HotkeyData(Keys key, bool ctrl, bool shift, bool alt)
		{
			Key = key;
			Ctrl = ctrl;
			Shift = shift;
			Alt = alt;
		}

		/// <summary>
		/// 转化为字符串形式
		/// </summary>
		/// <returns>字符串形式</returns>
		public override string ToString()
		{			
			List<string> mods = new List<string>();
			if (Ctrl)
			{
				mods.Add("Ctrl");
			}

			if (Shift)
			{
				mods.Add("Shift");
			}

			if (Alt)
			{
				mods.Add("Alt");
			}

			string value = GetKeyName(Key);
			if (mods.Count == 0)
			{
				return value;
			}

			return string.Join("+", mods) + "+" + value;
		}		

		/// <summary>
		/// 判断两个HotkeyData是否相同
		/// </summary>
		/// <param name="obj">判断对象</param>
		/// <returns>判断结果</returns>
		public override bool Equals(object obj)
		{
			HotkeyData rhs = obj as HotkeyData;
			if (rhs == null)
			{
				return false;
			}

			return Modifiers == rhs.Modifiers && Key == rhs.Key;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			int value = (int)Key << 16;
			if (Ctrl)
			{
				value |= 0x01;
			}

			if (Shift)
			{
				value |= 0x02;
			}

			if (Alt)
			{
				value |= 0x04;
			}

			return value;
		}

		/// <summary>
		/// 从另一个对象复制数据
		/// </summary>
		/// <param name="rhs">数据源对象</param>
		public void Copy(HotkeyData rhs)
		{
			if (this != rhs)
			{
				Modifiers = rhs.Modifiers;
				Key = rhs.Key;
			}			
		}

		/// <summary>
		/// 获取按键名称，避免类似于OemSemicolon被转化为Oem1这种默认行为
		/// </summary>
		/// <param name="key">按键</param>
		/// <returns>按键名称</returns>
		public static string GetKeyName(Keys key)
		{
			string name;
			if (m_keyMap.TryGetValue(key, out name))
			{
				return name;
			}

			return key.ToString();
		}

		/// <summary>
		/// 获取所有可作为快捷键的按键列表
		/// </summary>
		/// <returns>可作为快捷键的按键列表</returns>
		public static Keys[] GetAvailableKeys()
		{
			return m_availableKeys.ToArray();
		}

		static readonly Dictionary<Keys, string> m_keyMap = new Dictionary<Keys, string>();
		static readonly List<Keys> m_availableKeys = new List<Keys>();

		static HotkeyData()
		{
			m_keyMap.Add(Keys.Oemtilde, "OemTilde");
			m_keyMap.Add(Keys.OemOpenBrackets, "OemOpenBrackets");
			m_keyMap.Add(Keys.OemCloseBrackets, "OemCloseBrackets");
			m_keyMap.Add(Keys.OemPipe, "OemPipe");
			m_keyMap.Add(Keys.OemSemicolon, "OemSemicolon");
			m_keyMap.Add(Keys.OemQuotes, "OemQuotes");
			m_keyMap.Add(Keys.PageDown, "PageDown");

			m_availableKeys.Add(Keys.None);

			for (Keys key = Keys.D0; key <= Keys.D9; key++)
			{
				m_availableKeys.Add(key);
			}

			for (Keys key = Keys.A; key <= Keys.Z; key++)
			{
				m_availableKeys.Add(key);
			}

			for (Keys key = Keys.F1; key <= Keys.F12; key++)
			{
				m_availableKeys.Add(key);
			}

			for (Keys key = Keys.NumPad0; key <= Keys.NumPad9; key++)
			{
				m_availableKeys.Add(key);
			}

			m_availableKeys.Add(Keys.NumLock);
			m_availableKeys.Add(Keys.Add);
			m_availableKeys.Add(Keys.Subtract);
			m_availableKeys.Add(Keys.Multiply);
			m_availableKeys.Add(Keys.Divide);
			m_availableKeys.Add(Keys.Decimal);

			m_availableKeys.Add(Keys.Oemtilde); // `
			m_availableKeys.Add(Keys.OemMinus); // -
			m_availableKeys.Add(Keys.Oemplus); // +			
			m_availableKeys.Add(Keys.OemOpenBrackets); // {
			m_availableKeys.Add(Keys.OemCloseBrackets); // }
			m_availableKeys.Add(Keys.OemPipe); // |			
			m_availableKeys.Add(Keys.OemSemicolon); // ;
			m_availableKeys.Add(Keys.OemQuotes); // '
			m_availableKeys.Add(Keys.Oemcomma); // ,
			m_availableKeys.Add(Keys.OemPeriod); // .
			m_availableKeys.Add(Keys.OemQuestion); // /

			m_availableKeys.Add(Keys.Tab);
			m_availableKeys.Add(Keys.CapsLock);
			m_availableKeys.Add(Keys.Space);

			m_availableKeys.Add(Keys.Scroll);
			m_availableKeys.Add(Keys.Pause);
			m_availableKeys.Add(Keys.Insert);
			m_availableKeys.Add(Keys.Delete);
			m_availableKeys.Add(Keys.Home);
			m_availableKeys.Add(Keys.End);
			m_availableKeys.Add(Keys.PageUp);
			m_availableKeys.Add(Keys.PageDown);

			m_availableKeys.Add(Keys.Left);
			m_availableKeys.Add(Keys.Up);
			m_availableKeys.Add(Keys.Right);
			m_availableKeys.Add(Keys.Down);
		}
	}
}
