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

namespace api.schoolbase.entities.DBSchoolCourse
{
    
    public partial class _DBSchoolCourse
    {
        public static @__api.schoolbase.entities.DBSchoolCourse.Entity.IAM_TeaCourseItem_Columns IAM_TeaCourseItem = new @__api.schoolbase.entities.DBSchoolCourse.Entity.IAM_TeaCourseItem_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchoolCourse.Entity
    {
        public class IAM_TeaCourseItem_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_TeaCourseItem";
            private string ___aliasName;
            public IAM_TeaCourseItem_Columns(string aliasName) : base("DBSchoolCourse") { this.___aliasName = aliasName; }
            public IAM_TeaCourseItem_Columns() : base("DBSchoolCourse") { this.___aliasName = ___TABLE_NAME; }
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CourseSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CourseSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn CourseSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CourseSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CourseSerID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NDay = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NDay"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NDay
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NDay;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NDay"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _BeginTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".BeginTime"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn BeginTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _BeginTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".BeginTime"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _EndTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".EndTime"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn EndTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _EndTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".EndTime"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CourseTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CourseTime"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn CourseTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CourseTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CourseTime"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Address = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Address"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn Address
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Address;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Address"), DbType.String);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    		        public override IEnumerable<MyLib.DbAccess.SQL.QueryColumn> ___GetAutoIncrementColumn() { return new MyLib.DbAccess.SQL.QueryColumn[]{_SERID}; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SERID; }
            		public @__api.schoolbase.entities.DBSchoolCourse.Entity.IAM_TeaCourseItem_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchoolCourse.Entity.IAM_TeaCourseItem_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_TeaCourseItem
    {
        #region Property
    
        public virtual long SERID
        {
            get;
            set;
        }
    
        public virtual long CourseSerID
        {
            get;
            set;
        }
    
        public virtual int NDay
        {
            get;
            set;
        }
    
        public virtual int BeginTime
        {
            get;
            set;
        }
    
        public virtual int EndTime
        {
            get;
            set;
        }
    
        public virtual int CourseTime
        {
            get;
            set;
        }
    
        public virtual string Address
        {
            get;
            set;
        }

        #endregion

    }
}