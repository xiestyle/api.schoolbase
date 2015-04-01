// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBUser
{
    public  abstract class FakeDBUserEntitiesBase : IDBUserEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<tUser> tUser { 
    	get { return __tUser ?? (__tUser = new FakeObjectSet<tUser>()); }
    	set { __tUser = value; }
    	}
    	private IObjectSet<tUser> __tUser;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

