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
        public static @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourseItemClass_Columns VTeaCourseItemClass = new @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourseItemClass_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchoolCourse.Entity
    {
        public class VTeaCourseItemClass_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "VTeaCourseItemClass";
            private string ___aliasName;
            public VTeaCourseItemClass_Columns(string aliasName) : base("DBSchoolCourse") { this.___aliasName = aliasName; }
            public VTeaCourseItemClass_Columns() : base("DBSchoolCourse") { this.___aliasName = ___TABLE_NAME; }
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Address = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Address"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn Address
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Address;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Address"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _EndTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".EndTime"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn EndTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _EndTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".EndTime"), DbType.Int32);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NDay = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NDay"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NDay
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NDay;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NDay"), DbType.Int32);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ClassName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ClassName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn ClassName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ClassName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ClassName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ClassNumber = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ClassNumber"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn ClassNumber
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ClassNumber;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ClassNumber"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TeaName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TeaName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn TeaName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TeaName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TeaName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TeaSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TeaSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn TeaSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TeaSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TeaSerID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TeaPhoto = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TeaPhoto"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn TeaPhoto
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TeaPhoto;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TeaPhoto"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SchYear = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SchYear"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn SchYear
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SchYear;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SchYear"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SchTerm = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SchTerm"), DbType.Byte);
            public MyLib.DbAccess.SQL.QueryColumn SchTerm
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SchTerm;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SchTerm"), DbType.Byte);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SubjectID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SubjectID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SubjectID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SubjectID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SubjectID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Max = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Max"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn Max
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Max;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Max"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _LoopType = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".LoopType"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn LoopType
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _LoopType;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".LoopType"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _RequiredTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".RequiredTime"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn RequiredTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _RequiredTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".RequiredTime"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Score = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Score"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn Score
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Score;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Score"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SchSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SchSerID"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SchSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SchSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SchSerID"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Status = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Status"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn Status
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Status;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Status"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SpecName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SpecName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SpecName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SpecName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SpecName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SPEID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SPEID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SPEID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SPEID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SPEID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SubjectName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SubjectName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SubjectName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SubjectName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SubjectName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SUBID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SUBID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SUBID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SUBID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SUBID"), DbType.Int64);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SERID; }
            		public @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourseItemClass_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourseItemClass_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class VTeaCourseItemClass
    {
        #region Property
    
        public virtual long SERID
        {
            get;
            set;
        }
    
        public virtual string Address
        {
            get;
            set;
        }
    
        public virtual int CourseTime
        {
            get;
            set;
        }
    
        public virtual int EndTime
        {
            get;
            set;
        }
    
        public virtual int BeginTime
        {
            get;
            set;
        }
    
        public virtual int NDay
        {
            get;
            set;
        }
    
        public virtual long CourseSerID
        {
            get;
            set;
        }
    
        public virtual string ClassName
        {
            get;
            set;
        }
    
        public virtual string ClassNumber
        {
            get;
            set;
        }
    
        public virtual string TeaName
        {
            get;
            set;
        }
    
        public virtual long TeaSerID
        {
            get;
            set;
        }
    
        public virtual string TeaPhoto
        {
            get;
            set;
        }
    
        public virtual int SchYear
        {
            get;
            set;
        }
    
        public virtual byte SchTerm
        {
            get;
            set;
        }
    
        public virtual long SubjectID
        {
            get;
            set;
        }
    
        public virtual int Max
        {
            get;
            set;
        }
    
        public virtual long LoopType
        {
            get;
            set;
        }
    
        public virtual int RequiredTime
        {
            get;
            set;
        }
    
        public virtual int Score
        {
            get;
            set;
        }
    
        public virtual string SchSerID
        {
            get;
            set;
        }
    
        public virtual long Status
        {
            get;
            set;
        }
    
        public virtual long SpecialtyID
        {
            get;
            set;
        }
    
        public virtual string SpecName
        {
            get;
            set;
        }
    
        public virtual long SPEID
        {
            get;
            set;
        }
    
        public virtual string SubjectName
        {
            get;
            set;
        }
    
        public virtual long SUBID
        {
            get;
            set;
        }

        #endregion

    }
}
