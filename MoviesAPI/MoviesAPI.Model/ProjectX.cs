﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8789
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesAPI.Model
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
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Study")]
	public partial class ProjectXDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActor(Actor instance);
    partial void UpdateActor(Actor instance);
    partial void DeleteActor(Actor instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertMovie_Actor(Movie_Actor instance);
    partial void UpdateMovie_Actor(Movie_Actor instance);
    partial void DeleteMovie_Actor(Movie_Actor instance);
    partial void InsertProducer(Producer instance);
    partial void UpdateProducer(Producer instance);
    partial void DeleteProducer(Producer instance);
    #endregion
		
		public ProjectXDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectXDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectXDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectXDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Actor> Actors
		{
			get
			{
				return this.GetTable<Actor>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Movie_Actor> Movie_Actors
		{
			get
			{
				return this.GetTable<Movie_Actor>();
			}
		}
		
		public System.Data.Linq.Table<Producer> Producers
		{
			get
			{
				return this.GetTable<Producer>();
			}
		}
	}
	
	[Table(Name="dbo.Actor")]
	public partial class Actor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActorId;
		
		private string _ActorName;
		
		private System.Nullable<bool> _Gender;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private string _Bio;
		
		private EntitySet<Movie_Actor> _Movie_Actors;
		
		private EntitySet<Movie_Actor> _Actors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActorIdChanging(int value);
    partial void OnActorIdChanged();
    partial void OnActorNameChanging(string value);
    partial void OnActorNameChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfBirthChanged();
    partial void OnBioChanging(string value);
    partial void OnBioChanged();
    #endregion
		
		public Actor()
		{
			this._Movie_Actors = new EntitySet<Movie_Actor>(new Action<Movie_Actor>(this.attach_Movie_Actors), new Action<Movie_Actor>(this.detach_Movie_Actors));
			this._Actors = new EntitySet<Movie_Actor>(new Action<Movie_Actor>(this.attach_Actors), new Action<Movie_Actor>(this.detach_Actors));
			OnCreated();
		}
		
		[Column(Storage="_ActorId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ActorId
		{
			get
			{
				return this._ActorId;
			}
			set
			{
				if ((this._ActorId != value))
				{
					this.OnActorIdChanging(value);
					this.SendPropertyChanging();
					this._ActorId = value;
					this.SendPropertyChanged("ActorId");
					this.OnActorIdChanged();
				}
			}
		}
		
		[Column(Storage="_ActorName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ActorName
		{
			get
			{
				return this._ActorName;
			}
			set
			{
				if ((this._ActorName != value))
				{
					this.OnActorNameChanging(value);
					this.SendPropertyChanging();
					this._ActorName = value;
					this.SendPropertyChanged("ActorName");
					this.OnActorNameChanged();
				}
			}
		}
		
		[Column(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[Column(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[Column(Storage="_Bio", DbType="VarChar(255)")]
		public string Bio
		{
			get
			{
				return this._Bio;
			}
			set
			{
				if ((this._Bio != value))
				{
					this.OnBioChanging(value);
					this.SendPropertyChanging();
					this._Bio = value;
					this.SendPropertyChanged("Bio");
					this.OnBioChanged();
				}
			}
		}
		
		[Association(Name="FK__Movie_Act__Actor__1920BF5C", Storage="_Movie_Actors", ThisKey="ActorId", OtherKey="ActorID", DeleteRule="NO ACTION")]
		public EntitySet<Movie_Actor> Movie_Actors
		{
			get
			{
				return this._Movie_Actors;
			}
			set
			{
				this._Movie_Actors.Assign(value);
			}
		}
		
		[Association(Name="FK_ActorID", Storage="_Actors", ThisKey="ActorId", OtherKey="ActorID", DeleteRule="NO ACTION")]
		public EntitySet<Movie_Actor> Actors
		{
			get
			{
				return this._Actors;
			}
			set
			{
				this._Actors.Assign(value);
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
		
		private void attach_Movie_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.Actor = this;
		}
		
		private void detach_Movie_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.Actor = null;
		}
		
		private void attach_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.ActorID1 = this;
		}
		
		private void detach_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.ActorID1 = null;
		}
	}
	
	[Table(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeID;
		
		private string _EmployeeName;
		
		private string _Mobile;
		
		private string _Position;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(int value);
    partial void OnEmployeeIDChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[Column(Storage="_EmployeeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[Column(Storage="_EmployeeName", DbType="VarChar(100)")]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[Column(Storage="_Mobile", DbType="VarChar(10)")]
		public string Mobile
		{
			get
			{
				return this._Mobile;
			}
			set
			{
				if ((this._Mobile != value))
				{
					this.OnMobileChanging(value);
					this.SendPropertyChanging();
					this._Mobile = value;
					this.SendPropertyChanged("Mobile");
					this.OnMobileChanged();
				}
			}
		}
		
		[Column(Storage="_Position", DbType="VarChar(50)")]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
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
	
	[Table(Name="dbo.Movie")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieId;
		
		private string _MovieName;
		
		private int _ReleaseYear;
		
		private string _Plot;
		
		private System.Nullable<int> _ProducerId;
		
		private EntityRef<Producer> _Producer;
		
		private EntitySet<Movie_Actor> _Movie_Actors;
		
		private EntitySet<Movie_Actor> _Movies;
		
		private EntityRef<Producer> _ProducerID1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnMovieNameChanging(string value);
    partial void OnMovieNameChanged();
    partial void OnReleaseYearChanging(int value);
    partial void OnReleaseYearChanged();
    partial void OnPlotChanging(string value);
    partial void OnPlotChanged();
    partial void OnProducerIdChanging(System.Nullable<int> value);
    partial void OnProducerIdChanged();
    #endregion
		
		public Movie()
		{
			this._Producer = default(EntityRef<Producer>);
			this._Movie_Actors = new EntitySet<Movie_Actor>(new Action<Movie_Actor>(this.attach_Movie_Actors), new Action<Movie_Actor>(this.detach_Movie_Actors));
			this._Movies = new EntitySet<Movie_Actor>(new Action<Movie_Actor>(this.attach_Movies), new Action<Movie_Actor>(this.detach_Movies));
			this._ProducerID1 = default(EntityRef<Producer>);
			OnCreated();
		}
		
		[Column(Storage="_MovieId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[Column(Storage="_MovieName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string MovieName
		{
			get
			{
				return this._MovieName;
			}
			set
			{
				if ((this._MovieName != value))
				{
					this.OnMovieNameChanging(value);
					this.SendPropertyChanging();
					this._MovieName = value;
					this.SendPropertyChanged("MovieName");
					this.OnMovieNameChanged();
				}
			}
		}
		
		[Column(Storage="_ReleaseYear", DbType="Int NOT NULL")]
		public int ReleaseYear
		{
			get
			{
				return this._ReleaseYear;
			}
			set
			{
				if ((this._ReleaseYear != value))
				{
					this.OnReleaseYearChanging(value);
					this.SendPropertyChanging();
					this._ReleaseYear = value;
					this.SendPropertyChanged("ReleaseYear");
					this.OnReleaseYearChanged();
				}
			}
		}
		
		[Column(Storage="_Plot", DbType="VarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string Plot
		{
			get
			{
				return this._Plot;
			}
			set
			{
				if ((this._Plot != value))
				{
					this.OnPlotChanging(value);
					this.SendPropertyChanging();
					this._Plot = value;
					this.SendPropertyChanged("Plot");
					this.OnPlotChanged();
				}
			}
		}
		
		[Column(Storage="_ProducerId", DbType="Int")]
		public System.Nullable<int> ProducerId
		{
			get
			{
				return this._ProducerId;
			}
			set
			{
				if ((this._ProducerId != value))
				{
					if (this._Producer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProducerIdChanging(value);
					this.SendPropertyChanging();
					this._ProducerId = value;
					this.SendPropertyChanged("ProducerId");
					this.OnProducerIdChanged();
				}
			}
		}
		
		[Association(Name="FK__Movie__ProducerI__08EA5793", Storage="_Producer", ThisKey="ProducerId", OtherKey="ProducerID", IsForeignKey=true)]
		public Producer Producer
		{
			get
			{
				return this._Producer.Entity;
			}
			set
			{
				Producer previousValue = this._Producer.Entity;
				if (((previousValue != value) 
							|| (this._Producer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producer.Entity = null;
						previousValue.Movies.Remove(this);
					}
					this._Producer.Entity = value;
					if ((value != null))
					{
						value.Movies.Add(this);
						this._ProducerId = value.ProducerID;
					}
					else
					{
						this._ProducerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producer");
				}
			}
		}
		
		[Association(Name="FK__Movie_Act__Movie__182C9B23", Storage="_Movie_Actors", ThisKey="MovieId", OtherKey="MovieID", DeleteRule="NO ACTION")]
		public EntitySet<Movie_Actor> Movie_Actors
		{
			get
			{
				return this._Movie_Actors;
			}
			set
			{
				this._Movie_Actors.Assign(value);
			}
		}
		
		[Association(Name="FK_MovieID", Storage="_Movies", ThisKey="MovieId", OtherKey="MovieID", DeleteRule="NO ACTION")]
		public EntitySet<Movie_Actor> Movies
		{
			get
			{
				return this._Movies;
			}
			set
			{
				this._Movies.Assign(value);
			}
		}
		
		[Association(Name="FK_ProducerID", Storage="_ProducerID1", ThisKey="ProducerId", OtherKey="ProducerID", IsForeignKey=true)]
		public Producer ProducerID1
		{
			get
			{
				return this._ProducerID1.Entity;
			}
			set
			{
				Producer previousValue = this._ProducerID1.Entity;
				if (((previousValue != value) 
							|| (this._ProducerID1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ProducerID1.Entity = null;
						previousValue.Producers.Remove(this);
					}
					this._ProducerID1.Entity = value;
					if ((value != null))
					{
						value.Producers.Add(this);
						this._ProducerId = value.ProducerID;
					}
					else
					{
						this._ProducerId = default(Nullable<int>);
					}
					this.SendPropertyChanged("ProducerID1");
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
		
		private void attach_Movie_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_Movie_Actors(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
		
		private void attach_Movies(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.MovieID1 = this;
		}
		
		private void detach_Movies(Movie_Actor entity)
		{
			this.SendPropertyChanging();
			entity.MovieID1 = null;
		}
	}
	
	[Table(Name="dbo.Movie_Actor")]
	public partial class Movie_Actor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieID;
		
		private int _ActorID;
		
		private EntityRef<Actor> _Actor;
		
		private EntityRef<Movie> _Movie;
		
		private EntityRef<Actor> _ActorID1;
		
		private EntityRef<Movie> _MovieID1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnActorIDChanging(int value);
    partial void OnActorIDChanged();
    #endregion
		
		public Movie_Actor()
		{
			this._Actor = default(EntityRef<Actor>);
			this._Movie = default(EntityRef<Movie>);
			this._ActorID1 = default(EntityRef<Actor>);
			this._MovieID1 = default(EntityRef<Movie>);
			OnCreated();
		}
		
		[Column(Storage="_MovieID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_ActorID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ActorID
		{
			get
			{
				return this._ActorID;
			}
			set
			{
				if ((this._ActorID != value))
				{
					if (this._Actor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActorIDChanging(value);
					this.SendPropertyChanging();
					this._ActorID = value;
					this.SendPropertyChanged("ActorID");
					this.OnActorIDChanged();
				}
			}
		}
		
		[Association(Name="FK__Movie_Act__Actor__1920BF5C", Storage="_Actor", ThisKey="ActorID", OtherKey="ActorId", IsForeignKey=true)]
		public Actor Actor
		{
			get
			{
				return this._Actor.Entity;
			}
			set
			{
				Actor previousValue = this._Actor.Entity;
				if (((previousValue != value) 
							|| (this._Actor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Actor.Entity = null;
						previousValue.Movie_Actors.Remove(this);
					}
					this._Actor.Entity = value;
					if ((value != null))
					{
						value.Movie_Actors.Add(this);
						this._ActorID = value.ActorId;
					}
					else
					{
						this._ActorID = default(int);
					}
					this.SendPropertyChanged("Actor");
				}
			}
		}
		
		[Association(Name="FK__Movie_Act__Movie__182C9B23", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieId", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.Movie_Actors.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.Movie_Actors.Add(this);
						this._MovieID = value.MovieId;
					}
					else
					{
						this._MovieID = default(int);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		[Association(Name="FK_ActorID", Storage="_ActorID1", ThisKey="ActorID", OtherKey="ActorId", IsForeignKey=true)]
		public Actor ActorID1
		{
			get
			{
				return this._ActorID1.Entity;
			}
			set
			{
				Actor previousValue = this._ActorID1.Entity;
				if (((previousValue != value) 
							|| (this._ActorID1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ActorID1.Entity = null;
						previousValue.Actors.Remove(this);
					}
					this._ActorID1.Entity = value;
					if ((value != null))
					{
						value.Actors.Add(this);
						this._ActorID = value.ActorId;
					}
					else
					{
						this._ActorID = default(int);
					}
					this.SendPropertyChanged("ActorID1");
				}
			}
		}
		
		[Association(Name="FK_MovieID", Storage="_MovieID1", ThisKey="MovieID", OtherKey="MovieId", IsForeignKey=true)]
		public Movie MovieID1
		{
			get
			{
				return this._MovieID1.Entity;
			}
			set
			{
				Movie previousValue = this._MovieID1.Entity;
				if (((previousValue != value) 
							|| (this._MovieID1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MovieID1.Entity = null;
						previousValue.Movies.Remove(this);
					}
					this._MovieID1.Entity = value;
					if ((value != null))
					{
						value.Movies.Add(this);
						this._MovieID = value.MovieId;
					}
					else
					{
						this._MovieID = default(int);
					}
					this.SendPropertyChanged("MovieID1");
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
	
	[Table(Name="dbo.Producer")]
	public partial class Producer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProducerID;
		
		private string _ProducerName;
		
		private System.Nullable<bool> _Gender;
		
		private System.Nullable<System.DateTime> _DateOfBirth;
		
		private string _Bio;
		
		private EntitySet<Movie> _Movies;
		
		private EntitySet<Movie> _Producers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProducerIDChanging(int value);
    partial void OnProducerIDChanged();
    partial void OnProducerNameChanging(string value);
    partial void OnProducerNameChanged();
    partial void OnGenderChanging(System.Nullable<bool> value);
    partial void OnGenderChanged();
    partial void OnDateOfBirthChanging(System.Nullable<System.DateTime> value);
    partial void OnDateOfBirthChanged();
    partial void OnBioChanging(string value);
    partial void OnBioChanged();
    #endregion
		
		public Producer()
		{
			this._Movies = new EntitySet<Movie>(new Action<Movie>(this.attach_Movies), new Action<Movie>(this.detach_Movies));
			this._Producers = new EntitySet<Movie>(new Action<Movie>(this.attach_Producers), new Action<Movie>(this.detach_Producers));
			OnCreated();
		}
		
		[Column(Storage="_ProducerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProducerID
		{
			get
			{
				return this._ProducerID;
			}
			set
			{
				if ((this._ProducerID != value))
				{
					this.OnProducerIDChanging(value);
					this.SendPropertyChanging();
					this._ProducerID = value;
					this.SendPropertyChanged("ProducerID");
					this.OnProducerIDChanged();
				}
			}
		}
		
		[Column(Storage="_ProducerName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string ProducerName
		{
			get
			{
				return this._ProducerName;
			}
			set
			{
				if ((this._ProducerName != value))
				{
					this.OnProducerNameChanging(value);
					this.SendPropertyChanging();
					this._ProducerName = value;
					this.SendPropertyChanged("ProducerName");
					this.OnProducerNameChanged();
				}
			}
		}
		
		[Column(Storage="_Gender", DbType="Bit")]
		public System.Nullable<bool> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[Column(Storage="_DateOfBirth", DbType="Date")]
		public System.Nullable<System.DateTime> DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[Column(Storage="_Bio", DbType="VarChar(255)")]
		public string Bio
		{
			get
			{
				return this._Bio;
			}
			set
			{
				if ((this._Bio != value))
				{
					this.OnBioChanging(value);
					this.SendPropertyChanging();
					this._Bio = value;
					this.SendPropertyChanged("Bio");
					this.OnBioChanged();
				}
			}
		}
		
		[Association(Name="FK__Movie__ProducerI__08EA5793", Storage="_Movies", ThisKey="ProducerID", OtherKey="ProducerId", DeleteRule="NO ACTION")]
		public EntitySet<Movie> Movies
		{
			get
			{
				return this._Movies;
			}
			set
			{
				this._Movies.Assign(value);
			}
		}
		
		[Association(Name="FK_ProducerID", Storage="_Producers", ThisKey="ProducerID", OtherKey="ProducerId", DeleteRule="NO ACTION")]
		public EntitySet<Movie> Producers
		{
			get
			{
				return this._Producers;
			}
			set
			{
				this._Producers.Assign(value);
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
		
		private void attach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Producer = this;
		}
		
		private void detach_Movies(Movie entity)
		{
			this.SendPropertyChanging();
			entity.Producer = null;
		}
		
		private void attach_Producers(Movie entity)
		{
			this.SendPropertyChanging();
			entity.ProducerID1 = this;
		}
		
		private void detach_Producers(Movie entity)
		{
			this.SendPropertyChanging();
			entity.ProducerID1 = null;
		}
	}
}
#pragma warning restore 1591
