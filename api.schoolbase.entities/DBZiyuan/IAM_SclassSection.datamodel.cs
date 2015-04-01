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
        public static @__api.schoolbase.entities.DBZiyuan.Entity.IAM_SclassSection_Columns IAM_SclassSection = new @__api.schoolbase.entities.DBZiyuan.Entity.IAM_SclassSection_Columns();
    }
    namespace @__api.schoolbase.entities.DBZiyuan.Entity
    {
        public class IAM_SclassSection_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_SclassSection";
            private string ___aliasName;
            public IAM_SclassSection_Columns(string aliasName) : base("DBZiyuan") { this.___aliasName = aliasName; }
            public IAM_SclassSection_Columns() : base("DBZiyuan") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SclassID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SclassID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SclassID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SclassID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SclassID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _SectionID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".SectionID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn SectionID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _SectionID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".SectionID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Available = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Available"), DbType.Boolean);
            public MyLib.DbAccess.SQL.QueryColumn Available
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Available;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Available"), DbType.Boolean);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _SclassID; }
            		public @__api.schoolbase.entities.DBZiyuan.Entity.IAM_SclassSection_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBZiyuan.Entity.IAM_SclassSection_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_SclassSection
    {
        #region Property
    
        public virtual long SclassID
        {
            get { return _sclassID; }
            set
            {
                if (_sclassID != value)
                {
                    if (IAM_Sclass != null && IAM_Sclass.SERID != value)
                    {
                        IAM_Sclass = null;
                    }
                    _sclassID = value;
                }
            }
        }
        private long _sclassID;
    
        public virtual long SectionID
        {
            get;
            set;
        }
    
        public virtual bool Available
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual IAM_Sclass IAM_Sclass
        {
            get { return _iAM_Sclass; }
            set
            {
                if (!ReferenceEquals(_iAM_Sclass, value))
                {
                    var previousValue = _iAM_Sclass;
                    _iAM_Sclass = value;
                    FixupIAM_Sclass(previousValue);
                }
            }
        }
        private IAM_Sclass _iAM_Sclass;

        #endregion

        #region Association Fixup
    
        private void FixupIAM_Sclass(IAM_Sclass previousValue)
        {
            if (previousValue != null && previousValue.IAM_SclassSection.Contains(this))
            {
                previousValue.IAM_SclassSection.Remove(this);
            }
    
            if (IAM_Sclass != null)
            {
                if (!IAM_Sclass.IAM_SclassSection.Contains(this))
                {
                    IAM_Sclass.IAM_SclassSection.Add(this);
                }
                if (SclassID != IAM_Sclass.SERID)
                {
                    SclassID = IAM_Sclass.SERID;
                }
            }
        }

        #endregion

    }
}
