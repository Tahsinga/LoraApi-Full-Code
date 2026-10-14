using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale
{
	// Token: 0x02000201 RID: 513
	[DesignerGenerated]
	public partial class TestComport : Form
	{
		// Token: 0x06005C2C RID: 23596 RVA: 0x0034F8EB File Offset: 0x0034DAEB
		public TestComport()
		{
			this.serialPort = new SerialPort();
			this.lastWeight = "";
			this.InitializeComponent();
		}

		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x06005C2F RID: 23599 RVA: 0x0034FB5E File Offset: 0x0034DD5E
		// (set) Token: 0x06005C30 RID: 23600 RVA: 0x0034FB68 File Offset: 0x0034DD68
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x06005C31 RID: 23601 RVA: 0x0034FB71 File Offset: 0x0034DD71
		// (set) Token: 0x06005C32 RID: 23602 RVA: 0x0034FB7C File Offset: 0x0034DD7C
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002143 RID: 8515
		// (get) Token: 0x06005C33 RID: 23603 RVA: 0x0034FBBF File Offset: 0x0034DDBF
		// (set) Token: 0x06005C34 RID: 23604 RVA: 0x0034FBC9 File Offset: 0x0034DDC9
		internal virtual TextBox TextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002144 RID: 8516
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x0034FBD2 File Offset: 0x0034DDD2
		// (set) Token: 0x06005C36 RID: 23606 RVA: 0x0034FBDC File Offset: 0x0034DDDC
		private virtual SerialPort serialPort
		{
			[CompilerGenerated]
			get
			{
				return this._serialPort;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SerialDataReceivedEventHandler serialDataReceivedEventHandler = new SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
				SerialPort serialPort = this._serialPort;
				if (serialPort != null)
				{
					serialPort.DataReceived -= serialDataReceivedEventHandler;
				}
				this._serialPort = value;
				serialPort = this._serialPort;
				if (serialPort != null)
				{
					serialPort.DataReceived += serialDataReceivedEventHandler;
				}
			}
		}

		// Token: 0x06005C37 RID: 23607 RVA: 0x0034FC20 File Offset: 0x0034DE20
		private void Button1_Click(object sender, EventArgs e)
		{
			SerialPort serialPort = new SerialPort();
			try
			{
				SerialPort serialPort2 = serialPort;
				serialPort2.PortName = this.TextBox2.Text;
				serialPort2.BaudRate = 9600;
				serialPort2.Parity = Parity.None;
				serialPort2.DataBits = 8;
				serialPort2.StopBits = StopBits.One;
				serialPort2.Handshake = Handshake.None;
				serialPort2.ReadTimeout = 5000;
				serialPort.Open();
				for (;;)
				{
					try
					{
						string text = serialPort.ReadLine();
						int num = text.IndexOf("k");
						bool flag = num != -1;
						if (flag)
						{
							int num2 = text.IndexOf("/");
							bool flag2 = num2 == -1;
							if (flag2)
							{
								string text2 = Strings.Trim(text.Substring(0, num));
								this.TextBox1.Text = text2;
								this.lastWeight = text2;
							}
							else
							{
								this.TextBox1.Text = this.lastWeight;
							}
						}
						else
						{
							this.TextBox1.Text = this.lastWeight;
						}
					}
					catch (TimeoutException ex)
					{
					}
				}
			}
			catch (Exception ex2)
			{
				Console.WriteLine("Error: " + ex2.Message);
			}
			finally
			{
				bool isOpen = serialPort.IsOpen;
				if (isOpen)
				{
					serialPort.Close();
				}
			}
		}

		// Token: 0x06005C38 RID: 23608 RVA: 0x0034FDC8 File Offset: 0x0034DFC8
		private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			string incomingData = this.serialPort.ReadExisting();
			base.Invoke(new VB$AnonymousDelegate_0(delegate
			{
				this.TextBox1.Text = incomingData;
			}));
		}

		// Token: 0x04002859 RID: 10329
		private string lastWeight;
	}
}
