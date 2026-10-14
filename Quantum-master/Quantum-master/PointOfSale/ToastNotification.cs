using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000205 RID: 517
	[DesignerGenerated]
	public partial class ToastNotification : Form
	{
		// Token: 0x06005C99 RID: 23705
		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06005C9A RID: 23706 RVA: 0x00352378 File Offset: 0x00350578
		public ToastNotification(string message, int durationMillis = 3000, string msgHeader = "General Notice")
		{
			this.duration = 3000;
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.StartPosition = FormStartPosition.Manual;
			this.BackColor = Color.Black;
			this.ForeColor = Color.White;
			base.Size = new Size(300, 50);
			base.TopMost = true;
			this.duration = durationMillis;
			base.Region = Region.FromHrgn(ToastNotification.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
			this.DoubleBuffered = true;
			this.Text = msgHeader;
			Label label = new Label
			{
				Text = message,
				Dock = DockStyle.Fill,
				TextAlign = ContentAlignment.MiddleCenter,
				Font = new Font("Segoe UI", 10f, FontStyle.Regular),
				ForeColor = Color.White,
				BackColor = Color.Black
			};
			base.Controls.Add(label);
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			base.Location = new Point(checked(workingArea.Right - base.Width - 10), workingArea.Bottom);
			this.toastTimer = new Timer
			{
				Interval = 10
			};
			this.toastTimer.Tick += this.SlideIn;
			this.toastTimer.Start();
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x003524E4 File Offset: 0x003506E4
		private void SlideIn(object sender, EventArgs e)
		{
			checked
			{
				bool flag = base.Top > Screen.PrimaryScreen.WorkingArea.Bottom - base.Height - 10;
				if (flag)
				{
					base.Top -= 5;
				}
				else
				{
					this.toastTimer.Stop();
					Timer closeTimer = new Timer
					{
						Interval = this.duration
					};
					closeTimer.Tick += delegate(object a0, EventArgs a1)
					{
						base._Lambda$__0();
					};
					closeTimer.Start();
				}
			}
		}

		// Token: 0x04002880 RID: 10368
		private Timer toastTimer;

		// Token: 0x04002881 RID: 10369
		private int duration;
	}
}
