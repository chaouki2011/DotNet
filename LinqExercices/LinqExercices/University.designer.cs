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

namespace LinqExercices
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UniversityDB1")]
	public partial class UniversityDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertModule(Module instance);
    partial void UpdateModule(Module instance);
    partial void DeleteModule(Module instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertStudentModule(StudentModule instance);
    partial void UpdateStudentModule(StudentModule instance);
    partial void DeleteStudentModule(StudentModule instance);
    partial void InsertTeacher(Teacher instance);
    partial void UpdateTeacher(Teacher instance);
    partial void DeleteTeacher(Teacher instance);
    partial void InsertTeacherModule(TeacherModule instance);
    partial void UpdateTeacherModule(TeacherModule instance);
    partial void DeleteTeacherModule(TeacherModule instance);
    #endregion
		
		public UniversityDataContext() : 
				base(global::LinqExercices.Properties.Settings.Default.UniversityDB1ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public UniversityDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UniversityDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UniversityDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UniversityDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Module> Modules
		{
			get
			{
				return this.GetTable<Module>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<StudentModule> StudentModules
		{
			get
			{
				return this.GetTable<StudentModule>();
			}
		}
		
		public System.Data.Linq.Table<Teacher> Teachers
		{
			get
			{
				return this.GetTable<Teacher>();
			}
		}
		
		public System.Data.Linq.Table<TeacherModule> TeacherModules
		{
			get
			{
				return this.GetTable<TeacherModule>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Module")]
	public partial class Module : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<int> _nbHours;
		
		private EntitySet<TeacherModule> _TeacherModules;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnbHoursChanging(System.Nullable<int> value);
    partial void OnnbHoursChanged();
    #endregion
		
		public Module()
		{
			this._TeacherModules = new EntitySet<TeacherModule>(new Action<TeacherModule>(this.attach_TeacherModules), new Action<TeacherModule>(this.detach_TeacherModules));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nbHours", DbType="Int")]
		public System.Nullable<int> nbHours
		{
			get
			{
				return this._nbHours;
			}
			set
			{
				if ((this._nbHours != value))
				{
					this.OnnbHoursChanging(value);
					this.SendPropertyChanging();
					this._nbHours = value;
					this.SendPropertyChanged("nbHours");
					this.OnnbHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_TeacherModule", Storage="_TeacherModules", ThisKey="id", OtherKey="IdModule")]
		public EntitySet<TeacherModule> TeacherModules
		{
			get
			{
				return this._TeacherModules;
			}
			set
			{
				this._TeacherModules.Assign(value);
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
		
		private void attach_TeacherModules(TeacherModule entity)
		{
			this.SendPropertyChanging();
			entity.Module = this;
		}
		
		private void detach_TeacherModules(TeacherModule entity)
		{
			this.SendPropertyChanging();
			entity.Module = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.Nullable<System.DateTime> _bithday;
		
		private System.Data.Linq.Binary _photo;
		
		private EntitySet<StudentModule> _StudentModules;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnbithdayChanging(System.Nullable<System.DateTime> value);
    partial void OnbithdayChanged();
    partial void OnphotoChanging(System.Data.Linq.Binary value);
    partial void OnphotoChanged();
    #endregion
		
		public Student()
		{
			this._StudentModules = new EntitySet<StudentModule>(new Action<StudentModule>(this.attach_StudentModules), new Action<StudentModule>(this.detach_StudentModules));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bithday", DbType="DateTime")]
		public System.Nullable<System.DateTime> bithday
		{
			get
			{
				return this._bithday;
			}
			set
			{
				if ((this._bithday != value))
				{
					this.OnbithdayChanging(value);
					this.SendPropertyChanging();
					this._bithday = value;
					this.SendPropertyChanged("bithday");
					this.OnbithdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_StudentModule", Storage="_StudentModules", ThisKey="id", OtherKey="IdStudent")]
		public EntitySet<StudentModule> StudentModules
		{
			get
			{
				return this._StudentModules;
			}
			set
			{
				this._StudentModules.Assign(value);
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
		
		private void attach_StudentModules(StudentModule entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_StudentModules(StudentModule entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.StudentModule")]
	public partial class StudentModule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdStudent;
		
		private int _IdTeacher;
		
		private int _year;
		
		private System.Nullable<double> _average;
		
		private EntityRef<Student> _Student;
		
		private EntityRef<Teacher> _Teacher;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdStudentChanging(int value);
    partial void OnIdStudentChanged();
    partial void OnIdTeacherChanging(int value);
    partial void OnIdTeacherChanged();
    partial void OnyearChanging(int value);
    partial void OnyearChanged();
    partial void OnaverageChanging(System.Nullable<double> value);
    partial void OnaverageChanged();
    #endregion
		
		public StudentModule()
		{
			this._Student = default(EntityRef<Student>);
			this._Teacher = default(EntityRef<Teacher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdStudent", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdStudent
		{
			get
			{
				return this._IdStudent;
			}
			set
			{
				if ((this._IdStudent != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdStudentChanging(value);
					this.SendPropertyChanging();
					this._IdStudent = value;
					this.SendPropertyChanged("IdStudent");
					this.OnIdStudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTeacher", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdTeacher
		{
			get
			{
				return this._IdTeacher;
			}
			set
			{
				if ((this._IdTeacher != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTeacherChanging(value);
					this.SendPropertyChanging();
					this._IdTeacher = value;
					this.SendPropertyChanged("IdTeacher");
					this.OnIdTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_year", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int year
		{
			get
			{
				return this._year;
			}
			set
			{
				if ((this._year != value))
				{
					this.OnyearChanging(value);
					this.SendPropertyChanging();
					this._year = value;
					this.SendPropertyChanged("year");
					this.OnyearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_average", DbType="Float")]
		public System.Nullable<double> average
		{
			get
			{
				return this._average;
			}
			set
			{
				if ((this._average != value))
				{
					this.OnaverageChanging(value);
					this.SendPropertyChanging();
					this._average = value;
					this.SendPropertyChanged("average");
					this.OnaverageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_StudentModule", Storage="_Student", ThisKey="IdStudent", OtherKey="id", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.StudentModules.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.StudentModules.Add(this);
						this._IdStudent = value.id;
					}
					else
					{
						this._IdStudent = default(int);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_StudentModule", Storage="_Teacher", ThisKey="IdTeacher", OtherKey="id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.StudentModules.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.StudentModules.Add(this);
						this._IdTeacher = value.id;
					}
					else
					{
						this._IdTeacher = default(int);
					}
					this.SendPropertyChanged("Teacher");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teacher")]
	public partial class Teacher : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _grade;
		
		private EntitySet<StudentModule> _StudentModules;
		
		private EntitySet<TeacherModule> _TeacherModules;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OngradeChanging(string value);
    partial void OngradeChanged();
    #endregion
		
		public Teacher()
		{
			this._StudentModules = new EntitySet<StudentModule>(new Action<StudentModule>(this.attach_StudentModules), new Action<StudentModule>(this.detach_StudentModules));
			this._TeacherModules = new EntitySet<TeacherModule>(new Action<TeacherModule>(this.attach_TeacherModules), new Action<TeacherModule>(this.detach_TeacherModules));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_grade", DbType="VarChar(50)")]
		public string grade
		{
			get
			{
				return this._grade;
			}
			set
			{
				if ((this._grade != value))
				{
					this.OngradeChanging(value);
					this.SendPropertyChanging();
					this._grade = value;
					this.SendPropertyChanged("grade");
					this.OngradeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_StudentModule", Storage="_StudentModules", ThisKey="id", OtherKey="IdTeacher")]
		public EntitySet<StudentModule> StudentModules
		{
			get
			{
				return this._StudentModules;
			}
			set
			{
				this._StudentModules.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_TeacherModule", Storage="_TeacherModules", ThisKey="id", OtherKey="IdTeacher")]
		public EntitySet<TeacherModule> TeacherModules
		{
			get
			{
				return this._TeacherModules;
			}
			set
			{
				this._TeacherModules.Assign(value);
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
		
		private void attach_StudentModules(StudentModule entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_StudentModules(StudentModule entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
		
		private void attach_TeacherModules(TeacherModule entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = this;
		}
		
		private void detach_TeacherModules(TeacherModule entity)
		{
			this.SendPropertyChanging();
			entity.Teacher = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeacherModule")]
	public partial class TeacherModule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdTeacher;
		
		private int _IdModule;
		
		private System.Nullable<int> _NbHours;
		
		private EntityRef<Module> _Module;
		
		private EntityRef<Teacher> _Teacher;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdTeacherChanging(int value);
    partial void OnIdTeacherChanged();
    partial void OnIdModuleChanging(int value);
    partial void OnIdModuleChanged();
    partial void OnNbHoursChanging(System.Nullable<int> value);
    partial void OnNbHoursChanged();
    #endregion
		
		public TeacherModule()
		{
			this._Module = default(EntityRef<Module>);
			this._Teacher = default(EntityRef<Teacher>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdTeacher", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdTeacher
		{
			get
			{
				return this._IdTeacher;
			}
			set
			{
				if ((this._IdTeacher != value))
				{
					if (this._Teacher.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdTeacherChanging(value);
					this.SendPropertyChanging();
					this._IdTeacher = value;
					this.SendPropertyChanged("IdTeacher");
					this.OnIdTeacherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdModule", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IdModule
		{
			get
			{
				return this._IdModule;
			}
			set
			{
				if ((this._IdModule != value))
				{
					if (this._Module.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIdModuleChanging(value);
					this.SendPropertyChanging();
					this._IdModule = value;
					this.SendPropertyChanged("IdModule");
					this.OnIdModuleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NbHours", DbType="Int")]
		public System.Nullable<int> NbHours
		{
			get
			{
				return this._NbHours;
			}
			set
			{
				if ((this._NbHours != value))
				{
					this.OnNbHoursChanging(value);
					this.SendPropertyChanging();
					this._NbHours = value;
					this.SendPropertyChanged("NbHours");
					this.OnNbHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Module_TeacherModule", Storage="_Module", ThisKey="IdModule", OtherKey="id", IsForeignKey=true)]
		public Module Module
		{
			get
			{
				return this._Module.Entity;
			}
			set
			{
				Module previousValue = this._Module.Entity;
				if (((previousValue != value) 
							|| (this._Module.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Module.Entity = null;
						previousValue.TeacherModules.Remove(this);
					}
					this._Module.Entity = value;
					if ((value != null))
					{
						value.TeacherModules.Add(this);
						this._IdModule = value.id;
					}
					else
					{
						this._IdModule = default(int);
					}
					this.SendPropertyChanged("Module");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teacher_TeacherModule", Storage="_Teacher", ThisKey="IdTeacher", OtherKey="id", IsForeignKey=true)]
		public Teacher Teacher
		{
			get
			{
				return this._Teacher.Entity;
			}
			set
			{
				Teacher previousValue = this._Teacher.Entity;
				if (((previousValue != value) 
							|| (this._Teacher.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teacher.Entity = null;
						previousValue.TeacherModules.Remove(this);
					}
					this._Teacher.Entity = value;
					if ((value != null))
					{
						value.TeacherModules.Add(this);
						this._IdTeacher = value.id;
					}
					else
					{
						this._IdTeacher = default(int);
					}
					this.SendPropertyChanged("Teacher");
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