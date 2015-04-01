

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSchool
{
    public partial class DBSchoolEntities : ObjectContext, IDBSchoolEntities
    {
        public const string ConnectionString = "name=DBSchoolEntities";
        public const string ContainerName = "DBSchoolEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public DBSchoolEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public DBSchoolEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public DBSchoolEntities(EntityConnection connection)
            : base(connection, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        #endregion
    	
    	/// <summary>
    	/// This should be configured before you access any entities collection as they
    	/// are lazy initialized.
    	/// </summary>
    	public MergeOption? EntitiesMergeOption { get; set; } 
    	
    	bool IDBSchoolEntities.CanPreCompile
    	{
    		get { return true; }
    	}
    
    	/// <summary>
    	/// This is used to make sure we can use lazy loading and still be able to bind to GridView using collection
        /// of mixed dynamic proxy and concrete poco class instances.
    	/// See http://connect.microsoft.com/VisualStudio/feedback/details/104485/gridview-targetexception-object-does-not-match-target-type
    	/// </summary>
    	public static void RegisterTypeDescriptionProviders()
    	{
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_ClassHistory>(), typeof(IAM_ClassHistory));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_GradeSubject>(), typeof(IAM_GradeSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Group4Campus>(), typeof(IAM_Group4Campus));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Group4Grade>(), typeof(IAM_Group4Grade));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Group4Specialty>(), typeof(IAM_Group4Specialty));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Group4Subject>(), typeof(IAM_Group4Subject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchCampus>(), typeof(IAM_SchCampus));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchClass>(), typeof(IAM_SchClass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchDept>(), typeof(IAM_SchDept));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchGrade>(), typeof(IAM_SchGrade));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchInfo>(), typeof(IAM_SchInfo));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchoolServer>(), typeof(IAM_SchoolServer));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchSpecialty>(), typeof(IAM_SchSpecialty));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchSubject>(), typeof(IAM_SchSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SchTerm>(), typeof(IAM_SchTerm));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_StuClass>(), typeof(IAM_StuClass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Student>(), typeof(IAM_Student));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Teacher>(), typeof(IAM_Teacher));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_TeaSubject>(), typeof(IAM_TeaSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VClass>(), typeof(VClass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VClassHistory>(), typeof(VClassHistory));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VClassOfCurrentTerm>(), typeof(VClassOfCurrentTerm));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VClassStudent>(), typeof(VClassStudent));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGrade>(), typeof(VGrade));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGradeSubject>(), typeof(VGradeSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4Campus>(), typeof(VGroup4Campus));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4CampusUser>(), typeof(VGroup4CampusUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4Grade>(), typeof(VGroup4Grade));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4GradeUser>(), typeof(VGroup4GradeUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4Specialty>(), typeof(VGroup4Specialty));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4SpecialtyUser>(), typeof(VGroup4SpecialtyUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4Subject>(), typeof(VGroup4Subject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup4SubjectUser>(), typeof(VGroup4SubjectUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VSchool>(), typeof(VSchool));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudent>(), typeof(VStudent));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentSubject>(), typeof(VStudentSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VSubject>(), typeof(VSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VTeacher>(), typeof(VTeacher));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VTeaSubject>(), typeof(VTeaSubject));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<IAM_ClassHistory> IAM_ClassHistory
        {
            get { 
    			if (_iAM_ClassHistory == null) {
    				_iAM_ClassHistory = CreateObjectSet<IAM_ClassHistory>("IAM_ClassHistory"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_ClassHistory.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_ClassHistory;
    		}
        }
        private ObjectSet<IAM_ClassHistory> _iAM_ClassHistory;
        IObjectSet<IAM_ClassHistory> IDBSchoolEntities.IAM_ClassHistory
        {
            get { return this.IAM_ClassHistory; }
        }
    
        public ObjectSet<IAM_GradeSubject> IAM_GradeSubject
        {
            get { 
    			if (_iAM_GradeSubject == null) {
    				_iAM_GradeSubject = CreateObjectSet<IAM_GradeSubject>("IAM_GradeSubject"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_GradeSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_GradeSubject;
    		}
        }
        private ObjectSet<IAM_GradeSubject> _iAM_GradeSubject;
        IObjectSet<IAM_GradeSubject> IDBSchoolEntities.IAM_GradeSubject
        {
            get { return this.IAM_GradeSubject; }
        }
    
        public ObjectSet<IAM_Group4Campus> IAM_Group4Campus
        {
            get { 
    			if (_iAM_Group4Campus == null) {
    				_iAM_Group4Campus = CreateObjectSet<IAM_Group4Campus>("IAM_Group4Campus"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Group4Campus.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Group4Campus;
    		}
        }
        private ObjectSet<IAM_Group4Campus> _iAM_Group4Campus;
        IObjectSet<IAM_Group4Campus> IDBSchoolEntities.IAM_Group4Campus
        {
            get { return this.IAM_Group4Campus; }
        }
    
        public ObjectSet<IAM_Group4Grade> IAM_Group4Grade
        {
            get { 
    			if (_iAM_Group4Grade == null) {
    				_iAM_Group4Grade = CreateObjectSet<IAM_Group4Grade>("IAM_Group4Grade"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Group4Grade.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Group4Grade;
    		}
        }
        private ObjectSet<IAM_Group4Grade> _iAM_Group4Grade;
        IObjectSet<IAM_Group4Grade> IDBSchoolEntities.IAM_Group4Grade
        {
            get { return this.IAM_Group4Grade; }
        }
    
        public ObjectSet<IAM_Group4Specialty> IAM_Group4Specialty
        {
            get { 
    			if (_iAM_Group4Specialty == null) {
    				_iAM_Group4Specialty = CreateObjectSet<IAM_Group4Specialty>("IAM_Group4Specialty"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Group4Specialty.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Group4Specialty;
    		}
        }
        private ObjectSet<IAM_Group4Specialty> _iAM_Group4Specialty;
        IObjectSet<IAM_Group4Specialty> IDBSchoolEntities.IAM_Group4Specialty
        {
            get { return this.IAM_Group4Specialty; }
        }
    
        public ObjectSet<IAM_Group4Subject> IAM_Group4Subject
        {
            get { 
    			if (_iAM_Group4Subject == null) {
    				_iAM_Group4Subject = CreateObjectSet<IAM_Group4Subject>("IAM_Group4Subject"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Group4Subject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Group4Subject;
    		}
        }
        private ObjectSet<IAM_Group4Subject> _iAM_Group4Subject;
        IObjectSet<IAM_Group4Subject> IDBSchoolEntities.IAM_Group4Subject
        {
            get { return this.IAM_Group4Subject; }
        }
    
        public ObjectSet<IAM_SchCampus> IAM_SchCampus
        {
            get { 
    			if (_iAM_SchCampus == null) {
    				_iAM_SchCampus = CreateObjectSet<IAM_SchCampus>("IAM_SchCampus"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchCampus.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchCampus;
    		}
        }
        private ObjectSet<IAM_SchCampus> _iAM_SchCampus;
        IObjectSet<IAM_SchCampus> IDBSchoolEntities.IAM_SchCampus
        {
            get { return this.IAM_SchCampus; }
        }
    
        public ObjectSet<IAM_SchClass> IAM_SchClass
        {
            get { 
    			if (_iAM_SchClass == null) {
    				_iAM_SchClass = CreateObjectSet<IAM_SchClass>("IAM_SchClass"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchClass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchClass;
    		}
        }
        private ObjectSet<IAM_SchClass> _iAM_SchClass;
        IObjectSet<IAM_SchClass> IDBSchoolEntities.IAM_SchClass
        {
            get { return this.IAM_SchClass; }
        }
    
        public ObjectSet<IAM_SchDept> IAM_SchDept
        {
            get { 
    			if (_iAM_SchDept == null) {
    				_iAM_SchDept = CreateObjectSet<IAM_SchDept>("IAM_SchDept"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchDept.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchDept;
    		}
        }
        private ObjectSet<IAM_SchDept> _iAM_SchDept;
        IObjectSet<IAM_SchDept> IDBSchoolEntities.IAM_SchDept
        {
            get { return this.IAM_SchDept; }
        }
    
        public ObjectSet<IAM_SchGrade> IAM_SchGrade
        {
            get { 
    			if (_iAM_SchGrade == null) {
    				_iAM_SchGrade = CreateObjectSet<IAM_SchGrade>("IAM_SchGrade"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchGrade.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchGrade;
    		}
        }
        private ObjectSet<IAM_SchGrade> _iAM_SchGrade;
        IObjectSet<IAM_SchGrade> IDBSchoolEntities.IAM_SchGrade
        {
            get { return this.IAM_SchGrade; }
        }
    
        public ObjectSet<IAM_SchInfo> IAM_SchInfo
        {
            get { 
    			if (_iAM_SchInfo == null) {
    				_iAM_SchInfo = CreateObjectSet<IAM_SchInfo>("IAM_SchInfo"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchInfo.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchInfo;
    		}
        }
        private ObjectSet<IAM_SchInfo> _iAM_SchInfo;
        IObjectSet<IAM_SchInfo> IDBSchoolEntities.IAM_SchInfo
        {
            get { return this.IAM_SchInfo; }
        }
    
        public ObjectSet<IAM_SchoolServer> IAM_SchoolServer
        {
            get { 
    			if (_iAM_SchoolServer == null) {
    				_iAM_SchoolServer = CreateObjectSet<IAM_SchoolServer>("IAM_SchoolServer"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchoolServer.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchoolServer;
    		}
        }
        private ObjectSet<IAM_SchoolServer> _iAM_SchoolServer;
        IObjectSet<IAM_SchoolServer> IDBSchoolEntities.IAM_SchoolServer
        {
            get { return this.IAM_SchoolServer; }
        }
    
        public ObjectSet<IAM_SchSpecialty> IAM_SchSpecialty
        {
            get { 
    			if (_iAM_SchSpecialty == null) {
    				_iAM_SchSpecialty = CreateObjectSet<IAM_SchSpecialty>("IAM_SchSpecialty"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchSpecialty.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchSpecialty;
    		}
        }
        private ObjectSet<IAM_SchSpecialty> _iAM_SchSpecialty;
        IObjectSet<IAM_SchSpecialty> IDBSchoolEntities.IAM_SchSpecialty
        {
            get { return this.IAM_SchSpecialty; }
        }
    
        public ObjectSet<IAM_SchSubject> IAM_SchSubject
        {
            get { 
    			if (_iAM_SchSubject == null) {
    				_iAM_SchSubject = CreateObjectSet<IAM_SchSubject>("IAM_SchSubject"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchSubject;
    		}
        }
        private ObjectSet<IAM_SchSubject> _iAM_SchSubject;
        IObjectSet<IAM_SchSubject> IDBSchoolEntities.IAM_SchSubject
        {
            get { return this.IAM_SchSubject; }
        }
    
        public ObjectSet<IAM_SchTerm> IAM_SchTerm
        {
            get { 
    			if (_iAM_SchTerm == null) {
    				_iAM_SchTerm = CreateObjectSet<IAM_SchTerm>("IAM_SchTerm"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SchTerm.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SchTerm;
    		}
        }
        private ObjectSet<IAM_SchTerm> _iAM_SchTerm;
        IObjectSet<IAM_SchTerm> IDBSchoolEntities.IAM_SchTerm
        {
            get { return this.IAM_SchTerm; }
        }
    
        public ObjectSet<IAM_StuClass> IAM_StuClass
        {
            get { 
    			if (_iAM_StuClass == null) {
    				_iAM_StuClass = CreateObjectSet<IAM_StuClass>("IAM_StuClass"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_StuClass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_StuClass;
    		}
        }
        private ObjectSet<IAM_StuClass> _iAM_StuClass;
        IObjectSet<IAM_StuClass> IDBSchoolEntities.IAM_StuClass
        {
            get { return this.IAM_StuClass; }
        }
    
        public ObjectSet<IAM_Student> IAM_Student
        {
            get { 
    			if (_iAM_Student == null) {
    				_iAM_Student = CreateObjectSet<IAM_Student>("IAM_Student"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Student.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Student;
    		}
        }
        private ObjectSet<IAM_Student> _iAM_Student;
        IObjectSet<IAM_Student> IDBSchoolEntities.IAM_Student
        {
            get { return this.IAM_Student; }
        }
    
        public ObjectSet<IAM_Teacher> IAM_Teacher
        {
            get { 
    			if (_iAM_Teacher == null) {
    				_iAM_Teacher = CreateObjectSet<IAM_Teacher>("IAM_Teacher"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Teacher.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Teacher;
    		}
        }
        private ObjectSet<IAM_Teacher> _iAM_Teacher;
        IObjectSet<IAM_Teacher> IDBSchoolEntities.IAM_Teacher
        {
            get { return this.IAM_Teacher; }
        }
    
        public ObjectSet<IAM_TeaSubject> IAM_TeaSubject
        {
            get { 
    			if (_iAM_TeaSubject == null) {
    				_iAM_TeaSubject = CreateObjectSet<IAM_TeaSubject>("IAM_TeaSubject"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_TeaSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_TeaSubject;
    		}
        }
        private ObjectSet<IAM_TeaSubject> _iAM_TeaSubject;
        IObjectSet<IAM_TeaSubject> IDBSchoolEntities.IAM_TeaSubject
        {
            get { return this.IAM_TeaSubject; }
        }
    
        public ObjectSet<VClass> VClass
        {
            get { 
    			if (_vClass == null) {
    				_vClass = CreateObjectSet<VClass>("VClass"); 
    				if (EntitiesMergeOption != null) {
    					_vClass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vClass;
    		}
        }
        private ObjectSet<VClass> _vClass;
        IObjectSet<VClass> IDBSchoolEntities.VClass
        {
            get { return this.VClass; }
        }
    
        public ObjectSet<VClassHistory> VClassHistory
        {
            get { 
    			if (_vClassHistory == null) {
    				_vClassHistory = CreateObjectSet<VClassHistory>("VClassHistory"); 
    				if (EntitiesMergeOption != null) {
    					_vClassHistory.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vClassHistory;
    		}
        }
        private ObjectSet<VClassHistory> _vClassHistory;
        IObjectSet<VClassHistory> IDBSchoolEntities.VClassHistory
        {
            get { return this.VClassHistory; }
        }
    
        public ObjectSet<VClassOfCurrentTerm> VClassOfCurrentTerm
        {
            get { 
    			if (_vClassOfCurrentTerm == null) {
    				_vClassOfCurrentTerm = CreateObjectSet<VClassOfCurrentTerm>("VClassOfCurrentTerm"); 
    				if (EntitiesMergeOption != null) {
    					_vClassOfCurrentTerm.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vClassOfCurrentTerm;
    		}
        }
        private ObjectSet<VClassOfCurrentTerm> _vClassOfCurrentTerm;
        IObjectSet<VClassOfCurrentTerm> IDBSchoolEntities.VClassOfCurrentTerm
        {
            get { return this.VClassOfCurrentTerm; }
        }
    
        public ObjectSet<VClassStudent> VClassStudent
        {
            get { 
    			if (_vClassStudent == null) {
    				_vClassStudent = CreateObjectSet<VClassStudent>("VClassStudent"); 
    				if (EntitiesMergeOption != null) {
    					_vClassStudent.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vClassStudent;
    		}
        }
        private ObjectSet<VClassStudent> _vClassStudent;
        IObjectSet<VClassStudent> IDBSchoolEntities.VClassStudent
        {
            get { return this.VClassStudent; }
        }
    
        public ObjectSet<VGrade> VGrade
        {
            get { 
    			if (_vGrade == null) {
    				_vGrade = CreateObjectSet<VGrade>("VGrade"); 
    				if (EntitiesMergeOption != null) {
    					_vGrade.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGrade;
    		}
        }
        private ObjectSet<VGrade> _vGrade;
        IObjectSet<VGrade> IDBSchoolEntities.VGrade
        {
            get { return this.VGrade; }
        }
    
        public ObjectSet<VGradeSubject> VGradeSubject
        {
            get { 
    			if (_vGradeSubject == null) {
    				_vGradeSubject = CreateObjectSet<VGradeSubject>("VGradeSubject"); 
    				if (EntitiesMergeOption != null) {
    					_vGradeSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGradeSubject;
    		}
        }
        private ObjectSet<VGradeSubject> _vGradeSubject;
        IObjectSet<VGradeSubject> IDBSchoolEntities.VGradeSubject
        {
            get { return this.VGradeSubject; }
        }
    
        public ObjectSet<VGroup4Campus> VGroup4Campus
        {
            get { 
    			if (_vGroup4Campus == null) {
    				_vGroup4Campus = CreateObjectSet<VGroup4Campus>("VGroup4Campus"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4Campus.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4Campus;
    		}
        }
        private ObjectSet<VGroup4Campus> _vGroup4Campus;
        IObjectSet<VGroup4Campus> IDBSchoolEntities.VGroup4Campus
        {
            get { return this.VGroup4Campus; }
        }
    
        public ObjectSet<VGroup4CampusUser> VGroup4CampusUser
        {
            get { 
    			if (_vGroup4CampusUser == null) {
    				_vGroup4CampusUser = CreateObjectSet<VGroup4CampusUser>("VGroup4CampusUser"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4CampusUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4CampusUser;
    		}
        }
        private ObjectSet<VGroup4CampusUser> _vGroup4CampusUser;
        IObjectSet<VGroup4CampusUser> IDBSchoolEntities.VGroup4CampusUser
        {
            get { return this.VGroup4CampusUser; }
        }
    
        public ObjectSet<VGroup4Grade> VGroup4Grade
        {
            get { 
    			if (_vGroup4Grade == null) {
    				_vGroup4Grade = CreateObjectSet<VGroup4Grade>("VGroup4Grade"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4Grade.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4Grade;
    		}
        }
        private ObjectSet<VGroup4Grade> _vGroup4Grade;
        IObjectSet<VGroup4Grade> IDBSchoolEntities.VGroup4Grade
        {
            get { return this.VGroup4Grade; }
        }
    
        public ObjectSet<VGroup4GradeUser> VGroup4GradeUser
        {
            get { 
    			if (_vGroup4GradeUser == null) {
    				_vGroup4GradeUser = CreateObjectSet<VGroup4GradeUser>("VGroup4GradeUser"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4GradeUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4GradeUser;
    		}
        }
        private ObjectSet<VGroup4GradeUser> _vGroup4GradeUser;
        IObjectSet<VGroup4GradeUser> IDBSchoolEntities.VGroup4GradeUser
        {
            get { return this.VGroup4GradeUser; }
        }
    
        public ObjectSet<VGroup4Specialty> VGroup4Specialty
        {
            get { 
    			if (_vGroup4Specialty == null) {
    				_vGroup4Specialty = CreateObjectSet<VGroup4Specialty>("VGroup4Specialty"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4Specialty.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4Specialty;
    		}
        }
        private ObjectSet<VGroup4Specialty> _vGroup4Specialty;
        IObjectSet<VGroup4Specialty> IDBSchoolEntities.VGroup4Specialty
        {
            get { return this.VGroup4Specialty; }
        }
    
        public ObjectSet<VGroup4SpecialtyUser> VGroup4SpecialtyUser
        {
            get { 
    			if (_vGroup4SpecialtyUser == null) {
    				_vGroup4SpecialtyUser = CreateObjectSet<VGroup4SpecialtyUser>("VGroup4SpecialtyUser"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4SpecialtyUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4SpecialtyUser;
    		}
        }
        private ObjectSet<VGroup4SpecialtyUser> _vGroup4SpecialtyUser;
        IObjectSet<VGroup4SpecialtyUser> IDBSchoolEntities.VGroup4SpecialtyUser
        {
            get { return this.VGroup4SpecialtyUser; }
        }
    
        public ObjectSet<VGroup4Subject> VGroup4Subject
        {
            get { 
    			if (_vGroup4Subject == null) {
    				_vGroup4Subject = CreateObjectSet<VGroup4Subject>("VGroup4Subject"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4Subject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4Subject;
    		}
        }
        private ObjectSet<VGroup4Subject> _vGroup4Subject;
        IObjectSet<VGroup4Subject> IDBSchoolEntities.VGroup4Subject
        {
            get { return this.VGroup4Subject; }
        }
    
        public ObjectSet<VGroup4SubjectUser> VGroup4SubjectUser
        {
            get { 
    			if (_vGroup4SubjectUser == null) {
    				_vGroup4SubjectUser = CreateObjectSet<VGroup4SubjectUser>("VGroup4SubjectUser"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup4SubjectUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup4SubjectUser;
    		}
        }
        private ObjectSet<VGroup4SubjectUser> _vGroup4SubjectUser;
        IObjectSet<VGroup4SubjectUser> IDBSchoolEntities.VGroup4SubjectUser
        {
            get { return this.VGroup4SubjectUser; }
        }
    
        public ObjectSet<VSchool> VSchool
        {
            get { 
    			if (_vSchool == null) {
    				_vSchool = CreateObjectSet<VSchool>("VSchool"); 
    				if (EntitiesMergeOption != null) {
    					_vSchool.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vSchool;
    		}
        }
        private ObjectSet<VSchool> _vSchool;
        IObjectSet<VSchool> IDBSchoolEntities.VSchool
        {
            get { return this.VSchool; }
        }
    
        public ObjectSet<VStudent> VStudent
        {
            get { 
    			if (_vStudent == null) {
    				_vStudent = CreateObjectSet<VStudent>("VStudent"); 
    				if (EntitiesMergeOption != null) {
    					_vStudent.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudent;
    		}
        }
        private ObjectSet<VStudent> _vStudent;
        IObjectSet<VStudent> IDBSchoolEntities.VStudent
        {
            get { return this.VStudent; }
        }
    
        public ObjectSet<VStudentSubject> VStudentSubject
        {
            get { 
    			if (_vStudentSubject == null) {
    				_vStudentSubject = CreateObjectSet<VStudentSubject>("VStudentSubject"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentSubject;
    		}
        }
        private ObjectSet<VStudentSubject> _vStudentSubject;
        IObjectSet<VStudentSubject> IDBSchoolEntities.VStudentSubject
        {
            get { return this.VStudentSubject; }
        }
    
        public ObjectSet<VSubject> VSubject
        {
            get { 
    			if (_vSubject == null) {
    				_vSubject = CreateObjectSet<VSubject>("VSubject"); 
    				if (EntitiesMergeOption != null) {
    					_vSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vSubject;
    		}
        }
        private ObjectSet<VSubject> _vSubject;
        IObjectSet<VSubject> IDBSchoolEntities.VSubject
        {
            get { return this.VSubject; }
        }
    
        public ObjectSet<VTeacher> VTeacher
        {
            get { 
    			if (_vTeacher == null) {
    				_vTeacher = CreateObjectSet<VTeacher>("VTeacher"); 
    				if (EntitiesMergeOption != null) {
    					_vTeacher.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vTeacher;
    		}
        }
        private ObjectSet<VTeacher> _vTeacher;
        IObjectSet<VTeacher> IDBSchoolEntities.VTeacher
        {
            get { return this.VTeacher; }
        }
    
        public ObjectSet<VTeaSubject> VTeaSubject
        {
            get { 
    			if (_vTeaSubject == null) {
    				_vTeaSubject = CreateObjectSet<VTeaSubject>("VTeaSubject"); 
    				if (EntitiesMergeOption != null) {
    					_vTeaSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vTeaSubject;
    		}
        }
        private ObjectSet<VTeaSubject> _vTeaSubject;
        IObjectSet<VTeaSubject> IDBSchoolEntities.VTeaSubject
        {
            get { return this.VTeaSubject; }
        }

        #endregion

    }
}



