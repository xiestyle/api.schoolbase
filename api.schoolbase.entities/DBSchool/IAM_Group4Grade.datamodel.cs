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
        public static @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Grade_Columns IAM_Group4Grade = new @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Grade_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class IAM_Group4Grade_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_Group4Grade";
            private string ___aliasName;
            public IAM_Group4Grade_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public IAM_Group4Grade_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GradeID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GradeID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GradeID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GradeID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GradeID"), DbType.Int64);
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

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _GroupID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Grade_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Grade_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_Group4Grade
    {
        #region Property
    
        public virtual long GroupID
        {
            get;
            set;
        }
    
        public virtual long GradeID
        {
            get;
            set;
        }
    
        public virtual long SpecialtyID
        {
            get;
            set;
        }

        #endregion

    }
}
