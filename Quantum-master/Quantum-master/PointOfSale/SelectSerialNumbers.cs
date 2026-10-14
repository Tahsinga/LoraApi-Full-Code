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
	// Token: 0x020001BB RID: 443
	[DesignerGenerated]
	public partial class SelectSerialNumbers : Form
	{
		// Token: 0x0600500C RID: 20492 RVA: 0x002FC99C File Offset: 0x002FAB9C
		public SelectSerialNumbers()
		{
			base.Load += this.SelectSerialNumbers_Load;
			this.numofproducts = 0;
			this.productdesc = "";
			this.productid = 0;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600500F RID: 20495 RVA: 0x002FD1F9 File Offset: 0x002FB3F9
		// (set) Token: 0x06005010 RID: 20496 RVA: 0x002FD203 File Offset: 0x002FB403
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06005011 RID: 20497 RVA: 0x002FD20C File Offset: 0x002FB40C
		// (set) Token: 0x06005012 RID: 20498 RVA: 0x002FD218 File Offset: 0x002FB418
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

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06005013 RID: 20499 RVA: 0x002FD25B File Offset: 0x002FB45B
		// (set) Token: 0x06005014 RID: 20500 RVA: 0x002FD265 File Offset: 0x002FB465
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06005015 RID: 20501 RVA: 0x002FD26E File Offset: 0x002FB46E
		// (set) Token: 0x06005016 RID: 20502 RVA: 0x002FD278 File Offset: 0x002FB478
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06005017 RID: 20503 RVA: 0x002FD281 File Offset: 0x002FB481
		// (set) Token: 0x06005018 RID: 20504 RVA: 0x002FD28B File Offset: 0x002FB48B
		internal virtual TextBox TXTDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x002FD294 File Offset: 0x002FB494
		// (set) Token: 0x0600501A RID: 20506 RVA: 0x002FD29E File Offset: 0x002FB49E
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x002FD2A7 File Offset: 0x002FB4A7
		// (set) Token: 0x0600501C RID: 20508 RVA: 0x002FD2B1 File Offset: 0x002FB4B1
		internal virtual DataGridView dgvSerials
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x002FD2BA File Offset: 0x002FB4BA
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x002FD2C4 File Offset: 0x002FB4C4
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x002FD2CD File Offset: 0x002FB4CD
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x002FD2D8 File Offset: 0x002FB4D8
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

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x002FD31B File Offset: 0x002FB51B
		// (set) Token: 0x06005022 RID: 20514 RVA: 0x002FD325 File Offset: 0x002FB525
		internal virtual TextBox txtSearch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x002FD32E File Offset: 0x002FB52E
		// (set) Token: 0x06005024 RID: 20516 RVA: 0x002FD338 File Offset: 0x002FB538
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x06005025 RID: 20517 RVA: 0x002FD341 File Offset: 0x002FB541
		// (set) Token: 0x06005026 RID: 20518 RVA: 0x002FD34B File Offset: 0x002FB54B
		internal virtual Label lblNumOfSerials
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x002FD354 File Offset: 0x002FB554
		private void SelectSerialNumbers_Load(object sender, EventArgs e)
		{
			try
			{
				this.Text = "Select " + MyProject.Forms.Form1.serialNumberName + " being sold now";
				this.Label2.Text = "SELECT " + MyProject.Forms.Form1.serialNumberName + " BEING SOLD";
				this.Text = "Select " + MyProject.Forms.Form1.serialNumberName;
				this.Label3.Text = "Number of " + MyProject.Forms.Form1.serialNumberName + " required is " + Conversions.ToString(this.numofproducts);
				this.TXTDESC.Text = this.productdesc;
				this.loadSerials();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x002FD458 File Offset: 0x002FB658
		private void loadSerials()
		{
			this.dgvSerials.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select entryno,serialnumber,productid from SerialNumbers where productid=",
				Conversions.ToString(this.productid),
				" and coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and branch='",
				MyProject.Forms.Form1.branch,
				"' and [status]=0"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			this.dgvSerials.DataSource = dataTable;
			this.dgvSerials.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSerials.Columns["productid"].Visible = false;
			DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			dataGridViewCheckBoxColumn.Name = "Select";
			dataGridViewCheckBoxColumn.HeaderText = "Select";
			this.dgvSerials.Columns.Add(dataGridViewCheckBoxColumn);
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x002FD57C File Offset: 0x002FB77C
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					int num = 0;
					DataTable dataTable = new DataTable();
					dataTable.Columns.Add("EntryNo", typeof(int));
					dataTable.Columns.Add("SerialNumber", typeof(string));
					dataTable.Columns.Add("ProductID", typeof(string));
					try
					{
						foreach (object obj in ((IEnumerable)this.dgvSerials.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							bool flag = Conversions.ToBoolean(dataGridViewRow.Cells["Select"].Value);
							bool flag2 = flag;
							if (flag2)
							{
								DataRow dataRow = dataTable.NewRow();
								dataRow["EntryNo"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Entryno"].Value);
								dataRow["SerialNumber"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["SerialNumber"].Value);
								dataRow["ProductID"] = RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["ProductID"].Value);
								dataTable.Rows.Add(dataRow);
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
					bool flag3 = num == this.numofproducts;
					if (flag3)
					{
						MyProject.Forms.Form1.datSerialsSelect4Sales = dataTable;
						MessageBox.Show("Serial Numbers selected.");
						base.Dispose();
					}
					else
					{
						MessageBox.Show("Please select the correct number of serial numbers");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error processing. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x002FD784 File Offset: 0x002FB984
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.Search();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x002FD7D4 File Offset: 0x002FB9D4
		private void Search()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvSerials.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					bool flag = Operators.CompareString(dataGridViewRow.Cells["SerialNumber"].Value.ToString(), this.txtSearch.Text, false) == 0;
					if (flag)
					{
						dataGridViewRow.DefaultCellStyle.BackColor = Color.Blue;
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

		// Token: 0x040023CB RID: 9163
		public int numofproducts;

		// Token: 0x040023CC RID: 9164
		public string productdesc;

		// Token: 0x040023CD RID: 9165
		public int productid;

		// Token: 0x040023CE RID: 9166
		private PublicFunctions pf;

		// Token: 0x040023CF RID: 9167
		private string _cnn;
	}
}
