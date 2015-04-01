

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBBase
{
    public partial class OKBaseEntities : ObjectContext, IOKBaseEntities
    {
        public const string ConnectionString = "name=OKBaseEntities";
        public const string ContainerName = "OKBaseEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public OKBaseEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public OKBaseEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public OKBaseEntities(EntityConnection connection)
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
    	
    	bool IOKBaseEntities.CanPreCompile
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
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<App_Calendars>(), typeof(App_Calendars));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<app_version>(), typeof(app_version));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_Admin>(), typeof(Base_Admin));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_Config>(), typeof(Base_Config));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_DepInfo>(), typeof(Base_DepInfo));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_DepPlug>(), typeof(Base_DepPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_Group>(), typeof(Base_Group));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_GroupPlug>(), typeof(Base_GroupPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_GroupUser>(), typeof(Base_GroupUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_MyPlug>(), typeof(Base_MyPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_Plug>(), typeof(Base_Plug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_PlugSet>(), typeof(Base_PlugSet));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_PlugSort>(), typeof(Base_PlugSort));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_UpFiles>(), typeof(Base_UpFiles));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VAdmin>(), typeof(Base_VAdmin));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VDepPlug>(), typeof(Base_VDepPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VGroupPlug>(), typeof(Base_VGroupPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VGroupUser>(), typeof(Base_VGroupUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VMyPlug>(), typeof(Base_VMyPlug));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<Base_VPlugSet>(), typeof(Base_VPlugSet));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<tFile>(), typeof(tFile));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<tFolder>(), typeof(tFolder));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<tUser_ex>(), typeof(tUser_ex));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VConfig>(), typeof(VConfig));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VGroup>(), typeof(VGroup));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<VUser>(), typeof(VUser));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<WxAppKey>(), typeof(WxAppKey));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<WxApplication>(), typeof(WxApplication));
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<WxToken>(), typeof(WxToken));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<App_Calendars> App_Calendars
        {
            get { 
    			if (_app_Calendars == null) {
    				_app_Calendars = CreateObjectSet<App_Calendars>("App_Calendars"); 
    				if (EntitiesMergeOption != null) {
    					_app_Calendars.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _app_Calendars;
    		}
        }
        private ObjectSet<App_Calendars> _app_Calendars;
        IObjectSet<App_Calendars> IOKBaseEntities.App_Calendars
        {
            get { return this.App_Calendars; }
        }
    
        public ObjectSet<app_version> app_version
        {
            get { 
    			if (_app_version == null) {
    				_app_version = CreateObjectSet<app_version>("app_version"); 
    				if (EntitiesMergeOption != null) {
    					_app_version.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _app_version;
    		}
        }
        private ObjectSet<app_version> _app_version;
        IObjectSet<app_version> IOKBaseEntities.app_version
        {
            get { return this.app_version; }
        }
    
        public ObjectSet<Base_Admin> Base_Admin
        {
            get { 
    			if (_base_Admin == null) {
    				_base_Admin = CreateObjectSet<Base_Admin>("Base_Admin"); 
    				if (EntitiesMergeOption != null) {
    					_base_Admin.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_Admin;
    		}
        }
        private ObjectSet<Base_Admin> _base_Admin;
        IObjectSet<Base_Admin> IOKBaseEntities.Base_Admin
        {
            get { return this.Base_Admin; }
        }
    
        public ObjectSet<Base_Config> Base_Config
        {
            get { 
    			if (_base_Config == null) {
    				_base_Config = CreateObjectSet<Base_Config>("Base_Config"); 
    				if (EntitiesMergeOption != null) {
    					_base_Config.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_Config;
    		}
        }
        private ObjectSet<Base_Config> _base_Config;
        IObjectSet<Base_Config> IOKBaseEntities.Base_Config
        {
            get { return this.Base_Config; }
        }
    
        public ObjectSet<Base_DepInfo> Base_DepInfo
        {
            get { 
    			if (_base_DepInfo == null) {
    				_base_DepInfo = CreateObjectSet<Base_DepInfo>("Base_DepInfo"); 
    				if (EntitiesMergeOption != null) {
    					_base_DepInfo.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_DepInfo;
    		}
        }
        private ObjectSet<Base_DepInfo> _base_DepInfo;
        IObjectSet<Base_DepInfo> IOKBaseEntities.Base_DepInfo
        {
            get { return this.Base_DepInfo; }
        }
    
        public ObjectSet<Base_DepPlug> Base_DepPlug
        {
            get { 
    			if (_base_DepPlug == null) {
    				_base_DepPlug = CreateObjectSet<Base_DepPlug>("Base_DepPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_DepPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_DepPlug;
    		}
        }
        private ObjectSet<Base_DepPlug> _base_DepPlug;
        IObjectSet<Base_DepPlug> IOKBaseEntities.Base_DepPlug
        {
            get { return this.Base_DepPlug; }
        }
    
        public ObjectSet<Base_Group> Base_Group
        {
            get { 
    			if (_base_Group == null) {
    				_base_Group = CreateObjectSet<Base_Group>("Base_Group"); 
    				if (EntitiesMergeOption != null) {
    					_base_Group.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_Group;
    		}
        }
        private ObjectSet<Base_Group> _base_Group;
        IObjectSet<Base_Group> IOKBaseEntities.Base_Group
        {
            get { return this.Base_Group; }
        }
    
        public ObjectSet<Base_GroupPlug> Base_GroupPlug
        {
            get { 
    			if (_base_GroupPlug == null) {
    				_base_GroupPlug = CreateObjectSet<Base_GroupPlug>("Base_GroupPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_GroupPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_GroupPlug;
    		}
        }
        private ObjectSet<Base_GroupPlug> _base_GroupPlug;
        IObjectSet<Base_GroupPlug> IOKBaseEntities.Base_GroupPlug
        {
            get { return this.Base_GroupPlug; }
        }
    
        public ObjectSet<Base_GroupUser> Base_GroupUser
        {
            get { 
    			if (_base_GroupUser == null) {
    				_base_GroupUser = CreateObjectSet<Base_GroupUser>("Base_GroupUser"); 
    				if (EntitiesMergeOption != null) {
    					_base_GroupUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_GroupUser;
    		}
        }
        private ObjectSet<Base_GroupUser> _base_GroupUser;
        IObjectSet<Base_GroupUser> IOKBaseEntities.Base_GroupUser
        {
            get { return this.Base_GroupUser; }
        }
    
        public ObjectSet<Base_MyPlug> Base_MyPlug
        {
            get { 
    			if (_base_MyPlug == null) {
    				_base_MyPlug = CreateObjectSet<Base_MyPlug>("Base_MyPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_MyPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_MyPlug;
    		}
        }
        private ObjectSet<Base_MyPlug> _base_MyPlug;
        IObjectSet<Base_MyPlug> IOKBaseEntities.Base_MyPlug
        {
            get { return this.Base_MyPlug; }
        }
    
        public ObjectSet<Base_Plug> Base_Plug
        {
            get { 
    			if (_base_Plug == null) {
    				_base_Plug = CreateObjectSet<Base_Plug>("Base_Plug"); 
    				if (EntitiesMergeOption != null) {
    					_base_Plug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_Plug;
    		}
        }
        private ObjectSet<Base_Plug> _base_Plug;
        IObjectSet<Base_Plug> IOKBaseEntities.Base_Plug
        {
            get { return this.Base_Plug; }
        }
    
        public ObjectSet<Base_PlugSet> Base_PlugSet
        {
            get { 
    			if (_base_PlugSet == null) {
    				_base_PlugSet = CreateObjectSet<Base_PlugSet>("Base_PlugSet"); 
    				if (EntitiesMergeOption != null) {
    					_base_PlugSet.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_PlugSet;
    		}
        }
        private ObjectSet<Base_PlugSet> _base_PlugSet;
        IObjectSet<Base_PlugSet> IOKBaseEntities.Base_PlugSet
        {
            get { return this.Base_PlugSet; }
        }
    
        public ObjectSet<Base_PlugSort> Base_PlugSort
        {
            get { 
    			if (_base_PlugSort == null) {
    				_base_PlugSort = CreateObjectSet<Base_PlugSort>("Base_PlugSort"); 
    				if (EntitiesMergeOption != null) {
    					_base_PlugSort.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_PlugSort;
    		}
        }
        private ObjectSet<Base_PlugSort> _base_PlugSort;
        IObjectSet<Base_PlugSort> IOKBaseEntities.Base_PlugSort
        {
            get { return this.Base_PlugSort; }
        }
    
        public ObjectSet<Base_UpFiles> Base_UpFiles
        {
            get { 
    			if (_base_UpFiles == null) {
    				_base_UpFiles = CreateObjectSet<Base_UpFiles>("Base_UpFiles"); 
    				if (EntitiesMergeOption != null) {
    					_base_UpFiles.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_UpFiles;
    		}
        }
        private ObjectSet<Base_UpFiles> _base_UpFiles;
        IObjectSet<Base_UpFiles> IOKBaseEntities.Base_UpFiles
        {
            get { return this.Base_UpFiles; }
        }
    
        public ObjectSet<Base_VAdmin> Base_VAdmin
        {
            get { 
    			if (_base_VAdmin == null) {
    				_base_VAdmin = CreateObjectSet<Base_VAdmin>("Base_VAdmin"); 
    				if (EntitiesMergeOption != null) {
    					_base_VAdmin.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VAdmin;
    		}
        }
        private ObjectSet<Base_VAdmin> _base_VAdmin;
        IObjectSet<Base_VAdmin> IOKBaseEntities.Base_VAdmin
        {
            get { return this.Base_VAdmin; }
        }
    
        public ObjectSet<Base_VDepPlug> Base_VDepPlug
        {
            get { 
    			if (_base_VDepPlug == null) {
    				_base_VDepPlug = CreateObjectSet<Base_VDepPlug>("Base_VDepPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_VDepPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VDepPlug;
    		}
        }
        private ObjectSet<Base_VDepPlug> _base_VDepPlug;
        IObjectSet<Base_VDepPlug> IOKBaseEntities.Base_VDepPlug
        {
            get { return this.Base_VDepPlug; }
        }
    
        public ObjectSet<Base_VGroupPlug> Base_VGroupPlug
        {
            get { 
    			if (_base_VGroupPlug == null) {
    				_base_VGroupPlug = CreateObjectSet<Base_VGroupPlug>("Base_VGroupPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_VGroupPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VGroupPlug;
    		}
        }
        private ObjectSet<Base_VGroupPlug> _base_VGroupPlug;
        IObjectSet<Base_VGroupPlug> IOKBaseEntities.Base_VGroupPlug
        {
            get { return this.Base_VGroupPlug; }
        }
    
        public ObjectSet<Base_VGroupUser> Base_VGroupUser
        {
            get { 
    			if (_base_VGroupUser == null) {
    				_base_VGroupUser = CreateObjectSet<Base_VGroupUser>("Base_VGroupUser"); 
    				if (EntitiesMergeOption != null) {
    					_base_VGroupUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VGroupUser;
    		}
        }
        private ObjectSet<Base_VGroupUser> _base_VGroupUser;
        IObjectSet<Base_VGroupUser> IOKBaseEntities.Base_VGroupUser
        {
            get { return this.Base_VGroupUser; }
        }
    
        public ObjectSet<Base_VMyPlug> Base_VMyPlug
        {
            get { 
    			if (_base_VMyPlug == null) {
    				_base_VMyPlug = CreateObjectSet<Base_VMyPlug>("Base_VMyPlug"); 
    				if (EntitiesMergeOption != null) {
    					_base_VMyPlug.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VMyPlug;
    		}
        }
        private ObjectSet<Base_VMyPlug> _base_VMyPlug;
        IObjectSet<Base_VMyPlug> IOKBaseEntities.Base_VMyPlug
        {
            get { return this.Base_VMyPlug; }
        }
    
        public ObjectSet<Base_VPlugSet> Base_VPlugSet
        {
            get { 
    			if (_base_VPlugSet == null) {
    				_base_VPlugSet = CreateObjectSet<Base_VPlugSet>("Base_VPlugSet"); 
    				if (EntitiesMergeOption != null) {
    					_base_VPlugSet.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _base_VPlugSet;
    		}
        }
        private ObjectSet<Base_VPlugSet> _base_VPlugSet;
        IObjectSet<Base_VPlugSet> IOKBaseEntities.Base_VPlugSet
        {
            get { return this.Base_VPlugSet; }
        }
    
        public ObjectSet<tFile> tFile
        {
            get { 
    			if (_tFile == null) {
    				_tFile = CreateObjectSet<tFile>("tFile"); 
    				if (EntitiesMergeOption != null) {
    					_tFile.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _tFile;
    		}
        }
        private ObjectSet<tFile> _tFile;
        IObjectSet<tFile> IOKBaseEntities.tFile
        {
            get { return this.tFile; }
        }
    
        public ObjectSet<tFolder> tFolder
        {
            get { 
    			if (_tFolder == null) {
    				_tFolder = CreateObjectSet<tFolder>("tFolder"); 
    				if (EntitiesMergeOption != null) {
    					_tFolder.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _tFolder;
    		}
        }
        private ObjectSet<tFolder> _tFolder;
        IObjectSet<tFolder> IOKBaseEntities.tFolder
        {
            get { return this.tFolder; }
        }
    
        public ObjectSet<tUser_ex> tUser_ex
        {
            get { 
    			if (_tUser_ex == null) {
    				_tUser_ex = CreateObjectSet<tUser_ex>("tUser_ex"); 
    				if (EntitiesMergeOption != null) {
    					_tUser_ex.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _tUser_ex;
    		}
        }
        private ObjectSet<tUser_ex> _tUser_ex;
        IObjectSet<tUser_ex> IOKBaseEntities.tUser_ex
        {
            get { return this.tUser_ex; }
        }
    
        public ObjectSet<VConfig> VConfig
        {
            get { 
    			if (_vConfig == null) {
    				_vConfig = CreateObjectSet<VConfig>("VConfig"); 
    				if (EntitiesMergeOption != null) {
    					_vConfig.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vConfig;
    		}
        }
        private ObjectSet<VConfig> _vConfig;
        IObjectSet<VConfig> IOKBaseEntities.VConfig
        {
            get { return this.VConfig; }
        }
    
        public ObjectSet<VGroup> VGroup
        {
            get { 
    			if (_vGroup == null) {
    				_vGroup = CreateObjectSet<VGroup>("VGroup"); 
    				if (EntitiesMergeOption != null) {
    					_vGroup.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vGroup;
    		}
        }
        private ObjectSet<VGroup> _vGroup;
        IObjectSet<VGroup> IOKBaseEntities.VGroup
        {
            get { return this.VGroup; }
        }
    
        public ObjectSet<VUser> VUser
        {
            get { 
    			if (_vUser == null) {
    				_vUser = CreateObjectSet<VUser>("VUser"); 
    				if (EntitiesMergeOption != null) {
    					_vUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _vUser;
    		}
        }
        private ObjectSet<VUser> _vUser;
        IObjectSet<VUser> IOKBaseEntities.VUser
        {
            get { return this.VUser; }
        }
    
        public ObjectSet<WxAppKey> WxAppKey
        {
            get { 
    			if (_wxAppKey == null) {
    				_wxAppKey = CreateObjectSet<WxAppKey>("WxAppKey"); 
    				if (EntitiesMergeOption != null) {
    					_wxAppKey.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _wxAppKey;
    		}
        }
        private ObjectSet<WxAppKey> _wxAppKey;
        IObjectSet<WxAppKey> IOKBaseEntities.WxAppKey
        {
            get { return this.WxAppKey; }
        }
    
        public ObjectSet<WxApplication> WxApplication
        {
            get { 
    			if (_wxApplication == null) {
    				_wxApplication = CreateObjectSet<WxApplication>("WxApplication"); 
    				if (EntitiesMergeOption != null) {
    					_wxApplication.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _wxApplication;
    		}
        }
        private ObjectSet<WxApplication> _wxApplication;
        IObjectSet<WxApplication> IOKBaseEntities.WxApplication
        {
            get { return this.WxApplication; }
        }
    
        public ObjectSet<WxToken> WxToken
        {
            get { 
    			if (_wxToken == null) {
    				_wxToken = CreateObjectSet<WxToken>("WxToken"); 
    				if (EntitiesMergeOption != null) {
    					_wxToken.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _wxToken;
    		}
        }
        private ObjectSet<WxToken> _wxToken;
        IObjectSet<WxToken> IOKBaseEntities.WxToken
        {
            get { return this.WxToken; }
        }

        #endregion

    }
}



