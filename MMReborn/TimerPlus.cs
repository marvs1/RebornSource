using System;
using System.Timers;

namespace MMReborn
{
	// Token: 0x02000007 RID: 7
	public class TimerPlus : Timer
	{
		// Token: 0x06000075 RID: 117 RVA: 0x0000CCBB File Offset: 0x0000AEBB
		public TimerPlus()
		{
			base.Elapsed += this.ElapsedAction;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		protected new void Dispose()
		{
			base.Elapsed -= this.ElapsedAction;
			base.Dispose();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000077 RID: 119 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		public double TimeLeft
		{
			get
			{
				return (this.m_dueTime - DateTime.Now).TotalMilliseconds;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public new void Start()
		{
			this.m_dueTime = DateTime.Now.AddMilliseconds(base.Interval);
			base.Start();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000CD54 File Offset: 0x0000AF54
		private void ElapsedAction(object sender, ElapsedEventArgs e)
		{
			bool autoReset = base.AutoReset;
			if (autoReset)
			{
				this.m_dueTime = DateTime.Now.AddMilliseconds(base.Interval);
			}
		}

		// Token: 0x040000A8 RID: 168
		private DateTime m_dueTime;
	}
}
