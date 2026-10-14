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
	// Token: 0x0200013B RID: 315
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ShiftDetailTableAdapter : Component
	{
		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x0017C60A File Offset: 0x0017A80A
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x0017C614 File Offset: 0x0017A814
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0017C61D File Offset: 0x0017A81D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ShiftDetailTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06002C54 RID: 11348 RVA: 0x0017C630 File Offset: 0x0017A830
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

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x0017C660 File Offset: 0x0017A860
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x0017C690 File Offset: 0x0017A890
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

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x0017C754 File Offset: 0x0017A954
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x0017C76C File Offset: 0x0017A96C
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

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x0017C854 File Offset: 0x0017AA54
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

		// Token: 0x17001084 RID: 4228
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x0017C884 File Offset: 0x0017AA84
		// (set) Token: 0x06002C5B RID: 11355 RVA: 0x0017C89C File Offset: 0x0017AA9C
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

		// Token: 0x06002C5C RID: 11356 RVA: 0x0017C8A8 File Offset: 0x0017AAA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ShiftDetail";
			dataTableMapping.ColumnMappings.Add("entryno", "entryno");
			dataTableMapping.ColumnMappings.Add("StartTime", "StartTime");
			dataTableMapping.ColumnMappings.Add("EndTime", "EndTime");
			dataTableMapping.ColumnMappings.Add("IsClosed", "IsClosed");
			dataTableMapping.ColumnMappings.Add("ShiftName", "ShiftName");
			dataTableMapping.ColumnMappings.Add("ShiftUser", "ShiftUser");
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			dataTableMapping.ColumnMappings.Add("coid", "coid");
			dataTableMapping.ColumnMappings.Add("ShiftDate", "ShiftDate");
			dataTableMapping.ColumnMappings.Add("shiftenddate", "shiftenddate");
			this._adapter.TableMappings.Add(dataTableMapping);
			this._adapter.InsertCommand = new SqlCommand();
			this._adapter.InsertCommand.Connection = this.Connection;
			this._adapter.InsertCommand.CommandText = "INSERT INTO [ShiftDetail] ([StartTime], [EndTime], [IsClosed], [ShiftName], [ShiftUser], [branch], [coid]) VALUES (@StartTime, @EndTime, @IsClosed, @ShiftName, @ShiftUser, @branch, @coid);\r\nSELECT entryno, CONVERT (datetime2, CONVERT (varchar(10), ShiftDate), 112) AS ShiftDate, CONVERT (datetime2, CONVERT (varchar(10), shiftenddate), 112) AS shiftenddate, StartTime, EndTime, IsClosed, ShiftName, ShiftUser, branch, coid FROM ShiftDetail WHERE (ShiftName = @ShiftName) AND (ShiftUser = @ShiftUser) AND (branch = @branch) AND (coid = @coid)";
			this._adapter.InsertCommand.CommandType = CommandType.Text;
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@StartTime", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "StartTime", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@EndTime", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "EndTime", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@IsClosed", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "IsClosed", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShiftName", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShiftName", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@ShiftUser", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "ShiftUser", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "branch", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "coid", DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0017CBE1 File Offset: 0x0017ADE1
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0017CC08 File Offset: 0x0017AE08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT entryno, convert(datetime2, convert(varchar(10),shiftdate),112) as ShiftDate,convert(datetime2, convert(varchar(10),shiftenddate),112) as shiftenddate, StartTime, EndTime, IsClosed, ShiftName, ShiftUser, branch, coid FROM ShiftDetail WHERE (ShiftDate = @shiftdate) AND (coid = @coid) AND (branch = @branch) AND (ShiftUser = @theuser)";
			this._commandCollection[0].CommandType = CommandType.Text;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdate", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "ShiftDate", DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 0, 0, "coid", DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, "branch", DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, "ShiftUser", DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0017CD60 File Offset: 0x0017AF60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ShiftDetailDataTable dataTable, int shiftdate, int coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			this.Adapter.SelectCommand.Parameters[0].Value = shiftdate;
			this.Adapter.SelectCommand.Parameters[1].Value = coid;
			bool flag = branch == null;
			if (flag)
			{
				throw new ArgumentNullException("branch");
			}
			this.Adapter.SelectCommand.Parameters[2].Value = branch;
			bool flag2 = theuser == null;
			if (flag2)
			{
				throw new ArgumentNullException("theuser");
			}
			this.Adapter.SelectCommand.Parameters[3].Value = theuser;
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0017CE58 File Offset: 0x0017B058
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ShiftDetailDataTable GetData(int shiftdate, int coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			this.Adapter.SelectCommand.Parameters[0].Value = shiftdate;
			this.Adapter.SelectCommand.Parameters[1].Value = coid;
			bool flag = branch == null;
			if (flag)
			{
				throw new ArgumentNullException("branch");
			}
			this.Adapter.SelectCommand.Parameters[2].Value = branch;
			bool flag2 = theuser == null;
			if (flag2)
			{
				throw new ArgumentNullException("theuser");
			}
			this.Adapter.SelectCommand.Parameters[3].Value = theuser;
			POSDataSet.ShiftDetailDataTable shiftDetailDataTable = new POSDataSet.ShiftDetailDataTable();
			this.Adapter.Fill(shiftDetailDataTable);
			return shiftDetailDataTable;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0017CF3C File Offset: 0x0017B13C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(POSDataSet.ShiftDetailDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x0017CF5C File Offset: 0x0017B15C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(POSDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "ShiftDetail");
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0017CF80 File Offset: 0x0017B180
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[] { dataRow });
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0017CFA8 File Offset: 0x0017B1A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}

		// Token: 0x0400134B RID: 4939
		private SqlConnection _connection;

		// Token: 0x0400134C RID: 4940
		private SqlTransaction _transaction;

		// Token: 0x0400134D RID: 4941
		private SqlCommand[] _commandCollection;

		// Token: 0x0400134E RID: 4942
		private bool _clearBeforeFill;
	}
}
