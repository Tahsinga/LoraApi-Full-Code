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
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class ADF_SalesReport_Dubai : UserControl
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00012BC4 File Offset: 0x00010DC4
		public ADF_SalesReport_Dubai()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000216 RID: 534 RVA: 0x000134FF File Offset: 0x000116FF
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00013509 File Offset: 0x00011709
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00013512 File Offset: 0x00011712
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0001351C File Offset: 0x0001171C
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

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001355F File Offset: 0x0001175F
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0001356C File Offset: 0x0001176C
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600021C RID: 540 RVA: 0x000135AF File Offset: 0x000117AF
		// (set) Token: 0x0600021D RID: 541 RVA: 0x000135B9 File Offset: 0x000117B9
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000135C2 File Offset: 0x000117C2
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000135CC File Offset: 0x000117CC
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000135D5 File Offset: 0x000117D5
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000135DF File Offset: 0x000117DF
		internal virtual DateTimePicker DTenddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000135E8 File Offset: 0x000117E8
		// (set) Token: 0x06000223 RID: 547 RVA: 0x000135F2 File Offset: 0x000117F2
		internal virtual DateTimePicker DTstartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000135FB File Offset: 0x000117FB
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00013605 File Offset: 0x00011805
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001360E File Offset: 0x0001180E
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00013618 File Offset: 0x00011818
		internal virtual DataGridView dgvR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00013621 File Offset: 0x00011821
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0001362C File Offset: 0x0001182C
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

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0001366F File Offset: 0x0001186F
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00013679 File Offset: 0x00011879
		internal virtual CheckBox chkHideCogs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00013682 File Offset: 0x00011882
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0001368C File Offset: 0x0001188C
		internal virtual CheckBox chkHidePayMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00013695 File Offset: 0x00011895
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001369F File Offset: 0x0001189F
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000136A8 File Offset: 0x000118A8
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
				bool @checked = this.chkHideCogs.Checked;
				if (@checked)
				{
					this.dgvR.Columns["Accessories_COGS"].Visible = false;
					this.dgvR.Columns["Confectionery_COGS"].Visible = false;
					this.dgvR.Columns["Liquor_COGS"].Visible = false;
					this.dgvR.Columns["Perfumes_COGS"].Visible = false;
					this.dgvR.Columns["Refreshments_COGS"].Visible = false;
				}
				this.dgvR.Columns.Add("USD Cash", "Cash Collections");
				this.dgvR.Columns.Add("Euro", "Euro");
				this.dgvR.Columns.Add("Pound", "Pound");
				this.dgvR.Columns.Add("Rand", "Rand");
				this.dgvR.Columns.Add("Swipe - Foreign", "Credit Card Receipts");
				this.dgvR.Columns.Add("Sales Total USD", "Sales Total USD");
				this.dgvR.Columns.Add("Cost of Goods Sold", "Cost of Goods Sold");
				this.dgvR.Columns.Add("Margin", "Margin");
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
				decimal num16 = 0m;
				decimal num17 = 0m;
				decimal num18 = 0m;
				decimal num19 = 0m;
				decimal num20 = 0m;
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
							dataGridViewRow.Cells["USD Cash"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
							dataGridViewRow.Cells["Swipe - Foreign"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[1])), 0, RuntimeHelpers.GetObjectValue(dataRow[1])));
							dataGridViewRow.Cells["Euro"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[2])), 0, RuntimeHelpers.GetObjectValue(dataRow[2])));
							dataGridViewRow.Cells["Pound"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[3])), 0, RuntimeHelpers.GetObjectValue(dataRow[3])));
							dataGridViewRow.Cells["Rand"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[4])), 0, RuntimeHelpers.GetObjectValue(dataRow[4])));
							decimal num21 = this.sales(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid);
							dataGridViewRow.Cells["Sales Total USD"].Value = num21;
							dataGridViewRow.Cells["Cost of Goods Sold"].Value = this.cogs(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid);
							dataGridViewRow.Cells["Margin"].Value = this.vmargin(Conversions.ToInteger(dataGridViewRow.Cells["shiftdate"].Value), MyProject.Forms.Form1.coid);
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
				bool checked2 = this.chkHidePayMethods.Checked;
				if (checked2)
				{
					this.dgvR.Columns["USD Cash"].Visible = false;
					this.dgvR.Columns["Euro"].Visible = false;
					this.dgvR.Columns["Pound"].Visible = false;
					this.dgvR.Columns["Rand"].Visible = false;
					this.dgvR.Columns["Swipe - Foreign"].Visible = false;
				}
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Report loaded.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing report. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00013DE8 File Offset: 0x00011FE8
		private DataTable cat_dt(int startdate, int enddate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Categories2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("startshiftdate", startdate);
			sqlCommand.Parameters.AddWithValue("endshiftdate", enddate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00013E80 File Offset: 0x00012080
		private DataRow pay_dt(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_PayMethod2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows[0];
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00013F10 File Offset: 0x00012110
		private decimal sales(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Sales2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["sales"]);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00013FB0 File Offset: 0x000121B0
		private decimal vmargin(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_Margin2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["margin"]);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00014050 File Offset: 0x00012250
		private decimal cogs(int shiftdate, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "R_COGS2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["cogs"]);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label4_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000140F8 File Offset: 0x000122F8
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.SaveFileDialog1.DefaultExt = ".csv";
					this.SaveFileDialog1.OverwritePrompt = true;
					this.SaveFileDialog1.AddExtension = true;
					bool flag = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
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
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x040000F3 RID: 243
		private string _cnn;

		// Token: 0x040000F4 RID: 244
		private PublicFunctions pf;
	}
}
