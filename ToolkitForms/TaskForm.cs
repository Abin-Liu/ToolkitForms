using System;
using System.Windows.Forms;
using System.Threading;

namespace ToolkitForms
{
	/// <summary>
	/// 任务线程窗体
	/// </summary>
	public partial class TaskForm : Form
	{
		/// <summary>
		/// 线程工作函数（无参），如果非null则优先运行
		/// </summary>
		public ThreadStart ThreadProc { get; set; }

		/// <summary>
		/// 线程工作函数（带参），只有当ThreadProc为null时才会运行
		/// </summary>
		public ParameterizedThreadStart ParameterThreadProc { get; set; }

		/// <summary>
		/// ParameterThreadProc的参数
		/// </summary>
		public object Parameter { get; set; }

		/// <summary>
		/// 窗体标题，默认为已本地化的"Please Wait"
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 窗体文字，默认为已本地化的"Processing data..."
		/// </summary>
		public string Message { get; set; }	

		/// <summary>
		/// 线程运行中发生的错误信息
		/// </summary>
		public string Error { get; protected set; }

		/// <summary>
		/// 线程是否仍在运行中
		/// </summary>
		private bool IsAlive { get { return m_thread == null ? false : m_thread.IsAlive; } }
		private Thread m_thread = null; // 线程
		private System.Threading.Timer m_timer = null; // 定期检查线程是否已结束


		/// <summary>
		/// 默认构造函数
		/// </summary>
		public TaskForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="abortable">是否允许用户中途取消任务</param>
		public TaskForm(bool abortable)
		{
			InitializeComponent();

			if (!abortable)
			{
				this.SuspendLayout();
				this.ControlBox = abortable;
				this.btnAbort.Visible = abortable;
				this.lblPrompt.Location = new System.Drawing.Point(12, 20);
				this.ResumeLayout(false);
			}
		}

		private void TaskForm_Load(object sender, EventArgs e)
		{
			Text = Title ?? Localization.Get("Please Wait");
			lblPrompt.Text = Message ?? Localization.Get("Processing data...");
			btnAbort.Text = Localization.Get("Abort");

			Error = null;
			m_thread = new Thread(ProcessTask);
			m_thread.IsBackground = true;
			m_thread.Start();
		}

		// 时钟间隔检查线程是否结束
		private void OnTimerTick(object data)
		{
			if (!m_thread.IsAlive)
			{
				Close();
			}
		}

		// 内部处理函数
		private void ProcessTask()
		{
			bool completed = false;
			m_timer = new System.Threading.Timer(OnTimerTick, null, 100, 100);

			try
			{
				if (ThreadProc != null)
				{
					ThreadProc();
				}
				else
				{
					ParameterThreadProc?.Invoke(Parameter);
				}

				completed = true;
			}
			catch (Exception e)
			{
				Error = e.Message;
			}

			m_timer.Dispose();
			DialogResult = completed ? DialogResult.OK : DialogResult.Cancel;
		}

		private static readonly string m_popupTitle = Localization.Get("Abort Task");
		private static readonly string m_popupMessage = Localization.Get("Process is not completed yet, abort anyway?");
		private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (IsAlive)
			{
				// Display a confirmation if the thread is still alive
				e.Cancel = MessageBox.Show(this, m_popupMessage, m_popupTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

				// User has confirmed to abort
				if (!e.Cancel)
				{
					m_thread.Abort();
				}
			}
		}

		private void btnAbort_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
