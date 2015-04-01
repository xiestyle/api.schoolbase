// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSyllabus
{
    public  abstract class FakeDBSyllabusEntitiesBase : IDBSyllabusEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<area> area { 
    	get { return __area ?? (__area = new FakeObjectSet<area>()); }
    	set { __area = value; }
    	}
    	private IObjectSet<area> __area;
    
        public IObjectSet<chapters> chapters { 
    	get { return __chapters ?? (__chapters = new FakeObjectSet<chapters>()); }
    	set { __chapters = value; }
    	}
    	private IObjectSet<chapters> __chapters;
    
        public IObjectSet<dtproperties> dtproperties { 
    	get { return __dtproperties ?? (__dtproperties = new FakeObjectSet<dtproperties>()); }
    	set { __dtproperties = value; }
    	}
    	private IObjectSet<dtproperties> __dtproperties;
    
        public IObjectSet<sclass> sclass { 
    	get { return __sclass ?? (__sclass = new FakeObjectSet<sclass>()); }
    	set { __sclass = value; }
    	}
    	private IObjectSet<sclass> __sclass;
    
        public IObjectSet<sclasstosection> sclasstosection { 
    	get { return __sclasstosection ?? (__sclasstosection = new FakeObjectSet<sclasstosection>()); }
    	set { __sclasstosection = value; }
    	}
    	private IObjectSet<sclasstosection> __sclasstosection;
    
        public IObjectSet<sections> sections { 
    	get { return __sections ?? (__sections = new FakeObjectSet<sections>()); }
    	set { __sections = value; }
    	}
    	private IObjectSet<sections> __sections;
    
        public IObjectSet<subjects> subjects { 
    	get { return __subjects ?? (__subjects = new FakeObjectSet<subjects>()); }
    	set { __subjects = value; }
    	}
    	private IObjectSet<subjects> __subjects;
    
        public IObjectSet<syllabus> syllabus { 
    	get { return __syllabus ?? (__syllabus = new FakeObjectSet<syllabus>()); }
    	set { __syllabus = value; }
    	}
    	private IObjectSet<syllabus> __syllabus;
    
        public IObjectSet<syllabuschapters> syllabuschapters { 
    	get { return __syllabuschapters ?? (__syllabuschapters = new FakeObjectSet<syllabuschapters>()); }
    	set { __syllabuschapters = value; }
    	}
    	private IObjectSet<syllabuschapters> __syllabuschapters;
    
        public IObjectSet<syllabussections> syllabussections { 
    	get { return __syllabussections ?? (__syllabussections = new FakeObjectSet<syllabussections>()); }
    	set { __syllabussections = value; }
    	}
    	private IObjectSet<syllabussections> __syllabussections;
    
        public IObjectSet<syllabussubject> syllabussubject { 
    	get { return __syllabussubject ?? (__syllabussubject = new FakeObjectSet<syllabussubject>()); }
    	set { __syllabussubject = value; }
    	}
    	private IObjectSet<syllabussubject> __syllabussubject;
    
        public IObjectSet<syllabustosection> syllabustosection { 
    	get { return __syllabustosection ?? (__syllabustosection = new FakeObjectSet<syllabustosection>()); }
    	set { __syllabustosection = value; }
    	}
    	private IObjectSet<syllabustosection> __syllabustosection;
    
        public IObjectSet<vsclass> vsclass { 
    	get { return __vsclass ?? (__vsclass = new FakeObjectSet<vsclass>()); }
    	set { __vsclass = value; }
    	}
    	private IObjectSet<vsclass> __vsclass;
    
        public IObjectSet<vsections> vsections { 
    	get { return __vsections ?? (__vsections = new FakeObjectSet<vsections>()); }
    	set { __vsections = value; }
    	}
    	private IObjectSet<vsections> __vsections;
    
        public IObjectSet<vsyllabussections> vsyllabussections { 
    	get { return __vsyllabussections ?? (__vsyllabussections = new FakeObjectSet<vsyllabussections>()); }
    	set { __vsyllabussections = value; }
    	}
    	private IObjectSet<vsyllabussections> __vsyllabussections;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

