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
	// Token: 0x02000125 RID: 293
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetCompanyDetailsForCoidTableAdapter : Component
	{
		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002AF1 RID: 10993 RVA: 0x00170996 File Offset: 0x0016EB96
		// (set) Token: 0x06002AF2 RID: 10994 RVA: 0x001709A0 File Offset: 0x0016EBA0
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x001709A9 File Offset: 0x0016EBA9
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetCompanyDetailsForCoidTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x001709BC File Offset: 0x0016EBBC
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

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x001709EC File Offset: 0x0016EBEC
		// (set) Token: 0x06002AF6 RID: 10998 RVA: 0x00170A1C File Offset: 0x0016EC1C
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

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x00170AE0 File Offset: 0x0016ECE0
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x00170AF8 File Offset: 0x0016ECF8
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

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06002AF9 RID: 11001 RVA: 0x00170BE0 File Offset: 0x0016EDE0
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

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06002AFA RID: 11002 RVA: 0x00170C10 File Offset: 0x0016EE10
		// (set) Token: 0x06002AFB RID: 11003 RVA: 0x00170C28 File Offset: 0x0016EE28
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

		// Token: 0x06002AFC RID: 11004 RVA: 0x00170C34 File Offset: 0x0016EE34
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetCompanyDetailsForCoid";
			dataTableMapping.ColumnMappings.Add("Company", "Company");
			dataTableMapping.ColumnMappings.Add("Address", "Address");
			dataTableMapping.ColumnMappings.Add("Tel", "Tel");
			dataTableMapping.ColumnMappings.Add("logo", "logo");
			dataTableMapping.ColumnMappings.Add("VendorNumber", "VendorNumber");
			dataTableMapping.ColumnMappings.Add("Email", "Email");
			dataTableMapping.ColumnMappings.Add("website", "website");
			dataTableMapping.ColumnMappings.Add("Tel2", "Tel2");
			dataTableMapping.ColumnMappings.Add("Tel3", "Tel3");
			dataTableMapping.ColumnMappings.Add("BPNumber", "BPNumber");
			dataTableMapping.ColumnMappings.Add("bank", "bank");
			dataTableMapping.ColumnMappings.Add("bankbranch", "bankbranch");
			dataTableMapping.ColumnMappings.Add("bankaccnum", "bankaccnum");
			dataTableMapping.ColumnMappings.Add("bankaccname", "bankaccname");
			dataTableMapping.ColumnMappings.Add("bankswiftcode", "bankswiftcode");
			dataTableMapping.ColumnMappings.Add("InvoiceTerms", "InvoiceTerms");
			dataTableMapping.ColumnMappings.Add("BaseCurrency", "BaseCurrency");
			dataTableMapping.ColumnMappings.Add("BPNumber_name", "BPNumber_name");
			dataTableMapping.ColumnMappings.Add("VATNumber_name", "VATNumber_name");
			dataTableMapping.ColumnMappings.Add("Vendor_name", "Vendor_name");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002AFD RID: 11005 RVA: 0x00170E36 File Offset: 0x0016F036
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x00170E5C File Offset: 0x0016F05C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetCompanyDetailsForCoid";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x00170F30 File Offset: 0x0016F130
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetCompanyDetailsForCoidDataTable dataTable, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x00170FD0 File Offset: 0x0016F1D0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetCompanyDetailsForCoidDataTable GetData(int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.GetCompanyDetailsForCoidDataTable getCompanyDetailsForCoidDataTable = new POSDataSet.GetCompanyDetailsForCoidDataTable();
			this.Adapter.Fill(getCompanyDetailsForCoidDataTable);
			return getCompanyDetailsForCoidDataTable;
		}

		// Token: 0x040012DD RID: 4829
		private SqlConnection _connection;

		// Token: 0x040012DE RID: 4830
		private SqlTransaction _transaction;

		// Token: 0x040012DF RID: 4831
		private SqlCommand[] _commandCollection;

		// Token: 0x040012E0 RID: 4832
		private bool _clearBeforeFill;
	}
}
