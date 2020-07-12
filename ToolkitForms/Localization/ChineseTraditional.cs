using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolkitForms
{
	static partial class Localization
	{
		// 繁体中文
		static readonly Dictionary<string, string> ChineseTraditional = new Dictionary<string, string>() {
			// 通用
			{ "OK", "確定" },
			{ "Cancel", "取消" },

			// InputForm
			{ "Input", "錄入" },
			{ "Please type a value", "請錄入一個數值" },

			// LoginForm
			{ "User Login", "用戶登錄" },
			{ "User Name", "用戶名" },
			{ "Password", "密碼" },
			{ "Login", "登錄" },

			// SelectForm
			{ "Select", "選擇" },
			{ "Please select an option", "請選取一個選項" },

			// TaskForm
			{ "Please Wait", "請稍候" },
			{ "Processing data...", "正在處理數據..." },
			{ "Abort", "中止" },
			{ "Abort Task", "中止任務" },
			{ "Process is not completed yet, abort anyway?", "任務尚未完成，確定要中止嗎？" },
			{ "Task aborted by user.", "用戶中止了任務。" },
			{ "Task timed out.", "任務已超時。" },
		};
	}
}
