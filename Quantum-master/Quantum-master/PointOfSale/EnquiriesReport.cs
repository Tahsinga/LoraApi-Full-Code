using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000054 RID: 84
	[DesignerGenerated]
	public partial class EnquiriesReport : UserControl
	{
		// Token: 0x060011C5 RID: 4549 RVA: 0x000AAF19 File Offset: 0x000A9119
		public EnquiriesReport()
		{
			base.Load += this.EnquiriesReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000AB556 File Offset: 0x000A9756
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x000AB560 File Offset: 0x000A9760
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000AB569 File Offset: 0x000A9769
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x000AB573 File Offset: 0x000A9773
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000AB57C File Offset: 0x000A977C
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x000AB588 File Offset: 0x000A9788
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

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000AB5CB File Offset: 0x000A97CB
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x000AB5D5 File Offset: 0x000A97D5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000AB5DE File Offset: 0x000A97DE
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x000AB5E8 File Offset: 0x000A97E8
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000AB5F1 File Offset: 0x000A97F1
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x000AB5FB File Offset: 0x000A97FB
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000AB604 File Offset: 0x000A9804
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x000AB60E File Offset: 0x000A980E
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x000AB617 File Offset: 0x000A9817
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x000AB621 File Offset: 0x000A9821
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x000AB62A File Offset: 0x000A982A
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x000AB634 File Offset: 0x000A9834
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x000AB678 File Offset: 0x000A9878
		private void LoadEnquiries()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ViewPriceEnquiries";
			sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00002A30 File Offset: 0x00000C30
		private void EnquiriesReport_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000AB78C File Offset: 0x000A998C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadEnquiries();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading enquiries. Detail: " + ex.Message);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x000AB7DC File Offset: 0x000A99DC
		private void Label3_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000860 RID: 2144
		private string _cnn;
	}
}
