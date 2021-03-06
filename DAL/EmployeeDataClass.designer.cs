#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeTracking")]
	public partial class EmployeeDataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDEPARTEMENT(DEPARTEMENT instance);
    partial void UpdateDEPARTEMENT(DEPARTEMENT instance);
    partial void DeleteDEPARTEMENT(DEPARTEMENT instance);
    partial void InsertTASKSTATE(TASKSTATE instance);
    partial void UpdateTASKSTATE(TASKSTATE instance);
    partial void DeleteTASKSTATE(TASKSTATE instance);
    partial void InsertEMPLOYEE(EMPLOYEE instance);
    partial void UpdateEMPLOYEE(EMPLOYEE instance);
    partial void DeleteEMPLOYEE(EMPLOYEE instance);
    partial void InsertMONTH(MONTH instance);
    partial void UpdateMONTH(MONTH instance);
    partial void DeleteMONTH(MONTH instance);
    partial void InsertPERMISSION(PERMISSION instance);
    partial void UpdatePERMISSION(PERMISSION instance);
    partial void DeletePERMISSION(PERMISSION instance);
    partial void InsertPERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void UpdatePERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void DeletePERMISSIONSTATE(PERMISSIONSTATE instance);
    partial void InsertPOSITION(POSITION instance);
    partial void UpdatePOSITION(POSITION instance);
    partial void DeletePOSITION(POSITION instance);
    partial void InsertSALARY(SALARY instance);
    partial void UpdateSALARY(SALARY instance);
    partial void DeleteSALARY(SALARY instance);
    #endregion
		
		public EmployeeDataClassDataContext() : 
				base(global::DAL.Properties.Settings.Default.EmployeeTrackingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public EmployeeDataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DEPARTEMENT> DEPARTEMENTs
		{
			get
			{
				return this.GetTable<DEPARTEMENT>();
			}
		}
		
		public System.Data.Linq.Table<TASKSTATE> TASKSTATEs
		{
			get
			{
				return this.GetTable<TASKSTATE>();
			}
		}
		
		public System.Data.Linq.Table<EMPLOYEE> EMPLOYEEs
		{
			get
			{
				return this.GetTable<EMPLOYEE>();
			}
		}
		
		public System.Data.Linq.Table<MONTH> MONTHs
		{
			get
			{
				return this.GetTable<MONTH>();
			}
		}
		
		public System.Data.Linq.Table<PERMISSION> PERMISSIONs
		{
			get
			{
				return this.GetTable<PERMISSION>();
			}
		}
		
		public System.Data.Linq.Table<PERMISSIONSTATE> PERMISSIONSTATEs
		{
			get
			{
				return this.GetTable<PERMISSIONSTATE>();
			}
		}
		
		public System.Data.Linq.Table<POSITION> POSITIONs
		{
			get
			{
				return this.GetTable<POSITION>();
			}
		}
		
		public System.Data.Linq.Table<SALARY> SALARies
		{
			get
			{
				return this.GetTable<SALARY>();
			}
		}
		
		public System.Data.Linq.Table<TASK> TASKs
		{
			get
			{
				return this.GetTable<TASK>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DEPARTEMENT")]
	public partial class DEPARTEMENT : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepartmentId;
		
		private string _Department;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartmentIdChanging(int value);
    partial void OnDepartmentIdChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    #endregion
		
		public DEPARTEMENT()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TASKSTATE")]
	public partial class TASKSTATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _StateName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public TASKSTATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.EMPLOYEE")]
	public partial class EMPLOYEE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private int _UserNumber;
		
		private string _NameEmployee;
		
		private string _ImagePath;
		
		private int _DepartmentId;
		
		private int _PositionId;
		
		private int _Salary;
		
		private System.Nullable<System.DateTime> _BirthDay;
		
		private string _Adress;
		
		private string _Password;
		
		private System.Nullable<bool> _isAdmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnUserNumberChanging(int value);
    partial void OnUserNumberChanged();
    partial void OnNameEmployeeChanging(string value);
    partial void OnNameEmployeeChanged();
    partial void OnImagePathChanging(string value);
    partial void OnImagePathChanged();
    partial void OnDepartmentIdChanging(int value);
    partial void OnDepartmentIdChanged();
    partial void OnPositionIdChanging(int value);
    partial void OnPositionIdChanged();
    partial void OnSalaryChanging(int value);
    partial void OnSalaryChanged();
    partial void OnBirthDayChanging(System.Nullable<System.DateTime> value);
    partial void OnBirthDayChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnisAdminChanging(System.Nullable<bool> value);
    partial void OnisAdminChanged();
    #endregion
		
		public EMPLOYEE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserNumber", DbType="Int NOT NULL")]
		public int UserNumber
		{
			get
			{
				return this._UserNumber;
			}
			set
			{
				if ((this._UserNumber != value))
				{
					this.OnUserNumberChanging(value);
					this.SendPropertyChanging();
					this._UserNumber = value;
					this.SendPropertyChanged("UserNumber");
					this.OnUserNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameEmployee", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string NameEmployee
		{
			get
			{
				return this._NameEmployee;
			}
			set
			{
				if ((this._NameEmployee != value))
				{
					this.OnNameEmployeeChanging(value);
					this.SendPropertyChanging();
					this._NameEmployee = value;
					this.SendPropertyChanged("NameEmployee");
					this.OnNameEmployeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImagePath", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ImagePath
		{
			get
			{
				return this._ImagePath;
			}
			set
			{
				if ((this._ImagePath != value))
				{
					this.OnImagePathChanging(value);
					this.SendPropertyChanging();
					this._ImagePath = value;
					this.SendPropertyChanged("ImagePath");
					this.OnImagePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int NOT NULL")]
		public int DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionId", DbType="Int NOT NULL")]
		public int PositionId
		{
			get
			{
				return this._PositionId;
			}
			set
			{
				if ((this._PositionId != value))
				{
					this.OnPositionIdChanging(value);
					this.SendPropertyChanging();
					this._PositionId = value;
					this.SendPropertyChanged("PositionId");
					this.OnPositionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Salary", DbType="Int NOT NULL")]
		public int Salary
		{
			get
			{
				return this._Salary;
			}
			set
			{
				if ((this._Salary != value))
				{
					this.OnSalaryChanging(value);
					this.SendPropertyChanging();
					this._Salary = value;
					this.SendPropertyChanged("Salary");
					this.OnSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDay", DbType="Date")]
		public System.Nullable<System.DateTime> BirthDay
		{
			get
			{
				return this._BirthDay;
			}
			set
			{
				if ((this._BirthDay != value))
				{
					this.OnBirthDayChanging(value);
					this.SendPropertyChanging();
					this._BirthDay = value;
					this.SendPropertyChanged("BirthDay");
					this.OnBirthDayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="VarChar(MAX)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAdmin", DbType="Bit")]
		public System.Nullable<bool> isAdmin
		{
			get
			{
				return this._isAdmin;
			}
			set
			{
				if ((this._isAdmin != value))
				{
					this.OnisAdminChanging(value);
					this.SendPropertyChanging();
					this._isAdmin = value;
					this.SendPropertyChanged("isAdmin");
					this.OnisAdminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MONTHS")]
	public partial class MONTH : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _Id;
		
		private string _Month1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(short value);
    partial void OnIdChanged();
    partial void OnMonth1Changing(string value);
    partial void OnMonth1Changed();
    #endregion
		
		public MONTH()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="SmallInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public short Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Month", Storage="_Month1", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Month1
		{
			get
			{
				return this._Month1;
			}
			set
			{
				if ((this._Month1 != value))
				{
					this.OnMonth1Changing(value);
					this.SendPropertyChanging();
					this._Month1 = value;
					this.SendPropertyChanged("Month1");
					this.OnMonth1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERMISSION")]
	public partial class PERMISSION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PermissionId;
		
		private int _EmployeeId;
		
		private System.DateTime _PermissionStartDate;
		
		private System.DateTime _PermissionEndDate;
		
		private int _PermissionState;
		
		private string _PermissionExplanation;
		
		private int _PermissionDay;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPermissionIdChanging(int value);
    partial void OnPermissionIdChanged();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnPermissionStartDateChanging(System.DateTime value);
    partial void OnPermissionStartDateChanged();
    partial void OnPermissionEndDateChanging(System.DateTime value);
    partial void OnPermissionEndDateChanged();
    partial void OnPermissionStateChanging(int value);
    partial void OnPermissionStateChanged();
    partial void OnPermissionExplanationChanging(string value);
    partial void OnPermissionExplanationChanged();
    partial void OnPermissionDayChanging(int value);
    partial void OnPermissionDayChanged();
    #endregion
		
		public PERMISSION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PermissionId
		{
			get
			{
				return this._PermissionId;
			}
			set
			{
				if ((this._PermissionId != value))
				{
					this.OnPermissionIdChanging(value);
					this.SendPropertyChanging();
					this._PermissionId = value;
					this.SendPropertyChanged("PermissionId");
					this.OnPermissionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int NOT NULL")]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionStartDate", DbType="Date NOT NULL")]
		public System.DateTime PermissionStartDate
		{
			get
			{
				return this._PermissionStartDate;
			}
			set
			{
				if ((this._PermissionStartDate != value))
				{
					this.OnPermissionStartDateChanging(value);
					this.SendPropertyChanging();
					this._PermissionStartDate = value;
					this.SendPropertyChanged("PermissionStartDate");
					this.OnPermissionStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionEndDate", DbType="Date NOT NULL")]
		public System.DateTime PermissionEndDate
		{
			get
			{
				return this._PermissionEndDate;
			}
			set
			{
				if ((this._PermissionEndDate != value))
				{
					this.OnPermissionEndDateChanging(value);
					this.SendPropertyChanging();
					this._PermissionEndDate = value;
					this.SendPropertyChanged("PermissionEndDate");
					this.OnPermissionEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionState", DbType="Int NOT NULL")]
		public int PermissionState
		{
			get
			{
				return this._PermissionState;
			}
			set
			{
				if ((this._PermissionState != value))
				{
					this.OnPermissionStateChanging(value);
					this.SendPropertyChanging();
					this._PermissionState = value;
					this.SendPropertyChanged("PermissionState");
					this.OnPermissionStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionExplanation", DbType="VarChar(MAX)")]
		public string PermissionExplanation
		{
			get
			{
				return this._PermissionExplanation;
			}
			set
			{
				if ((this._PermissionExplanation != value))
				{
					this.OnPermissionExplanationChanging(value);
					this.SendPropertyChanging();
					this._PermissionExplanation = value;
					this.SendPropertyChanged("PermissionExplanation");
					this.OnPermissionExplanationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PermissionDay", DbType="Int NOT NULL")]
		public int PermissionDay
		{
			get
			{
				return this._PermissionDay;
			}
			set
			{
				if ((this._PermissionDay != value))
				{
					this.OnPermissionDayChanging(value);
					this.SendPropertyChanging();
					this._PermissionDay = value;
					this.SendPropertyChanged("PermissionDay");
					this.OnPermissionDayChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PERMISSIONSTATE")]
	public partial class PERMISSIONSTATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _StateName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStateNameChanging(string value);
    partial void OnStateNameChanged();
    #endregion
		
		public PERMISSIONSTATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StateName", DbType="VarChar(50)")]
		public string StateName
		{
			get
			{
				return this._StateName;
			}
			set
			{
				if ((this._StateName != value))
				{
					this.OnStateNameChanging(value);
					this.SendPropertyChanging();
					this._StateName = value;
					this.SendPropertyChanged("StateName");
					this.OnStateNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.POSITION")]
	public partial class POSITION : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PositionId;
		
		private string _PositionName;
		
		private int _DepartmentId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPositionIdChanging(int value);
    partial void OnPositionIdChanged();
    partial void OnPositionNameChanging(string value);
    partial void OnPositionNameChanged();
    partial void OnDepartmentIdChanging(int value);
    partial void OnDepartmentIdChanged();
    #endregion
		
		public POSITION()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PositionId
		{
			get
			{
				return this._PositionId;
			}
			set
			{
				if ((this._PositionId != value))
				{
					this.OnPositionIdChanging(value);
					this.SendPropertyChanging();
					this._PositionId = value;
					this.SendPropertyChanged("PositionId");
					this.OnPositionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PositionName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string PositionName
		{
			get
			{
				return this._PositionName;
			}
			set
			{
				if ((this._PositionName != value))
				{
					this.OnPositionNameChanging(value);
					this.SendPropertyChanging();
					this._PositionName = value;
					this.SendPropertyChanged("PositionName");
					this.OnPositionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentId", DbType="Int NOT NULL")]
		public int DepartmentId
		{
			get
			{
				return this._DepartmentId;
			}
			set
			{
				if ((this._DepartmentId != value))
				{
					this.OnDepartmentIdChanging(value);
					this.SendPropertyChanging();
					this._DepartmentId = value;
					this.SendPropertyChanged("DepartmentId");
					this.OnDepartmentIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SALARY")]
	public partial class SALARY : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _EmployeeId;
		
		private System.Nullable<int> _Amount;
		
		private System.Nullable<int> _Year;
		
		private System.Nullable<short> _MonthId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    partial void OnAmountChanging(System.Nullable<int> value);
    partial void OnAmountChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnMonthIdChanging(System.Nullable<short> value);
    partial void OnMonthIdChanged();
    #endregion
		
		public SALARY()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Int")]
		public System.Nullable<int> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MonthId", DbType="SmallInt")]
		public System.Nullable<short> MonthId
		{
			get
			{
				return this._MonthId;
			}
			set
			{
				if ((this._MonthId != value))
				{
					this.OnMonthIdChanging(value);
					this.SendPropertyChanging();
					this._MonthId = value;
					this.SendPropertyChanged("MonthId");
					this.OnMonthIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TASK")]
	public partial class TASK
	{
		
		private System.Nullable<int> _TaskId;
		
		private System.Nullable<int> _EmployeeId;
		
		private string _TaskTitle;
		
		private string _TaskContent;
		
		private System.Nullable<System.DateTime> _TaskStartDate;
		
		private System.Nullable<System.DateTime> _TaskDeliveryDate;
		
		private System.Nullable<int> _TaskState;
		
		public TASK()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskId", DbType="Int")]
		public System.Nullable<int> TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				if ((this._TaskId != value))
				{
					this._TaskId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this._EmployeeId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskTitle", DbType="VarChar(50)")]
		public string TaskTitle
		{
			get
			{
				return this._TaskTitle;
			}
			set
			{
				if ((this._TaskTitle != value))
				{
					this._TaskTitle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskContent", DbType="VarChar(50)")]
		public string TaskContent
		{
			get
			{
				return this._TaskContent;
			}
			set
			{
				if ((this._TaskContent != value))
				{
					this._TaskContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskStartDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskStartDate
		{
			get
			{
				return this._TaskStartDate;
			}
			set
			{
				if ((this._TaskStartDate != value))
				{
					this._TaskStartDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskDeliveryDate", DbType="Date")]
		public System.Nullable<System.DateTime> TaskDeliveryDate
		{
			get
			{
				return this._TaskDeliveryDate;
			}
			set
			{
				if ((this._TaskDeliveryDate != value))
				{
					this._TaskDeliveryDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaskState", DbType="Int")]
		public System.Nullable<int> TaskState
		{
			get
			{
				return this._TaskState;
			}
			set
			{
				if ((this._TaskState != value))
				{
					this._TaskState = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
