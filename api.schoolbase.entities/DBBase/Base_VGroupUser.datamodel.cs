//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace api.schoolbase.entities.DBBase
{
    
    public partial class _DBBase
    {
        public static @__api.schoolbase.entities.DBBase.Entity.Base_VGroupUser_Columns Base_VGroupUser = new @__api.schoolbase.entities.DBBase.Entity.Base_VGroupUser_Columns();
    }
    namespace @__api.schoolbase.entities.DBBase.Entity
    {
        public class Base_VGroupUser_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "Base_VGroupUser";
            private string ___aliasName;
            public Base_VGroupUser_Columns(string aliasName) : base("DBBase") { this.___aliasName = aliasName; }
            public Base_VGroupUser_Columns() : base("DBBase") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GroupID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GroupID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GroupID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GroupID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GroupID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _UID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".UID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn UID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _UID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".UID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _UserName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".UserName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn UserName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _UserName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".UserName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _DepID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".DepID"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn DepID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _DepID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".DepID"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _UserType = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".UserType"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn UserType
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _UserType;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".UserType"), DbType.Int64);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _UID; }
            		public @__api.schoolbase.entities.DBBase.Entity.Base_VGroupUser_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBBase.Entity.Base_VGroupUser_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class Base_VGroupUser
    {
        #region Property
    
        public virtual Nullable<long> GroupID
        {
            get;
            set;
        }
    
        public virtual long UID
        {
            get;
            set;
        }
    
        public virtual string UserName
        {
            get;
            set;
        }
    
        public virtual string DepID
        {
            get;
            set;
        }
    
        public virtual Nullable<long> UserType
        {
            get;
            set;
        }

        #endregion

    }
}