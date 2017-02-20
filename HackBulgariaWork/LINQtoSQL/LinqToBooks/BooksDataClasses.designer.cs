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

namespace LinqToBooks
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Entities")]
	public partial class BooksDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAuthor(Author instance);
    partial void UpdateAuthor(Author instance);
    partial void DeleteAuthor(Author instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    partial void InsertBooksLoaned(BooksLoaned instance);
    partial void UpdateBooksLoaned(BooksLoaned instance);
    partial void DeleteBooksLoaned(BooksLoaned instance);
    partial void InsertBooksWritten(BooksWritten instance);
    partial void UpdateBooksWritten(BooksWritten instance);
    partial void DeleteBooksWritten(BooksWritten instance);
    #endregion
		
		public BooksDataClassesDataContext() : 
				base(global::LinqToBooks.Properties.Settings.Default.EntitiesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BooksDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BooksDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BooksDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BooksDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		public System.Data.Linq.Table<BooksLoaned> BooksLoaneds
		{
			get
			{
				return this.GetTable<BooksLoaned>();
			}
		}
		
		public System.Data.Linq.Table<BooksWritten> BooksWrittens
		{
			get
			{
				return this.GetTable<BooksWritten>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Author")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private int _YearBorn;
		
		private System.Nullable<int> _YearDied;
		
		private EntitySet<BooksWritten> _BooksWrittens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnYearBornChanging(int value);
    partial void OnYearBornChanged();
    partial void OnYearDiedChanging(System.Nullable<int> value);
    partial void OnYearDiedChanged();
    #endregion
		
		public Author()
		{
			this._BooksWrittens = new EntitySet<BooksWritten>(new Action<BooksWritten>(this.attach_BooksWrittens), new Action<BooksWritten>(this.detach_BooksWrittens));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearBorn", DbType="Int NOT NULL")]
		public int YearBorn
		{
			get
			{
				return this._YearBorn;
			}
			set
			{
				if ((this._YearBorn != value))
				{
					this.OnYearBornChanging(value);
					this.SendPropertyChanging();
					this._YearBorn = value;
					this.SendPropertyChanged("YearBorn");
					this.OnYearBornChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearDied", DbType="Int")]
		public System.Nullable<int> YearDied
		{
			get
			{
				return this._YearDied;
			}
			set
			{
				if ((this._YearDied != value))
				{
					this.OnYearDiedChanging(value);
					this.SendPropertyChanging();
					this._YearDied = value;
					this.SendPropertyChanged("YearDied");
					this.OnYearDiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_BooksWritten", Storage="_BooksWrittens", ThisKey="ID", OtherKey="AuthorID")]
		public EntitySet<BooksWritten> BooksWrittens
		{
			get
			{
				return this._BooksWrittens;
			}
			set
			{
				this._BooksWrittens.Assign(value);
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
		
		private void attach_BooksWrittens(BooksWritten entity)
		{
			this.SendPropertyChanging();
			entity.Author = this;
		}
		
		private void detach_BooksWrittens(BooksWritten entity)
		{
			this.SendPropertyChanging();
			entity.Author = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _UserName;
		
		private string _Email;
		
		private long _Phone;
		
		private EntitySet<BooksLoaned> _BooksLoaneds;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(long value);
    partial void OnPhoneChanged();
    #endregion
		
		public User()
		{
			this._BooksLoaneds = new EntitySet<BooksLoaned>(new Action<BooksLoaned>(this.attach_BooksLoaneds), new Action<BooksLoaned>(this.detach_BooksLoaneds));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="BigInt NOT NULL")]
		public long Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BooksLoaned", Storage="_BooksLoaneds", ThisKey="ID", OtherKey="UserID")]
		public EntitySet<BooksLoaned> BooksLoaneds
		{
			get
			{
				return this._BooksLoaneds;
			}
			set
			{
				this._BooksLoaneds.Assign(value);
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
		
		private void attach_BooksLoaneds(BooksLoaned entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_BooksLoaneds(BooksLoaned entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Book")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Title;
		
		private string _Description;
		
		private System.DateTime _DatePublished;
		
		private string _Publisher;
		
		private string _Genre;
		
		private int _Pages;
		
		private int _ISBN;
		
		private EntitySet<BooksLoaned> _BooksLoaneds;
		
		private EntitySet<BooksWritten> _BooksWrittens;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnDatePublishedChanging(System.DateTime value);
    partial void OnDatePublishedChanged();
    partial void OnPublisherChanging(string value);
    partial void OnPublisherChanged();
    partial void OnGenreChanging(string value);
    partial void OnGenreChanged();
    partial void OnPagesChanging(int value);
    partial void OnPagesChanged();
    partial void OnISBNChanging(int value);
    partial void OnISBNChanged();
    #endregion
		
		public Book()
		{
			this._BooksLoaneds = new EntitySet<BooksLoaned>(new Action<BooksLoaned>(this.attach_BooksLoaneds), new Action<BooksLoaned>(this.detach_BooksLoaneds));
			this._BooksWrittens = new EntitySet<BooksWritten>(new Action<BooksWritten>(this.attach_BooksWrittens), new Action<BooksWritten>(this.detach_BooksWrittens));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DatePublished", DbType="Date NOT NULL")]
		public System.DateTime DatePublished
		{
			get
			{
				return this._DatePublished;
			}
			set
			{
				if ((this._DatePublished != value))
				{
					this.OnDatePublishedChanging(value);
					this.SendPropertyChanging();
					this._DatePublished = value;
					this.SendPropertyChanged("DatePublished");
					this.OnDatePublishedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Publisher", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Publisher
		{
			get
			{
				return this._Publisher;
			}
			set
			{
				if ((this._Publisher != value))
				{
					this.OnPublisherChanging(value);
					this.SendPropertyChanging();
					this._Publisher = value;
					this.SendPropertyChanged("Publisher");
					this.OnPublisherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genre", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Genre
		{
			get
			{
				return this._Genre;
			}
			set
			{
				if ((this._Genre != value))
				{
					this.OnGenreChanging(value);
					this.SendPropertyChanging();
					this._Genre = value;
					this.SendPropertyChanged("Genre");
					this.OnGenreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pages", DbType="Int NOT NULL")]
		public int Pages
		{
			get
			{
				return this._Pages;
			}
			set
			{
				if ((this._Pages != value))
				{
					this.OnPagesChanging(value);
					this.SendPropertyChanging();
					this._Pages = value;
					this.SendPropertyChanged("Pages");
					this.OnPagesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ISBN", DbType="Int NOT NULL")]
		public int ISBN
		{
			get
			{
				return this._ISBN;
			}
			set
			{
				if ((this._ISBN != value))
				{
					this.OnISBNChanging(value);
					this.SendPropertyChanging();
					this._ISBN = value;
					this.SendPropertyChanged("ISBN");
					this.OnISBNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BooksLoaned", Storage="_BooksLoaneds", ThisKey="ID", OtherKey="BookID")]
		public EntitySet<BooksLoaned> BooksLoaneds
		{
			get
			{
				return this._BooksLoaneds;
			}
			set
			{
				this._BooksLoaneds.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BooksWritten", Storage="_BooksWrittens", ThisKey="ID", OtherKey="BookID")]
		public EntitySet<BooksWritten> BooksWrittens
		{
			get
			{
				return this._BooksWrittens;
			}
			set
			{
				this._BooksWrittens.Assign(value);
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
		
		private void attach_BooksLoaneds(BooksLoaned entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_BooksLoaneds(BooksLoaned entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
		
		private void attach_BooksWrittens(BooksWritten entity)
		{
			this.SendPropertyChanging();
			entity.Book = this;
		}
		
		private void detach_BooksWrittens(BooksWritten entity)
		{
			this.SendPropertyChanging();
			entity.Book = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BooksLoaned")]
	public partial class BooksLoaned : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private int _BookID;
		
		private EntityRef<Book> _Book;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    #endregion
		
		public BooksLoaned()
		{
			this._Book = default(EntityRef<Book>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BooksLoaned", Storage="_Book", ThisKey="BookID", OtherKey="ID", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.BooksLoaneds.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.BooksLoaneds.Add(this);
						this._BookID = value.ID;
					}
					else
					{
						this._BookID = default(int);
					}
					this.SendPropertyChanged("Book");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_BooksLoaned", Storage="_User", ThisKey="UserID", OtherKey="ID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.BooksLoaneds.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.BooksLoaneds.Add(this);
						this._UserID = value.ID;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BooksWritten")]
	public partial class BooksWritten : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AuthorID;
		
		private int _BookID;
		
		private EntityRef<Author> _Author;
		
		private EntityRef<Book> _Book;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnBookIDChanging(int value);
    partial void OnBookIDChanged();
    #endregion
		
		public BooksWritten()
		{
			this._Author = default(EntityRef<Author>);
			this._Book = default(EntityRef<Book>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					if (this._Author.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BookID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BookID
		{
			get
			{
				return this._BookID;
			}
			set
			{
				if ((this._BookID != value))
				{
					if (this._Book.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnBookIDChanging(value);
					this.SendPropertyChanging();
					this._BookID = value;
					this.SendPropertyChanged("BookID");
					this.OnBookIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Author_BooksWritten", Storage="_Author", ThisKey="AuthorID", OtherKey="ID", IsForeignKey=true)]
		public Author Author
		{
			get
			{
				return this._Author.Entity;
			}
			set
			{
				Author previousValue = this._Author.Entity;
				if (((previousValue != value) 
							|| (this._Author.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Author.Entity = null;
						previousValue.BooksWrittens.Remove(this);
					}
					this._Author.Entity = value;
					if ((value != null))
					{
						value.BooksWrittens.Add(this);
						this._AuthorID = value.ID;
					}
					else
					{
						this._AuthorID = default(int);
					}
					this.SendPropertyChanged("Author");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Book_BooksWritten", Storage="_Book", ThisKey="BookID", OtherKey="ID", IsForeignKey=true)]
		public Book Book
		{
			get
			{
				return this._Book.Entity;
			}
			set
			{
				Book previousValue = this._Book.Entity;
				if (((previousValue != value) 
							|| (this._Book.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Book.Entity = null;
						previousValue.BooksWrittens.Remove(this);
					}
					this._Book.Entity = value;
					if ((value != null))
					{
						value.BooksWrittens.Add(this);
						this._BookID = value.ID;
					}
					else
					{
						this._BookID = default(int);
					}
					this.SendPropertyChanged("Book");
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
