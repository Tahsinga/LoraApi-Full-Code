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
	// Token: 0x020001BC RID: 444
	[DesignerGenerated]
	public partial class SelectTable : Form
	{
		// Token: 0x0600502C RID: 20524 RVA: 0x002FD878 File Offset: 0x002FBA78
		public SelectTable()
		{
			base.Load += this.SelectTable_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x0600502F RID: 20527 RVA: 0x002FE170 File Offset: 0x002FC370
		// (set) Token: 0x06005030 RID: 20528 RVA: 0x002FE17A File Offset: 0x002FC37A
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x06005031 RID: 20529 RVA: 0x002FE183 File Offset: 0x002FC383
		// (set) Token: 0x06005032 RID: 20530 RVA: 0x002FE190 File Offset: 0x002FC390
		internal virtual GroupBox GroupBox2
		{
			[CompilerGenerated]
			get
			{
				return this._GroupBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.GroupBox2_Enter);
				GroupBox groupBox = this._GroupBox2;
				if (groupBox != null)
				{
					groupBox.Enter -= eventHandler;
				}
				this._GroupBox2 = value;
				groupBox = this._GroupBox2;
				if (groupBox != null)
				{
					groupBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x06005033 RID: 20531 RVA: 0x002FE1D3 File Offset: 0x002FC3D3
		// (set) Token: 0x06005034 RID: 20532 RVA: 0x002FE1DD File Offset: 0x002FC3DD
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x06005035 RID: 20533 RVA: 0x002FE1E6 File Offset: 0x002FC3E6
		// (set) Token: 0x06005036 RID: 20534 RVA: 0x002FE1F0 File Offset: 0x002FC3F0
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06005037 RID: 20535 RVA: 0x002FE1F9 File Offset: 0x002FC3F9
		// (set) Token: 0x06005038 RID: 20536 RVA: 0x002FE203 File Offset: 0x002FC403
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06005039 RID: 20537 RVA: 0x002FE20C File Offset: 0x002FC40C
		// (set) Token: 0x0600503A RID: 20538 RVA: 0x002FE216 File Offset: 0x002FC416
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600503B RID: 20539 RVA: 0x002FE21F File Offset: 0x002FC41F
		// (set) Token: 0x0600503C RID: 20540 RVA: 0x002FE229 File Offset: 0x002FC429
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x0600503D RID: 20541 RVA: 0x002FE232 File Offset: 0x002FC432
		// (set) Token: 0x0600503E RID: 20542 RVA: 0x002FE23C File Offset: 0x002FC43C
		internal virtual Label lblCurrentTable
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x0600503F RID: 20543 RVA: 0x002FE245 File Offset: 0x002FC445
		// (set) Token: 0x06005040 RID: 20544 RVA: 0x002FE24F File Offset: 0x002FC44F
		internal virtual Panel GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x002FE258 File Offset: 0x002FC458
		// (set) Token: 0x06005042 RID: 20546 RVA: 0x002FE262 File Offset: 0x002FC462
		internal virtual Label lblCurrTableDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x002FE26B File Offset: 0x002FC46B
		// (set) Token: 0x06005044 RID: 20548 RVA: 0x002FE278 File Offset: 0x002FC478
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
				EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
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

		// Token: 0x06005045 RID: 20549 RVA: 0x002FE2BC File Offset: 0x002FC4BC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.lblCurrentTable.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x002FE330 File Offset: 0x002FC530
		private void SelectTable_Load(object sender, EventArgs e)
		{
			try
			{
				base.WindowState = FormWindowState.Maximized;
				this.GetFreeTables();
				this.GetUserTables();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading tables form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x002FE390 File Offset: 0x002FC590
		private void GetUserTables()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TablesGetUserTables";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("user", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			int num2 = 1;
			int num3 = 60;
			int num4 = 90;
			int num5 = 5;
			int num6 = 35;
			checked
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Button button = new Button();
						button.BackColor = Color.LightYellow;
						bool flag = num2 == 1;
						if (flag)
						{
							button.Text = Conversions.ToString(Operators.ConcatenateObject(dataRow["TableNumber"].ToString() + ": ", dataRow["TableDescription"]));
							button.Name = Conversions.ToString(dataRow["TableNumber"]);
							button.Location = new Point(num5, num6);
							num5 = num5 + num4 + 20;
							button.Height = num3;
							button.Width = num4;
							this.GroupBox2.Controls.Add(button);
							button.Click += this.Button_Click;
							num2++;
						}
						else
						{
							button.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["TableNumber"], ": "), dataRow["TableDescription"]));
							button.Name = Conversions.ToString(dataRow["TableNumber"]);
							button.Location = new Point(num5, num6);
							bool flag2 = num2 % 3 == 0;
							if (flag2)
							{
								num6 = num6 + num3 + 20;
								num5 = 5;
								button.Height = num3;
								button.Width = num4;
							}
							else
							{
								num5 = num5 + num4 + 20;
								button.Height = num3;
								button.Width = num4;
							}
							this.GroupBox2.Controls.Add(button);
							button.Click += this.Button_Click;
							num2++;
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
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x002FE678 File Offset: 0x002FC878
		private void Button_Click(object sender, EventArgs e)
		{
			try
			{
				Button button = (Button)sender;
				this.lblCurrentTable.Text = button.Text;
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading category products. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x002FE6E0 File Offset: 0x002FC8E0
		private void GetFreeTables()
		{
			this.GroupBox4.Controls.Clear();
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TablesGetFreeTables";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			int num2 = 1;
			int num3 = 60;
			int num4 = 90;
			int num5 = 5;
			int num6 = 35;
			checked
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						Button button = new Button();
						button.BackColor = Color.LightYellow;
						bool flag = num2 == 1;
						if (flag)
						{
							button.Text = Conversions.ToString(Operators.ConcatenateObject(dataRow["TableNumber"].ToString() + ": ", dataRow["TableDescription"]));
							button.Name = Conversions.ToString(dataRow["TableNumber"]);
							button.Location = new Point(num5, num6);
							num5 = num5 + num4 + 20;
							button.Height = num3;
							button.Width = num4;
							this.GroupBox4.Controls.Add(button);
							button.Click += this.Button_Click;
							num2++;
						}
						else
						{
							button.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["TableNumber"], ": "), dataRow["TableDescription"]));
							button.Name = Conversions.ToString(dataRow["TableNumber"]);
							button.Location = new Point(num5, num6);
							bool flag2 = num2 % 5 == 0;
							if (flag2)
							{
								num6 = num6 + num3 + 20;
								num5 = 5;
								button.Height = num3;
								button.Width = num4;
							}
							else
							{
								num5 = num5 + num4 + 20;
								button.Height = num3;
								button.Width = num4;
							}
							this.GroupBox4.Controls.Add(button);
							button.Click += this.Button_Click;
							num2++;
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
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00002A30 File Offset: 0x00000C30
		private void GroupBox2_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x002FE9B8 File Offset: 0x002FCBB8
		private void Button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.GroupBox4.Controls.Count > 0) & (!MyProject.Forms.Form1.IsAdmin | !MyProject.Forms.Form1.IsSupervisor);
				if (flag)
				{
					MessageBox.Show("Please select an existing free table. There is no need to create a new one.");
				}
				else
				{
					string userInput = this.pf.GetUserInput("Enter name of table.", "New Table Creation", "new");
					SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.CommandText = string.Concat(new string[]
					{
						"insert into [Tables] (TableDescription, coid, branch, isfree) values (' ",
						Strings.Trim(userInput),
						" ',",
						Conversions.ToString(MyProject.Forms.Form1.coid),
						",'",
						MyProject.Forms.Form1.branch,
						"',1)"
					});
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					this.GetFreeTables();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading create table. Detail: " + ex.Message);
			}
		}

		// Token: 0x040023DC RID: 9180
		private PublicFunctions pf;
	}
}
