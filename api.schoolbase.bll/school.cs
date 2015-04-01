using api.schoolbase.entities.DBSchool;
using api.schoolbase.entities.DBSyllabus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace api.schoolbase.bll
{
    public class schoolbll
    {

        //获取学校信息
        public static VSchool getSchoolById(string schid) {
            return _DBSchool.VSchool.Select().Where(_DBSchool.VSchool.SchSerID == schid).ToSingleObject<VSchool>();
        }

        //获取学校专业
        public static List<IAM_SchSpecialty> getSpecBySchId(string schid)
        {
            return _DBSchool.IAM_SchSpecialty.Select().Where(_DBSchool.IAM_SchSpecialty.SchSerID == schid).ToList<IAM_SchSpecialty>();
        }

        public static string getSpecName(long specid)
        {
            return _DBSchool.IAM_SchSpecialty.Select(_DBSchool.IAM_SchSpecialty.SpecName)
                .Where(_DBSchool.IAM_SchSpecialty.SERID == specid).ToScalar<string>();
        }

        //验证专业id是否存在
        public static bool yz_specid(string schid, long specid) {
           return _DBSchool.IAM_SchSpecialty.Select(_DBSchool.IAM_SchSpecialty.SERID)
                .Where(_DBSchool.IAM_SchSpecialty.SchSerID == schid
                && _DBSchool.IAM_SchSpecialty.SERID == specid).Length > 0;
        }
        //获取学校年级
        public static List<VGrade> getGrade(string schid, long specid)
        {
            return _DBSchool.VGrade.Select()
                .Where(_DBSchool.VGrade.SchSerID == schid
                && _DBSchool.VGrade.SpecialtyID == specid)
                .ToList<VGrade>();
        }
        public static string getGradeName(long gradeid)
        {
            return _DBSchool.IAM_SchGrade.Select(_DBSchool.IAM_SchGrade.GradeName)
                .Where(_DBSchool.IAM_SchGrade.GRAID == gradeid)
                .ToScalar<string>();
        }

        //验证年级id是否存在
        public static bool yz_gid(string schid, long specid, long gradeid)
        {
            return _DBSchool.VGrade.Select(_DBSchool.VGrade.GRAID)
                 .Where(_DBSchool.VGrade.SchSerID == schid
                 && _DBSchool.VGrade.SpecialtyID == specid
                 && _DBSchool.VGrade.GRAID == gradeid).Length > 0;
        }
        //获取学校学科
        public static List<VGradeSubject> getSubject(string schid, long specid, long gradeid)
        {
            return _DBSchool.VGradeSubject.Select()
                .Where(_DBSchool.VGradeSubject.SchSerID == schid
                && _DBSchool.VGradeSubject.SpecialtyID == specid
                && _DBSchool.VGradeSubject.GRAID == gradeid)
                .ToList<VGradeSubject>();
        }

        public static string getSubjectName(long sid)
        {
            return _DBSchool.VGradeSubject.Select(_DBSchool.VGradeSubject.SubjectName)
                .Where(_DBSchool.VGradeSubject.SubjectID == sid).ToScalar<string>();
        }

        //验证学科id是否存在
        public static bool yz_sid(string schid, long specid, long gradeid, long sid)
        {
            return _DBSchool.VGradeSubject.Select(_DBSchool.VGradeSubject.SubjectID)
                 .Where(_DBSchool.VGradeSubject.SchSerID == schid
                 && _DBSchool.VGradeSubject.SpecialtyID == specid
                 && _DBSchool.VGradeSubject.GRAID == gradeid
                 && _DBSchool.VGradeSubject.SubjectID ==sid).Length > 0;
        }

        //获取学校章节
        public static List<vsclass> getSclass(string schid, long specid, long gid, long sid, long pid)
        {
            return _DBSyllabus.vsclass.Select()
                                .Where(
                                _DBSyllabus.vsclass.SchSerID == schid &&
                                _DBSyllabus.vsclass.PID == pid &&
                                _DBSyllabus.vsclass.SpecialtyID == specid &&
                                _DBSyllabus.vsclass.GRAID == gid &&
                                _DBSyllabus.vsclass.SubjectID == sid &&
                                _DBSyllabus.vsclass.isDeleted == 0)
                                .OrderBy(_DBSyllabus.vsclass.Sorder.Asc)
                                .ToList<vsclass>();
        }

        public static List<vsclass> getSclassByNodePath(string nodepath)
        {
            string[] npatharr = nodepath.TrimEnd('>').Split('>');
              return  _DBSyllabus.vsclass.Select()
                                 .Where(
                                 _DBSyllabus.vsclass.SERID.In(npatharr) &&
                                 _DBSyllabus.vsclass.isDeleted == 0)
                                 .OrderBy(_DBSyllabus.vsclass.Depth.Asc)
                                 .ToList<vsclass>();
        }


        public static IAM_SchTerm getSchTerm(string schid, int year, int term) {
            return _DBSchool.IAM_SchTerm.Select()
                .Where(_DBSchool.IAM_SchTerm.SchSerID == schid
                &&_DBSchool.IAM_SchTerm.SchYear == year
                &&_DBSchool.IAM_SchTerm.SchTerm == term)
                .ToSingleObject<IAM_SchTerm>();
        }
    }
}
