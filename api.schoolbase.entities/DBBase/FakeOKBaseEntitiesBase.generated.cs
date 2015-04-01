// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBBase
{
    public  abstract class FakeOKBaseEntitiesBase : IOKBaseEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<App_Calendars> App_Calendars { 
    	get { return __app_Calendars ?? (__app_Calendars = new FakeObjectSet<App_Calendars>()); }
    	set { __app_Calendars = value; }
    	}
    	private IObjectSet<App_Calendars> __app_Calendars;
    
        public IObjectSet<app_version> app_version { 
    	get { return __app_version ?? (__app_version = new FakeObjectSet<app_version>()); }
    	set { __app_version = value; }
    	}
    	private IObjectSet<app_version> __app_version;
    
        public IObjectSet<Base_Admin> Base_Admin { 
    	get { return __base_Admin ?? (__base_Admin = new FakeObjectSet<Base_Admin>()); }
    	set { __base_Admin = value; }
    	}
    	private IObjectSet<Base_Admin> __base_Admin;
    
        public IObjectSet<Base_Config> Base_Config { 
    	get { return __base_Config ?? (__base_Config = new FakeObjectSet<Base_Config>()); }
    	set { __base_Config = value; }
    	}
    	private IObjectSet<Base_Config> __base_Config;
    
        public IObjectSet<Base_DepInfo> Base_DepInfo { 
    	get { return __base_DepInfo ?? (__base_DepInfo = new FakeObjectSet<Base_DepInfo>()); }
    	set { __base_DepInfo = value; }
    	}
    	private IObjectSet<Base_DepInfo> __base_DepInfo;
    
        public IObjectSet<Base_DepPlug> Base_DepPlug { 
    	get { return __base_DepPlug ?? (__base_DepPlug = new FakeObjectSet<Base_DepPlug>()); }
    	set { __base_DepPlug = value; }
    	}
    	private IObjectSet<Base_DepPlug> __base_DepPlug;
    
        public IObjectSet<Base_Group> Base_Group { 
    	get { return __base_Group ?? (__base_Group = new FakeObjectSet<Base_Group>()); }
    	set { __base_Group = value; }
    	}
    	private IObjectSet<Base_Group> __base_Group;
    
        public IObjectSet<Base_GroupPlug> Base_GroupPlug { 
    	get { return __base_GroupPlug ?? (__base_GroupPlug = new FakeObjectSet<Base_GroupPlug>()); }
    	set { __base_GroupPlug = value; }
    	}
    	private IObjectSet<Base_GroupPlug> __base_GroupPlug;
    
        public IObjectSet<Base_GroupUser> Base_GroupUser { 
    	get { return __base_GroupUser ?? (__base_GroupUser = new FakeObjectSet<Base_GroupUser>()); }
    	set { __base_GroupUser = value; }
    	}
    	private IObjectSet<Base_GroupUser> __base_GroupUser;
    
        public IObjectSet<Base_MyPlug> Base_MyPlug { 
    	get { return __base_MyPlug ?? (__base_MyPlug = new FakeObjectSet<Base_MyPlug>()); }
    	set { __base_MyPlug = value; }
    	}
    	private IObjectSet<Base_MyPlug> __base_MyPlug;
    
        public IObjectSet<Base_Plug> Base_Plug { 
    	get { return __base_Plug ?? (__base_Plug = new FakeObjectSet<Base_Plug>()); }
    	set { __base_Plug = value; }
    	}
    	private IObjectSet<Base_Plug> __base_Plug;
    
        public IObjectSet<Base_PlugSet> Base_PlugSet { 
    	get { return __base_PlugSet ?? (__base_PlugSet = new FakeObjectSet<Base_PlugSet>()); }
    	set { __base_PlugSet = value; }
    	}
    	private IObjectSet<Base_PlugSet> __base_PlugSet;
    
        public IObjectSet<Base_PlugSort> Base_PlugSort { 
    	get { return __base_PlugSort ?? (__base_PlugSort = new FakeObjectSet<Base_PlugSort>()); }
    	set { __base_PlugSort = value; }
    	}
    	private IObjectSet<Base_PlugSort> __base_PlugSort;
    
        public IObjectSet<Base_UpFiles> Base_UpFiles { 
    	get { return __base_UpFiles ?? (__base_UpFiles = new FakeObjectSet<Base_UpFiles>()); }
    	set { __base_UpFiles = value; }
    	}
    	private IObjectSet<Base_UpFiles> __base_UpFiles;
    
        public IObjectSet<Base_VAdmin> Base_VAdmin { 
    	get { return __base_VAdmin ?? (__base_VAdmin = new FakeObjectSet<Base_VAdmin>()); }
    	set { __base_VAdmin = value; }
    	}
    	private IObjectSet<Base_VAdmin> __base_VAdmin;
    
        public IObjectSet<Base_VDepPlug> Base_VDepPlug { 
    	get { return __base_VDepPlug ?? (__base_VDepPlug = new FakeObjectSet<Base_VDepPlug>()); }
    	set { __base_VDepPlug = value; }
    	}
    	private IObjectSet<Base_VDepPlug> __base_VDepPlug;
    
        public IObjectSet<Base_VGroupPlug> Base_VGroupPlug { 
    	get { return __base_VGroupPlug ?? (__base_VGroupPlug = new FakeObjectSet<Base_VGroupPlug>()); }
    	set { __base_VGroupPlug = value; }
    	}
    	private IObjectSet<Base_VGroupPlug> __base_VGroupPlug;
    
        public IObjectSet<Base_VGroupUser> Base_VGroupUser { 
    	get { return __base_VGroupUser ?? (__base_VGroupUser = new FakeObjectSet<Base_VGroupUser>()); }
    	set { __base_VGroupUser = value; }
    	}
    	private IObjectSet<Base_VGroupUser> __base_VGroupUser;
    
        public IObjectSet<Base_VMyPlug> Base_VMyPlug { 
    	get { return __base_VMyPlug ?? (__base_VMyPlug = new FakeObjectSet<Base_VMyPlug>()); }
    	set { __base_VMyPlug = value; }
    	}
    	private IObjectSet<Base_VMyPlug> __base_VMyPlug;
    
        public IObjectSet<Base_VPlugSet> Base_VPlugSet { 
    	get { return __base_VPlugSet ?? (__base_VPlugSet = new FakeObjectSet<Base_VPlugSet>()); }
    	set { __base_VPlugSet = value; }
    	}
    	private IObjectSet<Base_VPlugSet> __base_VPlugSet;
    
        public IObjectSet<tFile> tFile { 
    	get { return __tFile ?? (__tFile = new FakeObjectSet<tFile>()); }
    	set { __tFile = value; }
    	}
    	private IObjectSet<tFile> __tFile;
    
        public IObjectSet<tFolder> tFolder { 
    	get { return __tFolder ?? (__tFolder = new FakeObjectSet<tFolder>()); }
    	set { __tFolder = value; }
    	}
    	private IObjectSet<tFolder> __tFolder;
    
        public IObjectSet<tUser_ex> tUser_ex { 
    	get { return __tUser_ex ?? (__tUser_ex = new FakeObjectSet<tUser_ex>()); }
    	set { __tUser_ex = value; }
    	}
    	private IObjectSet<tUser_ex> __tUser_ex;
    
        public IObjectSet<VConfig> VConfig { 
    	get { return __vConfig ?? (__vConfig = new FakeObjectSet<VConfig>()); }
    	set { __vConfig = value; }
    	}
    	private IObjectSet<VConfig> __vConfig;
    
        public IObjectSet<VGroup> VGroup { 
    	get { return __vGroup ?? (__vGroup = new FakeObjectSet<VGroup>()); }
    	set { __vGroup = value; }
    	}
    	private IObjectSet<VGroup> __vGroup;
    
        public IObjectSet<VUser> VUser { 
    	get { return __vUser ?? (__vUser = new FakeObjectSet<VUser>()); }
    	set { __vUser = value; }
    	}
    	private IObjectSet<VUser> __vUser;
    
        public IObjectSet<WxAppKey> WxAppKey { 
    	get { return __wxAppKey ?? (__wxAppKey = new FakeObjectSet<WxAppKey>()); }
    	set { __wxAppKey = value; }
    	}
    	private IObjectSet<WxAppKey> __wxAppKey;
    
        public IObjectSet<WxApplication> WxApplication { 
    	get { return __wxApplication ?? (__wxApplication = new FakeObjectSet<WxApplication>()); }
    	set { __wxApplication = value; }
    	}
    	private IObjectSet<WxApplication> __wxApplication;
    
        public IObjectSet<WxToken> WxToken { 
    	get { return __wxToken ?? (__wxToken = new FakeObjectSet<WxToken>()); }
    	set { __wxToken = value; }
    	}
    	private IObjectSet<WxToken> __wxToken;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

