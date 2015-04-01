

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSchoolCourse
{
    public partial class DBSchoolCourseEntities : ObjectContext, IDBSchoolCourseEntities
    {
        public const string ConnectionString = "name=DBSchoolCourseEntities";
        public const string ContainerName = "DBSchoolCourseEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public DBSchoolCourseEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public DBSchoolCourseEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public DBSchoolCourseEntities(EntityConnection connection)
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
    	
    	bool IDBSchoolCourseEntities.CanPreCompile
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
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_StuSelectedCourse>(), typeof(IAM_StuSelectedCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_TeaCourse>(), typeof(IAM_TeaCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_TeaCourseClass>(), typeof(IAM_TeaCourseClass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_TeaCourseItem>(), typeof(IAM_TeaCourseItem));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VClassTeacher>(), typeof(VClassTeacher));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VCourseStudentArrangement>(), typeof(VCourseStudentArrangement));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VCourseTeacherArrangement>(), typeof(VCourseTeacherArrangement));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentClassCourse>(), typeof(VStudentClassCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentCourse>(), typeof(VStudentCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentCourseOfSubject>(), typeof(VStudentCourseOfSubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentSelectedCourse>(), typeof(VStudentSelectedCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VStudentSelectedCourseItem>(), typeof(VStudentSelectedCourseItem));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VTeaCourse>(), typeof(VTeaCourse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VTeaCourseItemClass>(), typeof(VTeaCourseItemClass));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<IAM_StuSelectedCourse> IAM_StuSelectedCourse
        {
            get { 
    			if (_iAM_StuSelectedCourse == null) {
    				_iAM_StuSelectedCourse = CreateObjectSet<IAM_StuSelectedCourse>("IAM_StuSelectedCourse"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_StuSelectedCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_StuSelectedCourse;
    		}
        }
        private ObjectSet<IAM_StuSelectedCourse> _iAM_StuSelectedCourse;
        IObjectSet<IAM_StuSelectedCourse> IDBSchoolCourseEntities.IAM_StuSelectedCourse
        {
            get { return this.IAM_StuSelectedCourse; }
        }
    
        public ObjectSet<IAM_TeaCourse> IAM_TeaCourse
        {
            get { 
    			if (_iAM_TeaCourse == null) {
    				_iAM_TeaCourse = CreateObjectSet<IAM_TeaCourse>("IAM_TeaCourse"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_TeaCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_TeaCourse;
    		}
        }
        private ObjectSet<IAM_TeaCourse> _iAM_TeaCourse;
        IObjectSet<IAM_TeaCourse> IDBSchoolCourseEntities.IAM_TeaCourse
        {
            get { return this.IAM_TeaCourse; }
        }
    
        public ObjectSet<IAM_TeaCourseClass> IAM_TeaCourseClass
        {
            get { 
    			if (_iAM_TeaCourseClass == null) {
    				_iAM_TeaCourseClass = CreateObjectSet<IAM_TeaCourseClass>("IAM_TeaCourseClass"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_TeaCourseClass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_TeaCourseClass;
    		}
        }
        private ObjectSet<IAM_TeaCourseClass> _iAM_TeaCourseClass;
        IObjectSet<IAM_TeaCourseClass> IDBSchoolCourseEntities.IAM_TeaCourseClass
        {
            get { return this.IAM_TeaCourseClass; }
        }
    
        public ObjectSet<IAM_TeaCourseItem> IAM_TeaCourseItem
        {
            get { 
    			if (_iAM_TeaCourseItem == null) {
    				_iAM_TeaCourseItem = CreateObjectSet<IAM_TeaCourseItem>("IAM_TeaCourseItem"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_TeaCourseItem.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_TeaCourseItem;
    		}
        }
        private ObjectSet<IAM_TeaCourseItem> _iAM_TeaCourseItem;
        IObjectSet<IAM_TeaCourseItem> IDBSchoolCourseEntities.IAM_TeaCourseItem
        {
            get { return this.IAM_TeaCourseItem; }
        }
    
        public ObjectSet<VClassTeacher> VClassTeacher
        {
            get { 
    			if (_vClassTeacher == null) {
    				_vClassTeacher = CreateObjectSet<VClassTeacher>("VClassTeacher"); 
    				if (EntitiesMergeOption != null) {
    					_vClassTeacher.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vClassTeacher;
    		}
        }
        private ObjectSet<VClassTeacher> _vClassTeacher;
        IObjectSet<VClassTeacher> IDBSchoolCourseEntities.VClassTeacher
        {
            get { return this.VClassTeacher; }
        }
    
        public ObjectSet<VCourseStudentArrangement> VCourseStudentArrangement
        {
            get { 
    			if (_vCourseStudentArrangement == null) {
    				_vCourseStudentArrangement = CreateObjectSet<VCourseStudentArrangement>("VCourseStudentArrangement"); 
    				if (EntitiesMergeOption != null) {
    					_vCourseStudentArrangement.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vCourseStudentArrangement;
    		}
        }
        private ObjectSet<VCourseStudentArrangement> _vCourseStudentArrangement;
        IObjectSet<VCourseStudentArrangement> IDBSchoolCourseEntities.VCourseStudentArrangement
        {
            get { return this.VCourseStudentArrangement; }
        }
    
        public ObjectSet<VCourseTeacherArrangement> VCourseTeacherArrangement
        {
            get { 
    			if (_vCourseTeacherArrangement == null) {
    				_vCourseTeacherArrangement = CreateObjectSet<VCourseTeacherArrangement>("VCourseTeacherArrangement"); 
    				if (EntitiesMergeOption != null) {
    					_vCourseTeacherArrangement.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vCourseTeacherArrangement;
    		}
        }
        private ObjectSet<VCourseTeacherArrangement> _vCourseTeacherArrangement;
        IObjectSet<VCourseTeacherArrangement> IDBSchoolCourseEntities.VCourseTeacherArrangement
        {
            get { return this.VCourseTeacherArrangement; }
        }
    
        public ObjectSet<VStudentClassCourse> VStudentClassCourse
        {
            get { 
    			if (_vStudentClassCourse == null) {
    				_vStudentClassCourse = CreateObjectSet<VStudentClassCourse>("VStudentClassCourse"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentClassCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentClassCourse;
    		}
        }
        private ObjectSet<VStudentClassCourse> _vStudentClassCourse;
        IObjectSet<VStudentClassCourse> IDBSchoolCourseEntities.VStudentClassCourse
        {
            get { return this.VStudentClassCourse; }
        }
    
        public ObjectSet<VStudentCourse> VStudentCourse
        {
            get { 
    			if (_vStudentCourse == null) {
    				_vStudentCourse = CreateObjectSet<VStudentCourse>("VStudentCourse"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentCourse;
    		}
        }
        private ObjectSet<VStudentCourse> _vStudentCourse;
        IObjectSet<VStudentCourse> IDBSchoolCourseEntities.VStudentCourse
        {
            get { return this.VStudentCourse; }
        }
    
        public ObjectSet<VStudentCourseOfSubject> VStudentCourseOfSubject
        {
            get { 
    			if (_vStudentCourseOfSubject == null) {
    				_vStudentCourseOfSubject = CreateObjectSet<VStudentCourseOfSubject>("VStudentCourseOfSubject"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentCourseOfSubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentCourseOfSubject;
    		}
        }
        private ObjectSet<VStudentCourseOfSubject> _vStudentCourseOfSubject;
        IObjectSet<VStudentCourseOfSubject> IDBSchoolCourseEntities.VStudentCourseOfSubject
        {
            get { return this.VStudentCourseOfSubject; }
        }
    
        public ObjectSet<VStudentSelectedCourse> VStudentSelectedCourse
        {
            get { 
    			if (_vStudentSelectedCourse == null) {
    				_vStudentSelectedCourse = CreateObjectSet<VStudentSelectedCourse>("VStudentSelectedCourse"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentSelectedCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentSelectedCourse;
    		}
        }
        private ObjectSet<VStudentSelectedCourse> _vStudentSelectedCourse;
        IObjectSet<VStudentSelectedCourse> IDBSchoolCourseEntities.VStudentSelectedCourse
        {
            get { return this.VStudentSelectedCourse; }
        }
    
        public ObjectSet<VStudentSelectedCourseItem> VStudentSelectedCourseItem
        {
            get { 
    			if (_vStudentSelectedCourseItem == null) {
    				_vStudentSelectedCourseItem = CreateObjectSet<VStudentSelectedCourseItem>("VStudentSelectedCourseItem"); 
    				if (EntitiesMergeOption != null) {
    					_vStudentSelectedCourseItem.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vStudentSelectedCourseItem;
    		}
        }
        private ObjectSet<VStudentSelectedCourseItem> _vStudentSelectedCourseItem;
        IObjectSet<VStudentSelectedCourseItem> IDBSchoolCourseEntities.VStudentSelectedCourseItem
        {
            get { return this.VStudentSelectedCourseItem; }
        }
    
        public ObjectSet<VTeaCourse> VTeaCourse
        {
            get { 
    			if (_vTeaCourse == null) {
    				_vTeaCourse = CreateObjectSet<VTeaCourse>("VTeaCourse"); 
    				if (EntitiesMergeOption != null) {
    					_vTeaCourse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vTeaCourse;
    		}
        }
        private ObjectSet<VTeaCourse> _vTeaCourse;
        IObjectSet<VTeaCourse> IDBSchoolCourseEntities.VTeaCourse
        {
            get { return this.VTeaCourse; }
        }
    
        public ObjectSet<VTeaCourseItemClass> VTeaCourseItemClass
        {
            get { 
    			if (_vTeaCourseItemClass == null) {
    				_vTeaCourseItemClass = CreateObjectSet<VTeaCourseItemClass>("VTeaCourseItemClass"); 
    				if (EntitiesMergeOption != null) {
    					_vTeaCourseItemClass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vTeaCourseItemClass;
    		}
        }
        private ObjectSet<VTeaCourseItemClass> _vTeaCourseItemClass;
        IObjectSet<VTeaCourseItemClass> IDBSchoolCourseEntities.VTeaCourseItemClass
        {
            get { return this.VTeaCourseItemClass; }
        }

        #endregion

    }
}



