// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBUser
{
    public partial interface IDBUserEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<tUser> tUser { get; }

            #endregion

    }
}

