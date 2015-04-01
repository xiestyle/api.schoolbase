

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSyllabus
{
    public partial class DBSyllabusEntities : ObjectContext, IDBSyllabusEntities
    {
        public const string ConnectionString = "name=DBSyllabusEntities";
        public const string ContainerName = "DBSyllabusEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public DBSyllabusEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public DBSyllabusEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public DBSyllabusEntities(EntityConnection connection)
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
    	
    	bool IDBSyllabusEntities.CanPreCompile
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
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<area>(), typeof(area));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<chapters>(), typeof(chapters));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<dtproperties>(), typeof(dtproperties));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<sclass>(), typeof(sclass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<sclasstosection>(), typeof(sclasstosection));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<sections>(), typeof(sections));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<subjects>(), typeof(subjects));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<syllabus>(), typeof(syllabus));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<syllabuschapters>(), typeof(syllabuschapters));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<syllabussections>(), typeof(syllabussections));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<syllabussubject>(), typeof(syllabussubject));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<syllabustosection>(), typeof(syllabustosection));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<vsclass>(), typeof(vsclass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<vsections>(), typeof(vsections));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<vsyllabussections>(), typeof(vsyllabussections));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<area> area
        {
            get { 
    			if (_area == null) {
    				_area = CreateObjectSet<area>("area"); 
    				if (EntitiesMergeOption != null) {
    					_area.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _area;
    		}
        }
        private ObjectSet<area> _area;
        IObjectSet<area> IDBSyllabusEntities.area
        {
            get { return this.area; }
        }
    
        public ObjectSet<chapters> chapters
        {
            get { 
    			if (_chapters == null) {
    				_chapters = CreateObjectSet<chapters>("chapters"); 
    				if (EntitiesMergeOption != null) {
    					_chapters.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _chapters;
    		}
        }
        private ObjectSet<chapters> _chapters;
        IObjectSet<chapters> IDBSyllabusEntities.chapters
        {
            get { return this.chapters; }
        }
    
        public ObjectSet<dtproperties> dtproperties
        {
            get { 
    			if (_dtproperties == null) {
    				_dtproperties = CreateObjectSet<dtproperties>("dtproperties"); 
    				if (EntitiesMergeOption != null) {
    					_dtproperties.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _dtproperties;
    		}
        }
        private ObjectSet<dtproperties> _dtproperties;
        IObjectSet<dtproperties> IDBSyllabusEntities.dtproperties
        {
            get { return this.dtproperties; }
        }
    
        public ObjectSet<sclass> sclass
        {
            get { 
    			if (_sclass == null) {
    				_sclass = CreateObjectSet<sclass>("sclass"); 
    				if (EntitiesMergeOption != null) {
    					_sclass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _sclass;
    		}
        }
        private ObjectSet<sclass> _sclass;
        IObjectSet<sclass> IDBSyllabusEntities.sclass
        {
            get { return this.sclass; }
        }
    
        public ObjectSet<sclasstosection> sclasstosection
        {
            get { 
    			if (_sclasstosection == null) {
    				_sclasstosection = CreateObjectSet<sclasstosection>("sclasstosection"); 
    				if (EntitiesMergeOption != null) {
    					_sclasstosection.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _sclasstosection;
    		}
        }
        private ObjectSet<sclasstosection> _sclasstosection;
        IObjectSet<sclasstosection> IDBSyllabusEntities.sclasstosection
        {
            get { return this.sclasstosection; }
        }
    
        public ObjectSet<sections> sections
        {
            get { 
    			if (_sections == null) {
    				_sections = CreateObjectSet<sections>("sections"); 
    				if (EntitiesMergeOption != null) {
    					_sections.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _sections;
    		}
        }
        private ObjectSet<sections> _sections;
        IObjectSet<sections> IDBSyllabusEntities.sections
        {
            get { return this.sections; }
        }
    
        public ObjectSet<subjects> subjects
        {
            get { 
    			if (_subjects == null) {
    				_subjects = CreateObjectSet<subjects>("subjects"); 
    				if (EntitiesMergeOption != null) {
    					_subjects.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _subjects;
    		}
        }
        private ObjectSet<subjects> _subjects;
        IObjectSet<subjects> IDBSyllabusEntities.subjects
        {
            get { return this.subjects; }
        }
    
        public ObjectSet<syllabus> syllabus
        {
            get { 
    			if (_syllabus == null) {
    				_syllabus = CreateObjectSet<syllabus>("syllabus"); 
    				if (EntitiesMergeOption != null) {
    					_syllabus.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _syllabus;
    		}
        }
        private ObjectSet<syllabus> _syllabus;
        IObjectSet<syllabus> IDBSyllabusEntities.syllabus
        {
            get { return this.syllabus; }
        }
    
        public ObjectSet<syllabuschapters> syllabuschapters
        {
            get { 
    			if (_syllabuschapters == null) {
    				_syllabuschapters = CreateObjectSet<syllabuschapters>("syllabuschapters"); 
    				if (EntitiesMergeOption != null) {
    					_syllabuschapters.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _syllabuschapters;
    		}
        }
        private ObjectSet<syllabuschapters> _syllabuschapters;
        IObjectSet<syllabuschapters> IDBSyllabusEntities.syllabuschapters
        {
            get { return this.syllabuschapters; }
        }
    
        public ObjectSet<syllabussections> syllabussections
        {
            get { 
    			if (_syllabussections == null) {
    				_syllabussections = CreateObjectSet<syllabussections>("syllabussections"); 
    				if (EntitiesMergeOption != null) {
    					_syllabussections.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _syllabussections;
    		}
        }
        private ObjectSet<syllabussections> _syllabussections;
        IObjectSet<syllabussections> IDBSyllabusEntities.syllabussections
        {
            get { return this.syllabussections; }
        }
    
        public ObjectSet<syllabussubject> syllabussubject
        {
            get { 
    			if (_syllabussubject == null) {
    				_syllabussubject = CreateObjectSet<syllabussubject>("syllabussubject"); 
    				if (EntitiesMergeOption != null) {
    					_syllabussubject.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _syllabussubject;
    		}
        }
        private ObjectSet<syllabussubject> _syllabussubject;
        IObjectSet<syllabussubject> IDBSyllabusEntities.syllabussubject
        {
            get { return this.syllabussubject; }
        }
    
        public ObjectSet<syllabustosection> syllabustosection
        {
            get { 
    			if (_syllabustosection == null) {
    				_syllabustosection = CreateObjectSet<syllabustosection>("syllabustosection"); 
    				if (EntitiesMergeOption != null) {
    					_syllabustosection.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _syllabustosection;
    		}
        }
        private ObjectSet<syllabustosection> _syllabustosection;
        IObjectSet<syllabustosection> IDBSyllabusEntities.syllabustosection
        {
            get { return this.syllabustosection; }
        }
    
        public ObjectSet<vsclass> vsclass
        {
            get { 
    			if (_vsclass == null) {
    				_vsclass = CreateObjectSet<vsclass>("vsclass"); 
    				if (EntitiesMergeOption != null) {
    					_vsclass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vsclass;
    		}
        }
        private ObjectSet<vsclass> _vsclass;
        IObjectSet<vsclass> IDBSyllabusEntities.vsclass
        {
            get { return this.vsclass; }
        }
    
        public ObjectSet<vsections> vsections
        {
            get { 
    			if (_vsections == null) {
    				_vsections = CreateObjectSet<vsections>("vsections"); 
    				if (EntitiesMergeOption != null) {
    					_vsections.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vsections;
    		}
        }
        private ObjectSet<vsections> _vsections;
        IObjectSet<vsections> IDBSyllabusEntities.vsections
        {
            get { return this.vsections; }
        }
    
        public ObjectSet<vsyllabussections> vsyllabussections
        {
            get { 
    			if (_vsyllabussections == null) {
    				_vsyllabussections = CreateObjectSet<vsyllabussections>("vsyllabussections"); 
    				if (EntitiesMergeOption != null) {
    					_vsyllabussections.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vsyllabussections;
    		}
        }
        private ObjectSet<vsyllabussections> _vsyllabussections;
        IObjectSet<vsyllabussections> IDBSyllabusEntities.vsyllabussections
        {
            get { return this.vsyllabussections; }
        }

        #endregion

    }
}



