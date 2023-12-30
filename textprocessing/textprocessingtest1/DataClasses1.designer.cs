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

namespace textprocessingtest1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="scraper")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMW(MW instance);
    partial void UpdateMW(MW instance);
    partial void DeleteMW(MW instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::textprocessingtest1.Properties.Settings.Default.scraperConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MW> MWs
		{
			get
			{
				return this.GetTable<MW>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MWS")]
	public partial class MW : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Date_Added;
		
		private string _LInk_Added;
		
		private string _Match;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDate_AddedChanging(System.DateTime value);
    partial void OnDate_AddedChanged();
    partial void OnLInk_AddedChanging(string value);
    partial void OnLInk_AddedChanged();
    partial void OnMatchChanging(string value);
    partial void OnMatchChanged();
    #endregion
		
		public MW()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Added", DbType="DateTime NOT NULL")]
		public System.DateTime Date_Added
		{
			get
			{
				return this._Date_Added;
			}
			set
			{
				if ((this._Date_Added != value))
				{
					this.OnDate_AddedChanging(value);
					this.SendPropertyChanging();
					this._Date_Added = value;
					this.SendPropertyChanged("Date_Added");
					this.OnDate_AddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LInk_Added", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string LInk_Added
		{
			get
			{
				return this._LInk_Added;
			}
			set
			{
				if ((this._LInk_Added != value))
				{
					this.OnLInk_AddedChanging(value);
					this.SendPropertyChanging();
					this._LInk_Added = value;
					this.SendPropertyChanged("LInk_Added");
					this.OnLInk_AddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Match", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Match
		{
			get
			{
				return this._Match;
			}
			set
			{
				if ((this._Match != value))
				{
					this.OnMatchChanging(value);
					this.SendPropertyChanging();
					this._Match = value;
					this.SendPropertyChanged("Match");
					this.OnMatchChanged();
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