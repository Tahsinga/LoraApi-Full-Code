using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x020000FC RID: 252
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class BankingDetails2TableAdapter : Component
	{
		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x0600285C RID: 10332 RVA: 0x0015BF74 File Offset: 0x0015A174
		// (set) Token: 0x0600285D RID: 10333 RVA: 0x0015BF7E File Offset: 0x0015A17E
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x0015BF87 File Offset: 0x0015A187
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BankingDetails2TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0015BF9C File Offset: 0x0015A19C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				bool flag = this._adapter == null;
				if (flag)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x0015BFCC File Offset: 0x0015A1CC
		// (set) Token: 0x06002861 RID: 10337 RVA: 0x0015BFFC File Offset: 0x0015A1FC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				bool flag = this._connection == null;
				if (flag)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				bool flag = this.Adapter.InsertCommand != null;
				if (flag)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				bool flag2 = this.Adapter.DeleteCommand != null;
				if (flag2)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				bool flag3 = this.Adapter.UpdateCommand != null;
				if (flag3)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						bool flag4 = this.CommandCollection[i] != null;
						if (flag4)
						{
							this.CommandCollection[i].Connection = value;
						}
					}
				}
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x0015C0C0 File Offset: 0x0015A2C0
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x0015C0D8 File Offset: 0x0015A2D8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						this.CommandCollection[i].Transaction = this._transaction;
					}
					bool flag = this.Adapter != null && this.Adapter.DeleteCommand != null;
					if (flag)
					{
						this.Adapter.DeleteCommand.Transaction = this._transaction;
					}
					bool flag2 = this.Adapter != null && this.Adapter.InsertCommand != null;
					if (flag2)
					{
						this.Adapter.InsertCommand.Transaction = this._transaction;
					}
					bool flag3 = this.Adapter != null && this.Adapter.UpdateCommand != null;
					if (flag3)
					{
						this.Adapter.UpdateCommand.Transaction = this._transaction;
					}
				}
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x0015C1C0 File Offset: 0x0015A3C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				bool flag = this._commandCollection == null;
				if (flag)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x0015C1F0 File Offset: 0x0015A3F0
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x0015C208 File Offset: 0x0015A408
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0015C214 File Offset: 0x0015A414
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "BankingDetails2";
			dataTableMapping.ColumnMappings.Add("BankName", "BankName");
			dataTableMapping.ColumnMappings.Add("Branch", "Branch");
			dataTableMapping.ColumnMappings.Add("Account_Name", "Account_Name");
			dataTableMapping.ColumnMappings.Add("Account_Number", "Account_Number");
			dataTableMapping.ColumnMappings.Add("Swift_Code", "Swift_Code");
			dataTableMapping.ColumnMappings.Add("Currency", "Currency");
			this._adapter.TableMappings.Add(dataTableMapping);
			this._adapter.InsertCommand = new SqlCommand();
			this._adapter.InsertCommand.Connection = this.Connection;
			this._adapter.InsertCommand.CommandText = "INSERT INTO [BankingDetails] ([BankName], [Branch], [AccName], [AccNum], [SwiftCode], [Currency]) VALUES (@BankName, @Branch, @Account_Name, @Account_Number, @Swift_Code, @Currency)";
			this._adapter.InsertCommand.CommandType = CommandType.Text;
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@BankName", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "BankName", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Branch", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Branch", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Account_Name", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Account_Name", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Account_Number", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Account_Number", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Swift_Code", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Swift_Code", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@Currency", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "Currency", DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0015C4B8 File Offset: 0x0015A6B8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x0015C4DC File Offset: 0x0015A6DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT BankName,Branch,AccName as Account_Name,AccNum as Account_Number,SwiftCode as Swift_Code,Currency \r\n\tfrom BankingDetails where coid=@coid order by currency desc";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "coid", DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x0015C578 File Offset: 0x0015A778
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.BankingDetails2DataTable dataTable, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[0].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0015C618 File Offset: 0x0015A818
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.BankingDetails2DataTable GetData(int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[0].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[0].Value = DBNull.Value;
			}
			POSDataSet.BankingDetails2DataTable bankingDetails2DataTable = new POSDataSet.BankingDetails2DataTable();
			this.Adapter.Fill(bankingDetails2DataTable);
			return bankingDetails2DataTable;
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0015C6AC File Offset: 0x0015A8AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(POSDataSet.BankingDetails2DataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x0015C6CC File Offset: 0x0015A8CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(POSDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "BankingDetails2");
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x0015C6F0 File Offset: 0x0015A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[] { dataRow });
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x0015C718 File Offset: 0x0015A918
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0015C738 File Offset: 0x0015A938
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		public virtual int Insert(string BankName, string Branch, string Account_Name, string Account_Number, string Swift_Code, string Currency)
		{
			bool flag = BankName == null;
			if (flag)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = BankName;
			}
			bool flag2 = Branch == null;
			if (flag2)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = Branch;
			}
			bool flag3 = Account_Name == null;
			if (flag3)
			{
				throw new ArgumentNullException("Account_Name");
			}
			this.Adapter.InsertCommand.Parameters[2].Value = Account_Name;
			bool flag4 = Account_Number == null;
			if (flag4)
			{
				throw new ArgumentNullException("Account_Number");
			}
			this.Adapter.InsertCommand.Parameters[3].Value = Account_Number;
			bool flag5 = Swift_Code == null;
			if (flag5)
			{
				throw new ArgumentNullException("Swift_Code");
			}
			this.Adapter.InsertCommand.Parameters[4].Value = Swift_Code;
			bool flag6 = Currency == null;
			if (flag6)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = Currency;
			}
			ConnectionState state = this.Adapter.InsertCommand.Connection.State;
			bool flag7 = (this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag7)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			int num2;
			try
			{
				int num = this.Adapter.InsertCommand.ExecuteNonQuery();
				num2 = num;
			}
			finally
			{
				bool flag8 = state == ConnectionState.Closed;
				if (flag8)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return num2;
		}

		// Token: 0x04001210 RID: 4624
		private SqlConnection _connection;

		// Token: 0x04001211 RID: 4625
		private SqlTransaction _transaction;

		// Token: 0x04001212 RID: 4626
		private SqlCommand[] _commandCollection;

		// Token: 0x04001213 RID: 4627
		private bool _clearBeforeFill;
	}
}
