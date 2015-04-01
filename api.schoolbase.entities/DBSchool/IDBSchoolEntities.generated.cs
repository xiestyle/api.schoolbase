// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBSchool
{
    public partial interface IDBSchoolEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<IAM_ClassHistory> IAM_ClassHistory { get; }
    
        IObjectSet<IAM_GradeSubject> IAM_GradeSubject { get; }
    
        IObjectSet<IAM_Group4Campus> IAM_Group4Campus { get; }
    
        IObjectSet<IAM_Group4Grade> IAM_Group4Grade { get; }
    
        IObjectSet<IAM_Group4Specialty> IAM_Group4Specialty { get; }
    
        IObjectSet<IAM_Group4Subject> IAM_Group4Subject { get; }
    
        IObjectSet<IAM_SchCampus> IAM_SchCampus { get; }
    
        IObjectSet<IAM_SchClass> IAM_SchClass { get; }
    
        IObjectSet<IAM_SchDept> IAM_SchDept { get; }
    
        IObjectSet<IAM_SchGrade> IAM_SchGrade { get; }
    
        IObjectSet<IAM_SchInfo> IAM_SchInfo { get; }
    
        IObjectSet<IAM_SchoolServer> IAM_SchoolServer { get; }
    
        IObjectSet<IAM_SchSpecialty> IAM_SchSpecialty { get; }
    
        IObjectSet<IAM_SchSubject> IAM_SchSubject { get; }
    
        IObjectSet<IAM_SchTerm> IAM_SchTerm { get; }
    
        IObjectSet<IAM_StuClass> IAM_StuClass { get; }
    
        IObjectSet<IAM_Student> IAM_Student { get; }
    
        IObjectSet<IAM_Teacher> IAM_Teacher { get; }
    
        IObjectSet<IAM_TeaSubject> IAM_TeaSubject { get; }
    
        IObjectSet<VClass> VClass { get; }
    
        IObjectSet<VClassHistory> VClassHistory { get; }
    
        IObjectSet<VClassOfCurrentTerm> VClassOfCurrentTerm { get; }
    
        IObjectSet<VClassStudent> VClassStudent { get; }
    
        IObjectSet<VGrade> VGrade { get; }
    
        IObjectSet<VGradeSubject> VGradeSubject { get; }
    
        IObjectSet<VGroup4Campus> VGroup4Campus { get; }
    
        IObjectSet<VGroup4CampusUser> VGroup4CampusUser { get; }
    
        IObjectSet<VGroup4Grade> VGroup4Grade { get; }
    
        IObjectSet<VGroup4GradeUser> VGroup4GradeUser { get; }
    
        IObjectSet<VGroup4Specialty> VGroup4Specialty { get; }
    
        IObjectSet<VGroup4SpecialtyUser> VGroup4SpecialtyUser { get; }
    
        IObjectSet<VGroup4Subject> VGroup4Subject { get; }
    
        IObjectSet<VGroup4SubjectUser> VGroup4SubjectUser { get; }
    
        IObjectSet<VSchool> VSchool { get; }
    
        IObjectSet<VStudent> VStudent { get; }
    
        IObjectSet<VStudentSubject> VStudentSubject { get; }
    
        IObjectSet<VSubject> VSubject { get; }
    
        IObjectSet<VTeacher> VTeacher { get; }
    
        IObjectSet<VTeaSubject> VTeaSubject { get; }

            #endregion

    }
}

