// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBZiyuan
{
    public partial interface IDBZiyuanEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<IAM_Sclass> IAM_Sclass { get; }
    
        IObjectSet<IAM_SclassSection> IAM_SclassSection { get; }
    
        IObjectSet<View_ResRemark> View_ResRemark { get; }
    
        IObjectSet<View_ZYKResource> View_ZYKResource { get; }
    
        IObjectSet<ZYK_HistoryDownLoad> ZYK_HistoryDownLoad { get; }
    
        IObjectSet<ZYK_HistoryFavorite> ZYK_HistoryFavorite { get; }
    
        IObjectSet<ZYK_HistoryPinJia> ZYK_HistoryPinJia { get; }
    
        IObjectSet<ZYK_HistoryUse> ZYK_HistoryUse { get; }
    
        IObjectSet<ZYK_HistoryView> ZYK_HistoryView { get; }
    
        IObjectSet<ZYK_PingjiaRemark> ZYK_PingjiaRemark { get; }
    
        IObjectSet<ZYK_ResAccessRecord> ZYK_ResAccessRecord { get; }
    
        IObjectSet<ZYK_ResoucePush> ZYK_ResoucePush { get; }
    
        IObjectSet<ZYK_Resource> ZYK_Resource { get; }
    
        IObjectSet<ZYK_ResourceCategory> ZYK_ResourceCategory { get; }
    
        IObjectSet<ZYK_ResourceFavorite> ZYK_ResourceFavorite { get; }
    
        IObjectSet<ZYK_ResourceFavoriteCategory> ZYK_ResourceFavoriteCategory { get; }
    
        IObjectSet<ZYK_ResourceFile> ZYK_ResourceFile { get; }
    
        IObjectSet<ZYK_ResourceSclass> ZYK_ResourceSclass { get; }
    
        IObjectSet<ZYK_ResourceSection> ZYK_ResourceSection { get; }
    
        IObjectSet<ZYK_SchoolCategory> ZYK_SchoolCategory { get; }

            #endregion

    }
}

