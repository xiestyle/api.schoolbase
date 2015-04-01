// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSchoolCourse
{
    public  abstract class FakeDBSchoolCourseEntitiesBase : IDBSchoolCourseEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<IAM_StuSelectedCourse> IAM_StuSelectedCourse { 
    	get { return __iAM_StuSelectedCourse ?? (__iAM_StuSelectedCourse = new FakeObjectSet<IAM_StuSelectedCourse>()); }
    	set { __iAM_StuSelectedCourse = value; }
    	}
    	private IObjectSet<IAM_StuSelectedCourse> __iAM_StuSelectedCourse;
    
        public IObjectSet<IAM_TeaCourse> IAM_TeaCourse { 
    	get { return __iAM_TeaCourse ?? (__iAM_TeaCourse = new FakeObjectSet<IAM_TeaCourse>()); }
    	set { __iAM_TeaCourse = value; }
    	}
    	private IObjectSet<IAM_TeaCourse> __iAM_TeaCourse;
    
        public IObjectSet<IAM_TeaCourseClass> IAM_TeaCourseClass { 
    	get { return __iAM_TeaCourseClass ?? (__iAM_TeaCourseClass = new FakeObjectSet<IAM_TeaCourseClass>()); }
    	set { __iAM_TeaCourseClass = value; }
    	}
    	private IObjectSet<IAM_TeaCourseClass> __iAM_TeaCourseClass;
    
        public IObjectSet<IAM_TeaCourseItem> IAM_TeaCourseItem { 
    	get { return __iAM_TeaCourseItem ?? (__iAM_TeaCourseItem = new FakeObjectSet<IAM_TeaCourseItem>()); }
    	set { __iAM_TeaCourseItem = value; }
    	}
    	private IObjectSet<IAM_TeaCourseItem> __iAM_TeaCourseItem;
    
        public IObjectSet<VClassTeacher> VClassTeacher { 
    	get { return __vClassTeacher ?? (__vClassTeacher = new FakeObjectSet<VClassTeacher>()); }
    	set { __vClassTeacher = value; }
    	}
    	private IObjectSet<VClassTeacher> __vClassTeacher;
    
        public IObjectSet<VCourseStudentArrangement> VCourseStudentArrangement { 
    	get { return __vCourseStudentArrangement ?? (__vCourseStudentArrangement = new FakeObjectSet<VCourseStudentArrangement>()); }
    	set { __vCourseStudentArrangement = value; }
    	}
    	private IObjectSet<VCourseStudentArrangement> __vCourseStudentArrangement;
    
        public IObjectSet<VCourseTeacherArrangement> VCourseTeacherArrangement { 
    	get { return __vCourseTeacherArrangement ?? (__vCourseTeacherArrangement = new FakeObjectSet<VCourseTeacherArrangement>()); }
    	set { __vCourseTeacherArrangement = value; }
    	}
    	private IObjectSet<VCourseTeacherArrangement> __vCourseTeacherArrangement;
    
        public IObjectSet<VStudentClassCourse> VStudentClassCourse { 
    	get { return __vStudentClassCourse ?? (__vStudentClassCourse = new FakeObjectSet<VStudentClassCourse>()); }
    	set { __vStudentClassCourse = value; }
    	}
    	private IObjectSet<VStudentClassCourse> __vStudentClassCourse;
    
        public IObjectSet<VStudentCourse> VStudentCourse { 
    	get { return __vStudentCourse ?? (__vStudentCourse = new FakeObjectSet<VStudentCourse>()); }
    	set { __vStudentCourse = value; }
    	}
    	private IObjectSet<VStudentCourse> __vStudentCourse;
    
        public IObjectSet<VStudentCourseOfSubject> VStudentCourseOfSubject { 
    	get { return __vStudentCourseOfSubject ?? (__vStudentCourseOfSubject = new FakeObjectSet<VStudentCourseOfSubject>()); }
    	set { __vStudentCourseOfSubject = value; }
    	}
    	private IObjectSet<VStudentCourseOfSubject> __vStudentCourseOfSubject;
    
        public IObjectSet<VStudentSelectedCourse> VStudentSelectedCourse { 
    	get { return __vStudentSelectedCourse ?? (__vStudentSelectedCourse = new FakeObjectSet<VStudentSelectedCourse>()); }
    	set { __vStudentSelectedCourse = value; }
    	}
    	private IObjectSet<VStudentSelectedCourse> __vStudentSelectedCourse;
    
        public IObjectSet<VStudentSelectedCourseItem> VStudentSelectedCourseItem { 
    	get { return __vStudentSelectedCourseItem ?? (__vStudentSelectedCourseItem = new FakeObjectSet<VStudentSelectedCourseItem>()); }
    	set { __vStudentSelectedCourseItem = value; }
    	}
    	private IObjectSet<VStudentSelectedCourseItem> __vStudentSelectedCourseItem;
    
        public IObjectSet<VTeaCourse> VTeaCourse { 
    	get { return __vTeaCourse ?? (__vTeaCourse = new FakeObjectSet<VTeaCourse>()); }
    	set { __vTeaCourse = value; }
    	}
    	private IObjectSet<VTeaCourse> __vTeaCourse;
    
        public IObjectSet<VTeaCourseItemClass> VTeaCourseItemClass { 
    	get { return __vTeaCourseItemClass ?? (__vTeaCourseItemClass = new FakeObjectSet<VTeaCourseItemClass>()); }
    	set { __vTeaCourseItemClass = value; }
    	}
    	private IObjectSet<VTeaCourseItemClass> __vTeaCourseItemClass;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

