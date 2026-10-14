using System;
using System.Collections;
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
	// Token: 0x02000051 RID: 81
	[DesignerGenerated]
	public partial class EditShiftDetail : Form
	{
		// Token: 0x0600118C RID: 4492 RVA: 0x000A9250 File Offset: 0x000A7450
		public EditShiftDetail()
		{
			base.Load += this.EditShiftDetail_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x000A96B6 File Offset: 0x000A78B6
		// (set) Token: 0x06001190 RID: 4496 RVA: 0x000A96C0 File Offset: 0x000A78C0
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000A96C9 File Offset: 0x000A78C9
		// (set) Token: 0x06001192 RID: 4498 RVA: 0x000A96D3 File Offset: 0x000A78D3
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000A96DC File Offset: 0x000A78DC
		// (set) Token: 0x06001194 RID: 4500 RVA: 0x000A96E8 File Offset: 0x000A78E8
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

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x000A972B File Offset: 0x000A792B
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x000A9738 File Offset: 0x000A7938
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

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x000A977B File Offset: 0x000A797B
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x000A9785 File Offset: 0x000A7985
		internal virtual DateTimePicker DTShiftDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x000A978E File Offset: 0x000A798E
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x000A9798 File Offset: 0x000A7998
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00002A30 File Offset: 0x00000C30
		private void EditShiftDetail_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000A97A4 File Offset: 0x000A79A4
		private void LoadShifts(int shiftdate)
		{
			this.DataGridView1.Columns.Clear();
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchShiftsForDay";
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DataGridView1.DataSource = dataTable;
				this.DataGridView1.Columns["coid"].Visible = false;
				this.DataGridView1.Columns["ShiftDate"].HeaderText = "Shift Date";
				this.DataGridView1.Columns["ShiftUser"].HeaderText = "Username";
				this.DataGridView1.Columns["ShiftName"].HeaderText = "Shift Name";
				this.DataGridView1.Columns["StartTime"].HeaderText = "Start Time";
				this.DataGridView1.Columns["EndTime"].HeaderText = "End Time";
				this.DataGridView1.Columns["IsClosed"].Visible = false;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DataGridView1.Columns.Add("IsClosedDesc", "Status");
				DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
				dataGridViewCheckBoxColumn.HeaderText = "Open Shift";
				dataGridViewCheckBoxColumn.Name = "CHKcol";
				dataGridViewCheckBoxColumn.DataPropertyName = "CHKcol";
				dataGridViewCheckBoxColumn.CellTemplate = new DataGridViewCheckBoxCell();
				this.DataGridView1.Columns.Insert(9, dataGridViewCheckBoxColumn);
				try
				{
					foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["IsClosed"].Value, true, false);
						if (flag2)
						{
							dataGridViewRow.Cells["IsClosedDesc"].Value = "Closed";
						}
						else
						{
							dataGridViewRow.Cells["IsClosedDesc"].Value = "Open";
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
			else
			{
				MessageBox.Show("There are no shifts for the selected shift date.");
			}
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000A9A7C File Offset: 0x000A7C7C
		private void OpenShift(int shiftdate, string shiftname, string shiftuser, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "OpenShift";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("shiftdate", shiftdate);
			sqlCommand.Parameters.AddWithValue("shiftuser", shiftuser);
			sqlCommand.Parameters.AddWithValue("shiftname", shiftname);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000A9B3C File Offset: 0x000A7D3C
		private void Button2_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = this.DataGridView1.Rows.Count > 0;
					if (flag)
					{
						int num = 0;
						try
						{
							foreach (object obj in ((IEnumerable)this.DataGridView1.Rows))
							{
								DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
								bool flag2 = Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells["CHKcol"].Value, true, false);
								if (flag2)
								{
									this.OpenShift((int)Math.Round(Conversion.Val(this.DTShiftDate.Value.ToString("yyyyMMdd"))), dataGridViewRow.Cells["ShiftName"].Value.ToString(), dataGridViewRow.Cells["ShiftUser"].Value.ToString(), MyProject.Forms.Form1.coid);
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
						MessageBox.Show(num.ToString() + " shifts opened.");
						this.LoadShifts((int)Math.Round(Conversion.Val(this.DTShiftDate.Value.ToString("yyyyMMdd"))));
					}
					else
					{
						MessageBox.Show("Please select a shift date and press View Shifts first.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error opening shift. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000A9CFC File Offset: 0x000A7EFC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadShifts(checked((int)Math.Round(Conversion.Val(this.DTShiftDate.Value.ToString("yyyyMMdd")))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading shifts. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000847 RID: 2119
		private string _cnn;
	}
}
