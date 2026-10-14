using System;
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
	// Token: 0x0200008C RID: 140
	[DesignerGenerated]
	public partial class PerformanceReport : UserControl
	{
		// Token: 0x06001FA8 RID: 8104 RVA: 0x0011AD70 File Offset: 0x00118F70
		public PerformanceReport()
		{
			base.Load += this.PerformanceReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0011B705 File Offset: 0x00119905
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0011B70F File Offset: 0x0011990F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0011B718 File Offset: 0x00119918
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0011B724 File Offset: 0x00119924
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

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0011B767 File Offset: 0x00119967
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x0011B771 File Offset: 0x00119971
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0011B77A File Offset: 0x0011997A
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0011B784 File Offset: 0x00119984
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

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0011B7C7 File Offset: 0x001199C7
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x0011B7D1 File Offset: 0x001199D1
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0011B7DA File Offset: 0x001199DA
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x0011B7E4 File Offset: 0x001199E4
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x0011B7ED File Offset: 0x001199ED
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x0011B7F7 File Offset: 0x001199F7
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0011B800 File Offset: 0x00119A00
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x0011B80A File Offset: 0x00119A0A
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0011B813 File Offset: 0x00119A13
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x0011B81D File Offset: 0x00119A1D
		internal virtual DataGridView dgvResults
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x0011B826 File Offset: 0x00119A26
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x0011B830 File Offset: 0x00119A30
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

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x0011B873 File Offset: 0x00119A73
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0011B87D File Offset: 0x00119A7D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0011B886 File Offset: 0x00119A86
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x0011B890 File Offset: 0x00119A90
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0011B899 File Offset: 0x00119A99
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x0011B8A3 File Offset: 0x00119AA3
		internal virtual CheckBox chkAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0011B8AC File Offset: 0x00119AAC
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x0011B8B6 File Offset: 0x00119AB6
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0011B8BF File Offset: 0x00119ABF
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x0011B8C9 File Offset: 0x00119AC9
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0011B8D4 File Offset: 0x00119AD4
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					Cursor.Current = Cursors.WaitCursor;
					bool flag = DateTime.Compare(this.DTEnddate.Value, this.DTStartdate.Value) < 0;
					if (flag)
					{
						MessageBox.Show("End date cannot be before the start date.");
					}
					else
					{
						this.loadPerformanceData((int)Math.Round(Conversion.Val(this.DTStartdate.Value.ToString("yyyyMMdd"))), (int)Math.Round(Conversion.Val(this.DTEnddate.Value.ToString("yyyyMMdd"))), Conversions.ToString(Interaction.IIf(this.chkAll.Checked, VariantType.Null, this.cboBranches.Text)), MyProject.Forms.Form1.coid);
						Cursor.Current = Cursors.Default;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error loading data. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0011B9E8 File Offset: 0x00119BE8
		private void loadPerformanceData(int startdate, int enddate, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PerformanceReport";
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvResults.DataSource = dataTable;
			bool flag = num > 0;
			if (flag)
			{
				MessageBox.Show("Performance Data loaded.");
			}
			else
			{
				MessageBox.Show("There is Not data loaded");
			}
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0011BAC0 File Offset: 0x00119CC0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvResults.Rows.Count > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_CSV(this.dgvResults, this.SaveFileDialog1.FileName);
					}
					MessageBox.Show("Data exported to excel.");
				}
				else
				{
					MessageBox.Show("There are no rows to export.");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0011BB68 File Offset: 0x00119D68
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

		// Token: 0x06001FCE RID: 8142 RVA: 0x0011BC2C File Offset: 0x00119E2C
		private void PerformanceReport_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000F18 RID: 3864
		private string _cnn;

		// Token: 0x04000F19 RID: 3865
		private PublicFunctions pf;
	}
}
