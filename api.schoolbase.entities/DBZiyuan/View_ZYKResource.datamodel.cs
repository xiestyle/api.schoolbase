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

namespace api.schoolbase.entities.DBZiyuan
{
    
    public partial class _DBZiyuan
    {
        public static @__api.schoolbase.entities.DBZiyuan.Entity.View_ZYKResource_Columns View_ZYKResource = new @__api.schoolbase.entities.DBZiyuan.Entity.View_ZYKResource_Columns();
    }
    namespace @__api.schoolbase.entities.DBZiyuan.Entity
    {
        public class View_ZYKResource_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "View_ZYKResource";
            private string ___aliasName;
            public View_ZYKResource_Columns(string aliasName) : base("DBZiyuan") { this.___aliasName = aliasName; }
            public View_ZYKResource_Columns() : base("DBZiyuan") { this.___aliasName = ___TABLE_NAME; }
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _FileID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".FileID"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn FileID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _FileID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".FileID"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CategoryID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CategoryID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn CategoryID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CategoryID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CategoryID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CategoryName = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CategoryName"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn CategoryName
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CategoryName;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CategoryName"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _GRAID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".GRAID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn GRAID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _GRAID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".GRAID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NodePath = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NodePath"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn NodePath
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NodePath;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NodePath"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SclassID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SclassID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SclassID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SclassID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SclassID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Dtime = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Dtime"), DbType.DateTime);
            public MyLib.DbAccess.SQL.QueryColumn Dtime
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Dtime;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Dtime"), DbType.DateTime);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ResTitle = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ResTitle"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn ResTitle
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ResTitle;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ResTitle"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _ResDes = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".ResDes"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn ResDes
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _ResDes;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".ResDes"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumView = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumView"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumView
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumView;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumView"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumUse = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumUse"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumUse
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumUse;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumUse"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumCollect = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumCollect"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumCollect
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumCollect;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumCollect"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumDownLoad = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumDownLoad"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumDownLoad
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumDownLoad;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumDownLoad"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumShare = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumShare"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumShare
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumShare;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumShare"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TotalScore = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TotalScore"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn TotalScore
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TotalScore;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TotalScore"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _NumScore = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".NumScore"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn NumScore
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _NumScore;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".NumScore"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _isPassed = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".isPassed"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn isPassed
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _isPassed;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".isPassed"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _isDeleted = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".isDeleted"), DbType.Boolean);
            public MyLib.DbAccess.SQL.QueryColumn isDeleted
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _isDeleted;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".isDeleted"), DbType.Boolean);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _numremark = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".numremark"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn numremark
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _numremark;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".numremark"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _FileType = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".FileType"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn FileType
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _FileType;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".FileType"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _FileSize = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".FileSize"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn FileSize
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _FileSize;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".FileSize"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _isPush = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".isPush"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn isPush
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _isPush;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".isPush"), DbType.Int32);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SERID; }
            		public @__api.schoolbase.entities.DBZiyuan.Entity.View_ZYKResource_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBZiyuan.Entity.View_ZYKResource_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class View_ZYKResource
    {
        #region Property
    
        public virtual long SERID
        {
            get;
            set;
        }
    
        public virtual string FileID
        {
            get;
            set;
        }
    
        public virtual string SchSerID
        {
            get;
            set;
        }
    
        public virtual long CategoryID
        {
            get;
            set;
        }
    
        public virtual string CategoryName
        {
            get;
            set;
        }
    
        public virtual long SpecialtyID
        {
            get;
            set;
        }
    
        public virtual long GRAID
        {
            get;
            set;
        }
    
        public virtual long SubjectID
        {
            get;
            set;
        }
    
        public virtual string NodePath
        {
            get;
            set;
        }
    
        public virtual long SclassID
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
    
        public virtual System.DateTime Dtime
        {
            get { return _dtime; }
            set { 
    			if (value.Kind == DateTimeKind.Unspecified) {
    			_dtime = DateTime.SpecifyKind(value, DateTimeKind.Utc);
    			} else {
    				_dtime = value;
    			}
    			}
        }
        private System.DateTime _dtime;
    
        public virtual string ResTitle
        {
            get;
            set;
        }
    
        public virtual string ResDes
        {
            get;
            set;
        }
    
        public virtual int NumView
        {
            get;
            set;
        }
    
        public virtual int NumUse
        {
            get;
            set;
        }
    
        public virtual int NumCollect
        {
            get;
            set;
        }
    
        public virtual int NumDownLoad
        {
            get;
            set;
        }
    
        public virtual int NumShare
        {
            get;
            set;
        }
    
        public virtual int TotalScore
        {
            get;
            set;
        }
    
        public virtual int NumScore
        {
            get;
            set;
        }
    
        public virtual int isPassed
        {
            get;
            set;
        }
    
        public virtual bool isDeleted
        {
            get;
            set;
        }
    
        public virtual int numremark
        {
            get;
            set;
        }
    
        public virtual string FileType
        {
            get;
            set;
        }
    
        public virtual int FileSize
        {
            get;
            set;
        }
    
        public virtual Nullable<int> isPush
        {
            get;
            set;
        }

        #endregion

    }
}
