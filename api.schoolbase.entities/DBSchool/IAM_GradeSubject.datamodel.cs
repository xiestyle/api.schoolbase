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
        public static @__api.schoolbase.entities.DBSchool.Entity.IAM_GradeSubject_Columns IAM_GradeSubject = new @__api.schoolbase.entities.DBSchool.Entity.IAM_GradeSubject_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class IAM_GradeSubject_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_GradeSubject";
            private string ___aliasName;
            public IAM_GradeSubject_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public IAM_GradeSubject_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _IsMust = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".IsMust"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn IsMust
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _IsMust;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".IsMust"), DbType.Int64);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _GRAID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.IAM_GradeSubject_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.IAM_GradeSubject_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_GradeSubject
    {
        #region Property
    
        public virtual long GRAID
        {
            get;
            set;
        }
    
        public virtual long SubjectID
        {
            get { return _subjectID; }
            set
            {
                if (_subjectID != value)
                {
                    if (IAM_SchSubject != null && IAM_SchSubject.SERID != value)
                    {
                        IAM_SchSubject = null;
                    }
                    _subjectID = value;
                }
            }
        }
        private long _subjectID;
    
        public virtual long IsMust
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual IAM_SchSubject IAM_SchSubject
        {
            get { return _iAM_SchSubject; }
            set
            {
                if (!ReferenceEquals(_iAM_SchSubject, value))
                {
                    var previousValue = _iAM_SchSubject;
                    _iAM_SchSubject = value;
                    FixupIAM_SchSubject(previousValue);
                }
            }
        }
        private IAM_SchSubject _iAM_SchSubject;

        #endregion

        #region Association Fixup
    
        private void FixupIAM_SchSubject(IAM_SchSubject previousValue)
        {
            if (previousValue != null && previousValue.IAM_GradeSubject.Contains(this))
            {
                previousValue.IAM_GradeSubject.Remove(this);
            }
    
            if (IAM_SchSubject != null)
            {
                if (!IAM_SchSubject.IAM_GradeSubject.Contains(this))
                {
                    IAM_SchSubject.IAM_GradeSubject.Add(this);
                }
                if (SubjectID != IAM_SchSubject.SERID)
                {
                    SubjectID = IAM_SchSubject.SERID;
                }
            }
        }

        #endregion

    }
}
