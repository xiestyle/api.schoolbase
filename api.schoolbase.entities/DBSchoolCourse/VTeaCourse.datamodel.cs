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
        public static @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourse_Columns VTeaCourse = new @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourse_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchoolCourse.Entity
    {
        public class VTeaCourse_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "VTeaCourse";
            private string ___aliasName;
            public VTeaCourse_Columns(string aliasName) : base("DBSchoolCourse") { this.___aliasName = aliasName; }
            public VTeaCourse_Columns() : base("DBSchoolCourse") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SerID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TeaSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TeaSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn TeaSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TeaSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TeaSerID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SpecialtyID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SpecialtyID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SpecialtyID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SpecialtyID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SpecialtyID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SpecName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SpecName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SpecName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SpecName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SpecName"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GRAID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GRAID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GRAID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GRAID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GRAID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GradeName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GradeName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn GradeName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GradeName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GradeName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Status = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Status"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn Status
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Status;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Status"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _IsMust = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".IsMust"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn IsMust
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _IsMust;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".IsMust"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _DTime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".DTime"), DbType.DateTime);
            public MyLib.DbAccess.SQL.QueryColumn DTime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _DTime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".DTime"), DbType.DateTime);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ClassSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ClassSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn ClassSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ClassSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ClassSerID"), DbType.Int64);
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

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SerID; }
            		public @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourse_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchoolCourse.Entity.VTeaCourse_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class VTeaCourse
    {
        #region Property
    
        public virtual long SerID
        {
            get;
            set;
        }
    
        public virtual string SchSerID
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
    
        public virtual long TeaSerID
        {
            get;
            set;
        }
    
        public virtual string TeaName
        {
            get;
            set;
        }
    
        public virtual long SpecialtyID
        {
            get;
            set;
        }
    
        public virtual long SPEID
        {
            get;
            set;
        }
    
        public virtual string SpecName
        {
            get;
            set;
        }
    
        public virtual long GRAID
        {
            get;
            set;
        }
    
        public virtual string GradeName
        {
            get;
            set;
        }
    
        public virtual long SubjectID
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
    
        public virtual long Status
        {
            get;
            set;
        }
    
        public virtual long IsMust
        {
            get;
            set;
        }
    
        public virtual System.DateTime DTime
        {
            get { return _dTime; }
            set { 
    			if (value.Kind == DateTimeKind.Unspecified) {
    			_dTime = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_dTime = value;
    			}
    			}
        }
        private System.DateTime _dTime;
    
        public virtual Nullable<long> ClassSerID
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

        #endregion

    }
}
