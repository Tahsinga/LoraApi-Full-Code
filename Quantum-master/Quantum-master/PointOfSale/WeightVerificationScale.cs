using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200021C RID: 540
	[DesignerGenerated]
	public partial class WeightVerificationScale : Form
	{
		// Token: 0x0600619E RID: 24990 RVA: 0x00379878 File Offset: 0x00377A78
		public WeightVerificationScale()
		{
			base.Load += this.WeightVerificationScale_Load;
			base.Disposed += this.WeightVerificationScale_Disposed;
			this.sScale = new clsScale();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.MaxDiff = 5m;
			this.InitializeComponent();
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060061A1 RID: 24993 RVA: 0x00379B5E File Offset: 0x00377D5E
		// (set) Token: 0x060061A2 RID: 24994 RVA: 0x00379B68 File Offset: 0x00377D68
		internal virtual TextBox txtQtyWeighed
		{
			[CompilerGenerated]
			get
			{
				return this._txtQtyWeighed;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtQtyWeighed_TextChanged);
				TextBox textBox = this._txtQtyWeighed;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtQtyWeighed = value;
				textBox = this._txtQtyWeighed;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x060061A3 RID: 24995 RVA: 0x00379BAB File Offset: 0x00377DAB
		// (set) Token: 0x060061A4 RID: 24996 RVA: 0x00379BB5 File Offset: 0x00377DB5
		internal virtual Label lblexpectedWeight
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x060061A5 RID: 24997 RVA: 0x00379BBE File Offset: 0x00377DBE
		// (set) Token: 0x060061A6 RID: 24998 RVA: 0x00379BC8 File Offset: 0x00377DC8
		internal virtual TextBox Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x00379BD4 File Offset: 0x00377DD4
		private void WeightVerificationScale_Load(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.VerificationWeightOK = false;
				this.GetScaleSettings();
				this.lblexpectedWeight.Text = this.ExpectedWeight.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00379C4C File Offset: 0x00377E4C
		private void GetScaleSettings()
		{
			this.sScale.BaudRate = Conversions.ToString(9600);
			this.sScale.Parity = Conversions.ToString(0);
			this.sScale.StopBits = Conversions.ToString(1);
			this.sScale.DataBits = Conversions.ToString(8);
			this.sScale.PortName = "COM" + Conversions.ToString(MyProject.Forms.Form1.ConnectedScalePortNum);
			this.sScale.TextWindow = this.txtQtyWeighed;
			bool flag = !this.sScale.comPort.IsOpen;
			if (flag)
			{
				this.sScale.OpenPort(2);
			}
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00379D08 File Offset: 0x00377F08
		private bool IsWieghtOk()
		{
			decimal num = new decimal((Convert.ToDouble(this.ExpectedWeight) - Conversion.Val(this.txtQtyWeighed.Text)) / Convert.ToDouble(this.ExpectedWeight) * 100.0);
			bool flag = decimal.Compare(num, 0m) < 0;
			if (flag)
			{
				num = decimal.Multiply(num, -1m);
			}
			return decimal.Compare(num, this.MaxDiff) <= 0;
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00379D90 File Offset: 0x00377F90
		private void txtQtyWeighed_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.IsWieghtOk();
				if (flag)
				{
					this.sScale.ClosePort();
					MyProject.Forms.Form1.VerificationWeightOK = true;
					base.Dispose();
				}
				else
				{
					MyProject.Forms.Form1.VerificationWeightOK = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00379E04 File Offset: 0x00378004
		private void WeightVerificationScale_Disposed(object sender, EventArgs e)
		{
			try
			{
				bool isOpen = this.sScale.comPort.IsOpen;
				if (isOpen)
				{
					this.sScale.comPort.Close();
				}
				this.sScale.comPort.Dispose();
				base.Dispose();
			}
			catch (Exception ex)
			{
				base.Dispose();
			}
		}

		// Token: 0x04002AF5 RID: 10997
		private clsScale sScale;

		// Token: 0x04002AF6 RID: 10998
		private string _cnn;

		// Token: 0x04002AF7 RID: 10999
		public decimal ExpectedWeight;

		// Token: 0x04002AF8 RID: 11000
		public decimal MaxDiff;
	}
}
