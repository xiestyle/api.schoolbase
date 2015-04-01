// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBBase
{
    public partial interface IOKBaseEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<App_Calendars> App_Calendars { get; }
    
        IObjectSet<app_version> app_version { get; }
    
        IObjectSet<Base_Admin> Base_Admin { get; }
    
        IObjectSet<Base_Config> Base_Config { get; }
    
        IObjectSet<Base_DepInfo> Base_DepInfo { get; }
    
        IObjectSet<Base_DepPlug> Base_DepPlug { get; }
    
        IObjectSet<Base_Group> Base_Group { get; }
    
        IObjectSet<Base_GroupPlug> Base_GroupPlug { get; }
    
        IObjectSet<Base_GroupUser> Base_GroupUser { get; }
    
        IObjectSet<Base_MyPlug> Base_MyPlug { get; }
    
        IObjectSet<Base_Plug> Base_Plug { get; }
    
        IObjectSet<Base_PlugSet> Base_PlugSet { get; }
    
        IObjectSet<Base_PlugSort> Base_PlugSort { get; }
    
        IObjectSet<Base_UpFiles> Base_UpFiles { get; }
    
        IObjectSet<Base_VAdmin> Base_VAdmin { get; }
    
        IObjectSet<Base_VDepPlug> Base_VDepPlug { get; }
    
        IObjectSet<Base_VGroupPlug> Base_VGroupPlug { get; }
    
        IObjectSet<Base_VGroupUser> Base_VGroupUser { get; }
    
        IObjectSet<Base_VMyPlug> Base_VMyPlug { get; }
    
        IObjectSet<Base_VPlugSet> Base_VPlugSet { get; }
    
        IObjectSet<tFile> tFile { get; }
    
        IObjectSet<tFolder> tFolder { get; }
    
        IObjectSet<tUser_ex> tUser_ex { get; }
    
        IObjectSet<VConfig> VConfig { get; }
    
        IObjectSet<VGroup> VGroup { get; }
    
        IObjectSet<VUser> VUser { get; }
    
        IObjectSet<WxAppKey> WxAppKey { get; }
    
        IObjectSet<WxApplication> WxApplication { get; }
    
        IObjectSet<WxToken> WxToken { get; }

            #endregion

    }
}

