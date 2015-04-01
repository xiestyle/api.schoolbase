using api.schoolbase.bll.model;
using api.schoolbase.entities.DBSchool;
using api.schoolbase.entities.DBSchoolCourse;
using api.schoolbase.entities.DBSyllabus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.schoolbase.bll
{
    public class coursebll
    {
        public static List<VStudentCourseOfSubject> getCourseSubject(long uid,string schid,int year,int term) {
            return _DBSchoolCourse.VStudentCourseOfSubject.Select()
                .Where(_DBSchoolCourse.VStudentCourseOfSubject.StuSerID == uid
                && _DBSchoolCourse.VStudentCourseOfSubject.SchYear == year
                && _DBSchoolCourse.VStudentCourseOfSubject.SchTerm == term)
                .ToList<VStudentCourseOfSubject>();
        }

        public static bool isExistSchoolSubject(string schid,long sid) {
            return _DBSchool.VSubject.Select(_DBSchool.VSubject.SERID)
                .Where(_DBSchool.VSubject.SchSerID == schid
                && _DBSchool.VSubject.SERID == sid).Length > 0;
        }

        public static VClassStudent getClassStudent(long uid, string schid, int year, int term) {
            return _DBSchool.VClassStudent.Select()
                .Where(_DBSchool.VClassStudent.StuSerID == uid
                    && _DBSchool.VClassStudent.SchSerID == schid
                    &&_DBSchool.VClassStudent.SchYear == year
                    &&_DBSchool.VClassStudent.SchTerm ==term)
                    .ToSingleObject<VClassStudent>();
        }
        public static List<VTeaCourse> getTeaCourse(string schid, int year, int term, long gid, long sid, long classserid) {
            return _DBSchoolCourse.VTeaCourse.Select()
                .Where(_DBSchoolCourse.VTeaCourse.SchSerID ==schid
                && _DBSchoolCourse.VTeaCourse.SchYear == year
                && _DBSchoolCourse.VTeaCourse.SchTerm.BitwiseAnd(term) == term
                && _DBSchoolCourse.VTeaCourse.GRAID == gid
                && _DBSchoolCourse.VTeaCourse.SubjectID == sid
                &&(_DBSchoolCourse.VTeaCourse.ClassSerID==classserid||_DBSchoolCourse.VTeaCourse.ClassSerID==null))
                .ToList<VTeaCourse>();
        }

        public static VTeaCourse getTeaCourse(long courseid) {
            return _DBSchoolCourse.VTeaCourse.Select()
                .Where(_DBSchoolCourse.VTeaCourse.SerID == courseid)
                .ToSingleObject<VTeaCourse>();
        }

        public static List<IAM_TeaCourseItem> getTeaCourseItem(long courseid) {
            return _DBSchoolCourse.IAM_TeaCourseItem.Select()
                .Where(_DBSchoolCourse.IAM_TeaCourseItem.CourseSerID == courseid)
                .ToList<IAM_TeaCourseItem>();
        }

        public static List<yeartermModel> getYearTerm(string schid) {
            var objschool = _DBSchool.IAM_SchInfo.Select()
                .Where(_DBSchool.IAM_SchInfo.SchSerID == schid).ToSingleObject<IAM_SchInfo>();
            return _DBSchool.IAM_SchTerm.Select()
                .Where(_DBSchool.IAM_SchTerm.SchSerID == schid).ToList<IAM_SchTerm>()
                .Select(r => new yeartermModel { 
                  year = r.SchYear,
                  term = r.SchTerm,
                  iscurrent = (objschool.SchYear==r.SchYear&&objschool.SchTerm ==r.SchTerm)
                }).ToList();
        }

        public static bool course_sel_IsRepeat(long uid, long courseid)
        {
            return _DBSchoolCourse.IAM_StuSelectedCourse.Select().Where(
                _DBSchoolCourse.IAM_StuSelectedCourse.CourseSerID == courseid &&
                _DBSchoolCourse.IAM_StuSelectedCourse.StuSerID == uid).Length > 0;
        }

        public static bool course_sel_ismax(long courseid) {
            long counter = _DBSchoolCourse.IAM_StuSelectedCourse.Select().
                Where(_DBSchoolCourse.IAM_StuSelectedCourse.CourseSerID == courseid).Length;
            var tmp = _DBSchoolCourse.IAM_TeaCourse.Select(_DBSchoolCourse.IAM_TeaCourse.Max).Identity(courseid).ToSingleObject<IAM_TeaCourse>();
            long Max = 0;
            if (tmp != null) Max = tmp.Max;
            return counter >= Max;
        }

        public static bool course_sel_insert(long uid, long courseid) { 
            return _DBSchoolCourse.IAM_StuSelectedCourse.Insert.
                              AddColumn(_DBSchoolCourse.IAM_StuSelectedCourse.CourseSerID, courseid).
                              AddColumn(_DBSchoolCourse.IAM_StuSelectedCourse.StuSerID, uid).
                              AddColumn(_DBSchoolCourse.IAM_StuSelectedCourse.isRequired, true).Execute() > 0;
        }

        public static List<VStudentSelectedCourse> course_selCourse(long uid,int year,int term) { 
            return _DBSchoolCourse.VStudentSelectedCourse.Select()
                .Where(_DBSchoolCourse.VStudentSelectedCourse.StuSerID ==uid
                && _DBSchoolCourse.VStudentSelectedCourse.SchYear==year
                && _DBSchoolCourse.VStudentSelectedCourse.SchTerm == term).ToList<VStudentSelectedCourse>();
        }
        public static List<VStudentSelectedCourseItem> course_selCourseItem(long[] ids) {
            return _DBSchoolCourse.VStudentSelectedCourseItem.Select()
                .Where(_DBSchoolCourse.VStudentSelectedCourseItem.CourseSerID.In(ids))
                .OrderBy(_DBSchoolCourse.VStudentSelectedCourseItem.BeginTime.Asc)
                .ToList<VStudentSelectedCourseItem>();
        }
    }
}
