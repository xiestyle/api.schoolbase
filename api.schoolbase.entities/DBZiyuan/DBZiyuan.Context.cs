

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBZiyuan
{
    public partial class DBZiyuanEntities : ObjectContext, IDBZiyuanEntities
    {
        public const string ConnectionString = "name=DBZiyuanEntities";
        public const string ContainerName = "DBZiyuanEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public DBZiyuanEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public DBZiyuanEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public DBZiyuanEntities(EntityConnection connection)
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
    	
    	bool IDBZiyuanEntities.CanPreCompile
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
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_Sclass>(), typeof(IAM_Sclass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<IAM_SclassSection>(), typeof(IAM_SclassSection));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<View_ResRemark>(), typeof(View_ResRemark));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<View_ZYKResource>(), typeof(View_ZYKResource));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_HistoryDownLoad>(), typeof(ZYK_HistoryDownLoad));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_HistoryFavorite>(), typeof(ZYK_HistoryFavorite));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_HistoryPinJia>(), typeof(ZYK_HistoryPinJia));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_HistoryUse>(), typeof(ZYK_HistoryUse));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_HistoryView>(), typeof(ZYK_HistoryView));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_PingjiaRemark>(), typeof(ZYK_PingjiaRemark));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResAccessRecord>(), typeof(ZYK_ResAccessRecord));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResoucePush>(), typeof(ZYK_ResoucePush));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_Resource>(), typeof(ZYK_Resource));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceCategory>(), typeof(ZYK_ResourceCategory));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceFavorite>(), typeof(ZYK_ResourceFavorite));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceFavoriteCategory>(), typeof(ZYK_ResourceFavoriteCategory));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceFile>(), typeof(ZYK_ResourceFile));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceSclass>(), typeof(ZYK_ResourceSclass));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_ResourceSection>(), typeof(ZYK_ResourceSection));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<ZYK_SchoolCategory>(), typeof(ZYK_SchoolCategory));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<IAM_Sclass> IAM_Sclass
        {
            get { 
    			if (_iAM_Sclass == null) {
    				_iAM_Sclass = CreateObjectSet<IAM_Sclass>("IAM_Sclass"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_Sclass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_Sclass;
    		}
        }
        private ObjectSet<IAM_Sclass> _iAM_Sclass;
        IObjectSet<IAM_Sclass> IDBZiyuanEntities.IAM_Sclass
        {
            get { return this.IAM_Sclass; }
        }
    
        public ObjectSet<IAM_SclassSection> IAM_SclassSection
        {
            get { 
    			if (_iAM_SclassSection == null) {
    				_iAM_SclassSection = CreateObjectSet<IAM_SclassSection>("IAM_SclassSection"); 
    				if (EntitiesMergeOption != null) {
    					_iAM_SclassSection.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _iAM_SclassSection;
    		}
        }
        private ObjectSet<IAM_SclassSection> _iAM_SclassSection;
        IObjectSet<IAM_SclassSection> IDBZiyuanEntities.IAM_SclassSection
        {
            get { return this.IAM_SclassSection; }
        }
    
        public ObjectSet<View_ResRemark> View_ResRemark
        {
            get { 
    			if (_view_ResRemark == null) {
    				_view_ResRemark = CreateObjectSet<View_ResRemark>("View_ResRemark"); 
    				if (EntitiesMergeOption != null) {
    					_view_ResRemark.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _view_ResRemark;
    		}
        }
        private ObjectSet<View_ResRemark> _view_ResRemark;
        IObjectSet<View_ResRemark> IDBZiyuanEntities.View_ResRemark
        {
            get { return this.View_ResRemark; }
        }
    
        public ObjectSet<View_ZYKResource> View_ZYKResource
        {
            get { 
    			if (_view_ZYKResource == null) {
    				_view_ZYKResource = CreateObjectSet<View_ZYKResource>("View_ZYKResource"); 
    				if (EntitiesMergeOption != null) {
    					_view_ZYKResource.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _view_ZYKResource;
    		}
        }
        private ObjectSet<View_ZYKResource> _view_ZYKResource;
        IObjectSet<View_ZYKResource> IDBZiyuanEntities.View_ZYKResource
        {
            get { return this.View_ZYKResource; }
        }
    
        public ObjectSet<ZYK_HistoryDownLoad> ZYK_HistoryDownLoad
        {
            get { 
    			if (_zYK_HistoryDownLoad == null) {
    				_zYK_HistoryDownLoad = CreateObjectSet<ZYK_HistoryDownLoad>("ZYK_HistoryDownLoad"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_HistoryDownLoad.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_HistoryDownLoad;
    		}
        }
        private ObjectSet<ZYK_HistoryDownLoad> _zYK_HistoryDownLoad;
        IObjectSet<ZYK_HistoryDownLoad> IDBZiyuanEntities.ZYK_HistoryDownLoad
        {
            get { return this.ZYK_HistoryDownLoad; }
        }
    
        public ObjectSet<ZYK_HistoryFavorite> ZYK_HistoryFavorite
        {
            get { 
    			if (_zYK_HistoryFavorite == null) {
    				_zYK_HistoryFavorite = CreateObjectSet<ZYK_HistoryFavorite>("ZYK_HistoryFavorite"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_HistoryFavorite.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_HistoryFavorite;
    		}
        }
        private ObjectSet<ZYK_HistoryFavorite> _zYK_HistoryFavorite;
        IObjectSet<ZYK_HistoryFavorite> IDBZiyuanEntities.ZYK_HistoryFavorite
        {
            get { return this.ZYK_HistoryFavorite; }
        }
    
        public ObjectSet<ZYK_HistoryPinJia> ZYK_HistoryPinJia
        {
            get { 
    			if (_zYK_HistoryPinJia == null) {
    				_zYK_HistoryPinJia = CreateObjectSet<ZYK_HistoryPinJia>("ZYK_HistoryPinJia"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_HistoryPinJia.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_HistoryPinJia;
    		}
        }
        private ObjectSet<ZYK_HistoryPinJia> _zYK_HistoryPinJia;
        IObjectSet<ZYK_HistoryPinJia> IDBZiyuanEntities.ZYK_HistoryPinJia
        {
            get { return this.ZYK_HistoryPinJia; }
        }
    
        public ObjectSet<ZYK_HistoryUse> ZYK_HistoryUse
        {
            get { 
    			if (_zYK_HistoryUse == null) {
    				_zYK_HistoryUse = CreateObjectSet<ZYK_HistoryUse>("ZYK_HistoryUse"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_HistoryUse.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_HistoryUse;
    		}
        }
        private ObjectSet<ZYK_HistoryUse> _zYK_HistoryUse;
        IObjectSet<ZYK_HistoryUse> IDBZiyuanEntities.ZYK_HistoryUse
        {
            get { return this.ZYK_HistoryUse; }
        }
    
        public ObjectSet<ZYK_HistoryView> ZYK_HistoryView
        {
            get { 
    			if (_zYK_HistoryView == null) {
    				_zYK_HistoryView = CreateObjectSet<ZYK_HistoryView>("ZYK_HistoryView"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_HistoryView.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_HistoryView;
    		}
        }
        private ObjectSet<ZYK_HistoryView> _zYK_HistoryView;
        IObjectSet<ZYK_HistoryView> IDBZiyuanEntities.ZYK_HistoryView
        {
            get { return this.ZYK_HistoryView; }
        }
    
        public ObjectSet<ZYK_PingjiaRemark> ZYK_PingjiaRemark
        {
            get { 
    			if (_zYK_PingjiaRemark == null) {
    				_zYK_PingjiaRemark = CreateObjectSet<ZYK_PingjiaRemark>("ZYK_PingjiaRemark"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_PingjiaRemark.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_PingjiaRemark;
    		}
        }
        private ObjectSet<ZYK_PingjiaRemark> _zYK_PingjiaRemark;
        IObjectSet<ZYK_PingjiaRemark> IDBZiyuanEntities.ZYK_PingjiaRemark
        {
            get { return this.ZYK_PingjiaRemark; }
        }
    
        public ObjectSet<ZYK_ResAccessRecord> ZYK_ResAccessRecord
        {
            get { 
    			if (_zYK_ResAccessRecord == null) {
    				_zYK_ResAccessRecord = CreateObjectSet<ZYK_ResAccessRecord>("ZYK_ResAccessRecord"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResAccessRecord.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResAccessRecord;
    		}
        }
        private ObjectSet<ZYK_ResAccessRecord> _zYK_ResAccessRecord;
        IObjectSet<ZYK_ResAccessRecord> IDBZiyuanEntities.ZYK_ResAccessRecord
        {
            get { return this.ZYK_ResAccessRecord; }
        }
    
        public ObjectSet<ZYK_ResoucePush> ZYK_ResoucePush
        {
            get { 
    			if (_zYK_ResoucePush == null) {
    				_zYK_ResoucePush = CreateObjectSet<ZYK_ResoucePush>("ZYK_ResoucePush"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResoucePush.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResoucePush;
    		}
        }
        private ObjectSet<ZYK_ResoucePush> _zYK_ResoucePush;
        IObjectSet<ZYK_ResoucePush> IDBZiyuanEntities.ZYK_ResoucePush
        {
            get { return this.ZYK_ResoucePush; }
        }
    
        public ObjectSet<ZYK_Resource> ZYK_Resource
        {
            get { 
    			if (_zYK_Resource == null) {
    				_zYK_Resource = CreateObjectSet<ZYK_Resource>("ZYK_Resource"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_Resource.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_Resource;
    		}
        }
        private ObjectSet<ZYK_Resource> _zYK_Resource;
        IObjectSet<ZYK_Resource> IDBZiyuanEntities.ZYK_Resource
        {
            get { return this.ZYK_Resource; }
        }
    
        public ObjectSet<ZYK_ResourceCategory> ZYK_ResourceCategory
        {
            get { 
    			if (_zYK_ResourceCategory == null) {
    				_zYK_ResourceCategory = CreateObjectSet<ZYK_ResourceCategory>("ZYK_ResourceCategory"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceCategory.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceCategory;
    		}
        }
        private ObjectSet<ZYK_ResourceCategory> _zYK_ResourceCategory;
        IObjectSet<ZYK_ResourceCategory> IDBZiyuanEntities.ZYK_ResourceCategory
        {
            get { return this.ZYK_ResourceCategory; }
        }
    
        public ObjectSet<ZYK_ResourceFavorite> ZYK_ResourceFavorite
        {
            get { 
    			if (_zYK_ResourceFavorite == null) {
    				_zYK_ResourceFavorite = CreateObjectSet<ZYK_ResourceFavorite>("ZYK_ResourceFavorite"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceFavorite.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceFavorite;
    		}
        }
        private ObjectSet<ZYK_ResourceFavorite> _zYK_ResourceFavorite;
        IObjectSet<ZYK_ResourceFavorite> IDBZiyuanEntities.ZYK_ResourceFavorite
        {
            get { return this.ZYK_ResourceFavorite; }
        }
    
        public ObjectSet<ZYK_ResourceFavoriteCategory> ZYK_ResourceFavoriteCategory
        {
            get { 
    			if (_zYK_ResourceFavoriteCategory == null) {
    				_zYK_ResourceFavoriteCategory = CreateObjectSet<ZYK_ResourceFavoriteCategory>("ZYK_ResourceFavoriteCategory"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceFavoriteCategory.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceFavoriteCategory;
    		}
        }
        private ObjectSet<ZYK_ResourceFavoriteCategory> _zYK_ResourceFavoriteCategory;
        IObjectSet<ZYK_ResourceFavoriteCategory> IDBZiyuanEntities.ZYK_ResourceFavoriteCategory
        {
            get { return this.ZYK_ResourceFavoriteCategory; }
        }
    
        public ObjectSet<ZYK_ResourceFile> ZYK_ResourceFile
        {
            get { 
    			if (_zYK_ResourceFile == null) {
    				_zYK_ResourceFile = CreateObjectSet<ZYK_ResourceFile>("ZYK_ResourceFile"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceFile.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceFile;
    		}
        }
        private ObjectSet<ZYK_ResourceFile> _zYK_ResourceFile;
        IObjectSet<ZYK_ResourceFile> IDBZiyuanEntities.ZYK_ResourceFile
        {
            get { return this.ZYK_ResourceFile; }
        }
    
        public ObjectSet<ZYK_ResourceSclass> ZYK_ResourceSclass
        {
            get { 
    			if (_zYK_ResourceSclass == null) {
    				_zYK_ResourceSclass = CreateObjectSet<ZYK_ResourceSclass>("ZYK_ResourceSclass"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceSclass.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceSclass;
    		}
        }
        private ObjectSet<ZYK_ResourceSclass> _zYK_ResourceSclass;
        IObjectSet<ZYK_ResourceSclass> IDBZiyuanEntities.ZYK_ResourceSclass
        {
            get { return this.ZYK_ResourceSclass; }
        }
    
        public ObjectSet<ZYK_ResourceSection> ZYK_ResourceSection
        {
            get { 
    			if (_zYK_ResourceSection == null) {
    				_zYK_ResourceSection = CreateObjectSet<ZYK_ResourceSection>("ZYK_ResourceSection"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_ResourceSection.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_ResourceSection;
    		}
        }
        private ObjectSet<ZYK_ResourceSection> _zYK_ResourceSection;
        IObjectSet<ZYK_ResourceSection> IDBZiyuanEntities.ZYK_ResourceSection
        {
            get { return this.ZYK_ResourceSection; }
        }
    
        public ObjectSet<ZYK_SchoolCategory> ZYK_SchoolCategory
        {
            get { 
    			if (_zYK_SchoolCategory == null) {
    				_zYK_SchoolCategory = CreateObjectSet<ZYK_SchoolCategory>("ZYK_SchoolCategory"); 
    				if (EntitiesMergeOption != null) {
    					_zYK_SchoolCategory.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _zYK_SchoolCategory;
    		}
        }
        private ObjectSet<ZYK_SchoolCategory> _zYK_SchoolCategory;
        IObjectSet<ZYK_SchoolCategory> IDBZiyuanEntities.ZYK_SchoolCategory
        {
            get { return this.ZYK_SchoolCategory; }
        }

        #endregion

    }
}



