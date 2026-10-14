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
	// Token: 0x02000187 RID: 391
	[DesignerGenerated]
	public partial class RunningBalReport : UserControl
	{
		// Token: 0x06003A61 RID: 14945 RVA: 0x001FA3E8 File Offset: 0x001F85E8
		public RunningBalReport()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x001FAAF9 File Offset: 0x001F8CF9
		// (set) Token: 0x06003A65 RID: 14949 RVA: 0x001FAB03 File Offset: 0x001F8D03
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001592 RID: 5522
		// (get) Token: 0x06003A66 RID: 14950 RVA: 0x001FAB0C File Offset: 0x001F8D0C
		// (set) Token: 0x06003A67 RID: 14951 RVA: 0x001FAB18 File Offset: 0x001F8D18
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x001FAB5B File Offset: 0x001F8D5B
		// (set) Token: 0x06003A69 RID: 14953 RVA: 0x001FAB68 File Offset: 0x001F8D68
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

		// Token: 0x17001594 RID: 5524
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x001FABAB File Offset: 0x001F8DAB
		// (set) Token: 0x06003A6B RID: 14955 RVA: 0x001FABB5 File Offset: 0x001F8DB5
		internal virtual DateTimePicker DTEndDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x001FABBE File Offset: 0x001F8DBE
		// (set) Token: 0x06003A6D RID: 14957 RVA: 0x001FABC8 File Offset: 0x001F8DC8
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x001FABD1 File Offset: 0x001F8DD1
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x001FABDB File Offset: 0x001F8DDB
		internal virtual DateTimePicker DTStartDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x001FABE4 File Offset: 0x001F8DE4
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x001FABEE File Offset: 0x001F8DEE
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x001FABF7 File Offset: 0x001F8DF7
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x001FAC01 File Offset: 0x001F8E01
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06003A74 RID: 14964 RVA: 0x001FAC0A File Offset: 0x001F8E0A
		// (set) Token: 0x06003A75 RID: 14965 RVA: 0x001FAC14 File Offset: 0x001F8E14
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x001FAC1D File Offset: 0x001F8E1D
		// (set) Token: 0x06003A77 RID: 14967 RVA: 0x001FAC28 File Offset: 0x001F8E28
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

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06003A78 RID: 14968 RVA: 0x001FAC6B File Offset: 0x001F8E6B
		// (set) Token: 0x06003A79 RID: 14969 RVA: 0x001FAC75 File Offset: 0x001F8E75
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label1_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x001FAC80 File Offset: 0x001F8E80
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandTimeout = 1000;
				sqlCommand.CommandText = "RunningBalReport";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand.Parameters.AddWithValue("startdate", Conversions.ToInteger(this.DTStartDate.Value.ToString("yyyyMMdd")));
				sqlCommand.Parameters.AddWithValue("enddate", Conversions.ToInteger(this.DTEndDate.Value.ToString("yyyyMMdd")));
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				sqlDataAdapter.Fill(dataTable);
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				Cursor.Current = Cursors.Default;
			}
			catch (Exception ex)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Error running report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x001FAE08 File Offset: 0x001F9008
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.DataGridView1.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.DataGridView1, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no items to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting. Detail: " + ex.Message);
			}
		}

		// Token: 0x040018ED RID: 6381
		private string _cnn;

		// Token: 0x040018EE RID: 6382
		private PublicFunctions pf;
	}
}
