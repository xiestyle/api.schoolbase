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
        public static @__api.schoolbase.entities.DBSchool.Entity.VClassStudent_Columns VClassStudent = new @__api.schoolbase.entities.DBSchool.Entity.VClassStudent_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class VClassStudent_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "VClassStudent";
            private string ___aliasName;
            public VClassStudent_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public VClassStudent_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SchSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SchSerID"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SchSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SchSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SchSerID"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SchName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SchName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn SchName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SchName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SchName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _StuSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".StuSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn StuSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _StuSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".StuSerID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _StuName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".StuName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn StuName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _StuName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".StuName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ClassSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ClassSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn ClassSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ClassSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ClassSerID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GradeName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GradeName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn GradeName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GradeName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GradeName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _StuStatus = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".StuStatus"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn StuStatus
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _StuStatus;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".StuStatus"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _StuPhoto = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".StuPhoto"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn StuPhoto
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _StuPhoto;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".StuPhoto"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Status = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Status"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn Status
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Status;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Status"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ClassStuID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ClassStuID"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn ClassStuID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ClassStuID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ClassStuID"), DbType.Int32);
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

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SchSerID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.VClassStudent_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.VClassStudent_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class VClassStudent
    {
        #region Property
    
        public virtual string SchSerID
        {
            get;
            set;
        }
    
        public virtual string SchName
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
    
        public virtual long StuSerID
        {
            get;
            set;
        }
    
        public virtual string StuName
        {
            get;
            set;
        }
    
        public virtual string ClassName
        {
            get;
            set;
        }
    
        public virtual long ClassSerID
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
    
        public virtual string GradeName
        {
            get;
            set;
        }
    
        public virtual long GRAID
        {
            get;
            set;
        }
    
        public virtual long StuStatus
        {
            get;
            set;
        }
    
        public virtual string StuPhoto
        {
            get;
            set;
        }
    
        public virtual string ClassNumber
        {
            get;
            set;
        }
    
        public virtual int Status
        {
            get;
            set;
        }
    
        public virtual int ClassStuID
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

        #endregion

    }
}
