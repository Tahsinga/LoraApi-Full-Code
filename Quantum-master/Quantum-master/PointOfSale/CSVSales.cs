using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000034 RID: 52
	[DesignerGenerated]
	public partial class CSVSales : UserControl
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x00071C28 File Offset: 0x0006FE28
		public CSVSales()
		{
			base.Load += this.CSVSales_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.mono_rate = 1m;
			this.invpaymethrate = 1m;
			this.selectedrowindex = 0;
			this.ProductError = false;
			this.QtyError = false;
			this.InitializeComponent();
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00072E29 File Offset: 0x00071029
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00072E33 File Offset: 0x00071033
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00072E3C File Offset: 0x0007103C
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00072E46 File Offset: 0x00071046
		internal virtual DataGridView dgvSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00072E4F File Offset: 0x0007104F
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00072E5C File Offset: 0x0007105C
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

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00072E9F File Offset: 0x0007109F
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00072EA9 File Offset: 0x000710A9
		internal virtual TextBox txtref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00072EB2 File Offset: 0x000710B2
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00072EBC File Offset: 0x000710BC
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00072EC5 File Offset: 0x000710C5
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00072ECF File Offset: 0x000710CF
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00072ED8 File Offset: 0x000710D8
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x00072EE2 File Offset: 0x000710E2
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00072EEB File Offset: 0x000710EB
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00072EF5 File Offset: 0x000710F5
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00072EFE File Offset: 0x000710FE
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00072F08 File Offset: 0x00071108
		internal virtual Label lblPath
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00072F11 File Offset: 0x00071111
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00072F1B File Offset: 0x0007111B
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00072F24 File Offset: 0x00071124
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00072F2E File Offset: 0x0007112E
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00072F37 File Offset: 0x00071137
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00072F44 File Offset: 0x00071144
		internal virtual Label Label4
		{
			[CompilerGenerated]
			get
			{
				return this._Label4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label4_Click);
				Label label = this._Label4;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label4 = value;
				label = this._Label4;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00072F87 File Offset: 0x00071187
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00072F91 File Offset: 0x00071191
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00072F9A File Offset: 0x0007119A
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00072FA4 File Offset: 0x000711A4
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00072FAD File Offset: 0x000711AD
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00072FB7 File Offset: 0x000711B7
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00072FC0 File Offset: 0x000711C0
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00072FCA File Offset: 0x000711CA
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00072FD3 File Offset: 0x000711D3
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00072FDD File Offset: 0x000711DD
		internal virtual TextBox txtbal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00072FE6 File Offset: 0x000711E6
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00072FF0 File Offset: 0x000711F0
		internal virtual TextBox txtamtpaid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00072FF9 File Offset: 0x000711F9
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00073003 File Offset: 0x00071203
		internal virtual TextBox txtInvTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0007300C File Offset: 0x0007120C
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00073016 File Offset: 0x00071216
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0007301F File Offset: 0x0007121F
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00073029 File Offset: 0x00071229
		internal virtual Label lblpaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00073032 File Offset: 0x00071232
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0007303C File Offset: 0x0007123C
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00073045 File Offset: 0x00071245
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00073050 File Offset: 0x00071250
		internal virtual DataGridView dgvPay
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPay;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(this.dgvPay_CellBeginEdit);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPay_CellEnter);
				DataGridViewCellEventHandler dataGridViewCellEventHandler2 = new DataGridViewCellEventHandler(this.dgvPay_CellEndEdit);
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.dgvPay_CellValidating);
				DataGridView dataGridView = this._dgvPay;
				if (dataGridView != null)
				{
					dataGridView.CellBeginEdit -= dataGridViewCellCancelEventHandler;
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler2;
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
				}
				this._dgvPay = value;
				dataGridView = this._dgvPay;
				if (dataGridView != null)
				{
					dataGridView.CellBeginEdit += dataGridViewCellCancelEventHandler;
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.CellEndEdit += dataGridViewCellEventHandler2;
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
				}
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x000730F0 File Offset: 0x000712F0
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x000730FA File Offset: 0x000712FA
		internal virtual Label txtConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00073103 File Offset: 0x00071303
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0007310D File Offset: 0x0007130D
		internal virtual ComboBox cboConsultant
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00073116 File Offset: 0x00071316
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00073120 File Offset: 0x00071320
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00073164 File Offset: 0x00071364
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranches.DataSource = dataTable;
			this.cboBranches.ValueMember = "branch";
			this.cboBranches.DisplayMember = "branch";
			this.cboBranches.SelectedIndex = this.cboBranches.FindStringExact(MyProject.Forms.Form1.branch);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00073228 File Offset: 0x00071428
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				this.dgvSales.DataSource = dataTable;
				this.OpenFileDialog1.Title = "Please Select CSV File";
				this.OpenFileDialog1.Filter = "CSV File|*.csv";
				bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.dgvSales.DataSource = this.pf.ReadCVStoDataTable(this.OpenFileDialog1.FileName);
					decimal num = 0m;
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvSales.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag2 = !dataGridViewRow.IsNewRow;
							if (flag2)
							{
								DataTable productDetailsAndBal = this.pf.GetProductDetailsAndBal(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, Conversions.ToString(dataGridViewRow.Cells[0].Value), this._cnn);
								DataRow dataRow = productDetailsAndBal.Rows[0];
								bool flag3 = productDetailsAndBal.Rows.Count > 0;
								if (flag3)
								{
									num = Conversions.ToDecimal(Operators.AddObject(num, Operators.MultiplyObject(dataGridViewRow.Cells[2].Value, dataGridViewRow.Cells[1].Value)));
									dataGridViewRow.Cells[0].Style.BackColor = Color.Green;
									bool flag4 = MyProject.Forms.Form1.NegativeStock == 1;
									if (flag4)
									{
										dataGridViewRow.Cells[1].Style.BackColor = Color.Green;
									}
									else
									{
										bool flag5 = Operators.ConditionalCompareObjectLess(dataRow["StockBal"], dataGridViewRow.Cells[1].Value, false);
										if (flag5)
										{
											dataGridViewRow.Cells[1].Style.BackColor = Color.Red;
											this.QtyError = true;
										}
									}
								}
								else
								{
									dataGridViewRow.Cells[0].Style.BackColor = Color.Red;
									this.ProductError = true;
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.txtInvTotal.Text = num.ToString();
					MessageBox.Show("Sales File loaded successfully.");
				}
				else
				{
					MessageBox.Show("No file selected.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading file. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00073510 File Offset: 0x00071710
		private bool CheckIfPayMethAccurate()
		{
			decimal num = 0m;
			bool flag = Operators.CompareString(this.txtInvTotal.Text, "", false) == 0;
			if (flag)
			{
				num = 0m;
			}
			else
			{
				num = Conversions.ToDecimal(this.txtInvTotal.Text);
			}
			return decimal.Compare(num, Conversions.ToDecimal(this.txtamtpaid.Text)) == 0;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00073588 File Offset: 0x00071788
		private void DoSale()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.Connection = sqlConnection;
			try
			{
				sqlConnection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunConfirmedSale");
				sqlCommand.Transaction = sqlTransaction;
				sqlCommand.CommandType = CommandType.StoredProcedure;
				int num = 0;
				bool flag = this.CheckIfPayMethAccurate();
				if (flag)
				{
					int num2 = 1;
					sqlCommand.CommandText = "GetSalesInvoiceNumber";
					sqlCommand.Parameters.AddWithValue("desc", DateTime.Today.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
					bool flag2 = (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1) | (MyProject.Forms.Form1.DateChange == 1);
					if (flag2)
					{
						sqlCommand.Parameters.AddWithValue("allowbackdated", 1);
					}
					else
					{
						sqlCommand.Parameters.AddWithValue("allowbackdated", 0);
					}
					sqlCommand.Parameters.Add("newinvoicenumber", SqlDbType.Int);
					sqlCommand.Parameters["newinvoicenumber"].Direction = ParameterDirection.Output;
					sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
					sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
					sqlCommand.ExecuteNonQuery();
					num = Conversions.ToInteger(sqlCommand.Parameters["newinvoicenumber"].Value);
					bool flag3 = num == 0;
					if (flag3)
					{
						MessageBox.Show("Date entered is inaccurate. Sale cannot proceed");
						sqlTransaction.Rollback();
						sqlConnection.Close();
					}
					else
					{
						sqlCommand.Parameters.Clear();
						sqlCommand.CommandText = "InsertNextSalesInvNumber";
						sqlCommand.Parameters.AddWithValue("desc", this.DTDate.Value.ToString("yyyyMMdd") + DateAndTime.Now.TimeOfDay.ToString());
						sqlCommand.Parameters.AddWithValue("newinvnumber", num);
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						sqlCommand.ExecuteNonQuery();
						int num3 = checked((int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm"))));
						try
						{
							foreach (object obj in ((IEnumerable)this.dgvSales.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag4 = Information.IsNothing(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value));
								if (!flag4)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertNewSale2WarehouseNOCOST";
									bool flag5 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag5)
									{
										sqlCommand.Parameters.AddWithValue("trandate", this.DTDate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("invoicenum", num);
									sqlCommand.Parameters.AddWithValue("isstockin", 0);
									sqlCommand.Parameters.AddWithValue("ref", "CSV");
									sqlCommand.Parameters.AddWithValue("quantity", Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[1].Value)));
									sqlCommand.Parameters.AddWithValue("salesprice", decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[2].Value)), this.mono_rate));
									sqlCommand.Parameters.AddWithValue("paymentmethod", num2);
									sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
									bool flag6 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag6)
									{
										sqlCommand.Parameters.AddWithValue("donewhen", this.DTDate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("trancode", 3);
									sqlCommand.Parameters.AddWithValue("TranTime", num3);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("shift", "");
									bool flag7 = (MyProject.Forms.Form1.DateChange == 1) | (MyProject.Forms.Form1.ShiftClosedUseNExtDay == 1);
									if (flag7)
									{
										sqlCommand.Parameters.AddWithValue("ShiftDate", this.DTDate.Value.ToString("yyyyMMdd"));
									}
									else
									{
										sqlCommand.Parameters.AddWithValue("ShiftDate", DateTime.Today.ToString("yyyyMMdd"));
									}
									sqlCommand.Parameters.AddWithValue("productcode", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[0].Value));
									sqlCommand.Parameters.AddWithValue("BatchNumber", "");
									sqlCommand.Parameters.AddWithValue("ExpiryDate", 0);
									sqlCommand.Parameters.AddWithValue("usereceiptdisplay", 1);
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayPaymentMethod", 1);
									sqlCommand.Parameters.AddWithValue("ReceiptDisplayRate", this.mono_rate);
									sqlCommand.Parameters.AddWithValue("discountamount", 0);
									sqlCommand.Parameters.AddWithValue("consultant", RuntimeHelpers.GetObjectValue(Interaction.IIf(MyProject.Forms.Form1.RecordConsultant == 1, this.cboConsultant.Text, "")));
									sqlCommand.Parameters.AddWithValue("invdiscount", 0);
									string text = "";
									sqlCommand.Parameters.AddWithValue("collection", text);
									sqlCommand.Parameters.AddWithValue("discountdesc", "");
									sqlCommand.Parameters.AddWithValue("otherdetail", "");
									sqlCommand.Parameters.AddWithValue("comments", "");
									sqlCommand.Parameters.AddWithValue("paymethref", "");
									sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
									sqlCommand.Parameters.AddWithValue("quotationnum", 0);
									sqlCommand.Parameters.AddWithValue("taxexempt", 0);
									sqlCommand.Parameters.AddWithValue("iswarehouse", MyProject.Forms.Form1.IsWarehouse);
									sqlCommand.ExecuteNonQuery();
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						try
						{
							foreach (object obj2 in ((IEnumerable)this.dgvPay.Rows))
							{
								DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
								bool flag8 = Operators.ConditionalCompareObjectGreater(Interaction.IIf(Information.IsDBNull(dataGridViewRow2.Cells["amtpaid"]), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["amtpaid"].Value)), 0, false);
								if (flag8)
								{
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "InsertActualPaymentMethods";
									sqlCommand.Parameters.AddWithValue("invnum", num);
									sqlCommand.Parameters.AddWithValue("payid", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["paymentmethodid"].Value));
									sqlCommand.Parameters.AddWithValue("paydesc", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["paymentmethoddesc"].Value));
									sqlCommand.Parameters.AddWithValue("amt", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["amtpaid"].Value));
									sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("rate", RuntimeHelpers.GetObjectValue(dataGridViewRow2.Cells["rate"].Value));
									sqlCommand.Parameters.AddWithValue("trandate", Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd")));
									sqlCommand.ExecuteNonQuery();
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						sqlTransaction.Commit();
						sqlConnection.Close();
						MessageBox.Show("Sale confirmed.");
						this.ClearForm();
					}
				}
				else
				{
					MessageBox.Show("Check payment methods. Sale cannot proceed.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error recording sale. Detail: " + ex.Message);
				SqlTransaction sqlTransaction;
				sqlTransaction.Rollback();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0007406C File Offset: 0x0007226C
		private void ClearForm()
		{
			this.QtyError = false;
			this.ProductError = false;
			DataTable dataTable = new DataTable();
			this.dgvSales.DataSource = dataTable;
			try
			{
				foreach (object obj in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(obj);
					NewLateBinding.LateIndexSet(objectValue, new object[] { "amtpaid", 0 }, null);
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.txtref.Text = "";
			this.txtInvTotal.Text = Conversions.ToString(0);
			this.CalcTotal();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00074140 File Offset: 0x00072340
		private void CSVSales_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				bool flag = MyProject.Forms.Form1.RecordConsultant == 1;
				if (flag)
				{
					this.txtConsultant.Visible = true;
					this.cboConsultant.Visible = true;
				}
				else
				{
					this.txtConsultant.Visible = false;
					this.cboConsultant.Visible = false;
				}
				try
				{
					foreach (object obj in MyProject.Forms.Form1.MultiPayMethodsDAT.Rows)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						NewLateBinding.LateIndexSet(objectValue, new object[] { "amtpaid", 0 }, null);
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				this.dgvPay.DataSource = MyProject.Forms.Form1.MultiPayMethodsDAT;
				this.dgvPay.Columns["paymentmethodid"].Visible = false;
				this.dgvPay.Columns["currency"].Visible = false;
				this.dgvPay.Columns["uploaded"].Visible = false;
				this.dgvPay.Columns["rate"].Visible = false;
				this.dgvPay.Columns["fiscalgroup"].Visible = false;
				this.dgvPay.Columns["discountperc"].Visible = false;
				this.dgvPay.Columns["paymentmethoddesc"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPay.Columns["paymentmethoddesc"].ReadOnly = true;
				this.dgvPay.Columns["equiv"].DefaultCellStyle.BackColor = Color.LightGray;
				this.dgvPay.Columns["equiv"].ReadOnly = true;
				this.dgvPay.Columns["equiv"].HeaderText = "Equivalent in " + this.lblpaymethod.Text;
				this.dgvPay.Columns["amtpaid"].HeaderText = "Actual Amount Paid";
				this.dgvPay.Columns["paymentmethoddesc"].HeaderText = "Payment Method";
				this.dgvPay.Columns["CurrencyIDEltrade"].Visible = false;
				this.dgvPay.Columns["RequiresRef"].Visible = false;
				this.dgvPay.Columns["BPNumber"].Visible = false;
				this.dgvPay.Columns["VATNumber"].Visible = false;
				this.dgvPay.Columns["coid"].Visible = false;
				this.dgvPay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.dgvPay.Focus();
				DataGridViewRow dataGridViewRow = this.dgvPay.Rows[0];
				dataGridViewRow.Selected = true;
				dataGridViewRow.Cells["amtpaid"].Selected = true;
				this.CalcTotal();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading CSV upload form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00074504 File Offset: 0x00072704
		private void CalcTotal()
		{
			decimal num = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvPay.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["amtpaid"].Value)), "", dataGridViewRow.Cells["amtpaid"].Value.ToString()));
					bool flag = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["amtpaid"].Value)), "", dataGridViewRow.Cells["amtpaid"].ToString()), "", false);
					if (flag)
					{
						object obj2 = char.IsDigit(Conversions.ToChar(dataGridViewRow.Cells["amtpaid"].Value));
						DataGridViewCell dataGridViewCell;
						object[] array;
						bool[] array2;
						object obj3 = NewLateBinding.LateGet(null, typeof(Strings), "Asc", array = new object[] { (dataGridViewCell = dataGridViewRow.Cells["amtpaid"]).Value }, null, null, array2 = new bool[] { true });
						if (array2[0])
						{
							dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
						bool flag2 = Conversions.ToBoolean(Operators.NotObject(Operators.OrObject(obj2, Operators.CompareObjectEqual(obj3, 8, false))));
						if (flag2)
						{
							dataGridViewRow.Cells["amtpaid"].Value = "0";
							return;
						}
						decimal num2 = 0m;
						try
						{
							num2 = decimal.Divide(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["DiscountPerc"].Value)), 100m);
						}
						catch (Exception ex)
						{
							num2 = 0m;
						}
						bool flag3 = decimal.Compare(num2, 0m) > 0;
						if (flag3)
						{
							MessageBox.Show("Payment Method Discount Effected.");
						}
						dataGridViewRow.Cells["equiv"].Value = Operators.MultiplyObject(Operators.DivideObject(dataGridViewRow.Cells["amtpaid"].Value, Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["rate"].Value))), this.invpaymethrate).ToString();
						dataGridViewRow.Cells["equiv"].Value = (Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["equiv"].Value)) - Convert.ToDouble(num2) * Conversion.Val(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["equiv"].Value))).ToString();
						num = Conversions.ToDecimal(Operators.AddObject(num, dataGridViewRow.Cells["equiv"].Value));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.txtamtpaid.Text = num.ToString();
			decimal num3 = 0m;
			bool flag4 = Operators.CompareString(this.txtInvTotal.Text, "", false) == 0;
			if (flag4)
			{
				num3 = 0m;
			}
			else
			{
				num3 = Conversions.ToDecimal(this.txtInvTotal.Text);
			}
			this.txtbal.Text = decimal.Subtract(num3, num).ToString();
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002A30 File Offset: 0x00000C30
		private void dgvPay_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x000748E8 File Offset: 0x00072AE8
		private void dgvPay_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.selectedrowindex = e.RowIndex;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x000748F8 File Offset: 0x00072AF8
		private void dgvPay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.CalcTotal();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error end edit. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00074948 File Offset: 0x00072B48
		private void dgvPay_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				this.dgvPay.Rows[e.RowIndex].ErrorText = "";
				bool flag = Operators.CompareString(this.dgvPay.Columns[e.ColumnIndex].Name, "amtpaid", false) == 0;
				if (flag)
				{
					bool isNewRow = this.dgvPay.Rows[e.RowIndex].IsNewRow;
					if (!isNewRow)
					{
						decimal num;
						bool flag2 = !decimal.TryParse(Conversions.ToString(Interaction.IIf(Conversions.ToBoolean(e.FormattedValue.ToString()), "0", e.FormattedValue.ToString())), out num) || decimal.Compare(num, 0m) < 0;
						if (flag2)
						{
							e.Cancel = true;
							this.dgvPay.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00074A64 File Offset: 0x00072C64
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.ProductError & !this.QtyError;
				if (flag)
				{
					bool flag2 = Operators.CompareString(this.txtref.Text, "", false) != 0;
					if (flag2)
					{
						bool flag3 = this.dgvSales.Rows.Count > 0;
						if (flag3)
						{
							this.DoSale();
						}
						else
						{
							MessageBox.Show("No file uploaded. No rows.");
						}
					}
					else
					{
						MessageBox.Show("Please enter a reference.");
						this.txtref.Focus();
					}
				}
				else
				{
					MessageBox.Show("Please attend to highlighted errors first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error confirming sale. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000573 RID: 1395
		private string _cnn;

		// Token: 0x04000574 RID: 1396
		private PublicFunctions pf;

		// Token: 0x04000575 RID: 1397
		private decimal mono_rate;

		// Token: 0x04000576 RID: 1398
		private decimal invpaymethrate;

		// Token: 0x04000577 RID: 1399
		private int selectedrowindex;

		// Token: 0x04000578 RID: 1400
		private bool ProductError;

		// Token: 0x04000579 RID: 1401
		private bool QtyError;
	}
}
