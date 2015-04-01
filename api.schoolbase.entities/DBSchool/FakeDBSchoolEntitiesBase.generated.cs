// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;
using MyLib.DAO;

namespace api.schoolbase.entities.DBSchool
{
    public  abstract class FakeDBSchoolEntitiesBase : IDBSchoolEntities
    {
    	public virtual bool CanPreCompile
    	{
    		get { return false; }
    	}
                #region ObjectSet Properties
    
        public IObjectSet<IAM_ClassHistory> IAM_ClassHistory { 
    	get { return __iAM_ClassHistory ?? (__iAM_ClassHistory = new FakeObjectSet<IAM_ClassHistory>()); }
    	set { __iAM_ClassHistory = value; }
    	}
    	private IObjectSet<IAM_ClassHistory> __iAM_ClassHistory;
    
        public IObjectSet<IAM_GradeSubject> IAM_GradeSubject { 
    	get { return __iAM_GradeSubject ?? (__iAM_GradeSubject = new FakeObjectSet<IAM_GradeSubject>()); }
    	set { __iAM_GradeSubject = value; }
    	}
    	private IObjectSet<IAM_GradeSubject> __iAM_GradeSubject;
    
        public IObjectSet<IAM_Group4Campus> IAM_Group4Campus { 
    	get { return __iAM_Group4Campus ?? (__iAM_Group4Campus = new FakeObjectSet<IAM_Group4Campus>()); }
    	set { __iAM_Group4Campus = value; }
    	}
    	private IObjectSet<IAM_Group4Campus> __iAM_Group4Campus;
    
        public IObjectSet<IAM_Group4Grade> IAM_Group4Grade { 
    	get { return __iAM_Group4Grade ?? (__iAM_Group4Grade = new FakeObjectSet<IAM_Group4Grade>()); }
    	set { __iAM_Group4Grade = value; }
    	}
    	private IObjectSet<IAM_Group4Grade> __iAM_Group4Grade;
    
        public IObjectSet<IAM_Group4Specialty> IAM_Group4Specialty { 
    	get { return __iAM_Group4Specialty ?? (__iAM_Group4Specialty = new FakeObjectSet<IAM_Group4Specialty>()); }
    	set { __iAM_Group4Specialty = value; }
    	}
    	private IObjectSet<IAM_Group4Specialty> __iAM_Group4Specialty;
    
        public IObjectSet<IAM_Group4Subject> IAM_Group4Subject { 
    	get { return __iAM_Group4Subject ?? (__iAM_Group4Subject = new FakeObjectSet<IAM_Group4Subject>()); }
    	set { __iAM_Group4Subject = value; }
    	}
    	private IObjectSet<IAM_Group4Subject> __iAM_Group4Subject;
    
        public IObjectSet<IAM_SchCampus> IAM_SchCampus { 
    	get { return __iAM_SchCampus ?? (__iAM_SchCampus = new FakeObjectSet<IAM_SchCampus>()); }
    	set { __iAM_SchCampus = value; }
    	}
    	private IObjectSet<IAM_SchCampus> __iAM_SchCampus;
    
        public IObjectSet<IAM_SchClass> IAM_SchClass { 
    	get { return __iAM_SchClass ?? (__iAM_SchClass = new FakeObjectSet<IAM_SchClass>()); }
    	set { __iAM_SchClass = value; }
    	}
    	private IObjectSet<IAM_SchClass> __iAM_SchClass;
    
        public IObjectSet<IAM_SchDept> IAM_SchDept { 
    	get { return __iAM_SchDept ?? (__iAM_SchDept = new FakeObjectSet<IAM_SchDept>()); }
    	set { __iAM_SchDept = value; }
    	}
    	private IObjectSet<IAM_SchDept> __iAM_SchDept;
    
        public IObjectSet<IAM_SchGrade> IAM_SchGrade { 
    	get { return __iAM_SchGrade ?? (__iAM_SchGrade = new FakeObjectSet<IAM_SchGrade>()); }
    	set { __iAM_SchGrade = value; }
    	}
    	private IObjectSet<IAM_SchGrade> __iAM_SchGrade;
    
        public IObjectSet<IAM_SchInfo> IAM_SchInfo { 
    	get { return __iAM_SchInfo ?? (__iAM_SchInfo = new FakeObjectSet<IAM_SchInfo>()); }
    	set { __iAM_SchInfo = value; }
    	}
    	private IObjectSet<IAM_SchInfo> __iAM_SchInfo;
    
        public IObjectSet<IAM_SchoolServer> IAM_SchoolServer { 
    	get { return __iAM_SchoolServer ?? (__iAM_SchoolServer = new FakeObjectSet<IAM_SchoolServer>()); }
    	set { __iAM_SchoolServer = value; }
    	}
    	private IObjectSet<IAM_SchoolServer> __iAM_SchoolServer;
    
        public IObjectSet<IAM_SchSpecialty> IAM_SchSpecialty { 
    	get { return __iAM_SchSpecialty ?? (__iAM_SchSpecialty = new FakeObjectSet<IAM_SchSpecialty>()); }
    	set { __iAM_SchSpecialty = value; }
    	}
    	private IObjectSet<IAM_SchSpecialty> __iAM_SchSpecialty;
    
        public IObjectSet<IAM_SchSubject> IAM_SchSubject { 
    	get { return __iAM_SchSubject ?? (__iAM_SchSubject = new FakeObjectSet<IAM_SchSubject>()); }
    	set { __iAM_SchSubject = value; }
    	}
    	private IObjectSet<IAM_SchSubject> __iAM_SchSubject;
    
        public IObjectSet<IAM_SchTerm> IAM_SchTerm { 
    	get { return __iAM_SchTerm ?? (__iAM_SchTerm = new FakeObjectSet<IAM_SchTerm>()); }
    	set { __iAM_SchTerm = value; }
    	}
    	private IObjectSet<IAM_SchTerm> __iAM_SchTerm;
    
        public IObjectSet<IAM_StuClass> IAM_StuClass { 
    	get { return __iAM_StuClass ?? (__iAM_StuClass = new FakeObjectSet<IAM_StuClass>()); }
    	set { __iAM_StuClass = value; }
    	}
    	private IObjectSet<IAM_StuClass> __iAM_StuClass;
    
        public IObjectSet<IAM_Student> IAM_Student { 
    	get { return __iAM_Student ?? (__iAM_Student = new FakeObjectSet<IAM_Student>()); }
    	set { __iAM_Student = value; }
    	}
    	private IObjectSet<IAM_Student> __iAM_Student;
    
        public IObjectSet<IAM_Teacher> IAM_Teacher { 
    	get { return __iAM_Teacher ?? (__iAM_Teacher = new FakeObjectSet<IAM_Teacher>()); }
    	set { __iAM_Teacher = value; }
    	}
    	private IObjectSet<IAM_Teacher> __iAM_Teacher;
    
        public IObjectSet<IAM_TeaSubject> IAM_TeaSubject { 
    	get { return __iAM_TeaSubject ?? (__iAM_TeaSubject = new FakeObjectSet<IAM_TeaSubject>()); }
    	set { __iAM_TeaSubject = value; }
    	}
    	private IObjectSet<IAM_TeaSubject> __iAM_TeaSubject;
    
        public IObjectSet<VClass> VClass { 
    	get { return __vClass ?? (__vClass = new FakeObjectSet<VClass>()); }
    	set { __vClass = value; }
    	}
    	private IObjectSet<VClass> __vClass;
    
        public IObjectSet<VClassHistory> VClassHistory { 
    	get { return __vClassHistory ?? (__vClassHistory = new FakeObjectSet<VClassHistory>()); }
    	set { __vClassHistory = value; }
    	}
    	private IObjectSet<VClassHistory> __vClassHistory;
    
        public IObjectSet<VClassOfCurrentTerm> VClassOfCurrentTerm { 
    	get { return __vClassOfCurrentTerm ?? (__vClassOfCurrentTerm = new FakeObjectSet<VClassOfCurrentTerm>()); }
    	set { __vClassOfCurrentTerm = value; }
    	}
    	private IObjectSet<VClassOfCurrentTerm> __vClassOfCurrentTerm;
    
        public IObjectSet<VClassStudent> VClassStudent { 
    	get { return __vClassStudent ?? (__vClassStudent = new FakeObjectSet<VClassStudent>()); }
    	set { __vClassStudent = value; }
    	}
    	private IObjectSet<VClassStudent> __vClassStudent;
    
        public IObjectSet<VGrade> VGrade { 
    	get { return __vGrade ?? (__vGrade = new FakeObjectSet<VGrade>()); }
    	set { __vGrade = value; }
    	}
    	private IObjectSet<VGrade> __vGrade;
    
        public IObjectSet<VGradeSubject> VGradeSubject { 
    	get { return __vGradeSubject ?? (__vGradeSubject = new FakeObjectSet<VGradeSubject>()); }
    	set { __vGradeSubject = value; }
    	}
    	private IObjectSet<VGradeSubject> __vGradeSubject;
    
        public IObjectSet<VGroup4Campus> VGroup4Campus { 
    	get { return __vGroup4Campus ?? (__vGroup4Campus = new FakeObjectSet<VGroup4Campus>()); }
    	set { __vGroup4Campus = value; }
    	}
    	private IObjectSet<VGroup4Campus> __vGroup4Campus;
    
        public IObjectSet<VGroup4CampusUser> VGroup4CampusUser { 
    	get { return __vGroup4CampusUser ?? (__vGroup4CampusUser = new FakeObjectSet<VGroup4CampusUser>()); }
    	set { __vGroup4CampusUser = value; }
    	}
    	private IObjectSet<VGroup4CampusUser> __vGroup4CampusUser;
    
        public IObjectSet<VGroup4Grade> VGroup4Grade { 
    	get { return __vGroup4Grade ?? (__vGroup4Grade = new FakeObjectSet<VGroup4Grade>()); }
    	set { __vGroup4Grade = value; }
    	}
    	private IObjectSet<VGroup4Grade> __vGroup4Grade;
    
        public IObjectSet<VGroup4GradeUser> VGroup4GradeUser { 
    	get { return __vGroup4GradeUser ?? (__vGroup4GradeUser = new FakeObjectSet<VGroup4GradeUser>()); }
    	set { __vGroup4GradeUser = value; }
    	}
    	private IObjectSet<VGroup4GradeUser> __vGroup4GradeUser;
    
        public IObjectSet<VGroup4Specialty> VGroup4Specialty { 
    	get { return __vGroup4Specialty ?? (__vGroup4Specialty = new FakeObjectSet<VGroup4Specialty>()); }
    	set { __vGroup4Specialty = value; }
    	}
    	private IObjectSet<VGroup4Specialty> __vGroup4Specialty;
    
        public IObjectSet<VGroup4SpecialtyUser> VGroup4SpecialtyUser { 
    	get { return __vGroup4SpecialtyUser ?? (__vGroup4SpecialtyUser = new FakeObjectSet<VGroup4SpecialtyUser>()); }
    	set { __vGroup4SpecialtyUser = value; }
    	}
    	private IObjectSet<VGroup4SpecialtyUser> __vGroup4SpecialtyUser;
    
        public IObjectSet<VGroup4Subject> VGroup4Subject { 
    	get { return __vGroup4Subject ?? (__vGroup4Subject = new FakeObjectSet<VGroup4Subject>()); }
    	set { __vGroup4Subject = value; }
    	}
    	private IObjectSet<VGroup4Subject> __vGroup4Subject;
    
        public IObjectSet<VGroup4SubjectUser> VGroup4SubjectUser { 
    	get { return __vGroup4SubjectUser ?? (__vGroup4SubjectUser = new FakeObjectSet<VGroup4SubjectUser>()); }
    	set { __vGroup4SubjectUser = value; }
    	}
    	private IObjectSet<VGroup4SubjectUser> __vGroup4SubjectUser;
    
        public IObjectSet<VSchool> VSchool { 
    	get { return __vSchool ?? (__vSchool = new FakeObjectSet<VSchool>()); }
    	set { __vSchool = value; }
    	}
    	private IObjectSet<VSchool> __vSchool;
    
        public IObjectSet<VStudent> VStudent { 
    	get { return __vStudent ?? (__vStudent = new FakeObjectSet<VStudent>()); }
    	set { __vStudent = value; }
    	}
    	private IObjectSet<VStudent> __vStudent;
    
        public IObjectSet<VStudentSubject> VStudentSubject { 
    	get { return __vStudentSubject ?? (__vStudentSubject = new FakeObjectSet<VStudentSubject>()); }
    	set { __vStudentSubject = value; }
    	}
    	private IObjectSet<VStudentSubject> __vStudentSubject;
    
        public IObjectSet<VSubject> VSubject { 
    	get { return __vSubject ?? (__vSubject = new FakeObjectSet<VSubject>()); }
    	set { __vSubject = value; }
    	}
    	private IObjectSet<VSubject> __vSubject;
    
        public IObjectSet<VTeacher> VTeacher { 
    	get { return __vTeacher ?? (__vTeacher = new FakeObjectSet<VTeacher>()); }
    	set { __vTeacher = value; }
    	}
    	private IObjectSet<VTeacher> __vTeacher;
    
        public IObjectSet<VTeaSubject> VTeaSubject { 
    	get { return __vTeaSubject ?? (__vTeaSubject = new FakeObjectSet<VTeaSubject>()); }
    	set { __vTeaSubject = value; }
    	}
    	private IObjectSet<VTeaSubject> __vTeaSubject;

                #endregion

    
    	public abstract int SaveChanges();
    	public abstract void DiscardChanges();
    	
    	public virtual void Dispose()
    	{
    	}
    }
}

