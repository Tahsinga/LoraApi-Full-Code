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
	// Token: 0x02000124 RID: 292
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetCompanyDetailsTableAdapter : Component
	{
		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x001703F9 File Offset: 0x0016E5F9
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x00170403 File Offset: 0x0016E603
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0017040C File Offset: 0x0016E60C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetCompanyDetailsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x00170420 File Offset: 0x0016E620
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

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x00170450 File Offset: 0x0016E650
		// (set) Token: 0x06002AE6 RID: 10982 RVA: 0x00170480 File Offset: 0x0016E680
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

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x00170544 File Offset: 0x0016E744
		// (set) Token: 0x06002AE8 RID: 10984 RVA: 0x0017055C File Offset: 0x0016E75C
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

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06002AE9 RID: 10985 RVA: 0x00170644 File Offset: 0x0016E844
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

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06002AEA RID: 10986 RVA: 0x00170674 File Offset: 0x0016E874
		// (set) Token: 0x06002AEB RID: 10987 RVA: 0x0017068C File Offset: 0x0016E88C
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

		// Token: 0x06002AEC RID: 10988 RVA: 0x00170698 File Offset: 0x0016E898
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetCompanyDetails";
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
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00170858 File Offset: 0x0016EA58
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x0017087C File Offset: 0x0016EA7C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetCompanyDetails";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00170914 File Offset: 0x0016EB14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetCompanyDetailsDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x0017095C File Offset: 0x0016EB5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetCompanyDetailsDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.GetCompanyDetailsDataTable getCompanyDetailsDataTable = new POSDataSet.GetCompanyDetailsDataTable();
			this.Adapter.Fill(getCompanyDetailsDataTable);
			return getCompanyDetailsDataTable;
		}

		// Token: 0x040012D8 RID: 4824
		private SqlConnection _connection;

		// Token: 0x040012D9 RID: 4825
		private SqlTransaction _transaction;

		// Token: 0x040012DA RID: 4826
		private SqlCommand[] _commandCollection;

		// Token: 0x040012DB RID: 4827
		private bool _clearBeforeFill;
	}
}
