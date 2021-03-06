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
        public static @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Campus_Columns IAM_Group4Campus = new @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Campus_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class IAM_Group4Campus_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_Group4Campus";
            private string ___aliasName;
            public IAM_Group4Campus_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public IAM_Group4Campus_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CampusID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CampusID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn CampusID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CampusID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CampusID"), DbType.Int64);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _GroupID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Campus_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.IAM_Group4Campus_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_Group4Campus
    {
        #region Property
    
        public virtual long GroupID
        {
            get;
            set;
        }
    
        public virtual long CampusID
        {
            get { return _campusID; }
            set
            {
                if (_campusID != value)
                {
                    if (IAM_SchCampus != null && IAM_SchCampus.CampusID != value)
                    {
                        IAM_SchCampus = null;
                    }
                    _campusID = value;
                }
            }
        }
        private long _campusID;

        #endregion

        #region Navigation Properties
    
        public virtual IAM_SchCampus IAM_SchCampus
        {
            get { return _iAM_SchCampus; }
            set
            {
                if (!ReferenceEquals(_iAM_SchCampus, value))
                {
                    var previousValue = _iAM_SchCampus;
                    _iAM_SchCampus = value;
                    FixupIAM_SchCampus(previousValue);
                }
            }
        }
        private IAM_SchCampus _iAM_SchCampus;

        #endregion

        #region Association Fixup
    
        private void FixupIAM_SchCampus(IAM_SchCampus previousValue)
        {
            if (previousValue != null && previousValue.IAM_Group4Campus.Contains(this))
            {
                previousValue.IAM_Group4Campus.Remove(this);
            }
    
            if (IAM_SchCampus != null)
            {
                if (!IAM_SchCampus.IAM_Group4Campus.Contains(this))
                {
                    IAM_SchCampus.IAM_Group4Campus.Add(this);
                }
                if (CampusID != IAM_SchCampus.CampusID)
                {
                    CampusID = IAM_SchCampus.CampusID;
                }
            }
        }

        #endregion

    }
}
