using System;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000025 RID: 37
	public class clsScale
	{
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x000481AC File Offset: 0x000463AC
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x000481B8 File Offset: 0x000463B8
		public virtual SerialPort comPort
		{
			[CompilerGenerated]
			get
			{
				return this._comPort;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SerialDataReceivedEventHandler serialDataReceivedEventHandler = new SerialDataReceivedEventHandler(this.comPort_DataReceived);
				SerialPort serialPort = this._comPort;
				if (serialPort != null)
				{
					serialPort.DataReceived -= serialDataReceivedEventHandler;
				}
				this._comPort = value;
				serialPort = this._comPort;
				if (serialPort != null)
				{
					serialPort.DataReceived += serialDataReceivedEventHandler;
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000481FC File Offset: 0x000463FC
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00048214 File Offset: 0x00046414
		public string BaudRate
		{
			get
			{
				return this.strBaudRate;
			}
			set
			{
				this.strBaudRate = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00048220 File Offset: 0x00046420
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00048238 File Offset: 0x00046438
		public string Parity
		{
			get
			{
				return this.strParity;
			}
			set
			{
				this.strParity = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00048244 File Offset: 0x00046444
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x0004825C File Offset: 0x0004645C
		public string StopBits
		{
			get
			{
				return this.strStopBits;
			}
			set
			{
				this.strStopBits = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00048268 File Offset: 0x00046468
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00048280 File Offset: 0x00046480
		public string DataBits
		{
			get
			{
				return this.strDataBits;
			}
			set
			{
				this.strDataBits = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x0004828C File Offset: 0x0004648C
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x000482A4 File Offset: 0x000464A4
		public string PortName
		{
			get
			{
				return this.strPortName;
			}
			set
			{
				this.strPortName = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x000482B0 File Offset: 0x000464B0
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x000482C8 File Offset: 0x000464C8
		public clsScale.MessageFormat Format
		{
			get
			{
				return this.mfMessageFormat;
			}
			set
			{
				this.mfMessageFormat = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x000482D4 File Offset: 0x000464D4
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x000482EC File Offset: 0x000464EC
		public TextBox TextWindow
		{
			get
			{
				return this.tbTextBoxDisplay;
			}
			set
			{
				this.tbTextBoxDisplay = value;
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000482F8 File Offset: 0x000464F8
		public clsScale()
		{
			this.strBaudRate = "";
			this.strParity = "";
			this.strStopBits = "";
			this.strDataBits = "";
			this.strPortName = "";
			this.comPort = new SerialPort();
			this.pf = new PublicFunctions();
			this.display_count = 0;
			this.lastWeight = "";
			this._sync = SynchronizationContext.Current;
			this.strBaudRate = "";
			this.strParity = "";
			this.strStopBits = "";
			this.strDataBits = "";
			this.strPortName = "";
			this.tbTextBoxDisplay = null;
			this.comPort.DtrEnable = true;
			this.comPort.ReadTimeout = 100;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000483D4 File Offset: 0x000465D4
		public bool OpenPort(int scaletype)
		{
			bool flag;
			try
			{
				bool isOpen = this.comPort.IsOpen;
				if (isOpen)
				{
					this.comPort.Close();
				}
				this.comPort.BaudRate = int.Parse(this.strBaudRate);
				this.comPort.DataBits = int.Parse(this.strDataBits);
				this.comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.strStopBits);
				this.comPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.strParity);
				this.comPort.PortName = this.strPortName;
				this.comPort.ReadTimeout = 100;
				this.comPort.Open();
				this.DisplayData("Port opened at " + Conversions.ToString(DateTime.Now) + "\n", scaletype);
				flag = true;
			}
			catch (Exception ex)
			{
				this.DisplayData("Err: " + ex.Message, scaletype);
				flag = false;
			}
			return flag;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00048508 File Offset: 0x00046708
		public void ClosePort()
		{
			try
			{
				this.comPort.DtrEnable = false;
				this.comPort.DiscardInBuffer();
				Thread.Sleep(100);
				this.comPort.DataReceived -= this.comPort_DataReceived;
				bool isOpen = this.comPort.IsOpen;
				if (isOpen)
				{
					this.comPort.Close();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00048590 File Offset: 0x00046790
		private void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			try
			{
				bool flag = !MyProject.Forms.Form1.receiveSerialPortData;
				if (!flag)
				{
					clsScale.MessageFormat format = this.Format;
					if (format != clsScale.MessageFormat.ASCII)
					{
						if (format != clsScale.MessageFormat.Hexadecimal)
						{
							bool isOpen = this.comPort.IsOpen;
							if (isOpen)
							{
								string text = this.comPort.ReadLine();
								this.DisplayData(text + Convert.ToString("\n"), 2);
							}
						}
						else
						{
							bool isOpen2 = this.comPort.IsOpen;
							if (isOpen2)
							{
								int bytesToRead = this.comPort.BytesToRead;
								byte[] array = new byte[checked(bytesToRead - 1 + 1)];
								this.comPort.Read(array, 0, bytesToRead);
								this.DisplayData(this.ConvertByteToHex(array) + Convert.ToString("\n"), 2);
							}
						}
					}
					else
					{
						bool isOpen3 = this.comPort.IsOpen;
						if (isOpen3)
						{
							string text2 = this.comPort.ReadLine();
							string text3 = text2;
							int scaleType = MyProject.Forms.Form1.scaleType;
							this.DisplayData(text3, MyProject.Forms.Form1.scaleType);
						}
					}
				}
			}
			catch (Exception ex)
			{
				this.DisplayData("Datareceived error: " + ex.Message, 2);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00048714 File Offset: 0x00046914
		private byte[] ConvertHexToByte(string strData)
		{
			strData = strData.Replace(" ", "");
			checked
			{
				byte[] array = new byte[(int)Math.Round(unchecked((double)strData.Length / 2.0 - 1.0)) + 1];
				int num = strData.Length - 1;
				for (int i = 0; i <= num; i += 2)
				{
					array[(int)Math.Round((double)i / 2.0)] = Convert.ToByte(strData.Substring(i, 2), 16);
				}
				return array;
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0004879C File Offset: 0x0004699C
		public string ConvertByteToHex(byte[] btData)
		{
			StringBuilder stringBuilder = new StringBuilder(checked(btData.Length * 3));
			foreach (byte b in btData)
			{
				stringBuilder.Append(Convert.ToString(b, 16).PadLeft(2, '0').PadRight(3, ' '));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00048800 File Offset: 0x00046A00
		[STAThread]
		public void DisplayData(string strData, int scaleType)
		{
			this._sync.Send(delegate(object a0)
			{
				base._Lambda$__0(RuntimeHelpers.GetObjectValue(a0));
			}, null);
		}

		// Token: 0x04000357 RID: 855
		private string strBaudRate;

		// Token: 0x04000358 RID: 856
		private string strParity;

		// Token: 0x04000359 RID: 857
		private string strStopBits;

		// Token: 0x0400035A RID: 858
		private string strDataBits;

		// Token: 0x0400035B RID: 859
		private string strPortName;

		// Token: 0x0400035C RID: 860
		public string strData;

		// Token: 0x0400035D RID: 861
		public string strDisplay;

		// Token: 0x0400035E RID: 862
		private clsScale.MessageFormat mfMessageFormat;

		// Token: 0x04000360 RID: 864
		public TextBox tbTextBoxDisplay;

		// Token: 0x04000361 RID: 865
		public PublicFunctions pf;

		// Token: 0x04000362 RID: 866
		public int display_count;

		// Token: 0x04000363 RID: 867
		private string lastWeight;

		// Token: 0x04000364 RID: 868
		private readonly SynchronizationContext _sync;

		// Token: 0x0200022E RID: 558
		public enum MessageFormat
		{
			// Token: 0x04002B23 RID: 11043
			ASCII,
			// Token: 0x04002B24 RID: 11044
			Hexadecimal
		}
	}
}
