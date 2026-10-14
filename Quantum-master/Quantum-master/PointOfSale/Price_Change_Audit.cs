using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000162 RID: 354
	[DesignerGenerated]
	public partial class Price_Change_Audit : UserControl
	{
		// Token: 0x06002F4E RID: 12110 RVA: 0x0019A8B0 File Offset: 0x00198AB0
		public Price_Change_Audit()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06002F51 RID: 12113 RVA: 0x0019B049 File Offset: 0x00199249
		// (set) Token: 0x06002F52 RID: 12114 RVA: 0x0019B053 File Offset: 0x00199253
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06002F53 RID: 12115 RVA: 0x0019B05C File Offset: 0x0019925C
		// (set) Token: 0x06002F54 RID: 12116 RVA: 0x0019B066 File Offset: 0x00199266
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x0019B06F File Offset: 0x0019926F
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x0019B079 File Offset: 0x00199279
		internal virtual DataGridView dgvAudit
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x0019B082 File Offset: 0x00199282
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x0019B08C File Offset: 0x0019928C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x0019B095 File Offset: 0x00199295
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x0019B0A0 File Offset: 0x001992A0
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

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x0019B0E3 File Offset: 0x001992E3
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x0019B0ED File Offset: 0x001992ED
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0019B0F6 File Offset: 0x001992F6
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x0019B100 File Offset: 0x00199300
		internal virtual DateTimePicker DTend
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x0019B109 File Offset: 0x00199309
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x0019B113 File Offset: 0x00199313
		internal virtual DateTimePicker DTstart
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x0019B11C File Offset: 0x0019931C
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x0019B126 File Offset: 0x00199326
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x0019B12F File Offset: 0x0019932F
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x0019B13C File Offset: 0x0019933C
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
				EventHandler eventHandler = new EventHandler(this.btnExportExcel_Click);
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

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x0019B17F File Offset: 0x0019937F
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x0019B189 File Offset: 0x00199389
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x0019B192 File Offset: 0x00199392
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x0019B19C File Offset: 0x0019939C
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

		// Token: 0x06002F69 RID: 12137 RVA: 0x0019B1E0 File Offset: 0x001993E0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.ViewPriceChangeAudit(this.DTstart.Value, this.DTend.Value, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.coid);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error retrieving price changes audit trail. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0019B264 File Offset: 0x00199464
		private void ViewPriceChangeAudit(DateTime startdate, DateTime enddate, string branch, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "Audit_PriceChangesSelect";
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("enddate", enddate);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvAudit.DataSource = dataTable;
				this.dgvAudit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				MessageBox.Show("There are no price changes done for the period selected.");
				DataTable dataTable2 = new DataTable();
				this.dgvAudit.DataSource = dataTable2;
			}
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x0019B370 File Offset: 0x00199570
		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					DataTable dataTable = new DataTable();
					try
					{
						foreach (object obj in this.dgvAudit.Columns)
						{
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
							dataTable.Columns.Add(dataGridViewColumn.HeaderText, dataGridViewColumn.ValueType);
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
						foreach (object obj2 in ((IEnumerable)this.dgvAudit.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
							dataTable.Rows.Add(new object[0]);
							try
							{
								foreach (object obj3 in dataGridViewRow.Cells)
								{
									DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
									dataTable.Rows[dataTable.Rows.Count - 1][dataGridViewCell.ColumnIndex] = dataGridViewCell.Value.ToString();
								}
							}
							finally
							{
								IEnumerator enumerator3;
								if (enumerator3 is IDisposable)
								{
									(enumerator3 as IDisposable).Dispose();
								}
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
					string text = "c:\\QuantumPOS Price Changes Audits";
					bool flag = !Directory.Exists(text);
					if (flag)
					{
						Directory.CreateDirectory(text);
					}
					using (XLWorkbook xlworkbook = new XLWorkbook())
					{
						xlworkbook.Worksheets.Add(dataTable, "Customers");
						xlworkbook.Worksheet(1).Cells("A1:C1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
						int count = dataTable.Rows.Count;
						for (int i = 1; i <= count; i++)
						{
							string text2 = string.Format("A{0}:C{0}", i + 1);
							bool flag2 = i % 2 != 0;
							if (flag2)
							{
								xlworkbook.Worksheet(1).Cells(text2).Style.Fill.BackgroundColor = XLColor.GreenYellow;
							}
							else
							{
								xlworkbook.Worksheet(1).Cells(text2).Style.Fill.BackgroundColor = XLColor.Yellow;
							}
						}
						xlworkbook.Worksheet(1).Columns().AdjustToContents();
						xlworkbook.SaveAs(text + "DataGridViewExport.xlsx");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error exporting data to excel. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x0019B684 File Offset: 0x00199884
		private void Label4_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001454 RID: 5204
		private string _cnn;
	}
}
