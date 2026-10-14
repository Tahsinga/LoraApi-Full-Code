using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x020001A1 RID: 417
	[DesignerGenerated]
	public partial class SalesForPeriodGrid : UserControl
	{
		// Token: 0x06004A8F RID: 19087 RVA: 0x002CCD70 File Offset: 0x002CAF70
		public SalesForPeriodGrid()
		{
			base.Load += this.SalesForPeriodGrid_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x002CD68D File Offset: 0x002CB88D
		// (set) Token: 0x06004A93 RID: 19091 RVA: 0x002CD697 File Offset: 0x002CB897
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x002CD6A0 File Offset: 0x002CB8A0
		// (set) Token: 0x06004A95 RID: 19093 RVA: 0x002CD6AC File Offset: 0x002CB8AC
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

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x002CD6EF File Offset: 0x002CB8EF
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x002CD6F9 File Offset: 0x002CB8F9
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x002CD702 File Offset: 0x002CB902
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x002CD70C File Offset: 0x002CB90C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x002CD715 File Offset: 0x002CB915
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x002CD71F File Offset: 0x002CB91F
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x002CD728 File Offset: 0x002CB928
		// (set) Token: 0x06004A9D RID: 19101 RVA: 0x002CD732 File Offset: 0x002CB932
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x002CD73B File Offset: 0x002CB93B
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x002CD745 File Offset: 0x002CB945
		internal virtual DateTimePicker DTstartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x002CD74E File Offset: 0x002CB94E
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x002CD758 File Offset: 0x002CB958
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x002CD761 File Offset: 0x002CB961
		// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x002CD76B File Offset: 0x002CB96B
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x002CD774 File Offset: 0x002CB974
		// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x002CD77E File Offset: 0x002CB97E
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x002CD787 File Offset: 0x002CB987
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x002CD791 File Offset: 0x002CB991
		internal virtual BindingSource SalesForPeriod2BindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x002CD79A File Offset: 0x002CB99A
		// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x002CD7A4 File Offset: 0x002CB9A4
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x002CD7AD File Offset: 0x002CB9AD
		// (set) Token: 0x06004AAB RID: 19115 RVA: 0x002CD7B7 File Offset: 0x002CB9B7
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x002CD7C0 File Offset: 0x002CB9C0
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x002CD7CA File Offset: 0x002CB9CA
		internal virtual SalesForPeriod2TableAdapter SalesForPeriod2TableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x002CD7D3 File Offset: 0x002CB9D3
		// (set) Token: 0x06004AAF RID: 19119 RVA: 0x002CD7DD File Offset: 0x002CB9DD
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x002CD7E6 File Offset: 0x002CB9E6
		// (set) Token: 0x06004AB1 RID: 19121 RVA: 0x002CD7F0 File Offset: 0x002CB9F0
		internal virtual CheckBox chkAllBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x002CD7F9 File Offset: 0x002CB9F9
		// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x002CD804 File Offset: 0x002CBA04
		internal virtual Label Label5
		{
			[CompilerGenerated]
			get
			{
				return this._Label5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label5_Click);
				Label label = this._Label5;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label5 = value;
				label = this._Label5;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x002CD848 File Offset: 0x002CBA48
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.SalesForPeriod2TableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTstartdate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter2 = new ReportParameter("startdatedesc", this.DTstartdate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))));
				ReportParameter reportParameter4 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter5 = new ReportParameter("coid", Conversions.ToString(MyProject.Forms.Form1.coid));
				bool @checked = this.chkAllBranches.Checked;
				string text;
				string text2;
				if (@checked)
				{
					text = Conversions.ToString(1);
					text2 = "All Branches";
				}
				else
				{
					text2 = this.cboBranches.SelectedValue.ToString();
					text = this.cboBranches.SelectedValue.ToString();
				}
				ReportParameter reportParameter6 = new ReportParameter("branch", text);
				ReportParameter reportParameter7 = new ReportParameter("branchdesc", text2);
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4, reportParameter7, reportParameter5, reportParameter6 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.SalesForPeriod2TableAdapter.Fill(this.POSDataSet.SalesForPeriod2, new int?(Convert.ToInt32(this.DTstartdate.Value.ToString("yyyyMMdd"))), new int?(Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranches.SelectedValue.ToString());
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x002CDADC File Offset: 0x002CBCDC
		private void GetData()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriod2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTstartdate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")));
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x002CDBD4 File Offset: 0x002CBDD4
		private void DataGridToCSV(ref DataGridView dt, string Qualifier, DataGridView gridResults, string savedir)
		{
			Directory.CreateDirectory(savedir);
			string text = Path.GetRandomFileName() + ".csv";
			StreamWriter streamWriter = File.CreateText(savedir + "\\" + text);
			StringBuilder stringBuilder = new StringBuilder();
			int num = 1;
			StringBuilder stringBuilder2 = new StringBuilder();
			checked
			{
				try
				{
					foreach (object obj in dt.Columns)
					{
						DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
						bool flag = num == 1;
						if (flag)
						{
							stringBuilder2.Append(Qualifier + dataGridViewColumn.HeaderText.ToString() + Qualifier);
						}
						else
						{
							stringBuilder2.Append("," + Qualifier + dataGridViewColumn.HeaderText.ToString() + Qualifier);
						}
						num++;
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
				streamWriter.WriteLine(stringBuilder2.ToString());
				streamWriter.Flush();
				int num2 = dt.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					string text2 = "";
					int num3 = dt.Columns.Count - 1;
					for (int j = 0; j <= num3; j++)
					{
						bool flag2 = j == 0;
						if (flag2)
						{
							text2 = text2 + Qualifier + gridResults.Rows[i].Cells[j].Value.ToString() + Qualifier;
						}
						else
						{
							text2 = string.Concat(new string[]
							{
								text2,
								",",
								Qualifier,
								gridResults.Rows[i].Cells[j].Value.ToString(),
								Qualifier
							});
						}
					}
					streamWriter.WriteLine(text2);
					streamWriter.Flush();
				}
				streamWriter.Close();
				streamWriter = null;
				Process.Start(savedir + "\\" + text);
				GC.Collect();
			}
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x002CDDEC File Offset: 0x002CBFEC
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
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x002CDE8C File Offset: 0x002CC08C
		private void SalesForPeriodGrid_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x002CDEDC File Offset: 0x002CC0DC
		private void Label5_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040020C6 RID: 8390
		private string _cnn;
	}
}
