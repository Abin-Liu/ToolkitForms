﻿using System;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

// Depreciated API: AppDomain.GetCurrentThreadId()
#pragma warning disable 0618

/// <summary>
/// 解决MessageBox无法居中显示于父窗体的缺陷
/// </summary>
public class MessageForm
{
	#region 公开方法
	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text)
	{
		Initialize();
		return MessageBox.Show(text);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text, string caption)
	{
		Initialize();
		return MessageBox.Show(text, caption);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
	{
		Initialize();
		return MessageBox.Show(text, caption, buttons);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		Initialize();
		return MessageBox.Show(text, caption, buttons, icon);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <param name="defButton">默认按钮</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton)
	{
		Initialize();
		return MessageBox.Show(text, caption, buttons, icon, defButton);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <param name="defButton">默认按钮</param>
	/// <param name="options">显示选项</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton, MessageBoxOptions options)
	{
		Initialize();
		return MessageBox.Show(text, caption, buttons, icon, defButton, options);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text, string caption)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text, caption);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text, caption, buttons);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text, caption, buttons, icon);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <param name="defButton">默认按钮</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text, caption, buttons, icon, defButton);
	}

	/// <summary>
	/// 显示消息框
	/// </summary>
	/// <param name="owner">要居中显示于的父窗体</param>
	/// <param name="text">消息文字</param>
	/// <param name="caption">窗体标题</param>
	/// <param name="buttons">按钮组合</param>
	/// <param name="icon">主题图标</param>
	/// <param name="defButton">默认按钮</param>
	/// <param name="options">显示选项</param>
	/// <returns>用户选择结果</returns>
	public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defButton, MessageBoxOptions options)
	{
		_owner = owner;
		Initialize();
		return MessageBox.Show(owner, text, caption, buttons, icon,
							   defButton, options);
	}
	#endregion

	#region 私有成员与方法
	private static IWin32Window _owner = null;
	private static HookProc _hookProc = new HookProc(MessageBoxHookProc);
	private static IntPtr _hHook = IntPtr.Zero;
	delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
	delegate void TimerProc(IntPtr hWnd, uint uMsg, UIntPtr nIDEvent, uint dwTime);
	const int WH_CALLWNDPROCRET = 12;

	enum CbtHookAction : int
	{
		HCBT_MOVESIZE = 0,
		HCBT_MINMAX = 1,
		HCBT_QS = 2,
		HCBT_CREATEWND = 3,
		HCBT_DESTROYWND = 4,
		HCBT_ACTIVATE = 5,
		HCBT_CLICKSKIPPED = 6,
		HCBT_KEYSKIPPED = 7,
		HCBT_SYSCOMMAND = 8,
		HCBT_SETFOCUS = 9
	}

	[DllImport("user32.dll")]
	static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect);

	[DllImport("user32.dll")]
	static extern int MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

	[DllImport("User32.dll")]
	static extern UIntPtr SetTimer(IntPtr hWnd, UIntPtr nIDEvent, uint uElapse, TimerProc lpTimerFunc);

	[DllImport("User32.dll")]
	static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

	[DllImport("user32.dll")]
	static extern int UnhookWindowsHookEx(IntPtr idHook);

	[DllImport("user32.dll")]
	static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	static extern int GetWindowTextLength(IntPtr hWnd);

	[DllImport("user32.dll")]
	static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int maxLength);

	[DllImport("user32.dll")]
	static extern int EndDialog(IntPtr hDlg, IntPtr nResult);

	[StructLayout(LayoutKind.Sequential)]
	struct CWPRETSTRUCT
	{
		public IntPtr lResult;
		public IntPtr lParam;
		public IntPtr wParam;
		public uint message;
		public IntPtr hwnd;
	};	

	private static void Initialize()
	{
		if (_hHook != IntPtr.Zero)
		{
			throw new NotSupportedException("multiple calls are not supported");
		}

		if (_owner != null)
		{
			_hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, _hookProc, IntPtr.Zero, AppDomain.GetCurrentThreadId());
		}
	}

	private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		if (nCode < 0)
		{
			return CallNextHookEx(_hHook, nCode, wParam, lParam);
		}

		CWPRETSTRUCT msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
		IntPtr hook = _hHook;

		if (msg.message == (int)CbtHookAction.HCBT_ACTIVATE)
		{
			try
			{
				CenterWindow(msg.hwnd);
			}
			finally
			{
				UnhookWindowsHookEx(_hHook);
				_hHook = IntPtr.Zero;
			}
		}

		return CallNextHookEx(hook, nCode, wParam, lParam);
	}

	private static void CenterWindow(IntPtr hChildWnd)
	{
		Rectangle recChild = new Rectangle(0, 0, 0, 0);
		bool success = GetWindowRect(hChildWnd, ref recChild);

		int width = recChild.Width - recChild.X;
		int height = recChild.Height - recChild.Y;

		Rectangle recParent = new Rectangle(0, 0, 0, 0);
		success = GetWindowRect(_owner.Handle, ref recParent);

		Point ptCenter = new Point(0, 0);
		ptCenter.X = recParent.X + ((recParent.Width - recParent.X) / 2);
		ptCenter.Y = recParent.Y + ((recParent.Height - recParent.Y) / 2);

		Point ptStart = new Point(0, 0);
		ptStart.X = (ptCenter.X - (width / 2));
		ptStart.Y = (ptCenter.Y - (height / 2));

		ptStart.X = (ptStart.X < 0) ? 0 : ptStart.X;
		ptStart.Y = (ptStart.Y < 0) ? 0 : ptStart.Y;

		int result = MoveWindow(hChildWnd, ptStart.X, ptStart.Y, width, height, false);
	}
	#endregion
}