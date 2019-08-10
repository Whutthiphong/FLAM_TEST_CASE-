﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FLAME_TEST
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MasterProducts> MasterProducts
		{
			get
			{
				return this.GetTable<MasterProducts>();
			}
		}
		
		public System.Data.Linq.Table<TransactionsSaleHeader> TransactionsSaleHeaders
		{
			get
			{
				return this.GetTable<TransactionsSaleHeader>();
			}
		}
		
		public System.Data.Linq.Table<MasterCustomer> MasterCustomers
		{
			get
			{
				return this.GetTable<MasterCustomer>();
			}
		}
		
		public System.Data.Linq.Table<MasterSalePerson> MasterSalePersons
		{
			get
			{
				return this.GetTable<MasterSalePerson>();
			}
		}
		
		public System.Data.Linq.Table<MasterProductCategory> MasterProductCategories
		{
			get
			{
				return this.GetTable<MasterProductCategory>();
			}
		}
		
		public System.Data.Linq.Table<TransactionsSaleDetail> TransactionsSaleDetails
		{
			get
			{
				return this.GetTable<TransactionsSaleDetail>();
			}
		}
		
		public System.Data.Linq.Table<ReportSale> ReportSales
		{
			get
			{
				return this.GetTable<ReportSale>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class MasterProducts
	{
		
		private string _productCode;
		
		private string _productName;
		
		private double _salePrice;
		
		private string _categoryCode;
		
		public MasterProducts()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productCode", CanBeNull=false)]
		public string productCode
		{
			get
			{
				return this._productCode;
			}
			set
			{
				if ((this._productCode != value))
				{
					this._productCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", CanBeNull=false)]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this._productName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePrice")]
		public double salePrice
		{
			get
			{
				return this._salePrice;
			}
			set
			{
				if ((this._salePrice != value))
				{
					this._salePrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryCode", CanBeNull=false)]
		public string categoryCode
		{
			get
			{
				return this._categoryCode;
			}
			set
			{
				if ((this._categoryCode != value))
				{
					this._categoryCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TransactionsSaleHeader
	{
		
		private string _docno;
		
		private System.DateTime _saleDate;
		
		private string _customerCode;
		
		private string _salePersonCode;
		
		public TransactionsSaleHeader()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_docno", CanBeNull=false)]
		public string docno
		{
			get
			{
				return this._docno;
			}
			set
			{
				if ((this._docno != value))
				{
					this._docno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saleDate")]
		public System.DateTime saleDate
		{
			get
			{
				return this._saleDate;
			}
			set
			{
				if ((this._saleDate != value))
				{
					this._saleDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerCode", CanBeNull=false)]
		public string customerCode
		{
			get
			{
				return this._customerCode;
			}
			set
			{
				if ((this._customerCode != value))
				{
					this._customerCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePersonCode", CanBeNull=false)]
		public string salePersonCode
		{
			get
			{
				return this._salePersonCode;
			}
			set
			{
				if ((this._salePersonCode != value))
				{
					this._salePersonCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class MasterCustomer
	{
		
		private string _customerCode;
		
		private string _customerName;
		
		public MasterCustomer()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerCode", CanBeNull=false)]
		public string customerCode
		{
			get
			{
				return this._customerCode;
			}
			set
			{
				if ((this._customerCode != value))
				{
					this._customerCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerName", CanBeNull=false)]
		public string customerName
		{
			get
			{
				return this._customerName;
			}
			set
			{
				if ((this._customerName != value))
				{
					this._customerName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class MasterSalePerson
	{
		
		private string _salePersonCode;
		
		private string _salePersonName;
		
		public MasterSalePerson()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePersonCode", CanBeNull=false)]
		public string salePersonCode
		{
			get
			{
				return this._salePersonCode;
			}
			set
			{
				if ((this._salePersonCode != value))
				{
					this._salePersonCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePersonName", CanBeNull=false)]
		public string salePersonName
		{
			get
			{
				return this._salePersonName;
			}
			set
			{
				if ((this._salePersonName != value))
				{
					this._salePersonName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class MasterProductCategory
	{
		
		private string _categoryCode;
		
		private string _categoryName;
		
		public MasterProductCategory()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryCode", CanBeNull=false)]
		public string categoryCode
		{
			get
			{
				return this._categoryCode;
			}
			set
			{
				if ((this._categoryCode != value))
				{
					this._categoryCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_categoryName", CanBeNull=false)]
		public string categoryName
		{
			get
			{
				return this._categoryName;
			}
			set
			{
				if ((this._categoryName != value))
				{
					this._categoryName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class TransactionsSaleDetail
	{
		
		private string _docno;
		
		private string _produCode;
		
		public TransactionsSaleDetail()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_docno", CanBeNull=false)]
		public string docno
		{
			get
			{
				return this._docno;
			}
			set
			{
				if ((this._docno != value))
				{
					this._docno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_produCode", CanBeNull=false)]
		public string produCode
		{
			get
			{
				return this._produCode;
			}
			set
			{
				if ((this._produCode != value))
				{
					this._produCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class ReportSale
	{
		
		private string _docno;
		
		private System.DateTime _saleDate;
		
		private string _customerCode;
		
		private string _salePersonCode;
		
		private double _salePrice;
		
		private string _productName;
		
		private string _customerName;
		
		private string _salePersonName;
		
		private string _productCode;
		
		public ReportSale()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_docno", CanBeNull=false)]
		public string docno
		{
			get
			{
				return this._docno;
			}
			set
			{
				if ((this._docno != value))
				{
					this._docno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_saleDate")]
		public System.DateTime saleDate
		{
			get
			{
				return this._saleDate;
			}
			set
			{
				if ((this._saleDate != value))
				{
					this._saleDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerCode", CanBeNull=false)]
		public string customerCode
		{
			get
			{
				return this._customerCode;
			}
			set
			{
				if ((this._customerCode != value))
				{
					this._customerCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePersonCode", CanBeNull=false)]
		public string salePersonCode
		{
			get
			{
				return this._salePersonCode;
			}
			set
			{
				if ((this._salePersonCode != value))
				{
					this._salePersonCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePrice")]
		public double salePrice
		{
			get
			{
				return this._salePrice;
			}
			set
			{
				if ((this._salePrice != value))
				{
					this._salePrice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productName", CanBeNull=false)]
		public string productName
		{
			get
			{
				return this._productName;
			}
			set
			{
				if ((this._productName != value))
				{
					this._productName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_customerName", CanBeNull=false)]
		public string customerName
		{
			get
			{
				return this._customerName;
			}
			set
			{
				if ((this._customerName != value))
				{
					this._customerName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salePersonName", CanBeNull=false)]
		public string salePersonName
		{
			get
			{
				return this._salePersonName;
			}
			set
			{
				if ((this._salePersonName != value))
				{
					this._salePersonName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_productCode", CanBeNull=false)]
		public string productCode
		{
			get
			{
				return this._productCode;
			}
			set
			{
				if ((this._productCode != value))
				{
					this._productCode = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
