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

namespace De2.WPF
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCHOTHUENHA")]
	public partial class QLChoThueNhaDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNHA(NHA instance);
    partial void UpdateNHA(NHA instance);
    partial void DeleteNHA(NHA instance);
    partial void InsertKHACHTHUENHA(KHACHTHUENHA instance);
    partial void UpdateKHACHTHUENHA(KHACHTHUENHA instance);
    partial void DeleteKHACHTHUENHA(KHACHTHUENHA instance);
    partial void InsertHOPDONG(HOPDONG instance);
    partial void UpdateHOPDONG(HOPDONG instance);
    partial void DeleteHOPDONG(HOPDONG instance);
    #endregion
		
		public QLChoThueNhaDBDataContext() : 
				base(global::De2.WPF.Properties.Settings.Default.QLCHOTHUENHAConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QLChoThueNhaDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLChoThueNhaDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLChoThueNhaDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QLChoThueNhaDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<NHA> NHAs
		{
			get
			{
				return this.GetTable<NHA>();
			}
		}
		
		public System.Data.Linq.Table<KHACHTHUENHA> KHACHTHUENHAs
		{
			get
			{
				return this.GetTable<KHACHTHUENHA>();
			}
		}
		
		public System.Data.Linq.Table<HOPDONG> HOPDONGs
		{
			get
			{
				return this.GetTable<HOPDONG>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NHA")]
	public partial class NHA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNha;
		
		private string _TenChuNha;
		
		private double _GiaThue;
		
		private bool _DaCHoThue;
		
		private EntitySet<HOPDONG> _HOPDONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhaChanging(string value);
    partial void OnMaNhaChanged();
    partial void OnTenChuNhaChanging(string value);
    partial void OnTenChuNhaChanged();
    partial void OnGiaThueChanging(double value);
    partial void OnGiaThueChanged();
    partial void OnDaCHoThueChanging(bool value);
    partial void OnDaCHoThueChanged();
    #endregion
		
		public NHA()
		{
			this._HOPDONGs = new EntitySet<HOPDONG>(new Action<HOPDONG>(this.attach_HOPDONGs), new Action<HOPDONG>(this.detach_HOPDONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNha", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNha
		{
			get
			{
				return this._MaNha;
			}
			set
			{
				if ((this._MaNha != value))
				{
					this.OnMaNhaChanging(value);
					this.SendPropertyChanging();
					this._MaNha = value;
					this.SendPropertyChanged("MaNha");
					this.OnMaNhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenChuNha", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenChuNha
		{
			get
			{
				return this._TenChuNha;
			}
			set
			{
				if ((this._TenChuNha != value))
				{
					this.OnTenChuNhaChanging(value);
					this.SendPropertyChanging();
					this._TenChuNha = value;
					this.SendPropertyChanged("TenChuNha");
					this.OnTenChuNhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaThue", DbType="Float NOT NULL")]
		public double GiaThue
		{
			get
			{
				return this._GiaThue;
			}
			set
			{
				if ((this._GiaThue != value))
				{
					this.OnGiaThueChanging(value);
					this.SendPropertyChanging();
					this._GiaThue = value;
					this.SendPropertyChanged("GiaThue");
					this.OnGiaThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaCHoThue", DbType="Bit NOT NULL")]
		public bool DaCHoThue
		{
			get
			{
				return this._DaCHoThue;
			}
			set
			{
				if ((this._DaCHoThue != value))
				{
					this.OnDaCHoThueChanging(value);
					this.SendPropertyChanging();
					this._DaCHoThue = value;
					this.SendPropertyChanged("DaCHoThue");
					this.OnDaCHoThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHA_HOPDONG", Storage="_HOPDONGs", ThisKey="MaNha", OtherKey="MaNha")]
		public EntitySet<HOPDONG> HOPDONGs
		{
			get
			{
				return this._HOPDONGs;
			}
			set
			{
				this._HOPDONGs.Assign(value);
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
		
		private void attach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.NHA = this;
		}
		
		private void detach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.NHA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHTHUENHA")]
	public partial class KHACHTHUENHA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaKhach;
		
		private string _TenKhach;
		
		private bool _GioiTinh;
		
		private System.DateTime _NgaySinh;
		
		private EntitySet<HOPDONG> _HOPDONGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKhachChanging(string value);
    partial void OnMaKhachChanged();
    partial void OnTenKhachChanging(string value);
    partial void OnTenKhachChanged();
    partial void OnGioiTinhChanging(bool value);
    partial void OnGioiTinhChanged();
    partial void OnNgaySinhChanging(System.DateTime value);
    partial void OnNgaySinhChanged();
    #endregion
		
		public KHACHTHUENHA()
		{
			this._HOPDONGs = new EntitySet<HOPDONG>(new Action<HOPDONG>(this.attach_HOPDONGs), new Action<HOPDONG>(this.detach_HOPDONGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhach", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaKhach
		{
			get
			{
				return this._MaKhach;
			}
			set
			{
				if ((this._MaKhach != value))
				{
					this.OnMaKhachChanging(value);
					this.SendPropertyChanging();
					this._MaKhach = value;
					this.SendPropertyChanged("MaKhach");
					this.OnMaKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhach", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenKhach
		{
			get
			{
				return this._TenKhach;
			}
			set
			{
				if ((this._TenKhach != value))
				{
					this.OnTenKhachChanging(value);
					this.SendPropertyChanging();
					this._TenKhach = value;
					this.SendPropertyChanged("TenKhach");
					this.OnTenKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit NOT NULL")]
		public bool GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime NOT NULL")]
		public System.DateTime NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHTHUENHA_HOPDONG", Storage="_HOPDONGs", ThisKey="MaKhach", OtherKey="MaKhach")]
		public EntitySet<HOPDONG> HOPDONGs
		{
			get
			{
				return this._HOPDONGs;
			}
			set
			{
				this._HOPDONGs.Assign(value);
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
		
		private void attach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHTHUENHA = this;
		}
		
		private void detach_HOPDONGs(HOPDONG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHTHUENHA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HOPDONG")]
	public partial class HOPDONG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SoHD;
		
		private string _MaNha;
		
		private string _MaKhach;
		
		private System.DateTime _NgayBatDau;
		
		private System.DateTime _NgayKetThuc;
		
		private EntityRef<KHACHTHUENHA> _KHACHTHUENHA;
		
		private EntityRef<NHA> _NHA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSoHDChanging(int value);
    partial void OnSoHDChanged();
    partial void OnMaNhaChanging(string value);
    partial void OnMaNhaChanged();
    partial void OnMaKhachChanging(string value);
    partial void OnMaKhachChanged();
    partial void OnNgayBatDauChanging(System.DateTime value);
    partial void OnNgayBatDauChanged();
    partial void OnNgayKetThucChanging(System.DateTime value);
    partial void OnNgayKetThucChanged();
    #endregion
		
		public HOPDONG()
		{
			this._KHACHTHUENHA = default(EntityRef<KHACHTHUENHA>);
			this._NHA = default(EntityRef<NHA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoHD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SoHD
		{
			get
			{
				return this._SoHD;
			}
			set
			{
				if ((this._SoHD != value))
				{
					this.OnSoHDChanging(value);
					this.SendPropertyChanging();
					this._SoHD = value;
					this.SendPropertyChanged("SoHD");
					this.OnSoHDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNha", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MaNha
		{
			get
			{
				return this._MaNha;
			}
			set
			{
				if ((this._MaNha != value))
				{
					if (this._NHA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhaChanging(value);
					this.SendPropertyChanging();
					this._MaNha = value;
					this.SendPropertyChanged("MaNha");
					this.OnMaNhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKhach", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string MaKhach
		{
			get
			{
				return this._MaKhach;
			}
			set
			{
				if ((this._MaKhach != value))
				{
					if (this._KHACHTHUENHA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKhachChanging(value);
					this.SendPropertyChanging();
					this._MaKhach = value;
					this.SendPropertyChanged("MaKhach");
					this.OnMaKhachChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayBatDau", DbType="Date NOT NULL")]
		public System.DateTime NgayBatDau
		{
			get
			{
				return this._NgayBatDau;
			}
			set
			{
				if ((this._NgayBatDau != value))
				{
					this.OnNgayBatDauChanging(value);
					this.SendPropertyChanging();
					this._NgayBatDau = value;
					this.SendPropertyChanged("NgayBatDau");
					this.OnNgayBatDauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayKetThuc", DbType="Date NOT NULL")]
		public System.DateTime NgayKetThuc
		{
			get
			{
				return this._NgayKetThuc;
			}
			set
			{
				if ((this._NgayKetThuc != value))
				{
					this.OnNgayKetThucChanging(value);
					this.SendPropertyChanging();
					this._NgayKetThuc = value;
					this.SendPropertyChanged("NgayKetThuc");
					this.OnNgayKetThucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHTHUENHA_HOPDONG", Storage="_KHACHTHUENHA", ThisKey="MaKhach", OtherKey="MaKhach", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public KHACHTHUENHA KHACHTHUENHA
		{
			get
			{
				return this._KHACHTHUENHA.Entity;
			}
			set
			{
				KHACHTHUENHA previousValue = this._KHACHTHUENHA.Entity;
				if (((previousValue != value) 
							|| (this._KHACHTHUENHA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHTHUENHA.Entity = null;
						previousValue.HOPDONGs.Remove(this);
					}
					this._KHACHTHUENHA.Entity = value;
					if ((value != null))
					{
						value.HOPDONGs.Add(this);
						this._MaKhach = value.MaKhach;
					}
					else
					{
						this._MaKhach = default(string);
					}
					this.SendPropertyChanged("KHACHTHUENHA");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NHA_HOPDONG", Storage="_NHA", ThisKey="MaNha", OtherKey="MaNha", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public NHA NHA
		{
			get
			{
				return this._NHA.Entity;
			}
			set
			{
				NHA previousValue = this._NHA.Entity;
				if (((previousValue != value) 
							|| (this._NHA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NHA.Entity = null;
						previousValue.HOPDONGs.Remove(this);
					}
					this._NHA.Entity = value;
					if ((value != null))
					{
						value.HOPDONGs.Add(this);
						this._MaNha = value.MaNha;
					}
					else
					{
						this._MaNha = default(string);
					}
					this.SendPropertyChanged("NHA");
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
