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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000188 RID: 392
	[DesignerGenerated]
	public partial class R_SalesReport : Form
	{
		// Token: 0x06003A7D RID: 14973 RVA: 0x001FAEC0 File Offset: 0x001F90C0
		public R_SalesReport()
		{
			base.Load += this.R_SalesReport_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06003A80 RID: 14976 RVA: 0x001FB5E8 File Offset: 0x001F97E8
		// (set) Token: 0x06003A81 RID: 14977 RVA: 0x001FB5F2 File Offset: 0x001F97F2
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06003A82 RID: 14978 RVA: 0x001FB5FB File Offset: 0x001F97FB
		// (set) Token: 0x06003A83 RID: 14979 RVA: 0x001FB605 File Offset: 0x001F9805
		internal virtual DataGridView dgvR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x001FB60E File Offset: 0x001F980E
		// (set) Token: 0x06003A85 RID: 14981 RVA: 0x001FB618 File Offset: 0x001F9818
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x001FB621 File Offset: 0x001F9821
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x001FB62B File Offset: 0x001F982B
		internal virtual DateTimePicker DTenddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06003A88 RID: 14984 RVA: 0x001FB634 File Offset: 0x001F9834
		// (set) Token: 0x06003A89 RID: 14985 RVA: 0x001FB63E File Offset: 0x001F983E
		internal virtual DateTimePicker DTstartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06003A8A RID: 14986 RVA: 0x001FB647 File Offset: 0x001F9847
		// (set) Token: 0x06003A8B RID: 14987 RVA: 0x001FB651 File Offset: 0x001F9851
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06003A8C RID: 14988 RVA: 0x001FB65A File Offset: 0x001F985A
		// (set) Token: 0x06003A8D RID: 14989 RVA: 0x001FB664 File Offset: 0x001F9864
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x001FB66D File Offset: 0x001F986D
		// (set) Token: 0x06003A8F RID: 14991 RVA: 0x001FB678 File Offset: 0x001F9878
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

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06003A90 RID: 14992 RVA: 0x001FB6BB File Offset: 0x001F98BB
		// (set) Token: 0x06003A91 RID: 14993 RVA: 0x001FB6C5 File Offset: 0x001F98C5
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x06003A92 RID: 14994 RVA: 0x001FB6CE File Offset: 0x001F98CE
		// (set) Token: 0x06003A93 RID: 14995 RVA: 0x001FB6D8 File Offset: 0x001F98D8
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

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06003A94 RID: 14996 RVA: 0x001FB71B File Offset: 0x001F991B
		// (set) Token: 0x06003A95 RID: 14997 RVA: 0x001FB725 File Offset: 0x001F9925
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003A96 RID: 14998 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label5_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06003A97 RID: 14999 RVA: 0x001FB730 File Offset: 0x001F9930
		private void R_SalesReport_Load(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003A98 RID: 15000 RVA: 0x001FB778 File Offset: 0x001F9978
		private DataTable cat_dt(int startdate, int enddate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Categories3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("startshiftdate", startdate);
			sqlCommand.Parameters.AddWithValue("endshiftdate", enddate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003A99 RID: 15001 RVA: 0x001FB810 File Offset: 0x001F9A10
		private DataRow pay_dt(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_PayMethod3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			DataRow dataRow2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				dataRow2 = dataRow;
			}
			else
			{
				DataRow dataRow3 = dataTable.NewRow();
				dataRow2 = dataRow3;
			}
			return dataRow2;
		}

		// Token: 0x06003A9A RID: 15002 RVA: 0x001FB8BC File Offset: 0x001F9ABC
		private decimal mtd(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_MTD3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["mtd_revenue"]);
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x001FB95C File Offset: 0x001F9B5C
		private decimal ytd(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_YTD3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["ytd_revenue"]);
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x001FB9FC File Offset: 0x001F9BFC
		private decimal cogs(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_COGS3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["cogs"]);
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x001FBA9C File Offset: 0x001F9C9C
		private decimal sales(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Sales3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["sales"]);
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x001FBB3C File Offset: 0x001F9D3C
		private decimal vmargin(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Margin3";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["margin"]);
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x001FBBDC File Offset: 0x001F9DDC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SelectBranches selectBranches = new SelectBranches();
				selectBranches.ShowDialog(this);
				selectBranches.Dispose();
				Cursor.Current = Cursors.WaitCursor;
				this.dgvR.Columns.Clear();
				DataTable dataTable = new DataTable();
				this.dgvR.DataSource = dataTable;
				this.dgvR.DataSource = this.cat_dt(Convert.ToInt32(this.DTstartdate.Value.ToString("yyyyMMdd")), Convert.ToInt32(this.DTenddate.Value.ToString("yyyyMMdd")), MyProject.Forms.Form1.coid);
				this.dgvR.Columns.Add("Cash USD", "Cash Collections");
				this.dgvR.Columns.Add("Euro", "Euro");
				this.dgvR.Columns.Add("Pound", "Pound");
				this.dgvR.Columns.Add("Rand", "Rand");
				this.dgvR.Columns.Add("Swipe - Foreign", "Credit Card Receipts");
				this.dgvR.Columns.Add("Sales Total USD", "Sales Total USD");
				this.dgvR.Columns.Add("Cost of Goods Sold", "Cost of Goods Sold");
				this.dgvR.Columns.Add("Margin", "Margin");
				this.dgvR.Columns.Add("MTD", "MTD");
				this.dgvR.Columns.Add("AVG", "Monthly AVG");
				this.dgvR.Columns.Add("YTD", "YTD");
				decimal num = 0m;
				decimal num2 = 0m;
				decimal num3 = 0m;
				decimal num4 = 0m;
				decimal num5 = 0m;
				decimal num6 = 0m;
				decimal num7 = 0m;
				decimal num8 = 0m;
				decimal num9 = 0m;
				decimal num10 = 0m;
				decimal num11 = 0m;
				decimal num12 = 0m;
				decimal num13 = 0m;
				decimal num14 = 0m;
				decimal num15 = 0m;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvR.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = !dataGridViewRow.IsNewRow;
						if (flag)
						{
							try
							{
								foreach (object obj2 in dataGridViewRow.Cells)
								{
									DataGridViewCell dataGridViewCell = (DataGridViewCell)obj2;
									bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewCell.Value));
									if (flag2)
									{
										dataGridViewCell.Value = 0;
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
							DataRow dataRow = this.pay_dt(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid);
							dataGridViewRow.Cells["Cash USD"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
							dataGridViewRow.Cells["Swipe - Foreign"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[1])), 0, RuntimeHelpers.GetObjectValue(dataRow[1])));
							dataGridViewRow.Cells["Euro"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[2])), 0, RuntimeHelpers.GetObjectValue(dataRow[2])));
							dataGridViewRow.Cells["Pound"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[3])), 0, RuntimeHelpers.GetObjectValue(dataRow[3])));
							dataGridViewRow.Cells["Rand"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[4])), 0, RuntimeHelpers.GetObjectValue(dataRow[4])));
							decimal num16 = this.sales(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid);
							dataGridViewRow.Cells["Sales Total USD"].Value = Math.Round(num16, 4, MidpointRounding.AwayFromZero);
							dataGridViewRow.Cells["Cost of Goods Sold"].Value = Math.Round(this.cogs(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid), 4, MidpointRounding.AwayFromZero);
							dataGridViewRow.Cells["Margin"].Value = Math.Round(this.vmargin(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid), 4, MidpointRounding.AwayFromZero);
							dataGridViewRow.Cells["MTD"].Value = Math.Round(this.mtd(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid), 4, MidpointRounding.AwayFromZero);
							dataGridViewRow.Cells["AVG"].Value = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.DivideObject(dataGridViewRow.Cells["MTD"].Value, checked(dataGridViewRow.Index + 1)),
								4,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							dataGridViewRow.Cells["YTD"].Value = Math.Round(this.ytd(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid), 4, MidpointRounding.AwayFromZero);
							num = Conversions.ToDecimal(Operators.AddObject(num, dataGridViewRow.Cells["Accessories"].Value));
							num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataGridViewRow.Cells["Liquor_Tobacco"].Value));
							num12 = Conversions.ToDecimal(Operators.AddObject(num12, dataGridViewRow.Cells["Cost of Goods Sold"].Value));
							num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataGridViewRow.Cells["Confectionery"].Value));
							num10 = Conversions.ToDecimal(Operators.AddObject(num10, dataGridViewRow.Cells["Swipe - Foreign"].Value));
							num7 = Conversions.ToDecimal(Operators.AddObject(num7, dataGridViewRow.Cells["Euro"].Value));
							num13 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.AddObject(num13, dataGridViewRow.Cells["Margin"].Value),
								4,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num14 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.AddObject(num14, dataGridViewRow.Cells["MTD"].Value),
								4,
								MidpointRounding.AwayFromZero
							}, null, null, null));
							num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataGridViewRow.Cells["Perfume"].Value));
							num8 = Conversions.ToDecimal(Operators.AddObject(num8, dataGridViewRow.Cells["Pound"].Value));
							num9 = Conversions.ToDecimal(Operators.AddObject(num9, dataGridViewRow.Cells["Rand"].Value));
							num5 = Conversions.ToDecimal(Operators.AddObject(num5, dataGridViewRow.Cells["Refreshments"].Value));
							num11 = Conversions.ToDecimal(Operators.AddObject(num11, dataGridViewRow.Cells["Sales Total USD"].Value));
							num6 = Conversions.ToDecimal(Operators.AddObject(num6, dataGridViewRow.Cells["Cash USD"].Value));
							num15 = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
							{
								Operators.AddObject(num15, dataGridViewRow.Cells["YTD"].Value),
								4,
								MidpointRounding.AwayFromZero
							}, null, null, null));
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
				string[] array = new string[]
				{
					"",
					"",
					num.ToString(),
					num2.ToString(),
					num4.ToString(),
					num5.ToString(),
					num3.ToString(),
					num6.ToString(),
					num7.ToString(),
					num8.ToString(),
					num9.ToString(),
					num10.ToString(),
					num11.ToString(),
					num12.ToString(),
					num13.ToString(),
					num14.ToString(),
					num15.ToString()
				};
				Cursor.Current = Cursors.WaitCursor;
				MessageBox.Show("Report loaded.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report data. Details: " + ex.Message);
			}
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x001FC6E8 File Offset: 0x001FA8E8
		private void DataGridToCSV(ref DataGridView dt, string Qualifier)
		{
			string text = "";
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			checked
			{
				if (flag)
				{
					text = this.FolderBrowserDialog1.SelectedPath;
					Directory.CreateDirectory(text);
					string text2 = "ADF Sales Report " + DateTime.Today.ToString("yyyyMMdd") + ".csv";
					StreamWriter streamWriter = File.CreateText(text + "\\" + text2);
					StringBuilder stringBuilder = new StringBuilder();
					int num = 1;
					StringBuilder stringBuilder2 = new StringBuilder();
					try
					{
						foreach (object obj in dt.Columns)
						{
							DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
							bool flag2 = num == 1;
							if (flag2)
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
						string text3 = "";
						int num3 = dt.Columns.Count - 1;
						for (int j = 0; j <= num3; j++)
						{
							bool flag3 = j == 0;
							if (flag3)
							{
								text3 = text3 + Qualifier + this.dgvR.Rows[i].Cells[j].Value.ToString() + Qualifier;
							}
							else
							{
								text3 = string.Concat(new string[]
								{
									text3,
									",",
									Qualifier,
									this.dgvR.Rows[i].Cells[j].Value.ToString(),
									Qualifier
								});
							}
						}
						streamWriter.WriteLine(text3);
						streamWriter.Flush();
					}
					streamWriter.Close();
					streamWriter = null;
					Process.Start(text + "\\" + text2);
					GC.Collect();
				}
				else
				{
					MessageBox.Show("File NOT Saved.");
				}
			}
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x001FC954 File Offset: 0x001FAB54
		private void Button2_Click(object sender, EventArgs e)
		{
			this.SaveFileDialog1.DefaultExt = ".csv";
			this.SaveFileDialog1.OverwritePrompt = true;
			this.SaveFileDialog1.AddExtension = true;
			bool flag = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
			checked
			{
				if (flag)
				{
					string fileName = this.SaveFileDialog1.FileName;
					string text = fileName;
					string text2 = ",";
					StringBuilder stringBuilder = new StringBuilder();
					int num = this.dgvR.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string[] array = new string[this.dgvR.Columns.Count - 1 + 1];
						bool flag2 = i.Equals(0);
						if (flag2)
						{
							int num2 = this.dgvR.Columns.Count - 1;
							for (int j = 0; j <= num2; j++)
							{
								array[j] = this.dgvR.Columns[j].HeaderText;
							}
							stringBuilder.AppendLine(string.Join(text2, array));
						}
						int num3 = this.dgvR.Columns.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							bool flag3 = !this.dgvR.Rows[i].IsNewRow;
							if (flag3)
							{
								array[k] = this.dgvR[k, i].Value.ToString();
							}
						}
						bool flag4 = !this.dgvR.Rows[i].IsNewRow;
						if (flag4)
						{
							stringBuilder.AppendLine(string.Join(text2, array));
						}
					}
					File.WriteAllText(text, stringBuilder.ToString());
					Process.Start(text);
				}
				else
				{
					MessageBox.Show("File NOT Saved.");
				}
			}
		}

		// Token: 0x040018FB RID: 6395
		private string _cnn;

		// Token: 0x040018FC RID: 6396
		private PublicFunctions pf;
	}
}
