using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToolkitForms
{
	static partial class Localization
	{
		// 简体中文
		static readonly Dictionary<string, string> ChineseSimplified = new Dictionary<string, string>() {
			// 通用
			{ "OK", "确定" },
			{ "Cancel", "取消" },

			// InputForm
			{ "Input", "输入" },
			{ "Please type a value", "请输入一个数值" },

			// LoginForm
			{ "User Login", "用户登录" },
			{ "User Name", "用户名" },
			{ "Password", "密码" },
			{ "Login", "登录" },
			{ "Login Failed", "登录失败" },

			// SelectForm
			{ "Select", "选择" },
			{ "Please select an option", "请选取一个选项" },

			// TaskForm
			{ "Please Wait", "请稍候" },
			{ "Processing data...", "正在处理数据..." },
			{ "Abort", "中止" },
			{ "Abort Task", "中止任务" },
			{ "Process is not completed yet, abort anyway?", "任务尚未完成，确定要取消吗？" },
			{ "Task aborted by user.", "用户中止了任务。" },
			{ "Task timed out.", "任务已超时。" },			

			// SwipeForm
			{ "Swipe Your Card", "请刷卡"},

			// ShutdownFrom
			{ "Auto Shutdown", "自动关机" },
			{ "System will shutdown in:", "距离系统关机还剩：" },
			{ "Shutdown", "立即关机" },
		};
	}
}
