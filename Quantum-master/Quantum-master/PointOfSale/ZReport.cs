using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EltradeFPAx;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200021D RID: 541
	[DesignerGenerated]
	public partial class ZReport : Form
	{
		// Token: 0x060061AC RID: 25004 RVA: 0x00379E7C File Offset: 0x0037807C
		public ZReport()
		{
			base.Load += this.ZReport_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x060061AF RID: 25007 RVA: 0x0037A488 File Offset: 0x00378688
		// (set) Token: 0x060061B0 RID: 25008 RVA: 0x0037A492 File Offset: 0x00378692
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x060061B1 RID: 25009 RVA: 0x0037A49B File Offset: 0x0037869B
		// (set) Token: 0x060061B2 RID: 25010 RVA: 0x0037A4A5 File Offset: 0x003786A5
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x060061B3 RID: 25011 RVA: 0x0037A4AE File Offset: 0x003786AE
		// (set) Token: 0x060061B4 RID: 25012 RVA: 0x0037A4B8 File Offset: 0x003786B8
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x0037A4C1 File Offset: 0x003786C1
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x0037A4CB File Offset: 0x003786CB
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x060061B7 RID: 25015 RVA: 0x0037A4D4 File Offset: 0x003786D4
		// (set) Token: 0x060061B8 RID: 25016 RVA: 0x0037A4E0 File Offset: 0x003786E0
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

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x0037A523 File Offset: 0x00378723
		// (set) Token: 0x060061BA RID: 25018 RVA: 0x0037A530 File Offset: 0x00378730
		internal virtual ComboBox cboPaymentMethod
		{
			[CompilerGenerated]
			get
			{
				return this._cboPaymentMethod;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				ComboBox comboBox = this._cboPaymentMethod;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPaymentMethod = value;
				comboBox = this._cboPaymentMethod;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x060061BB RID: 25019 RVA: 0x0037A573 File Offset: 0x00378773
		// (set) Token: 0x060061BC RID: 25020 RVA: 0x0037A57D File Offset: 0x0037877D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x060061BD RID: 25021 RVA: 0x0037A586 File Offset: 0x00378786
		// (set) Token: 0x060061BE RID: 25022 RVA: 0x0037A590 File Offset: 0x00378790
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x0037A59C File Offset: 0x0037879C
		private void ZReport_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.FiscalEltrade == 1;
				if (flag)
				{
					this.cboPaymentMethod.DataSource = this.pf.GetPaymentMethods(this._cnn);
					this.cboPaymentMethod.DisplayMember = "PaymentMethodDesc";
					this.cboPaymentMethod.ValueMember = "PaymentMethodID";
					this.TabControl1.SelectedTab = this.TabPage1;
				}
				else
				{
					bool flag2 = MyProject.Forms.Form1.FiscalRevmax == 1;
					if (flag2)
					{
						this.TabControl1.SelectedTab = this.TabPage2;
					}
				}
				bool flag3 = MyProject.Forms.Form1.PrintFiscal == 0;
				if (flag3)
				{
					MessageBox.Show("Fiscal devices are not set. Closing.");
					base.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Z Report form: " + ex.Message);
			}
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x0037A6A0 File Offset: 0x003788A0
		private void GetEtradePortSettings(int paymentmethodid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "getEltradePortSettings";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			MyProject.Forms.Form1.FiscalcomPortNum = Conversions.ToInteger(dataRow["ComPort"]);
			MyProject.Forms.Form1.FiscalcomPortSpeed = Conversions.ToInteger(dataRow["ComSpeed"]);
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x0037A750 File Offset: 0x00378950
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.GetEtradePortSettings(Conversions.ToInteger(this.cboPaymentMethod.SelectedValue));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x0037A798 File Offset: 0x00378998
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				EltradeFprn eltradeFprn = (EltradeFprn)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("BAD7EC8B-0E5B-4421-936E-F5AE2338BE32")));
				bool flag = eltradeFprn.Init(MyProject.Forms.Form1.FiscalcomPortNum, MyProject.Forms.Form1.FiscalcomPortSpeed, 0, 0, 0, "") == 0;
				if (flag)
				{
					long num = (long)eltradeFprn.RunZReport();
					bool flag2 = num != 0L;
					if (flag2)
					{
						MessageBox.Show(Conversions.ToString(Conversions.ToDouble("Error. ") + (double)num));
					}
					else
					{
						MessageBox.Show("Z Report success.");
					}
				}
				else
				{
					MessageBox.Show("Eltrade Fiscal Init Failed.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error running Z Report. Detail: " + ex.Message);
			}
		}

		// Token: 0x04002B02 RID: 11010
		private PublicFunctions pf;

		// Token: 0x04002B03 RID: 11011
		private string _cnn;
	}
}
