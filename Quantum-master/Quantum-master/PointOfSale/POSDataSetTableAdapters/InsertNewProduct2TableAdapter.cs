using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x020000A5 RID: 165
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class InsertNewProduct2TableAdapter : Component
	{
		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x00133523 File Offset: 0x00131723
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x0013352D File Offset: 0x0013172D
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00133536 File Offset: 0x00131736
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public InsertNewProduct2TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00133548 File Offset: 0x00131748
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

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00133578 File Offset: 0x00131778
		// (set) Token: 0x060022F1 RID: 8945 RVA: 0x001335A8 File Offset: 0x001317A8
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

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x0013366C File Offset: 0x0013186C
		// (set) Token: 0x060022F3 RID: 8947 RVA: 0x00133684 File Offset: 0x00131884
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

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0013376C File Offset: 0x0013196C
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

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0013379C File Offset: 0x0013199C
		// (set) Token: 0x060022F6 RID: 8950 RVA: 0x001337B4 File Offset: 0x001319B4
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

		// Token: 0x060022F7 RID: 8951 RVA: 0x001337C0 File Offset: 0x001319C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "InsertNewProduct2";
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x00133820 File Offset: 0x00131A20
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00133844 File Offset: 0x00131A44
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.InsertNewProduct2";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@catid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productdesc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@cost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@sellingprice", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@reorderlevel", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productcode", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@barcode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@taxrate", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@new_prodtid", SqlDbType.Int, 4, ParameterDirection.InputOutput, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00133B5C File Offset: 0x00131D5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.InsertNewProduct2DataTable dataTable, int? catid, string productdesc, double? cost, double? sellingprice, int? reorderlevel, string doneby, int? donewhen, string productcode, int? barcode, double? taxrate, ref int? new_prodtid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = catid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = catid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = productdesc == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = productdesc;
			}
			bool flag3 = cost != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = cost.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = sellingprice != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = sellingprice.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = reorderlevel != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reorderlevel.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = doneby == null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = doneby;
			}
			bool flag7 = donewhen != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = donewhen.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = productcode == null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = productcode;
			}
			bool flag9 = barcode != null;
			if (flag9)
			{
				this.Adapter.SelectCommand.Parameters[9].Value = barcode.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = taxrate != null;
			if (flag10)
			{
				this.Adapter.SelectCommand.Parameters[10].Value = taxrate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[10].Value = DBNull.Value;
			}
			bool flag11 = new_prodtid != null;
			if (flag11)
			{
				this.Adapter.SelectCommand.Parameters[11].Value = new_prodtid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[11].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			int num = this.Adapter.Fill(dataTable);
			bool flag12 = this.Adapter.SelectCommand.Parameters[11].Value == null || this.Adapter.SelectCommand.Parameters[11].Value.GetType() == typeof(DBNull);
			if (flag12)
			{
				new_prodtid = null;
			}
			else
			{
				new_prodtid = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[11].Value));
			}
			return num;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00133FF8 File Offset: 0x001321F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.InsertNewProduct2DataTable GetData(int? catid, string productdesc, double? cost, double? sellingprice, int? reorderlevel, string doneby, int? donewhen, string productcode, int? barcode, double? taxrate, ref int? new_prodtid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = catid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = catid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = productdesc == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = productdesc;
			}
			bool flag3 = cost != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = cost.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = sellingprice != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = sellingprice.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = reorderlevel != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reorderlevel.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = doneby == null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = doneby;
			}
			bool flag7 = donewhen != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = donewhen.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = productcode == null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = productcode;
			}
			bool flag9 = barcode != null;
			if (flag9)
			{
				this.Adapter.SelectCommand.Parameters[9].Value = barcode.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = taxrate != null;
			if (flag10)
			{
				this.Adapter.SelectCommand.Parameters[10].Value = taxrate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[10].Value = DBNull.Value;
			}
			bool flag11 = new_prodtid != null;
			if (flag11)
			{
				this.Adapter.SelectCommand.Parameters[11].Value = new_prodtid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[11].Value = DBNull.Value;
			}
			POSDataSet.InsertNewProduct2DataTable insertNewProduct2DataTable = new POSDataSet.InsertNewProduct2DataTable();
			this.Adapter.Fill(insertNewProduct2DataTable);
			bool flag12 = this.Adapter.SelectCommand.Parameters[11].Value == null || this.Adapter.SelectCommand.Parameters[11].Value.GetType() == typeof(DBNull);
			if (flag12)
			{
				new_prodtid = null;
			}
			else
			{
				new_prodtid = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[11].Value));
			}
			return insertNewProduct2DataTable;
		}

		// Token: 0x0400105D RID: 4189
		private SqlConnection _connection;

		// Token: 0x0400105E RID: 4190
		private SqlTransaction _transaction;

		// Token: 0x0400105F RID: 4191
		private SqlCommand[] _commandCollection;

		// Token: 0x04001060 RID: 4192
		private bool _clearBeforeFill;
	}
}
