using MyLib.DbAccess.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using api.schoolbase.entities.DBZiyuan;
using api.schoolbase.entities.DBSyllabus;

namespace api.schoolbase.bll
{
    public class resource_school
    {
        //获取学校资源
        public static List<View_ZYKResource> getlist(string schid, long z, long n, long x, long s, string key, int page, int count, out long total_number)
        {
            total_number = 0;

            long t = 0;
            long _specid = z;
            long _gradeid = n;
            long _subjectid = x;
            long _chapterid = s;

            WhereClip where = _DBZiyuan.View_ZYKResource.SchSerID == schid
                    && _DBZiyuan.View_ZYKResource.isPassed == true
                    &&_DBZiyuan.View_ZYKResource.isDeleted == false;
          
            if (_specid != 0)
            {
                where.And(_DBZiyuan.View_ZYKResource.SpecialtyID == _specid);
            }
            if (_gradeid != 0)
            {
                where.And(_DBZiyuan.View_ZYKResource.GRAID == _gradeid);
            }
            if (_subjectid != 0)
            {
                where.And(_DBZiyuan.View_ZYKResource.SubjectID == _subjectid);
            }
            if (!string.IsNullOrEmpty(key))
            {
                where.And(_DBZiyuan.View_ZYKResource.ResTitle.Like("%" + key + "%"));
            }


            //获取 章节列表
            var sclassobj =_DBSyllabus.sclass.Select().Where(_DBSyllabus.sclass.SERID == _chapterid).ToSingleObject<sclass>();
            
            if (sclassobj!=null)
            {
                where = where.And(_DBZiyuan.View_ZYKResource.NodePath.Like(sclassobj.NodePath + "%"));
            }

            long t_PageCount = 0;

            return _DBZiyuan.View_ZYKResource.Select()
                    .Where(where)
                    .OrderBy(_DBZiyuan.View_ZYKResource.Dtime.Desc)
                    .Page(count, page, out total_number, out t_PageCount)
                .ToList<View_ZYKResource>();
        }
    
        //获取我的收藏列表
        public static List<View_ZYKResource> getmycollectlist(string schid, long uid, int page, int count, out long total_number)
        {
            total_number = 0;
              
                long t_PageCount = 0;

                return _DBZiyuan.View_ZYKResource.Select(
                        _DBZiyuan.View_ZYKResource.SERID,
                        _DBZiyuan.View_ZYKResource.ResTitle,
                        _DBZiyuan.View_ZYKResource.SpecialtyID,
                        _DBZiyuan.View_ZYKResource.GRAID,
                        _DBZiyuan.View_ZYKResource.SubjectID,
                        _DBZiyuan.View_ZYKResource.SclassID,
                        _DBZiyuan.View_ZYKResource.NodePath,
                        _DBZiyuan.View_ZYKResource.FileType,
                        _DBZiyuan.View_ZYKResource.FileSize,
                        _DBZiyuan.View_ZYKResource.Dtime,
                        _DBZiyuan.View_ZYKResource.UID,
                        _DBZiyuan.View_ZYKResource.UserName,
                        _DBZiyuan.View_ZYKResource.NumScore,
                        _DBZiyuan.View_ZYKResource.TotalScore
                    )
                    .Where(_DBZiyuan.ZYK_ResourceFavorite.UID == uid
                    && _DBZiyuan.View_ZYKResource.SchSerID == schid
                    && _DBZiyuan.View_ZYKResource.isDeleted == false
                    )
                    .Join(_DBZiyuan.ZYK_ResourceFavorite,_DBZiyuan.ZYK_ResourceFavorite.ResID==_DBZiyuan.View_ZYKResource.SERID)
                    .OrderBy(_DBZiyuan.View_ZYKResource.Dtime.Desc)
                    .Page(count, page, out total_number, out t_PageCount)
                    .ToList<View_ZYKResource>();
        }

        //获取一个资源
        public static View_ZYKResource getResItem(long rid)
        {
            return _DBZiyuan.View_ZYKResource.Select()
                .Where(_DBZiyuan.View_ZYKResource.SERID == rid).ToSingleObject<View_ZYKResource>();
        }

        public static ZYK_ResourceFile getFileInfo(string fileid)
        {
            return _DBZiyuan.ZYK_ResourceFile.Select()
                .Where(_DBZiyuan.ZYK_ResourceFile.FileID == fileid).ToSingleObject<ZYK_ResourceFile>();
        }

        //是否收藏
        public static bool isCollect(long rid, long uid) {
            return _DBZiyuan.ZYK_ResourceFavorite.Select(_DBZiyuan.ZYK_ResourceFavorite.SERID)
                .Where(_DBZiyuan.ZYK_ResourceFavorite.ResID == rid
                && _DBZiyuan.ZYK_ResourceFavorite.UID == uid).Length > 0;
        }

        //添加收藏
        public static int collect_add(long rid,long uid) {
            if (getResItem(rid) == null) {
                return 1;
            }
            if (isCollect(rid, uid)) {
                return 2;
            }
            return _DBZiyuan.ZYK_ResourceFavorite.Insert
                .Set(new ZYK_ResourceFavorite { 
                    ResID=rid,
                    FClasID=0,
                    UID = uid,
                    Dtime = DateTime.Now,
                    ZT=0
                })
                .Execute() > 0?0:3;
        }
        //取消收藏
        public static int collect_cancel(long rid, long uid)
        {
            if (getResItem(rid) == null)
            {
                return 1;
            }
            if (!isCollect(rid, uid))
            {
                return 2;
            }
            return _DBZiyuan.ZYK_ResourceFavorite.Delete
                .Where(_DBZiyuan.ZYK_ResourceFavorite.UID==uid
                && _DBZiyuan.ZYK_ResourceFavorite.ResID==rid)
                .Execute() > 0 ? 0 : 3;
        }

        //获取资源评论列表
        public static List<View_ResRemark> getcommentlist(long rid, int page, int count, out long total_number)
        {
            total_number = 0;
            long t_PageCount = 0;
            return _DBZiyuan.View_ResRemark.Select()
                .Where(_DBZiyuan.View_ResRemark.ResourceID == rid)
                .OrderBy(_DBZiyuan.View_ResRemark.DateAndTime.Desc)
                .Page(count, page, out total_number, out t_PageCount)
                .ToList<View_ResRemark>();
        }

        public static bool iscomment(long rid, long uid) {
            return _DBZiyuan.ZYK_PingjiaRemark.Select(_DBZiyuan.ZYK_PingjiaRemark.SerID)
                .Where(_DBZiyuan.ZYK_PingjiaRemark.ResourceID == rid
                && _DBZiyuan.ZYK_PingjiaRemark.UID == uid).Length > 0;
        }

        public static int comment_add(long rid, long uid,string content,int score)
        {
            if (getResItem(rid) == null)
            {
                return 1;
            }
            if (iscomment(rid, uid))
            {
                return 2;
            }
            return _DBZiyuan.ZYK_PingjiaRemark.Insert
                .Set(new ZYK_PingjiaRemark
                {
                    ResourceID = rid,
                    remarkcontent = content,
                    DateAndTime =DateTime.Now,
                    UID = (int)uid,
                    Score = score
                })
                .Execute() > 0 ? 0 : 3;
        }
    }
}
