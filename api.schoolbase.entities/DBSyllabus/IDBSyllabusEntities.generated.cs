// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBSyllabus
{
    public partial interface IDBSyllabusEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<area> area { get; }
    
        IObjectSet<chapters> chapters { get; }
    
        IObjectSet<dtproperties> dtproperties { get; }
    
        IObjectSet<sclass> sclass { get; }
    
        IObjectSet<sclasstosection> sclasstosection { get; }
    
        IObjectSet<sections> sections { get; }
    
        IObjectSet<subjects> subjects { get; }
    
        IObjectSet<syllabus> syllabus { get; }
    
        IObjectSet<syllabuschapters> syllabuschapters { get; }
    
        IObjectSet<syllabussections> syllabussections { get; }
    
        IObjectSet<syllabussubject> syllabussubject { get; }
    
        IObjectSet<syllabustosection> syllabustosection { get; }
    
        IObjectSet<vsclass> vsclass { get; }
    
        IObjectSet<vsections> vsections { get; }
    
        IObjectSet<vsyllabussections> vsyllabussections { get; }

            #endregion

    }
}

