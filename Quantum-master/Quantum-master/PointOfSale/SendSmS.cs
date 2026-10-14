using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x020001BE RID: 446
	[DesignerGenerated]
	public partial class SendSmS : Form
	{
		// Token: 0x0600505B RID: 20571 RVA: 0x002FF160 File Offset: 0x002FD360
		public SendSmS()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x0600505E RID: 20574 RVA: 0x002FF96B File Offset: 0x002FDB6B
		// (set) Token: 0x0600505F RID: 20575 RVA: 0x002FF975 File Offset: 0x002FDB75
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06005060 RID: 20576 RVA: 0x002FF97E File Offset: 0x002FDB7E
		// (set) Token: 0x06005061 RID: 20577 RVA: 0x002FF988 File Offset: 0x002FDB88
		internal virtual DataGridView dgvCustomers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x06005062 RID: 20578 RVA: 0x002FF991 File Offset: 0x002FDB91
		// (set) Token: 0x06005063 RID: 20579 RVA: 0x002FF99B File Offset: 0x002FDB9B
		internal virtual Label lblwordcount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x002FF9A4 File Offset: 0x002FDBA4
		// (set) Token: 0x06005065 RID: 20581 RVA: 0x002FF9B0 File Offset: 0x002FDBB0
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
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
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

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x06005066 RID: 20582 RVA: 0x002FF9F3 File Offset: 0x002FDBF3
		// (set) Token: 0x06005067 RID: 20583 RVA: 0x002FFA00 File Offset: 0x002FDC00
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x002FFA43 File Offset: 0x002FDC43
		// (set) Token: 0x06005069 RID: 20585 RVA: 0x002FFA4D File Offset: 0x002FDC4D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x0600506A RID: 20586 RVA: 0x002FFA56 File Offset: 0x002FDC56
		// (set) Token: 0x0600506B RID: 20587 RVA: 0x002FFA60 File Offset: 0x002FDC60
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600506C RID: 20588 RVA: 0x002FFA69 File Offset: 0x002FDC69
		// (set) Token: 0x0600506D RID: 20589 RVA: 0x002FFA73 File Offset: 0x002FDC73
		internal virtual TextBox txtSubject
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x0600506E RID: 20590 RVA: 0x002FFA7C File Offset: 0x002FDC7C
		// (set) Token: 0x0600506F RID: 20591 RVA: 0x002FFA88 File Offset: 0x002FDC88
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

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x06005070 RID: 20592 RVA: 0x002FFACB File Offset: 0x002FDCCB
		// (set) Token: 0x06005071 RID: 20593 RVA: 0x002FFAD5 File Offset: 0x002FDCD5
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D8C RID: 7564
		// (get) Token: 0x06005072 RID: 20594 RVA: 0x002FFADE File Offset: 0x002FDCDE
		// (set) Token: 0x06005073 RID: 20595 RVA: 0x002FFAE8 File Offset: 0x002FDCE8
		internal virtual TextBox txtTextMsg
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06005074 RID: 20596 RVA: 0x002FFAF1 File Offset: 0x002FDCF1
		// (set) Token: 0x06005075 RID: 20597 RVA: 0x002FFAFC File Offset: 0x002FDCFC
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

		// Token: 0x06005076 RID: 20598 RVA: 0x002FFB40 File Offset: 0x002FDD40
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.LoadCustomers();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying customers. Details: " + ex.Message);
			}
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x002FFB90 File Offset: 0x002FDD90
		private void LoadCustomers()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.dgvCustomers.DataSource = dataTable;
				this.dgvCustomers.Columns["Address"].Visible = false;
				this.dgvCustomers.Columns["Email"].Visible = false;
				this.dgvCustomers.Columns["CustomerName"].HeaderText = "Company Name";
				this.dgvCustomers.Columns["ContactName"].HeaderText = "Contact Name";
				this.dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x002FFCC4 File Offset: 0x002FDEC4
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				int selectionStart = this.txtTextMsg.SelectionStart;
				this.txtTextMsg.Text = this.txtTextMsg.Text.Insert(selectionStart, "[ContactName]");
				this.txtTextMsg.SelectionStart = checked(selectionStart + this.txtTextMsg.Text.Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding Contact Name template. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x002FFD58 File Offset: 0x002FDF58
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				int selectionStart = this.txtTextMsg.SelectionStart;
				this.txtTextMsg.Text = this.txtTextMsg.Text.Insert(selectionStart, "[CompanyName]");
				this.txtTextMsg.SelectionStart = checked(selectionStart + this.txtTextMsg.Text.Length);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding Company Name template. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x002FFDEC File Offset: 0x002FDFEC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtSubject.Text, "", false) != 0;
				if (flag)
				{
					DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Are you sure that you want to send SMSs to the customers listed in the grid?", MsgBoxStyle.YesNo, null);
					bool flag2 = dialogResult == DialogResult.Yes;
					if (flag2)
					{
						this.SendSMS();
					}
					else
					{
						bool flag3 = dialogResult == DialogResult.No;
						if (flag3)
						{
							MessageBox.Show("No SMSs sent. Thank you.");
						}
					}
				}
				else
				{
					MessageBox.Show("Please type in a reference for this batch of SMSs.", "Notice", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Dtail: " + ex.Message);
			}
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x002FFE9C File Offset: 0x002FE09C
		private void SendSMS()
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertSMSHeaderData";
			sqlCommand.Parameters.AddWithValue("schoolId", 10);
			sqlCommand.Parameters.AddWithValue("user", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("Subject", this.txtSubject.Text);
			sqlCommand.Parameters.AddWithValue("BatchDate", Conversion.Val(DateTime.Today.ToString("yyyyMMdd")));
			SqlParameter sqlParameter = sqlCommand.CreateParameter();
			sqlParameter.ParameterName = "BatchNo";
			sqlParameter.Direction = ParameterDirection.Output;
			sqlParameter.Value = 0;
			sqlCommand.Parameters.Add(sqlParameter);
			SqlCommand sqlCommand2 = sqlConnection.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "SP_savesms";
			bool flag = this.dgvCustomers.Rows.Count > 0;
			checked
			{
				if (flag)
				{
					using (sqlConnection)
					{
						sqlConnection.Open();
						using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
						{
							try
							{
								sqlCommand.Transaction = sqlTransaction;
								sqlCommand2.Transaction = sqlTransaction;
								sqlCommand.ExecuteNonQuery();
								int num2 = Conversions.ToInteger(sqlParameter.Value);
								int num3 = 1;
								try
								{
									foreach (object obj in ((IEnumerable)this.dgvCustomers.Rows))
									{
										DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append(this.txtTextMsg.Text);
										stringBuilder.Replace("[ContactName]", dataGridViewRow.Cells["ContactName"].Value.ToString());
										stringBuilder.Replace("[CompanyName]", dataGridViewRow.Cells["CustomerName"].Value.ToString());
										string text = stringBuilder.ToString();
										bool flag2 = Operators.CompareString(dataGridViewRow.Cells["Mobile"].Value.ToString(), "", false) != 0;
										if (flag2)
										{
											num3++;
											sqlCommand2.Parameters.Clear();
											sqlCommand2.Parameters.AddWithValue("Mobi", RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Mobile"].Value));
											sqlCommand2.Parameters.AddWithValue("SMS", text);
											sqlCommand2.Parameters.AddWithValue("DateGenerated", DateTime.Today.ToString("yyyyMMdd"));
											sqlCommand2.Parameters.AddWithValue("SendingDate", 0);
											sqlCommand2.Parameters.AddWithValue("SendingTime", 0);
											sqlCommand2.Parameters.AddWithValue("valdty", 1);
											sqlCommand2.Parameters.AddWithValue("EntryNo", 0);
											sqlCommand2.Parameters.AddWithValue("BatchNo", num2);
											sqlCommand2.ExecuteNonQuery();
										}
										else
										{
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
								sqlTransaction.Commit();
								sqlConnection.Close();
								MessageBox.Show(Conversions.ToString(num3 - 1) + " SMSs successfully saved and scheduled for sending.", "Success", MessageBoxButtons.OK);
								bool flag3 = num > 0;
								if (flag3)
								{
									MessageBox.Show(Conversions.ToString(num) + " SMSs did not have mobile numbers and were not scheduled for sending.", "Notice", MessageBoxButtons.OK);
								}
							}
							catch (Exception ex)
							{
								sqlTransaction.Rollback();
								sqlConnection.Close();
								MessageBox.Show("An error saving sms has occurred. Detail: " + ex.Message, "Error", MessageBoxButtons.OK);
							}
						}
					}
				}
				else
				{
					MessageBox.Show("Please click View List first before attempting to Send SMSs.", "Error", MessageBoxButtons.OK);
				}
			}
		}

		// Token: 0x040023F0 RID: 9200
		private string _cnn;
	}
}
