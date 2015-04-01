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

namespace api.schoolbase.entities.DBSyllabus
{
    
    public partial class _DBSyllabus
    {
        public static @__api.schoolbase.entities.DBSyllabus.Entity.syllabuschapters_Columns syllabuschapters = new @__api.schoolbase.entities.DBSyllabus.Entity.syllabuschapters_Columns();
    }
    namespace @__api.schoolbase.entities.DBSyllabus.Entity
    {
        public class syllabuschapters_Columns : MyLib.DbAccess.SQL.IQueryTable
        {
            private const string ___TABLE_NAME = "syllabuschapters";
            private string ___aliasName;
            public syllabuschapters_Columns(string aliasName) : base("DBSyllabus") { this.___aliasName = aliasName; }
            public syllabuschapters_Columns() : base("DBSyllabus") { this.___aliasName = ___TABLE_NAME; }
    
        #region Table Columns
    
    		private static MyLib.DbAccess.SQL.QueryColumn _chapterid = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".chapterid"), DbType.Int16);
            public MyLib.DbAccess.SQL.QueryColumn chapterid
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _chapterid;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".chapterid"), DbType.Int16);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _syllabussbujectid = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".syllabussbujectid"), DbType.Int32);
            public MyLib.DbAccess.SQL.QueryColumn syllabussbujectid
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _syllabussbujectid;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".syllabussbujectid"), DbType.Int32);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _chapter = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".chapter"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn chapter
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _chapter;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".chapter"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _chapter_prefix = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".chapter_prefix"), DbType.String);
            public MyLib.DbAccess.SQL.QueryColumn chapter_prefix
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _chapter_prefix;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".chapter_prefix"), DbType.String);
                }
            }
    
    		private static MyLib.DbAccess.SQL.QueryColumn _term = new MyLib.DbAccess.SQL.QueryColumn((___TABLE_NAME + ".term"), DbType.Int16);
            public MyLib.DbAccess.SQL.QueryColumn term
            {
                get
                {
                    if ((this.___aliasName == ___TABLE_NAME)) return _term;
                    else return new MyLib.DbAccess.SQL.QueryColumn((this.___aliasName + ".term"), DbType.Int16);
                }
            }

        #endregion

                
            public override string ___GetTableName() { return ___TABLE_NAME; }
    		public override string ___GetAliasName() { return ___aliasName ?? ___TABLE_NAME; }
    		        public override IEnumerable<MyLib.DbAccess.SQL.QueryColumn> ___GetAutoIncrementColumn() { return new MyLib.DbAccess.SQL.QueryColumn[]{_chapterid}; }
    				        public override MyLib.DbAccess.SQL.QueryColumn ___GetIdentityColumn() { return _chapterid; }
            		public @__api.schoolbase.entities.DBSyllabus.Entity.syllabuschapters_Columns @__Alias(string aliasName) { return new @__api.schoolbase.entities.DBSyllabus.Entity.syllabuschapters_Columns(aliasName); }
        }
    }
    [System.Serializable]
    public partial class syllabuschapters
    {
        #region Property
    
        public virtual short chapterid
        {
            get { return _chapterid; }
            set
            {
                if (_chapterid != value)
                {
                    if (syllabuschapters2 != null && syllabuschapters2.chapterid != value)
                    {
                        syllabuschapters2 = null;
                    }
                    _chapterid = value;
                }
            }
        }
        private short _chapterid;
    
        public virtual int syllabussbujectid
        {
            get { return _syllabussbujectid; }
            set
            {
                if (_syllabussbujectid != value)
                {
                    if (syllabussubject != null && syllabussubject.id != value)
                    {
                        syllabussubject = null;
                    }
                    _syllabussbujectid = value;
                }
            }
        }
        private int _syllabussbujectid;
    
        public virtual string chapter
        {
            get;
            set;
        }
    
        public virtual string chapter_prefix
        {
            get;
            set;
        }
    
        public virtual short term
        {
            get;
            set;
        }

        #endregion

        #region Navigation Properties
    
        public virtual syllabuschapters syllabuschapters1
        {
            get { return _syllabuschapters1; }
            set
            {
                if (!ReferenceEquals(_syllabuschapters1, value))
                {
                    var previousValue = _syllabuschapters1;
                    _syllabuschapters1 = value;
                    Fixupsyllabuschapters1(previousValue);
                }
            }
        }
        private syllabuschapters _syllabuschapters1;
    
        public virtual syllabuschapters syllabuschapters2
        {
            get { return _syllabuschapters2; }
            set
            {
                if (!ReferenceEquals(_syllabuschapters2, value))
                {
                    var previousValue = _syllabuschapters2;
                    _syllabuschapters2 = value;
                    Fixupsyllabuschapters2(previousValue);
                }
            }
        }
        private syllabuschapters _syllabuschapters2;
    
        public virtual syllabussubject syllabussubject
        {
            get { return _syllabussubject; }
            set
            {
                if (!ReferenceEquals(_syllabussubject, value))
                {
                    var previousValue = _syllabussubject;
                    _syllabussubject = value;
                    Fixupsyllabussubject(previousValue);
                }
            }
        }
        private syllabussubject _syllabussubject;

        #endregion

        #region Association Fixup
    
        private void Fixupsyllabuschapters1(syllabuschapters previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.syllabuschapters2, this))
            {
                previousValue.syllabuschapters2 = null;
            }
    
            if (syllabuschapters1 != null)
            {
                syllabuschapters1.syllabuschapters2 = this;
            }
        }
    
        private void Fixupsyllabuschapters2(syllabuschapters previousValue)
        {
            if (previousValue != null && ReferenceEquals(previousValue.syllabuschapters1, this))
            {
                previousValue.syllabuschapters1 = null;
            }
    
            if (syllabuschapters2 != null)
            {
                syllabuschapters2.syllabuschapters1 = this;
                if (chapterid != syllabuschapters2.chapterid)
                {
                    chapterid = syllabuschapters2.chapterid;
                }
            }
        }
    
        private void Fixupsyllabussubject(syllabussubject previousValue)
        {
            if (previousValue != null && previousValue.syllabuschapters.Contains(this))
            {
                previousValue.syllabuschapters.Remove(this);
            }
    
            if (syllabussubject != null)
            {
                if (!syllabussubject.syllabuschapters.Contains(this))
                {
                    syllabussubject.syllabuschapters.Add(this);
                }
                if (syllabussbujectid != syllabussubject.id)
                {
                    syllabussbujectid = syllabussubject.id;
                }
            }
        }

        #endregion

    }
}
