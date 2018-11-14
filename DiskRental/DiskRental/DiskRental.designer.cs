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

namespace DiskRental
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DiskRental")]
	public partial class DiskRentalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBookList(BookList instance);
    partial void UpdateBookList(BookList instance);
    partial void DeleteBookList(BookList instance);
    partial void InsertTittle(Tittle instance);
    partial void UpdateTittle(Tittle instance);
    partial void DeleteTittle(Tittle instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertRentInfo(RentInfo instance);
    partial void UpdateRentInfo(RentInfo instance);
    partial void DeleteRentInfo(RentInfo instance);
    partial void InsertDisk(Disk instance);
    partial void UpdateDisk(Disk instance);
    partial void DeleteDisk(Disk instance);
    partial void InsertRentDetail(RentDetail instance);
    partial void UpdateRentDetail(RentDetail instance);
    partial void DeleteRentDetail(RentDetail instance);
    #endregion
		
		public DiskRentalDataContext() : 
				base(global::DiskRental.Properties.Settings.Default.DiskRentalConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DiskRentalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiskRentalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiskRentalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DiskRentalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BookList> BookLists
		{
			get
			{
				return this.GetTable<BookList>();
			}
		}
		
		public System.Data.Linq.Table<Tittle> Tittles
		{
			get
			{
				return this.GetTable<Tittle>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<RentInfo> RentInfos
		{
			get
			{
				return this.GetTable<RentInfo>();
			}
		}
		
		public System.Data.Linq.Table<Disk> Disks
		{
			get
			{
				return this.GetTable<Disk>();
			}
		}
		
		public System.Data.Linq.Table<RentDetail> RentDetails
		{
			get
			{
				return this.GetTable<RentDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BookList")]
	public partial class BookList : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private System.Nullable<System.DateTime> _BookDay;
		
		private int _TittleID;
		
		private EntityRef<Tittle> _Tittle;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnBookDayChanging(System.Nullable<System.DateTime> value);
    partial void OnBookDayChanged();
    partial void OnTittleIDChanging(int value);
    partial void OnTittleIDChanged();
    #endregion
		
		public BookList()
		{
			this._Tittle = default(EntityRef<Tittle>);
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookDay", DbType="DateTime")]
		public System.Nullable<System.DateTime> BookDay
		{
			get
			{
				return this._BookDay;
			}
			set
			{
				if ((this._BookDay != value))
				{
					this.OnBookDayChanging(value);
					this.SendPropertyChanging();
					this._BookDay = value;
					this.SendPropertyChanged("BookDay");
					this.OnBookDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TittleID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TittleID
		{
			get
			{
				return this._TittleID;
			}
			set
			{
				if ((this._TittleID != value))
				{
					if (this._Tittle.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTittleIDChanging(value);
					this.SendPropertyChanging();
					this._TittleID = value;
					this.SendPropertyChanged("TittleID");
					this.OnTittleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tittle_BookList", Storage="_Tittle", ThisKey="TittleID", OtherKey="TittleID", IsForeignKey=true)]
		public Tittle Tittle
		{
			get
			{
				return this._Tittle.Entity;
			}
			set
			{
				Tittle previousValue = this._Tittle.Entity;
				if (((previousValue != value) 
							|| (this._Tittle.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tittle.Entity = null;
						previousValue.BookLists.Remove(this);
					}
					this._Tittle.Entity = value;
					if ((value != null))
					{
						value.BookLists.Add(this);
						this._TittleID = value.TittleID;
					}
					else
					{
						this._TittleID = default(int);
					}
					this.SendPropertyChanged("Tittle");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BookList", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.BookLists.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.BookLists.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tittle")]
	public partial class Tittle : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TittleID;
		
		private string _TittleName;
		
		private string _TittleDescription;
		
		private System.Nullable<decimal> _Cost;
		
		private EntitySet<BookList> _BookLists;
		
		private EntitySet<Disk> _Disks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTittleIDChanging(int value);
    partial void OnTittleIDChanged();
    partial void OnTittleNameChanging(string value);
    partial void OnTittleNameChanged();
    partial void OnTittleDescriptionChanging(string value);
    partial void OnTittleDescriptionChanged();
    partial void OnCostChanging(System.Nullable<decimal> value);
    partial void OnCostChanged();
    #endregion
		
		public Tittle()
		{
			this._BookLists = new EntitySet<BookList>(new Action<BookList>(this.attach_BookLists), new Action<BookList>(this.detach_BookLists));
			this._Disks = new EntitySet<Disk>(new Action<Disk>(this.attach_Disks), new Action<Disk>(this.detach_Disks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TittleID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TittleID
		{
			get
			{
				return this._TittleID;
			}
			set
			{
				if ((this._TittleID != value))
				{
					this.OnTittleIDChanging(value);
					this.SendPropertyChanging();
					this._TittleID = value;
					this.SendPropertyChanged("TittleID");
					this.OnTittleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TittleName", DbType="NVarChar(50)")]
		public string TittleName
		{
			get
			{
				return this._TittleName;
			}
			set
			{
				if ((this._TittleName != value))
				{
					this.OnTittleNameChanging(value);
					this.SendPropertyChanging();
					this._TittleName = value;
					this.SendPropertyChanged("TittleName");
					this.OnTittleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TittleDescription", DbType="NVarChar(50)")]
		public string TittleDescription
		{
			get
			{
				return this._TittleDescription;
			}
			set
			{
				if ((this._TittleDescription != value))
				{
					this.OnTittleDescriptionChanging(value);
					this.SendPropertyChanging();
					this._TittleDescription = value;
					this.SendPropertyChanged("TittleDescription");
					this.OnTittleDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Money")]
		public System.Nullable<decimal> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tittle_BookList", Storage="_BookLists", ThisKey="TittleID", OtherKey="TittleID")]
		public EntitySet<BookList> BookLists
		{
			get
			{
				return this._BookLists;
			}
			set
			{
				this._BookLists.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tittle_Disk", Storage="_Disks", ThisKey="TittleID", OtherKey="TittleID")]
		public EntitySet<Disk> Disks
		{
			get
			{
				return this._Disks;
			}
			set
			{
				this._Disks.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BookLists(BookList entity)
		{
			this.SendPropertyChanging();
			entity.Tittle = this;
		}
		
		private void detach_BookLists(BookList entity)
		{
			this.SendPropertyChanging();
			entity.Tittle = null;
		}
		
		private void attach_Disks(Disk entity)
		{
			this.SendPropertyChanging();
			entity.Tittle = this;
		}
		
		private void detach_Disks(Disk entity)
		{
			this.SendPropertyChanging();
			entity.Tittle = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerID;
		
		private string _CustomerName;
		
		private System.Nullable<int> _CustomerPhone;
		
		private string _CustomerAddress;
		
		private EntitySet<BookList> _BookLists;
		
		private EntitySet<RentInfo> _RentInfos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnCustomerPhoneChanging(System.Nullable<int> value);
    partial void OnCustomerPhoneChanged();
    partial void OnCustomerAddressChanging(string value);
    partial void OnCustomerAddressChanged();
    #endregion
		
		public Customer()
		{
			this._BookLists = new EntitySet<BookList>(new Action<BookList>(this.attach_BookLists), new Action<BookList>(this.detach_BookLists));
			this._RentInfos = new EntitySet<RentInfo>(new Action<RentInfo>(this.attach_RentInfos), new Action<RentInfo>(this.detach_RentInfos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="NVarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerPhone", DbType="Int")]
		public System.Nullable<int> CustomerPhone
		{
			get
			{
				return this._CustomerPhone;
			}
			set
			{
				if ((this._CustomerPhone != value))
				{
					this.OnCustomerPhoneChanging(value);
					this.SendPropertyChanging();
					this._CustomerPhone = value;
					this.SendPropertyChanged("CustomerPhone");
					this.OnCustomerPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerAddress", DbType="NVarChar(50)")]
		public string CustomerAddress
		{
			get
			{
				return this._CustomerAddress;
			}
			set
			{
				if ((this._CustomerAddress != value))
				{
					this.OnCustomerAddressChanging(value);
					this.SendPropertyChanging();
					this._CustomerAddress = value;
					this.SendPropertyChanged("CustomerAddress");
					this.OnCustomerAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_BookList", Storage="_BookLists", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<BookList> BookLists
		{
			get
			{
				return this._BookLists;
			}
			set
			{
				this._BookLists.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_RentInfo", Storage="_RentInfos", ThisKey="CustomerID", OtherKey="CustomerID")]
		public EntitySet<RentInfo> RentInfos
		{
			get
			{
				return this._RentInfos;
			}
			set
			{
				this._RentInfos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_BookLists(BookList entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_BookLists(BookList entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
		
		private void attach_RentInfos(RentInfo entity)
		{
			this.SendPropertyChanging();
			entity.Customer = this;
		}
		
		private void detach_RentInfos(RentInfo entity)
		{
			this.SendPropertyChanging();
			entity.Customer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RentInfo")]
	public partial class RentInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _RentDate;
		
		private System.Nullable<decimal> _RentCost;
		
		private System.DateTime _ReturnDate;
		
		private System.Nullable<decimal> _LateFee;
		
		private int _CustomerID;
		
		private int _RentID;
		
		private EntitySet<RentDetail> _RentDetails;
		
		private EntityRef<Customer> _Customer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRentDateChanging(System.DateTime value);
    partial void OnRentDateChanged();
    partial void OnRentCostChanging(System.Nullable<decimal> value);
    partial void OnRentCostChanged();
    partial void OnReturnDateChanging(System.DateTime value);
    partial void OnReturnDateChanged();
    partial void OnLateFeeChanging(System.Nullable<decimal> value);
    partial void OnLateFeeChanged();
    partial void OnCustomerIDChanging(int value);
    partial void OnCustomerIDChanged();
    partial void OnRentIDChanging(int value);
    partial void OnRentIDChanged();
    #endregion
		
		public RentInfo()
		{
			this._RentDetails = new EntitySet<RentDetail>(new Action<RentDetail>(this.attach_RentDetails), new Action<RentDetail>(this.detach_RentDetails));
			this._Customer = default(EntityRef<Customer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentDate", DbType="DateTime NOT NULL")]
		public System.DateTime RentDate
		{
			get
			{
				return this._RentDate;
			}
			set
			{
				if ((this._RentDate != value))
				{
					this.OnRentDateChanging(value);
					this.SendPropertyChanging();
					this._RentDate = value;
					this.SendPropertyChanged("RentDate");
					this.OnRentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentCost", DbType="Money")]
		public System.Nullable<decimal> RentCost
		{
			get
			{
				return this._RentCost;
			}
			set
			{
				if ((this._RentCost != value))
				{
					this.OnRentCostChanging(value);
					this.SendPropertyChanging();
					this._RentCost = value;
					this.SendPropertyChanged("RentCost");
					this.OnRentCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="DateTime NOT NULL")]
		public System.DateTime ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LateFee", DbType="Money")]
		public System.Nullable<decimal> LateFee
		{
			get
			{
				return this._LateFee;
			}
			set
			{
				if ((this._LateFee != value))
				{
					this.OnLateFeeChanging(value);
					this.SendPropertyChanging();
					this._LateFee = value;
					this.SendPropertyChanged("LateFee");
					this.OnLateFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerID", DbType="Int NOT NULL")]
		public int CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					if (this._Customer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RentID
		{
			get
			{
				return this._RentID;
			}
			set
			{
				if ((this._RentID != value))
				{
					this.OnRentIDChanging(value);
					this.SendPropertyChanging();
					this._RentID = value;
					this.SendPropertyChanged("RentID");
					this.OnRentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RentInfo_RentDetail", Storage="_RentDetails", ThisKey="RentID", OtherKey="RentID")]
		public EntitySet<RentDetail> RentDetails
		{
			get
			{
				return this._RentDetails;
			}
			set
			{
				this._RentDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Customer_RentInfo", Storage="_Customer", ThisKey="CustomerID", OtherKey="CustomerID", IsForeignKey=true)]
		public Customer Customer
		{
			get
			{
				return this._Customer.Entity;
			}
			set
			{
				Customer previousValue = this._Customer.Entity;
				if (((previousValue != value) 
							|| (this._Customer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Customer.Entity = null;
						previousValue.RentInfos.Remove(this);
					}
					this._Customer.Entity = value;
					if ((value != null))
					{
						value.RentInfos.Add(this);
						this._CustomerID = value.CustomerID;
					}
					else
					{
						this._CustomerID = default(int);
					}
					this.SendPropertyChanged("Customer");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RentDetails(RentDetail entity)
		{
			this.SendPropertyChanging();
			entity.RentInfo = this;
		}
		
		private void detach_RentDetails(RentDetail entity)
		{
			this.SendPropertyChanging();
			entity.RentInfo = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Disk]")]
	public partial class Disk : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DiskID;
		
		private System.Nullable<int> _TittleID;
		
		private string _DiskStatus;
		
		private EntitySet<RentDetail> _RentDetails;
		
		private EntityRef<Tittle> _Tittle;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDiskIDChanging(int value);
    partial void OnDiskIDChanged();
    partial void OnTittleIDChanging(System.Nullable<int> value);
    partial void OnTittleIDChanged();
    partial void OnDiskStatusChanging(string value);
    partial void OnDiskStatusChanged();
    #endregion
		
		public Disk()
		{
			this._RentDetails = new EntitySet<RentDetail>(new Action<RentDetail>(this.attach_RentDetails), new Action<RentDetail>(this.detach_RentDetails));
			this._Tittle = default(EntityRef<Tittle>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiskID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DiskID
		{
			get
			{
				return this._DiskID;
			}
			set
			{
				if ((this._DiskID != value))
				{
					this.OnDiskIDChanging(value);
					this.SendPropertyChanging();
					this._DiskID = value;
					this.SendPropertyChanged("DiskID");
					this.OnDiskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TittleID", DbType="Int")]
		public System.Nullable<int> TittleID
		{
			get
			{
				return this._TittleID;
			}
			set
			{
				if ((this._TittleID != value))
				{
					if (this._Tittle.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTittleIDChanging(value);
					this.SendPropertyChanging();
					this._TittleID = value;
					this.SendPropertyChanged("TittleID");
					this.OnTittleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiskStatus", DbType="NVarChar(50)")]
		public string DiskStatus
		{
			get
			{
				return this._DiskStatus;
			}
			set
			{
				if ((this._DiskStatus != value))
				{
					this.OnDiskStatusChanging(value);
					this.SendPropertyChanging();
					this._DiskStatus = value;
					this.SendPropertyChanged("DiskStatus");
					this.OnDiskStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Disk_RentDetail", Storage="_RentDetails", ThisKey="DiskID", OtherKey="DiskID")]
		public EntitySet<RentDetail> RentDetails
		{
			get
			{
				return this._RentDetails;
			}
			set
			{
				this._RentDetails.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tittle_Disk", Storage="_Tittle", ThisKey="TittleID", OtherKey="TittleID", IsForeignKey=true)]
		public Tittle Tittle
		{
			get
			{
				return this._Tittle.Entity;
			}
			set
			{
				Tittle previousValue = this._Tittle.Entity;
				if (((previousValue != value) 
							|| (this._Tittle.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tittle.Entity = null;
						previousValue.Disks.Remove(this);
					}
					this._Tittle.Entity = value;
					if ((value != null))
					{
						value.Disks.Add(this);
						this._TittleID = value.TittleID;
					}
					else
					{
						this._TittleID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tittle");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_RentDetails(RentDetail entity)
		{
			this.SendPropertyChanging();
			entity.Disk = this;
		}
		
		private void detach_RentDetails(RentDetail entity)
		{
			this.SendPropertyChanging();
			entity.Disk = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RentDetail")]
	public partial class RentDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RentID;
		
		private int _DiskID;
		
		private System.Nullable<System.DateTime> _ReturnDate;
		
		private EntityRef<Disk> _Disk;
		
		private EntityRef<RentInfo> _RentInfo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRentIDChanging(int value);
    partial void OnRentIDChanged();
    partial void OnDiskIDChanging(int value);
    partial void OnDiskIDChanged();
    partial void OnReturnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnReturnDateChanged();
    #endregion
		
		public RentDetail()
		{
			this._Disk = default(EntityRef<Disk>);
			this._RentInfo = default(EntityRef<RentInfo>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RentID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int RentID
		{
			get
			{
				return this._RentID;
			}
			set
			{
				if ((this._RentID != value))
				{
					if (this._RentInfo.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRentIDChanging(value);
					this.SendPropertyChanging();
					this._RentID = value;
					this.SendPropertyChanged("RentID");
					this.OnRentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiskID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DiskID
		{
			get
			{
				return this._DiskID;
			}
			set
			{
				if ((this._DiskID != value))
				{
					if (this._Disk.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDiskIDChanging(value);
					this.SendPropertyChanging();
					this._DiskID = value;
					this.SendPropertyChanged("DiskID");
					this.OnDiskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReturnDate", DbType="Date")]
		public System.Nullable<System.DateTime> ReturnDate
		{
			get
			{
				return this._ReturnDate;
			}
			set
			{
				if ((this._ReturnDate != value))
				{
					this.OnReturnDateChanging(value);
					this.SendPropertyChanging();
					this._ReturnDate = value;
					this.SendPropertyChanged("ReturnDate");
					this.OnReturnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Disk_RentDetail", Storage="_Disk", ThisKey="DiskID", OtherKey="DiskID", IsForeignKey=true)]
		public Disk Disk
		{
			get
			{
				return this._Disk.Entity;
			}
			set
			{
				Disk previousValue = this._Disk.Entity;
				if (((previousValue != value) 
							|| (this._Disk.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Disk.Entity = null;
						previousValue.RentDetails.Remove(this);
					}
					this._Disk.Entity = value;
					if ((value != null))
					{
						value.RentDetails.Add(this);
						this._DiskID = value.DiskID;
					}
					else
					{
						this._DiskID = default(int);
					}
					this.SendPropertyChanged("Disk");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="RentInfo_RentDetail", Storage="_RentInfo", ThisKey="RentID", OtherKey="RentID", IsForeignKey=true)]
		public RentInfo RentInfo
		{
			get
			{
				return this._RentInfo.Entity;
			}
			set
			{
				RentInfo previousValue = this._RentInfo.Entity;
				if (((previousValue != value) 
							|| (this._RentInfo.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._RentInfo.Entity = null;
						previousValue.RentDetails.Remove(this);
					}
					this._RentInfo.Entity = value;
					if ((value != null))
					{
						value.RentDetails.Add(this);
						this._RentID = value.RentID;
					}
					else
					{
						this._RentID = default(int);
					}
					this.SendPropertyChanged("RentInfo");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591