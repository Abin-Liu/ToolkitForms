using System;
using System.Windows.Forms;
using System.Threading;
using UIToolkits;

namespace ToolkitForms
{
	/// <summary>
	/// 任务线程窗体
	/// </summary>
	public partial class TaskForm : Form
	{	
		/// <summary>
		/// 任务运行结果
		/// </summary>
		public enum TaskResults
		{
			/// <summary>
			/// 任务尚未开始
			/// </summary>
			None = 0,

			/// <summary>
			/// 任务运行中
			/// </summary>
			Running,

			/// <summary>
			/// 任务成功结束
			/// </summary>
			Success,

			/// <summary>
			/// 用户取消了任务
			/// </summary>
			Aborted,

			/// <summary>
			/// 任务因超时而被迫终止
			/// </summary>
			TimedOut,

			/// <summary>
			/// 任务因出现异常而终止
			/// </summary>
			Error
		}

		/// <summary>
		/// 获取当前进度值的回调
		/// </summary>
		/// <returns>当前进度值</returns>
		public delegate int ProgressValueDelegate();

		/// <summary>
		/// 线程工作函数（无参），如果非null则优先运行
		/// </summary>
		public ThreadStart TaskProc { get; set; }

		/// <summary>
		/// 线程工作函数（带参），只有当TaskProc为null时才会运行
		/// </summary>
		public ParameterizedThreadStart ParameterTaskProc { get; set; }

		/// <summary>
		/// ParameterThreadProc的参数
		/// </summary>
		public object Parameter { get; set; }		

		/// <summary>
		/// 提示文字，默认为已本地化的"Processing data..."
		/// </summary>
		public string Message
		{
			get
			{
				return m_messageText;
			}

			set
			{
				if (m_messageText != value)
				{
					m_messageText = value;
					BeginInvoke(new Action(() => { 
						lblPrompt.Text = m_messageText;
					}));
				}
			}
		}

		/// <summary>
		/// 进度条文字，默认为"{Value}/{Max} ({Percent})" => 32/100 (32%)
		/// </summary>
		public string ProgressFormat { get; set; } = "{value}/{max} ({percent})";

		/// <summary>
		/// 进度条上限值，如果为0则不显示进度条
		/// </summary>
		public int ProgressMax { get; set; }

		/// <summary>
		/// 获取当前进度值的委托，如果为null则不显示进度条
		/// </summary>
		public ProgressValueDelegate ProgressValue { get; set; }

		/// <summary>
		/// 是否允许用户中止任务，为true则显示Abort按钮，默认为false
		/// </summary>
		public bool AllowAbort { get; set; }

		/// <summary>
		/// 限制任务最大运行时间（毫秒），超过则强制中止，0表示无限制，默认为0
		/// </summary>
		public int TimeLimit { get; set; }

		/// <summary>
		/// 任务运行结果
		/// </summary>
		public TaskResults TaskResult { get; private set; } = TaskResults.None;		

		/// <summary>
		/// 线程运行中发生的错误信息
		/// </summary>
		public string Error { get; protected set; }		

		private Thread m_thread = null; // 线程
		private DateTime m_startTime;
		private bool m_timedout = false;
		private bool m_hasProgress = false;
		private string m_messageText = Localization.Get("Processing data...");

		/// <summary>
		///默认 构造函数
		/// </summary>
		public TaskForm()
		{
			InitializeComponent();
			Text = Localization.Get("Please Wait");
		}

		private void TaskForm_Load(object sender, EventArgs e)
		{			
			lblPrompt.Text = m_messageText;
			btnAbort.Text = " " + Localization.Get("Abort");

			ControlBox = AllowAbort;
			btnAbort.Visible = AllowAbort;

			m_hasProgress = ProgressMax > 0 && ProgressValue != null;
			progressBar1.Visible = m_hasProgress;
			lblProgress.Visible = m_hasProgress;

			int height = Height;
			if (!AllowAbort)
			{
				height -= btnAbort.Height;
			}

			if (!m_hasProgress)
			{
				height -= progressBar1.Height;
				height -= lblProgress.Height;
			}

			if (height != Height)
			{
				Height = height;
			}

			if (m_hasProgress)
			{
				progressBar1.Minimum = 0;
				progressBar1.Maximum = ProgressMax;
				progressBar1.Value = 0;
			}

			TaskResult = TaskResults.None;
			m_timedout = false;
			Error = null;			

			m_thread = new Thread(ProcessTask);
			m_thread.IsBackground = true;
			m_thread.Start();

			m_startTime = DateTime.Now;
			timer1.Enabled = true;
		}		

		// 内部处理函数
		private void ProcessTask()
		{
			TaskResult = TaskResults.Running;

			try
			{
				if (TaskProc != null)
				{
					TaskProc();
				}
				else
				{
					ParameterTaskProc?.Invoke(Parameter);
				}

				TaskResult = TaskResults.Success;
			}
			catch (ThreadAbortException)
			{
				if (m_timedout)
				{
					TaskResult = TaskResults.TimedOut;
					Error = Localization.Get("Task timed out.");
				}
				else
				{
					TaskResult = TaskResults.Aborted;
					Error = Localization.Get("Task aborted by user.");
				}				
			}
			catch (Exception e)
			{
				TaskResult = TaskResults.Error;
				Error = e.Message;
			}
		}

		// 循环检查线程是否结束
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (m_thread.IsAlive)
			{
				UpdateProgressBar();

				if (!m_timedout && TimeLimit > 0 && (DateTime.Now - m_startTime).TotalMilliseconds > TimeLimit)
				{
					// 运行超时，强制中止
					m_timedout = true;
					m_thread.Abort();
				}
			}
			else
			{
				timer1.Enabled = false;
				if (TaskResult == TaskResults.Success)
				{
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.Cancel;
				}
			}
		}

		private static readonly string m_popupTitle = Localization.Get("Abort Task");
		private static readonly string m_popupMessage = Localization.Get("Process is not completed yet, abort anyway?");
		private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!m_thread.IsAlive)
			{
				return;
			}

			// 线程运行中，显示中止任务确认框
			bool confirmed = Messagex.Confirm(this, m_popupMessage, m_popupTitle);

			// 任务在确认期间自然结束了
			if (!m_thread.IsAlive)
			{
				return;
			}

			if (confirmed)
			{
				// 确认中止
				m_thread.Abort();
			}
			else
			{
				// 用户不希望中止
				e.Cancel = true;
			}
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			Close();
		}
		
		private void UpdateProgressBar()
		{
			if (!m_hasProgress)
			{
				return;
			}

			int value = ProgressValue();
			if (value < 0)
			{
				value = 0;
			}

			if (value > ProgressMax)
			{
				value = ProgressMax;
			}

			progressBar1.Value = value;

			// {value}/{max} ({percent})
			string text = ProgressFormat;
			text = text.Replace("{value}", value.ToString());
			text = text.Replace("{max}", ProgressMax.ToString());
			text = text.Replace("{percent}", string.Format("{0:P0}", (double)value / ProgressMax));

			if (text.Contains("{vps}"))
			{
				double seconds = (DateTime.Now - m_startTime).TotalSeconds;
				int vps = (int)(seconds > 0.1 ? (double)value / seconds : 0.0);
				text = text.Replace("{vps}", vps.ToString());
			}

			if (text != lblProgress.Text)
			{
				lblProgress.Text = text;
			}
		}		
	}
}
