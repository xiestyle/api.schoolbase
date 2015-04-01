

// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Data.EntityClient;
using System.Collections.Generic;
using System.ComponentModel;
using MyLib.DAO;

namespace api.schoolbase.entities.DBUser
{
    public partial class DBUserEntities : ObjectContext, IDBUserEntities
    {
        public const string ConnectionString = "name=DBUserEntities";
        public const string ContainerName = "DBUserEntities";
    	
    	public void DiscardChanges()
    	{
    		ObjectContextExtensions.DiscardChanges(this);
    	}
    
        #region Constructors
    
        public DBUserEntities()
            : base(ConnectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
        }
    
        public DBUserEntities(string connectionString, int? commandTimeout = null)
            : base(connectionString, ContainerName)
        {
            this.ContextOptions.LazyLoadingEnabled = true;
    		CommandTimeout = commandTimeout;
        }
    
        public DBUserEntities(EntityConnection connection)
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
    	
    	bool IDBUserEntities.CanPreCompile
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
    		TypeDescriptor.AddProvider(new EfPocoTypeDescriptionProvider<tUser>(), typeof(tUser));
    	}
        #region ObjectSet Properties
    
        public ObjectSet<tUser> tUser
        {
            get { 
    			if (_tUser == null) {
    				_tUser = CreateObjectSet<tUser>("tUser"); 
    				if (EntitiesMergeOption != null) {
    					_tUser.MergeOption = EntitiesMergeOption.Value;
    				}
    			}
    			return _tUser;
    		}
        }
        private ObjectSet<tUser> _tUser;
        IObjectSet<tUser> IDBUserEntities.tUser
        {
            get { return this.tUser; }
        }

        #endregion

    }
}



