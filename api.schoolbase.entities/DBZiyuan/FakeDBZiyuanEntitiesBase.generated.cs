// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBZiyuan
{
    public  abstract class FakeDBZiyuanEntitiesBase : IDBZiyuanEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<IAM_Sclass> IAM_Sclass { 
    	get { return __iAM_Sclass ?? (__iAM_Sclass = new FakeObjectSet<IAM_Sclass>()); }
    	set { __iAM_Sclass = value; }
    	}
    	private IObjectSet<IAM_Sclass> __iAM_Sclass;
    
        public IObjectSet<IAM_SclassSection> IAM_SclassSection { 
    	get { return __iAM_SclassSection ?? (__iAM_SclassSection = new FakeObjectSet<IAM_SclassSection>()); }
    	set { __iAM_SclassSection = value; }
    	}
    	private IObjectSet<IAM_SclassSection> __iAM_SclassSection;
    
        public IObjectSet<View_ResRemark> View_ResRemark { 
    	get { return __view_ResRemark ?? (__view_ResRemark = new FakeObjectSet<View_ResRemark>()); }
    	set { __view_ResRemark = value; }
    	}
    	private IObjectSet<View_ResRemark> __view_ResRemark;
    
        public IObjectSet<View_ZYKResource> View_ZYKResource { 
    	get { return __view_ZYKResource ?? (__view_ZYKResource = new FakeObjectSet<View_ZYKResource>()); }
    	set { __view_ZYKResource = value; }
    	}
    	private IObjectSet<View_ZYKResource> __view_ZYKResource;
    
        public IObjectSet<ZYK_HistoryDownLoad> ZYK_HistoryDownLoad { 
    	get { return __zYK_HistoryDownLoad ?? (__zYK_HistoryDownLoad = new FakeObjectSet<ZYK_HistoryDownLoad>()); }
    	set { __zYK_HistoryDownLoad = value; }
    	}
    	private IObjectSet<ZYK_HistoryDownLoad> __zYK_HistoryDownLoad;
    
        public IObjectSet<ZYK_HistoryFavorite> ZYK_HistoryFavorite { 
    	get { return __zYK_HistoryFavorite ?? (__zYK_HistoryFavorite = new FakeObjectSet<ZYK_HistoryFavorite>()); }
    	set { __zYK_HistoryFavorite = value; }
    	}
    	private IObjectSet<ZYK_HistoryFavorite> __zYK_HistoryFavorite;
    
        public IObjectSet<ZYK_HistoryPinJia> ZYK_HistoryPinJia { 
    	get { return __zYK_HistoryPinJia ?? (__zYK_HistoryPinJia = new FakeObjectSet<ZYK_HistoryPinJia>()); }
    	set { __zYK_HistoryPinJia = value; }
    	}
    	private IObjectSet<ZYK_HistoryPinJia> __zYK_HistoryPinJia;
    
        public IObjectSet<ZYK_HistoryUse> ZYK_HistoryUse { 
    	get { return __zYK_HistoryUse ?? (__zYK_HistoryUse = new FakeObjectSet<ZYK_HistoryUse>()); }
    	set { __zYK_HistoryUse = value; }
    	}
    	private IObjectSet<ZYK_HistoryUse> __zYK_HistoryUse;
    
        public IObjectSet<ZYK_HistoryView> ZYK_HistoryView { 
    	get { return __zYK_HistoryView ?? (__zYK_HistoryView = new FakeObjectSet<ZYK_HistoryView>()); }
    	set { __zYK_HistoryView = value; }
    	}
    	private IObjectSet<ZYK_HistoryView> __zYK_HistoryView;
    
        public IObjectSet<ZYK_PingjiaRemark> ZYK_PingjiaRemark { 
    	get { return __zYK_PingjiaRemark ?? (__zYK_PingjiaRemark = new FakeObjectSet<ZYK_PingjiaRemark>()); }
    	set { __zYK_PingjiaRemark = value; }
    	}
    	private IObjectSet<ZYK_PingjiaRemark> __zYK_PingjiaRemark;
    
        public IObjectSet<ZYK_ResAccessRecord> ZYK_ResAccessRecord { 
    	get { return __zYK_ResAccessRecord ?? (__zYK_ResAccessRecord = new FakeObjectSet<ZYK_ResAccessRecord>()); }
    	set { __zYK_ResAccessRecord = value; }
    	}
    	private IObjectSet<ZYK_ResAccessRecord> __zYK_ResAccessRecord;
    
        public IObjectSet<ZYK_ResoucePush> ZYK_ResoucePush { 
    	get { return __zYK_ResoucePush ?? (__zYK_ResoucePush = new FakeObjectSet<ZYK_ResoucePush>()); }
    	set { __zYK_ResoucePush = value; }
    	}
    	private IObjectSet<ZYK_ResoucePush> __zYK_ResoucePush;
    
        public IObjectSet<ZYK_Resource> ZYK_Resource { 
    	get { return __zYK_Resource ?? (__zYK_Resource = new FakeObjectSet<ZYK_Resource>()); }
    	set { __zYK_Resource = value; }
    	}
    	private IObjectSet<ZYK_Resource> __zYK_Resource;
    
        public IObjectSet<ZYK_ResourceCategory> ZYK_ResourceCategory { 
    	get { return __zYK_ResourceCategory ?? (__zYK_ResourceCategory = new FakeObjectSet<ZYK_ResourceCategory>()); }
    	set { __zYK_ResourceCategory = value; }
    	}
    	private IObjectSet<ZYK_ResourceCategory> __zYK_ResourceCategory;
    
        public IObjectSet<ZYK_ResourceFavorite> ZYK_ResourceFavorite { 
    	get { return __zYK_ResourceFavorite ?? (__zYK_ResourceFavorite = new FakeObjectSet<ZYK_ResourceFavorite>()); }
    	set { __zYK_ResourceFavorite = value; }
    	}
    	private IObjectSet<ZYK_ResourceFavorite> __zYK_ResourceFavorite;
    
        public IObjectSet<ZYK_ResourceFavoriteCategory> ZYK_ResourceFavoriteCategory { 
    	get { return __zYK_ResourceFavoriteCategory ?? (__zYK_ResourceFavoriteCategory = new FakeObjectSet<ZYK_ResourceFavoriteCategory>()); }
    	set { __zYK_ResourceFavoriteCategory = value; }
    	}
    	private IObjectSet<ZYK_ResourceFavoriteCategory> __zYK_ResourceFavoriteCategory;
    
        public IObjectSet<ZYK_ResourceFile> ZYK_ResourceFile { 
    	get { return __zYK_ResourceFile ?? (__zYK_ResourceFile = new FakeObjectSet<ZYK_ResourceFile>()); }
    	set { __zYK_ResourceFile = value; }
    	}
    	private IObjectSet<ZYK_ResourceFile> __zYK_ResourceFile;
    
        public IObjectSet<ZYK_ResourceSclass> ZYK_ResourceSclass { 
    	get { return __zYK_ResourceSclass ?? (__zYK_ResourceSclass = new FakeObjectSet<ZYK_ResourceSclass>()); }
    	set { __zYK_ResourceSclass = value; }
    	}
    	private IObjectSet<ZYK_ResourceSclass> __zYK_ResourceSclass;
    
        public IObjectSet<ZYK_ResourceSection> ZYK_ResourceSection { 
    	get { return __zYK_ResourceSection ?? (__zYK_ResourceSection = new FakeObjectSet<ZYK_ResourceSection>()); }
    	set { __zYK_ResourceSection = value; }
    	}
    	private IObjectSet<ZYK_ResourceSection> __zYK_ResourceSection;
    
        public IObjectSet<ZYK_SchoolCategory> ZYK_SchoolCategory { 
    	get { return __zYK_SchoolCategory ?? (__zYK_SchoolCategory = new FakeObjectSet<ZYK_SchoolCategory>()); }
    	set { __zYK_SchoolCategory = value; }
    	}
    	private IObjectSet<ZYK_SchoolCategory> __zYK_SchoolCategory;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

