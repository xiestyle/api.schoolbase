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

namespace api.schoolbase.entities.DBSchool
{
    
    public partial class _DBSchool
    {
        public static @__api.schoolbase.entities.DBSchool.Entity.VGroup4SpecialtyUser_Columns VGroup4SpecialtyUser = new @__api.schoolbase.entities.DBSchool.Entity.VGroup4SpecialtyUser_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class VGroup4SpecialtyUser_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "VGroup4SpecialtyUser";
            private string ___aliasName;
            public VGroup4SpecialtyUser_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public VGroup4SpecialtyUser_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _UID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".UID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn UID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _UID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".UID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GroupID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GroupID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GroupID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GroupID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GroupID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SpecialtyID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SpecialtyID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SpecialtyID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SpecialtyID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SpecialtyID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn GName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GMgr = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GMgr"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GMgr
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GMgr;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GMgr"), DbType.Int64);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _UID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.VGroup4SpecialtyUser_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.VGroup4SpecialtyUser_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class VGroup4SpecialtyUser
    {
        #region Property
    
        public virtual long UID
        {
            get;
            set;
        }
    
        public virtual long GroupID
        {
            get;
            set;
        }
    
        public virtual string UserName
        {
            get;
            set;
        }
    
        public virtual long SpecialtyID
        {
            get;
            set;
        }
    
        public virtual string DepID
        {
            get;
            set;
        }
    
        public virtual string GName
        {
            get;
            set;
        }
    
        public virtual Nullable<long> GMgr
        {
            get;
            set;
        }

        #endregion

    }
}
