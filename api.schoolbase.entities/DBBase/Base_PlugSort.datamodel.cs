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
        public static @__api.schoolbase.entities.DBBase.Entity.Base_PlugSort_Columns Base_PlugSort = new @__api.schoolbase.entities.DBBase.Entity.Base_PlugSort_Columns();
    }
    namespace @__api.schoolbase.entities.DBBase.Entity
    {
        public class Base_PlugSort_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "Base_PlugSort";
            private string ___aliasName;
            public Base_PlugSort_Columns(string aliasName) : base("DBBase") { this.___aliasName = aliasName; }
            public Base_PlugSort_Columns() : base("DBBase") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SERID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SERID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SERID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SERID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SERID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SIndex = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SIndex"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn SIndex
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SIndex;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SIndex"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _DskType = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".DskType"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn DskType
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _DskType;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".DskType"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _IsShow = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".IsShow"), DbType.Byte);
            public MyLib.DbAccess.SQL.QueryColumn IsShow
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _IsShow;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".IsShow"), DbType.Byte);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    		        public override IEnumerable<MyLib.DbAccess.SQL.QueryColumn> ___GetAutoIncrementColumn() { return new MyLib.DbAccess.SQL.QueryColumn[]{_SERID}; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SERID; }
            		public @__api.schoolbase.entities.DBBase.Entity.Base_PlugSort_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBBase.Entity.Base_PlugSort_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class Base_PlugSort
    {
        #region Property
    
        public virtual long SERID
        {
            get;
            set;
        }
    
        public virtual string SName
        {
            get;
            set;
        }
    
        public virtual long UID
        {
            get;
            set;
        }
    
        public virtual int SIndex
        {
            get;
            set;
        }
    
        public virtual string DskType
        {
            get;
            set;
        }
    
        public virtual byte IsShow
        {
            get;
            set;
        }

        #endregion

    }
}