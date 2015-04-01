using api.schoolbase.bll;
using api.schoolbase.Filters;
using api.schoolbase.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.schoolbase.Controllers
{
    /// <summary>
    /// 8.课程
    /// </summary>
    [Auth]
    [RoutePrefix("course")]
    public class CourseController : ApiControllerBase
    {
        /// <summary>
        /// 8.1.获取学科选课状态列表
        /// </summary>
        /// <returns></returns>
        [Route("subject.json")]
        [HttpGet]
        public IHttpActionResult subject(string source, string access_token, int year,int term)
        {
            var userobj = user.getUserByToken(access_token);
            var list = coursebll.getCourseSubject(userobj.uid, userobj.schid, year, term)
                .Select(r => new { 
                    sid=r.SubjectID,
                    sname =r.SubjectName,
                    ismust = r.IsMust,
                    status =r.CourseSerID!=null,
                    courseid=r.CourseSerID
                })
                .ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }

        /// <summary>
        /// 8.2.获取选课列表
        /// </summary>
        /// <returns></returns>
        [Route("course.json")]
        [HttpGet]
        public IHttpActionResult course(string source, string access_token, long sid, int year, int term)
        {
            var userobj = user.getUserByToken(access_token);
            if (term > 3) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            if (!coursebll.isExistSchoolSubject(userobj.schid, sid)) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080201")
                });
            }
            long gid = 0;
            long classserid = 0;
            var student = coursebll.getClassStudent(userobj.uid, userobj.schid, year, term);
            if (student == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080202")
                });
            }
            gid = student.GRAID;
            classserid = student.ClassSerID;

            var list = coursebll.getTeaCourse(userobj.schid, year, term, gid, sid, classserid)
                .Select(r => new { 
                    courseid = r.SerID,
                    coursename = r.SubjectName,
                    teacher = r.TeaName,
                    credit = r.Score,
                    limitnum = r.Max,
                    classhour = r.RequiredTime
                })
                .ToArray();
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Length
                }
            });
        }

        /// <summary>
        /// 8.3.获取课程详细
        /// </summary>
        /// <returns></returns>
        [Route("course/show.json")]
        [HttpGet]
        public IHttpActionResult resource_show(string source, string access_token, long courseid)
        {
            var courseobj = coursebll.getTeaCourse(courseid);
            if (courseobj == null) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080301")
                });
            }
            var cilist = coursebll.getTeaCourseItem(courseid)
                .Select(r => new {
                    loopitemname = Tools.course_LoopItemName(courseobj.LoopType,r.NDay),
                    starttime = r.BeginTime,
                    endtime = r.EndTime,
                    place = r.Address
                }).ToArray();
            return Ok(new{
                    status = 0,
                    msg = "接口请求成功",
                    result = new
                    {
                        code = "0",
                        courseid=courseid,
                        coursename =courseobj.SubjectName,
                        teacher = courseobj.TeaName,
                        credit = courseobj.Score,
                        limitnum = courseobj.Max,
                        classhour = courseobj.RequiredTime,
                        looptypename=Tools.course_LoopTypeName(courseobj.LoopType),
                        timeandplace = cilist
                    }
                });
            
        }

        /// <summary>
        /// 8.4.添加选课
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="name"></param>
        /// <param name="did"></param>
        /// <returns></returns>
        [Route("course/add.json")]
        [HttpPost]
        public IHttpActionResult resource_collect_add(courseAddModel model)
        {
            if (!ModelState.IsValid || model == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010001")
                });
            }
            var userobj = user.getUserByToken(model.access_token);
            if (coursebll.getTeaCourse(model.courseid) == null)
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080401")
                });
            }
            if (coursebll.course_sel_IsRepeat(userobj.uid,model.courseid))
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080402")
                });
            }
            if (coursebll.course_sel_ismax(model.courseid)) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080403")
                });
            }
            if (coursebll.course_sel_insert(userobj.uid, model.courseid))
            {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = new { code = "0" }
                });
            }
            else {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("010002")
                });
            }
        }


        /// <summary>
        /// 8.5.获取一周课程
        /// </summary>
        /// <param name="source"></param>
        /// <param name="access_token"></param>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        [Route("weekcourse.json")]
        [HttpGet]
        public IHttpActionResult weekcourse(string source, string access_token,int week=0)
        {
            var userobj = user.getUserByToken(access_token);
            string schid = userobj.schid;
            long uid = userobj.uid;
            var schoolobj = schoolbll.getSchoolById(schid);
            var schoolterm = schoolbll.getSchTerm(schid, schoolobj.SchYear, schoolobj.SchTerm);
            int schoolweeks = Tools.getDatasWeed(schoolterm.StartTime,schoolterm.EndTime);
            int nowweek = Tools.getDatasWeed(schoolterm.StartTime, DateTime.Now);
            if (nowweek > schoolweeks) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080502")
                });
            }
            int curweek = week <= 0 ? nowweek : week;
            if (week > schoolweeks) {
                return Ok(new
                {
                    status = 0,
                    msg = "接口请求成功",
                    result = GetEMsg("080501")
                });
            }

            var StuSelCourseList = coursebll.course_selCourse(uid, schoolobj.SchYear, schoolobj.SchTerm);
            var StuSelCourseListItem = coursebll.course_selCourseItem(StuSelCourseList.Select(r => r.CourseSerID).ToArray());
            var weeklist = StuSelCourseListItem.Where(r => r.LoopType == 8).ToArray();
            ArrayList al = new ArrayList();
            int i = 1;
            int loop = 8;
            if (curweek == 1) {
                i = (int)schoolterm.StartTime.DayOfWeek;
            }
            if (curweek == schoolweeks)
            {
                loop = (int)schoolterm.EndTime.DayOfWeek+1;
            }
            for (; i < loop; i++)
            {
                var _list =weeklist.Where(r=>r.NDay==i).ToArray();
                foreach (var item in _list)
	            {
                    var _course = StuSelCourseList.Where(r => r.CourseSerID == item.CourseSerID).SingleOrDefault();
                    al.Add(new {
                        courseid = item.CourseSerID,
                        coursename = _course.SubjectName,
                        place =item.Address,
                        weekday =i,
                        starttime =item.BeginTime,
                        endtime = item.EndTime
                    });
	            }
                
            }

               
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    current_week = curweek,
                    list = al,
                    total_number = al.Count
                }
            });
        }

        /// <summary>
        /// 8.6.获取可选学年学期列表
        /// </summary>
        /// <returns></returns>
        [Route("yearsandterms.json")]
        [HttpGet]
        public IHttpActionResult yearsandterms(string source, string access_token,string schid)
        {
            var userobj = user.getUserByToken(access_token);
            var list =coursebll.getYearTerm(schid);
            return Ok(new
            {
                status = 0,
                msg = "接口请求成功",
                result = new
                {
                    code = "0",
                    list = list,
                    total_number = list.Count
                }
            });
        }
        
    }
    
}
