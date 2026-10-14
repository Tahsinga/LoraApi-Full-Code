using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001F5 RID: 501
	[DesignerGenerated]
	public partial class StockTakeExcel : Form
	{
		// Token: 0x06005939 RID: 22841 RVA: 0x00336DC0 File Offset: 0x00334FC0
		public StockTakeExcel()
		{
			base.Load += this.StockTakeExcel_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dt = new DataTable();
			this.pf = new PublicFunctions();
			this.firstbalrun = false;
			this.InitializeComponent();
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600593C RID: 22844 RVA: 0x0033815E File Offset: 0x0033635E
		// (set) Token: 0x0600593D RID: 22845 RVA: 0x00338168 File Offset: 0x00336368
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x00338171 File Offset: 0x00336371
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x0033817B File Offset: 0x0033637B
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x00338184 File Offset: 0x00336384
		// (set) Token: 0x06005941 RID: 22849 RVA: 0x0033818E File Offset: 0x0033638E
		internal virtual Label lblinfor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x06005942 RID: 22850 RVA: 0x00338197 File Offset: 0x00336397
		// (set) Token: 0x06005943 RID: 22851 RVA: 0x003381A1 File Offset: 0x003363A1
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x06005944 RID: 22852 RVA: 0x003381AA File Offset: 0x003363AA
		// (set) Token: 0x06005945 RID: 22853 RVA: 0x003381B4 File Offset: 0x003363B4
		internal virtual DataGridView DGVSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06005946 RID: 22854 RVA: 0x003381BD File Offset: 0x003363BD
		// (set) Token: 0x06005947 RID: 22855 RVA: 0x003381C7 File Offset: 0x003363C7
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x06005948 RID: 22856 RVA: 0x003381D0 File Offset: 0x003363D0
		// (set) Token: 0x06005949 RID: 22857 RVA: 0x003381DA File Offset: 0x003363DA
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600594A RID: 22858 RVA: 0x003381E3 File Offset: 0x003363E3
		// (set) Token: 0x0600594B RID: 22859 RVA: 0x003381ED File Offset: 0x003363ED
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600594C RID: 22860 RVA: 0x003381F6 File Offset: 0x003363F6
		// (set) Token: 0x0600594D RID: 22861 RVA: 0x00338200 File Offset: 0x00336400
		internal virtual TextBox txtsearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x00338209 File Offset: 0x00336409
		// (set) Token: 0x0600594F RID: 22863 RVA: 0x00338213 File Offset: 0x00336413
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x0033821C File Offset: 0x0033641C
		// (set) Token: 0x06005951 RID: 22865 RVA: 0x00338226 File Offset: 0x00336426
		internal virtual TextBox txtProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06005952 RID: 22866 RVA: 0x0033822F File Offset: 0x0033642F
		// (set) Token: 0x06005953 RID: 22867 RVA: 0x00338239 File Offset: 0x00336439
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x00338242 File Offset: 0x00336442
		// (set) Token: 0x06005955 RID: 22869 RVA: 0x0033824C File Offset: 0x0033644C
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x00338255 File Offset: 0x00336455
		// (set) Token: 0x06005957 RID: 22871 RVA: 0x0033825F File Offset: 0x0033645F
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06005958 RID: 22872 RVA: 0x00338268 File Offset: 0x00336468
		// (set) Token: 0x06005959 RID: 22873 RVA: 0x00338272 File Offset: 0x00336472
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x0600595A RID: 22874 RVA: 0x0033827B File Offset: 0x0033647B
		// (set) Token: 0x0600595B RID: 22875 RVA: 0x00338285 File Offset: 0x00336485
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x0033828E File Offset: 0x0033648E
		// (set) Token: 0x0600595D RID: 22877 RVA: 0x00338298 File Offset: 0x00336498
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

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x003382DB File Offset: 0x003364DB
		// (set) Token: 0x0600595F RID: 22879 RVA: 0x003382E5 File Offset: 0x003364E5
		internal virtual DateTimePicker DTdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x003382EE File Offset: 0x003364EE
		// (set) Token: 0x06005961 RID: 22881 RVA: 0x003382F8 File Offset: 0x003364F8
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06005962 RID: 22882 RVA: 0x00338301 File Offset: 0x00336501
		// (set) Token: 0x06005963 RID: 22883 RVA: 0x0033830C File Offset: 0x0033650C
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

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x0033834F File Offset: 0x0033654F
		// (set) Token: 0x06005965 RID: 22885 RVA: 0x00338359 File Offset: 0x00336559
		internal virtual OpenFileDialog OpenFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06005966 RID: 22886 RVA: 0x00338362 File Offset: 0x00336562
		// (set) Token: 0x06005967 RID: 22887 RVA: 0x0033836C File Offset: 0x0033656C
		internal virtual TextBox TextBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06005968 RID: 22888 RVA: 0x00338375 File Offset: 0x00336575
		// (set) Token: 0x06005969 RID: 22889 RVA: 0x0033837F File Offset: 0x0033657F
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600596A RID: 22890 RVA: 0x00338388 File Offset: 0x00336588
		// (set) Token: 0x0600596B RID: 22891 RVA: 0x00338394 File Offset: 0x00336594
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click_1);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600596C RID: 22892 RVA: 0x003383D7 File Offset: 0x003365D7
		// (set) Token: 0x0600596D RID: 22893 RVA: 0x003383E1 File Offset: 0x003365E1
		internal virtual DataGridView DataGridView2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x003383EA File Offset: 0x003365EA
		// (set) Token: 0x0600596F RID: 22895 RVA: 0x003383F4 File Offset: 0x003365F4
		internal virtual CheckBox chkRecordAll
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x003383FD File Offset: 0x003365FD
		// (set) Token: 0x06005971 RID: 22897 RVA: 0x00338407 File Offset: 0x00336607
		internal virtual CheckBox cboIncStockBal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06005972 RID: 22898 RVA: 0x00338410 File Offset: 0x00336610
		// (set) Token: 0x06005973 RID: 22899 RVA: 0x0033841A File Offset: 0x0033661A
		internal virtual CheckBox chkCostPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005974 RID: 22900 RVA: 0x00338424 File Offset: 0x00336624
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.ProgressBar1.Visible = true;
					this.ProgressBar1.Step = 1;
					this.ProgressBar1.Minimum = 0;
					this.ProgressBar1.Maximum = 5;
					this.ProgressBar1.Value = 1;
					this.ProgressBar1.PerformStep();
					this.ReadCSV();
					this.ProgressBar1.PerformStep();
					DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
					dataGridViewTextBoxColumn.Name = "StockBalance";
					dataGridViewTextBoxColumn.HeaderText = "Current Stock Balance";
					dataGridViewTextBoxColumn.DataPropertyName = "StockBalance";
					this.DataGridView1.Columns.Insert(2, dataGridViewTextBoxColumn);
					DataGridViewTextBoxColumn dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
					dataGridViewTextBoxColumn2.Name = "Reason";
					dataGridViewTextBoxColumn2.HeaderText = "Variance Reason";
					dataGridViewTextBoxColumn2.DataPropertyName = "Reason";
					this.DataGridView1.Columns.Insert(4, dataGridViewTextBoxColumn2);
					this.ProgressBar1.PerformStep();
					int num = 0;
					try
					{
						foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								bool flag = dataGridViewRow.Cells["ProductCode"].Value != null;
								if (flag)
								{
									string text = dataGridViewRow.Cells["ProductCode"].Value.ToString();
									string text2 = text.TrimStart(new char[] { '\'' });
									dataGridViewRow.Cells["ProductCode"].Value = text2;
								}
								dataGridViewRow.Cells["StockBalance"].Value = this.pf.GetStockBalSimpleProdCode(this._cnn, dataGridViewRow.Cells["ProductCode"].Value.ToString(), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
								bool flag2 = Operators.ConditionalCompareObjectNotEqual(Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["StockBalance"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)), Interaction.IIf(Operators.CompareString(dataGridViewRow.Cells["PhysicalBal"].Value.ToString(), "", false) == 0, 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalBal"].Value)), false);
								if (flag2)
								{
									dataGridViewRow.DefaultCellStyle.BackColor = Color.LightBlue;
								}
							}
							catch (Exception ex)
							{
								dataGridViewRow.DefaultCellStyle.BackColor = Color.OrangeRed;
								num++;
								MessageBox.Show("Row " + dataGridViewRow.Index.ToString() + " has an error: " + ex.Message);
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
					this.ProgressBar1.PerformStep();
					this.ProgressBar1.Visible = false;
					bool flag3 = num > 0;
					if (flag3)
					{
						MessageBox.Show("There are " + num.ToString() + " rows that have errors and have been marked in red. Please fix them and re-upload");
					}
				}
				catch (Exception ex2)
				{
					MessageBox.Show("Error processing. Detail: " + ex2.Message);
					this.ProgressBar1.Visible = false;
				}
			}
		}

		// Token: 0x06005975 RID: 22901 RVA: 0x00338814 File Offset: 0x00336A14
		private DataTable LoadCSVtoDataTable()
		{
			this.DataGridView1.Columns.Clear();
			this.DataGridView1.Rows.Clear();
			this.DataGridView1.Columns.Add("ProductCode", "ProductCode");
			this.DataGridView1.Columns.Add("ProductDesc", "ProductDesc");
			this.DataGridView1.Columns.Add("PhysicalBal", "PhysicalBal");
			OpenFileDialog openFileDialog = this.OpenFileDialog1;
			openFileDialog.Filter = "CSV files (*.csv)|*.csv";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Import data from CSV file";
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBox2.Text = this.OpenFileDialog1.FileName;
				string text = Path.GetFileName(this.OpenFileDialog1.FileName);
				text = text.Substring(0, text.IndexOf("."));
			}
			string[] array = File.ReadAllLines(this.TextBox2.Text);
			DataTable dataTable = new DataTable();
			int num = array.First<string>().Split(new char[] { ',' }).Length;
			int num2 = num;
			checked
			{
				for (int i = 1; i <= num2; i++)
				{
					dataTable.Columns.Add(new DataColumn("Column_" + Conversions.ToString(i), typeof(string)));
				}
				foreach (string text2 in array)
				{
					IEnumerable<object> enumerable = text2.Split(new char[] { ',' }).Select<string, object>((StockTakeExcel._Closure$__.$I121-0 == null) ? (StockTakeExcel._Closure$__.$I121-0 = (string field) => Conversion.Str(field)) : StockTakeExcel._Closure$__.$I121-0);
					DataRow dataRow = dataTable.Rows.Add(new object[0]);
					dataRow.ItemArray = enumerable.ToArray<object>();
				}
				return dataTable;
			}
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00338A10 File Offset: 0x00336C10
		private void LoadStockGrid()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from tempStockTakeExcel";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.DataGridView1.DataSource = dataTable;
			this.DataGridView1.Columns["systembal"].ReadOnly = true;
			this.DataGridView1.Columns["productdescSYS"].ReadOnly = true;
			this.DataGridView1.Columns["productcode"].ReadOnly = true;
			this.DataGridView1.Columns["productdesc"].ReadOnly = true;
			this.DataGridView1.Columns["Variance"].ReadOnly = true;
			this.DataGridView1.Columns["productdesc"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["productdescSYS"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["productcode"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["systembal"].DefaultCellStyle.BackColor = Color.LightGray;
			this.DataGridView1.Columns["Variance"].DefaultCellStyle.BackColor = Color.LightGray;
			try
			{
				foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = !dataGridViewRow.IsNewRow;
					if (flag)
					{
						DataTable dataTable2 = new DataTable();
						dataTable2 = this.pf.GetStockBalProductCode(Conversions.ToString(dataGridViewRow.Cells["productcode"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.isRestaurant, this._cnn);
						DataRow dataRow = dataTable2.Rows[0];
						dataGridViewRow.Cells["productdescSYS"].Value = RuntimeHelpers.GetObjectValue(dataRow["productdesc"]);
						dataGridViewRow.Cells["systembal"].Value = RuntimeHelpers.GetObjectValue(dataRow["productbal"]);
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["productdescSYS"].Value, "", false);
						if (flag2)
						{
							dataGridViewRow.DefaultCellStyle.BackColor = Color.PaleVioletRed;
							dataGridViewRow.Cells["Variance"].Value = "PRODUCT NOT FOUND";
						}
						else
						{
							bool flag3 = Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(dataGridViewRow.Cells["systembal"].Value, dataGridViewRow.Cells["physicalbal"].Value), 0, false);
							if (flag3)
							{
								dataGridViewRow.Cells["Variance"].Value = "REDUCED";
							}
							else
							{
								bool flag4 = Operators.ConditionalCompareObjectLess(Operators.SubtractObject(dataGridViewRow.Cells["systembal"].Value, dataGridViewRow.Cells["physicalbal"].Value), 0, false);
								if (flag4)
								{
									dataGridViewRow.Cells["Variance"].Value = "INCREASED";
								}
								else
								{
									bool flag5 = Operators.ConditionalCompareObjectEqual(Operators.SubtractObject(dataGridViewRow.Cells["systembal"].Value, dataGridViewRow.Cells["physicalbal"].Value), 0, false);
									if (flag5)
									{
										dataGridViewRow.Cells["Variance"].Value = "NO CHANGE";
									}
								}
							}
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
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00338E74 File Offset: 0x00337074
		private void ReadCSV()
		{
			this.DataGridView1.Columns.Clear();
			this.DataGridView1.Rows.Clear();
			this.DataGridView1.Columns.Add("ProductCode", "ProductCode");
			this.DataGridView1.Columns.Add("ProductDesc", "ProductDesc");
			this.DataGridView1.Columns.Add("PhysicalBal", "PhysicalBal");
			OpenFileDialog openFileDialog = this.OpenFileDialog1;
			openFileDialog.Filter = "CSV files (*.csv)|*.csv";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Import data from CSV file";
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBox2.Text = this.OpenFileDialog1.FileName;
			}
			string text = this.TextBox2.Text;
			bool flag2 = File.Exists(text);
			checked
			{
				if (flag2)
				{
					using (TextFieldParser textFieldParser = new TextFieldParser(text, Encoding.ASCII))
					{
						textFieldParser.TextFieldType = FieldType.Delimited;
						textFieldParser.SetDelimiters(new string[] { "," });
						textFieldParser.HasFieldsEnclosedInQuotes = true;
						int num = 0;
						while (!textFieldParser.EndOfData)
						{
							string[] array = textFieldParser.ReadFields();
							bool flag3 = num != 0;
							if (flag3)
							{
								this.DataGridView1.Rows.Add(array);
							}
							num++;
						}
					}
				}
				else
				{
					Interaction.MsgBox("File Does Not Exist", MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00339014 File Offset: 0x00337214
		private void loadstocktake()
		{
			this.dt.Columns.Clear();
			this.dt.Clear();
			OleDbCommand oleDbCommand = new OleDbCommand();
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter();
			OpenFileDialog openFileDialog = this.OpenFileDialog1;
			openFileDialog.Filter = "CSV files (*.csv)|*.csv";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Import data from CSV file";
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.TextBox2.Text = this.OpenFileDialog1.FileName;
				string text = Path.GetFileName(this.OpenFileDialog1.FileName);
				text = text.Substring(0, text.IndexOf("."));
				OleDbConnection oleDbConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + this.TextBox2.Text + " ; Extended Properties=Excel 8.0;");
				oleDbConnection.Open();
				OleDbCommand oleDbCommand2 = oleDbCommand;
				oleDbCommand2.Connection = oleDbConnection;
				oleDbCommand2.CommandText = "select * from [" + text + "$]";
				oleDbDataAdapter.SelectCommand = oleDbCommand;
				oleDbDataAdapter.Fill(this.dt);
				this.dt.Columns[0].ColumnName = "ProductCode";
				this.dt.Columns[1].ColumnName = "ProductDesc";
				this.dt.Columns[2].ColumnName = "PhysicalBal";
			}
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00339188 File Offset: 0x00337388
		private void Button4_Click(object sender, EventArgs e)
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

		// Token: 0x0600597A RID: 22906 RVA: 0x00339240 File Offset: 0x00337440
		private void Button4_Click_1(object sender, EventArgs e)
		{
			try
			{
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.datSelectedCategories = dataTable;
				SelectCategories selectCategories = new SelectCategories();
				selectCategories.ShowDialog(this);
				selectCategories.Dispose();
				bool flag = MyProject.Forms.Form1.datSelectedCategoriesStockTake.Rows.Count > 0;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					using (sqlConnection)
					{
						SqlCommand sqlCommand = new SqlCommand("SelectAllProductByCatExcel", sqlConnection);
						sqlCommand.CommandType = CommandType.StoredProcedure;
						sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
						sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
						bool @checked = this.cboIncStockBal.Checked;
						if (@checked)
						{
							sqlCommand.Parameters.AddWithValue("inclstockbal", 1);
						}
						else
						{
							sqlCommand.Parameters.AddWithValue("inclstockbal", 0);
						}
						bool checked2 = this.chkCostPrice.Checked;
						if (checked2)
						{
							sqlCommand.Parameters.AddWithValue("inclcostprice", 1);
						}
						else
						{
							sqlCommand.Parameters.AddWithValue("inclcostprice", 0);
						}
						SqlParameter sqlParameter = sqlCommand.Parameters.AddWithValue("@tvpSelectedCategories", MyProject.Forms.Form1.datSelectedCategoriesStockTake);
						sqlParameter.SqlDbType = SqlDbType.Structured;
						DataTable dataTable2 = new DataTable();
						SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
						sqlDataAdapter.Fill(dataTable2);
						this.DataGridView2.DataSource = dataTable2;
						this.SaveFileDialog1.Filter = "CSV Files (*.csv*)|*.csv";
						bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
						if (flag2)
						{
							this.pf.DATAGRIDVIEW_TO_EXCEL_From_DGV_ForStockTake(this.DataGridView2, this.SaveFileDialog1.FileName, "Sheet1");
						}
					}
				}
				else
				{
					MessageBox.Show("Please select the categories first.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying");
			}
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x003394A8 File Offset: 0x003376A8
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.ProgressBar1.Visible = true;
					this.ProgressBar1.Step = 1;
					this.ProgressBar1.Minimum = 0;
					this.ProgressBar1.Maximum = 20;
					this.ProgressBar1.Value = 1;
					using (SqlConnection sqlConnection = new SqlConnection(this._cnn))
					{
						SqlCommand sqlCommand = sqlConnection.CreateCommand();
						sqlCommand.Connection = sqlConnection;
						sqlConnection.Open();
						using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunSaveExcelUploads"))
						{
							sqlCommand.Transaction = sqlTransaction;
							int nextInvNumStockTake = this.pf.GetNextInvNumStockTake(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
							int num = (int)Math.Round(Conversion.Val(DateAndTime.TimeOfDay.ToString("HHmm")));
							try
							{
								foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
									int num2;
									num2++;
									bool isNewRow = dataGridViewRow.IsNewRow;
									if (isNewRow)
									{
										break;
									}
									bool flag = dataGridViewRow.Cells["ProductCode"].Value != null;
									if (flag)
									{
										string text = dataGridViewRow.Cells["ProductCode"].Value.ToString();
										string text2 = text.TrimStart(new char[] { '\'' });
										dataGridViewRow.Cells["ProductCode"].Value = text2;
									}
									bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductCode"].Value));
									if (flag2)
									{
										break;
									}
									decimal num3 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["StockBalance"].Value))));
									bool flag3 = Operators.CompareString(dataGridViewRow.Cells["PhysicalBal"].Value.ToString(), "", false) == 0;
									decimal num4;
									if (flag3)
									{
										num4 = 0m;
									}
									else
									{
										num4 = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalBal"].Value)), 0, RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["PhysicalBal"].Value))));
									}
									bool flag4 = decimal.Compare(num3, num4) > 0;
									if (flag4)
									{
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "InsertNewSaleStockTake";
										sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
										sqlCommand.Parameters.AddWithValue("productid", this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn));
										sqlCommand.Parameters.AddWithValue("isstockin", 0);
										sqlCommand.Parameters.AddWithValue("ref", "STOCK REDUCED");
										sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num3, num4));
										sqlCommand.Parameters.AddWithValue("unitcost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn), this._cnn)));
										sqlCommand.Parameters.AddWithValue("salesprice", 0);
										sqlCommand.Parameters.AddWithValue("paymentmethod", 0);
										sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
										sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
										sqlCommand.Parameters.AddWithValue("trancode", 2);
										sqlCommand.Parameters.AddWithValue("TranTime", num);
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
										bool flag5 = dataGridViewRow.Cells[4].Value == null;
										string text3;
										if (flag5)
										{
											text3 = "";
										}
										else
										{
											text3 = dataGridViewRow.Cells[4].Value.ToString();
										}
										sqlCommand.Parameters.AddWithValue("details", text3);
										sqlCommand.Parameters.AddWithValue("stockbal", num3);
										sqlCommand.ExecuteNonQuery();
									}
									else
									{
										bool flag6 = decimal.Compare(num3, num4) < 0;
										if (flag6)
										{
											sqlCommand.Parameters.Clear();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "InsertNewStockStockTake";
											sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
											sqlCommand.Parameters.AddWithValue("productid", this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn));
											sqlCommand.Parameters.AddWithValue("isstockin", 1);
											sqlCommand.Parameters.AddWithValue("ref", "STOCK INCREASED");
											sqlCommand.Parameters.AddWithValue("quantity", decimal.Subtract(num4, num3));
											sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn), this._cnn)));
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand.Parameters.AddWithValue("trancode", 2);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											bool flag7 = dataGridViewRow.Cells[4].Value == null;
											string text4;
											if (flag7)
											{
												text4 = "";
											}
											else
											{
												text4 = dataGridViewRow.Cells[4].Value.ToString();
											}
											sqlCommand.Parameters.AddWithValue("details", text4);
											sqlCommand.Parameters.AddWithValue("stockbal", num3);
											sqlCommand.ExecuteNonQuery();
										}
										else
										{
											num3 = num4;
											bool flag8 = this.chkRecordAll.Checked | !this.firstbalrun;
											if (flag8)
											{
												sqlCommand.Parameters.Clear();
												sqlCommand.CommandType = CommandType.StoredProcedure;
												sqlCommand.CommandText = "InsertNewStockStockTake";
												sqlCommand.Parameters.AddWithValue("trandate", this.DTdate.Value.ToString("yyyyMMdd"));
												sqlCommand.Parameters.AddWithValue("invoicenum", nextInvNumStockTake);
												sqlCommand.Parameters.AddWithValue("productid", this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn));
												sqlCommand.Parameters.AddWithValue("isstockin", 1);
												sqlCommand.Parameters.AddWithValue("ref", "STOCK MAINTAINED");
												sqlCommand.Parameters.AddWithValue("quantity", 0);
												sqlCommand.Parameters.AddWithValue("cost", RuntimeHelpers.GetObjectValue(this.pf.GetProdCost(this.pf.GetProductIDFromCode(MyProject.Forms.Form1.coid, Conversions.ToString(dataGridViewRow.Cells["ProductCode"].Value), this._cnn), this._cnn)));
												sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
												sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
												sqlCommand.Parameters.AddWithValue("trancode", 2);
												sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
												sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
												bool flag9 = dataGridViewRow.Cells[4].Value == null;
												string text5;
												if (flag9)
												{
													text5 = "";
												}
												else
												{
													text5 = dataGridViewRow.Cells[4].Value.ToString();
												}
												sqlCommand.Parameters.AddWithValue("details", text5);
												sqlCommand.Parameters.AddWithValue("stockbal", num3);
												sqlCommand.ExecuteNonQuery();
											}
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
							sqlTransaction.Commit();
							sqlConnection.Close();
							this.ProgressBar1.Visible = false;
						}
					}
					MessageBox.Show("Stock take done successfully.");
				}
				catch (Exception ex)
				{
					int num2;
					MessageBox.Show("Error processing. Detail:  row:" + num2.ToString() + ex.Message);
					this.ProgressBar1.Visible = false;
				}
			}
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x0033A038 File Offset: 0x00338238
		private void StockTakeExcel_Load(object sender, EventArgs e)
		{
			try
			{
				this.firstbalrun = this.pf.CheckIfFirstBalRun(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0400270B RID: 9995
		private string _cnn;

		// Token: 0x0400270C RID: 9996
		private DataTable dt;

		// Token: 0x0400270D RID: 9997
		private PublicFunctions pf;

		// Token: 0x0400270E RID: 9998
		private bool firstbalrun;
	}
}
