using System;
using System.Collections;
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
	// Token: 0x020001B8 RID: 440
	[DesignerGenerated]
	public partial class SelectCategories : Form
	{
		// Token: 0x06004FCF RID: 20431 RVA: 0x002FAB78 File Offset: 0x002F8D78
		public SelectCategories()
		{
			base.Load += this.SelectCategories_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06004FD2 RID: 20434 RVA: 0x002FAF5C File Offset: 0x002F915C
		// (set) Token: 0x06004FD3 RID: 20435 RVA: 0x002FAF66 File Offset: 0x002F9166
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06004FD4 RID: 20436 RVA: 0x002FAF6F File Offset: 0x002F916F
		// (set) Token: 0x06004FD5 RID: 20437 RVA: 0x002FAF7C File Offset: 0x002F917C
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

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x002FAFBF File Offset: 0x002F91BF
		// (set) Token: 0x06004FD7 RID: 20439 RVA: 0x002FAFC9 File Offset: 0x002F91C9
		internal virtual DataGridView dgvCategories
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x002FAFD2 File Offset: 0x002F91D2
		// (set) Token: 0x06004FD9 RID: 20441 RVA: 0x002FAFDC File Offset: 0x002F91DC
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

		// Token: 0x06004FDA RID: 20442 RVA: 0x002FB020 File Offset: 0x002F9220
		private void SelectCategories_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				DataTable dataTable = new DataTable();
				MyProject.Forms.Form1.datSelectedCategories = dataTable;
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchCategories";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable2 = new DataTable();
				sqlDataAdapter.Fill(dataTable2);
				dataTable2.Columns.Add("select_category", typeof(bool));
				this.dgvCategories.AutoGenerateColumns = true;
				this.dgvCategories.DataSource = dataTable2;
				this.dgvCategories.Columns["pic"].Visible = false;
				this.dgvCategories.Columns["Uploaded"].Visible = false;
				this.dgvCategories.Columns["coid"].Visible = false;
				this.dgvCategories.Columns["kdu"].Visible = false;
				this.dgvCategories.Columns["CatID"].DefaultCellStyle.BackColor = Color.Gray;
				this.dgvCategories.Columns["CatID"].ReadOnly = true;
				this.dgvCategories.Columns["CatDesc"].DefaultCellStyle.BackColor = Color.Gray;
				this.dgvCategories.Columns["CatDesc"].ReadOnly = true;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvCategories.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue, null, "Cells", new object[] { "select_category" }, null, null, null), null, "Value", new object[] { true }, null, null, false, true);
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
			catch (Exception ex)
			{
				MessageBox.Show("Error laoding branches. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x002FB2C0 File Offset: 0x002F94C0
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("Category", typeof(int));
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvCategories.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["select_category"].Value, true, false);
							if (flag)
							{
								dataTable.Rows.Add(new object[] { dataGridViewRow.Cells["CatID"].Value });
								num++;
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
					bool flag2 = num == 0;
					if (flag2)
					{
						MessageBox.Show("NO categories selected.");
						MyProject.Forms.Form1.datSelectedCategories = dataTable;
						this.SelectedCategoriesForStockTake();
						base.Dispose();
					}
					else
					{
						MyProject.Forms.Form1.datSelectedCategories = dataTable;
						this.SelectedCategoriesForStockTake();
						base.Dispose();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error selecting branches. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x002FB440 File Offset: 0x002F9640
		private void SelectedCategoriesForStockTake()
		{
			int num = 0;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("catid", typeof(int));
			dataTable.Columns.Add("coid", typeof(int));
			dataTable.Columns.Add("branch", typeof(string));
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvCategories.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["select_category"].Value, true, false);
						if (flag)
						{
							dataTable.Rows.Add(new object[]
							{
								dataGridViewRow.Cells["CatID"].Value,
								MyProject.Forms.Form1.coid,
								MyProject.Forms.Form1.branch
							});
							num++;
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
				MyProject.Forms.Form1.datSelectedCategoriesStockTake = dataTable;
			}
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x002FB590 File Offset: 0x002F9790
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvCategories.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						dataGridViewRow.Cells["select_category"].Value = true;
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
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400239F RID: 9119
		private string _cnn;
	}
}
