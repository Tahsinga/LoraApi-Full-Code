using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x0200002C RID: 44
	[DesignerGenerated]
	public partial class ComputedSalesReport : UserControl
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00053107 File Offset: 0x00051307
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00053111 File Offset: 0x00051311
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0005311A File Offset: 0x0005131A
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00053124 File Offset: 0x00051324
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0005312D File Offset: 0x0005132D
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00053137 File Offset: 0x00051337
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00053140 File Offset: 0x00051340
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x0005314A File Offset: 0x0005134A
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00053153 File Offset: 0x00051353
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x0005315D File Offset: 0x0005135D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00053166 File Offset: 0x00051366
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00053170 File Offset: 0x00051370
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

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x000531B3 File Offset: 0x000513B3
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x000531BD File Offset: 0x000513BD
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000531C6 File Offset: 0x000513C6
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x000531D0 File Offset: 0x000513D0
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x000531D9 File Offset: 0x000513D9
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x000531E3 File Offset: 0x000513E3
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x000531EC File Offset: 0x000513EC
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x000531F6 File Offset: 0x000513F6
		internal virtual BindingSource SelectComputedSalesBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x000531FF File Offset: 0x000513FF
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00053209 File Offset: 0x00051409
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00053212 File Offset: 0x00051412
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0005321C File Offset: 0x0005141C
		internal virtual SelectComputedSalesTableAdapter SelectComputedSalesTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00053225 File Offset: 0x00051425
		public ComputedSalesReport()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0005324C File Offset: 0x0005144C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.DeleteData();
			checked
			{
				this.InsertDataDay1((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Departures1");
				this.InsertDataDay2((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Arrivals1");
				this.InsertDataDay3((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Arrivals2");
				this.InsertDataNight1((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Departures1");
				this.InsertDataNight2((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Arrivals1");
				this.InsertDataNight3((int)Math.Round(Conversion.Val(this.DTStartDate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEndDate.Value.ToString("yyyyMMdd"))), "Arrivals2");
				this.RunReport();
			}
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00053454 File Offset: 0x00051654
		private void RunReport()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
			this.SelectComputedSalesTableAdapter.Connection = sqlConnection;
			ReportParameter reportParameter = new ReportParameter("startdate", Conversions.ToString(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter2 = new ReportParameter("enddate", Conversions.ToString(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
			ReportParameter reportParameter3 = new ReportParameter("startdateDesc", this.DTStartDate.Value.ToShortDateString());
			ReportParameter reportParameter4 = new ReportParameter("enddateDesc", this.DTEndDate.Value.ToShortDateString());
			ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
			this.ReportViewer1.LocalReport.SetParameters(array);
			this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
			this.SelectComputedSalesTableAdapter.Fill(this.POSDataSet.SelectComputedSales, new int?(Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd"))));
			this.ReportViewer1.RefreshReport();
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000535D8 File Offset: 0x000517D8
		private void DeleteData()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "DeleteComputedSales";
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00053644 File Offset: 0x00051844
		private void InsertDataDay1(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesDayShift1";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00053714 File Offset: 0x00051914
		private void InsertDataDay2(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesDayShift2";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000537E4 File Offset: 0x000519E4
		private void InsertDataDay3(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesDayShift3";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000538B4 File Offset: 0x00051AB4
		private void InsertDataNight1(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesNightShift1";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00053984 File Offset: 0x00051B84
		private void InsertDataNight2(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesNightShift2";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00053A54 File Offset: 0x00051C54
		private void InsertDataNight3(int startdate, int enddate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertComputedSalesNightShift3";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0400040B RID: 1035
		private string _cnn;
	}
}
