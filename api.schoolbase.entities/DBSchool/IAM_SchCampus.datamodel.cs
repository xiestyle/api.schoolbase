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
        public static @__api.schoolbase.entities.DBSchool.Entity.IAM_SchCampus_Columns IAM_SchCampus = new @__api.schoolbase.entities.DBSchool.Entity.IAM_SchCampus_Columns();
    }
    namespace @__api.schoolbase.entities.DBSchool.Entity
    {
        public class IAM_SchCampus_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "IAM_SchCampus";
            private string ___aliasName;
            public IAM_SchCampus_Columns(string aliasName) : base("DBSchool") { this.___aliasName = aliasName; }
            public IAM_SchCampus_Columns() : base("DBSchool") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _CampusID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".CampusID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn CampusID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _CampusID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".CampusID"), DbType.Int64);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _TeaSerID = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".TeaSerID"), DbType.Int64);
            public MyLib.DbAccess.SQL.QueryColumn TeaSerID
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _TeaSerID;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".TeaSerID"), DbType.Int64);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Name = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Name"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn Name
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Name;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Name"), DbType.String);
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
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Tel = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Tel"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn Tel
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Tel;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Tel"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _Switch = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".Switch"), DbType.Byte);
            public MyLib.DbAccess.SQL.QueryColumn Switch
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _Switch;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".Switch"), DbType.Byte);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    		        public override IEnumerable<MyLib.DbAccess.SQL.QueryColumn> ___GetAutoIncrementColumn() { return new MyLib.DbAccess.SQL.QueryColumn[]{_CampusID}; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _CampusID; }
            		public @__api.schoolbase.entities.DBSchool.Entity.IAM_SchCampus_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSchool.Entity.IAM_SchCampus_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class IAM_SchCampus
    {
        #region Property
    
        public virtual long CampusID
        {
            get;
            set;
        }
    
        public virtual string SchSerID
        {
            get;
            set;
        }
    
        public virtual Nullable<long> TeaSerID
        {
            get;
            set;
        }
    
        public virtual string Name
        {
            get;
            set;
        }
    
        public virtual string Address
        {
            get;
            set;
        }
    
        public virtual string Tel
        {
            get;
            set;
        }
    
        public virtual byte Switch
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual ICollection<IAM_Group4Campus> IAM_Group4Campus
        {
            get
            {
                if (_iAM_Group4Campus == null)
                {
                    var newCollection = new MyLib.DAO.FixupCollection<IAM_Group4Campus>();
                    newCollection.CollectionChanged += FixupIAM_Group4Campus;
                    _iAM_Group4Campus = newCollection;
                }
                return _iAM_Group4Campus;
            }
            set
            {
                if (!ReferenceEquals(_iAM_Group4Campus, value))
                {
                    var previousValue = _iAM_Group4Campus as MyLib.DAO.FixupCollection<IAM_Group4Campus>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupIAM_Group4Campus;
                    }
                    _iAM_Group4Campus = value;
                    var newValue = value as MyLib.DAO.FixupCollection<IAM_Group4Campus>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupIAM_Group4Campus;
                    }
                }
            }
        }
        private ICollection<IAM_Group4Campus> _iAM_Group4Campus;

        #endregion

        #region Association Fixup
    
        private void FixupIAM_Group4Campus(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (IAM_Group4Campus item in e.NewItems)
                {
                    item.IAM_SchCampus = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (IAM_Group4Campus item in e.OldItems)
                {
                    if (ReferenceEquals(item.IAM_SchCampus, this))
                    {
                        item.IAM_SchCampus = null;
                    }
                }
            }
        }

        #endregion

    }
}
