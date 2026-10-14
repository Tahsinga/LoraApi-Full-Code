using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000202 RID: 514
	[DesignerGenerated]
	public partial class TestConnectedScale : Form
	{
		// Token: 0x06005C39 RID: 23609 RVA: 0x0034FE08 File Offset: 0x0034E008
		public TestConnectedScale()
		{
			base.Load += this.TestConnectedScale_Load;
			base.Closing += this.TestConnectedScale_Closing;
			this.sp = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
			this.InitializeComponent();
		}

		// Token: 0x17002145 RID: 8517
		// (get) Token: 0x06005C3C RID: 23612 RVA: 0x0035004D File Offset: 0x0034E24D
		// (set) Token: 0x06005C3D RID: 23613 RVA: 0x00350058 File Offset: 0x0034E258
		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.TextBox1_TextChanged);
				TextBox textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._TextBox1 = value;
				textBox = this._TextBox1;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002146 RID: 8518
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x0035009B File Offset: 0x0034E29B
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x003500A8 File Offset: 0x0034E2A8
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17002147 RID: 8519
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x003500EB File Offset: 0x0034E2EB
		// (set) Token: 0x06005C41 RID: 23617 RVA: 0x003500F5 File Offset: 0x0034E2F5
		internal virtual TextBox TextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002148 RID: 8520
		// (get) Token: 0x06005C42 RID: 23618 RVA: 0x003500FE File Offset: 0x0034E2FE
		// (set) Token: 0x06005C43 RID: 23619 RVA: 0x00350108 File Offset: 0x0034E308
		internal virtual Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this._Timer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
				Timer timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer2 = value;
				timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x0035014C File Offset: 0x0034E34C
		private void TestConnectedScale_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.sp.IsOpen;
				if (flag)
				{
					this.sp.Open();
				}
				this.Timer1.Start();
				this.Timer2.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error detail: " + ex.Message);
			}
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x003501CC File Offset: 0x0034E3CC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.GetSerialData();
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x003501D8 File Offset: 0x0034E3D8
		private void GetSerialData()
		{
			string text = this.sp.ReadExisting();
			string text2 = text.Substring(0, 5);
			bool flag = Operators.CompareString(text2, "ST,GS", false) == 0;
			if (flag)
			{
				this.TextBox1.Text = text.Substring(7, 7);
			}
			else
			{
				this.TextBox1.Text = text;
			}
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x00350238 File Offset: 0x0034E438
		private void TestConnectedScale_Closing(object sender, CancelEventArgs e)
		{
			try
			{
				bool isOpen = this.sp.IsOpen;
				if (isOpen)
				{
					this.sp.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x00350288 File Offset: 0x0034E488
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x003502BC File Offset: 0x0034E4BC
		private void Verify()
		{
			try
			{
				bool flag = decimal.Compare(Conversions.ToDecimal(this.TextBox1.Text), Conversions.ToDecimal(this.TextBox2.Text)) == 0;
				if (flag)
				{
					this.TextBox2.BackColor = Color.Green;
				}
				else
				{
					this.TextBox2.BackColor = Color.Red;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x00350340 File Offset: 0x0034E540
		private void Timer2_Tick(object sender, EventArgs e)
		{
			this.Verify();
		}

		// Token: 0x0400285F RID: 10335
		private SerialPort sp;
	}
}
