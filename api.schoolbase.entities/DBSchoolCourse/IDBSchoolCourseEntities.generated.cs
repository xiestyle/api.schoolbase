// This file is auto-generated, do not modify this file.
using System;
using System.Data.Objects;
using System.Collections.Generic;

namespace api.schoolbase.entities.DBSchoolCourse
{
    public partial interface IDBSchoolCourseEntities : IDisposable
    {
    	bool CanPreCompile { get; }
    	int SaveChanges();
    	void DiscardChanges();
            #region ObjectSet Properties
    
        IObjectSet<IAM_StuSelectedCourse> IAM_StuSelectedCourse { get; }
    
        IObjectSet<IAM_TeaCourse> IAM_TeaCourse { get; }
    
        IObjectSet<IAM_TeaCourseClass> IAM_TeaCourseClass { get; }
    
        IObjectSet<IAM_TeaCourseItem> IAM_TeaCourseItem { get; }
    
        IObjectSet<VClassTeacher> VClassTeacher { get; }
    
        IObjectSet<VCourseStudentArrangement> VCourseStudentArrangement { get; }
    
        IObjectSet<VCourseTeacherArrangement> VCourseTeacherArrangement { get; }
    
        IObjectSet<VStudentClassCourse> VStudentClassCourse { get; }
    
        IObjectSet<VStudentCourse> VStudentCourse { get; }
    
        IObjectSet<VStudentCourseOfSubject> VStudentCourseOfSubject { get; }
    
        IObjectSet<VStudentSelectedCourse> VStudentSelectedCourse { get; }
    
        IObjectSet<VStudentSelectedCourseItem> VStudentSelectedCourseItem { get; }
    
        IObjectSet<VTeaCourse> VTeaCourse { get; }
    
        IObjectSet<VTeaCourseItemClass> VTeaCourseItemClass { get; }

            #endregion

    }
}

