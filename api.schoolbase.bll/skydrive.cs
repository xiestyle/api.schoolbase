using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using api.schoolbase.bll.model;
using MyLib.DbAccess.SQL;
using System.Text.RegularExpressions;
using api.schoolbase.entities.DBBase;

namespace api.schoolbase.bll
{
    public class skydrive
    {
        public static tFolder getFolder(string fid) {
            return _DBBase.tFolder.Select().Where(_DBBase.tFolder.folder_uuid == fid).ToSingleObject<tFolder>();
        }

        //获取网盘目录文件
        public static List<skydriveModel> GetFileList(int uid,int type,string folder_uuid =null) {
            List<skydriveModel> list = new List<skydriveModel>();
            folder_uuid = string.IsNullOrEmpty(folder_uuid) ? string.Empty : folder_uuid;

            if (type != 2) {
                WhereClip where1 = _DBBase.tFolder.folder_owner == uid;
            if (!string.IsNullOrEmpty(folder_uuid))
            {
                where1.And(_DBBase.tFolder.parent_uuid == folder_uuid);
            }
            else {
                where1.And(_DBBase.tFolder.parent_uuid == "" || _DBBase.tFolder.parent_uuid == null);
            }
            list = _DBBase.tFolder.Select()
                .Where(where1)
                .OrderBy(_DBBase.tFolder.create_time.Desc)
                .ToList<tFolder>().Select(r => new skydriveModel
                {
                    id = r.folder_uuid,
                    name = r.folder_name,
                    filesize = 0,
                    dtime = ((DateTime)r.create_time).ToString("yyyy-MM-dd HH:mm:ss"),
                    type = 1
                }).ToList();
            }
            if (type == 1) {
                return list;
            }
            WhereClip where2 = _DBBase.tFile.file_owner == uid && _DBBase.tFile.valid == true;
            if (!string.IsNullOrEmpty(folder_uuid))
            {
                where2.And(_DBBase.tFile.folder_uuid == folder_uuid);
            }
            else {
                where2.And(_DBBase.tFile.folder_uuid == "" || _DBBase.tFile.folder_uuid == null);
            }
            var listfiles = _DBBase.tFile.Select()
                .Where(where2)
                .OrderBy(_DBBase.tFile.create_time.Desc)
                .ToList<tFile>().Select(r => new skydriveModel
                {
                    id = r.file_uuid,
                    name = r.file_name,
                    filesize = (long)r.file_size,
                    dtime = ((DateTime)r.create_time).ToString("yyyy-MM-dd HH:mm:ss"),
                    type = 2
                }).ToList();
            if (type == 2) {
                return listfiles;
            }
            list.AddRange(listfiles);
            return list;
        }

        //新建网盘目录
        public static KeyValuePair<int,string> addFolder(int uid,string name ,string folder_uuid =null) {
            int code=0;
            string message="创建成功";
            folder_uuid = string.IsNullOrEmpty(folder_uuid) ? string.Empty : folder_uuid;
            if (!string.IsNullOrEmpty(folder_uuid) //非空的目录id不存在
                && _DBBase.tFolder.Select()
                .Where(_DBBase.tFolder.folder_owner == uid
                && _DBBase.tFolder.folder_uuid == folder_uuid).Length == 0) {
                code = 3;
                message = "目录id不存在";
            }
            else if (_DBBase.tFolder.Select()
                .Where(_DBBase.tFolder.folder_owner == uid
                && _DBBase.tFolder.parent_uuid == folder_uuid
                && _DBBase.tFolder.folder_name == name).Length > 0)
            {
                code = 1;
                message = "文件目录名称已存在";
            }
            else {

                code = _DBBase.tFolder.Insert.Set(
                     new tFolder
                     {
                         folder_uuid = Guid.NewGuid().ToString(),
                         parent_uuid = folder_uuid,
                         folder_name = name,
                         folder_type = 100,
                         folder_owner = uid,
                         folder_creator = uid,
                         create_time = DateTime.Now,
                         modify_time = DateTime.Now,
                         valid = true
                     }).Execute() > 0 ? 0 : 2;
                if (code == 2) {
                    message = "创建失败";
                }
            }
            
            return new KeyValuePair<int,string>(code,message);
        }

        //修改网盘名称
        public static KeyValuePair<int,string> editFolder(int uid, string name, string folder_uuid)
        {
            int code = 0;
            string message = "修改成功";
            var folderobj = _DBBase.tFolder.Select()
                .Where(_DBBase.tFolder.folder_owner == uid
                && _DBBase.tFolder.folder_uuid == folder_uuid).ToSingleObject<tFolder>();

            if (folderobj == null) {//如果目录不存在
                code = 1;
                message = "修改失败[目录不存在]";
            }else if(folderobj.folder_name==name){//如果目录名称没变化
                code = 0;
            }
            else {
                if (_DBBase.tFolder.Select()
                    .Where(_DBBase.tFolder.folder_owner == uid
                    && _DBBase.tFolder.parent_uuid == folderobj.parent_uuid
                    && _DBBase.tFolder.folder_name == name).Length > 0)
                {//修改的目录名称已存在
                    code = 2;
                    message = "文件目录名称已存在";
                }
                else
                {

                    code = _DBBase.tFolder.Update
                        .AddColumn(_DBBase.tFolder.folder_name, name)
                        .AddColumn(_DBBase.tFolder.modify_time, DateTime.Now)
                        .Where(_DBBase.tFolder.folder_uuid == folder_uuid)
                        .Execute() > 0 ? 0 : 3;

                    if (code == 3) { 
                        message="修改失败";
                    }
                }
            }
            return new KeyValuePair<int,string>(code,message);
        }

        //删除网盘目录
        public static KeyValuePair<int,string> delFolder(int uid, string folder_uuid)
        {
            int code = 0;
            string message = "删除成功";
            if (_DBBase.tFolder.Select()
                .Where(_DBBase.tFolder.folder_owner == uid
                && _DBBase.tFolder.folder_uuid == folder_uuid).Length > 0)
            {
                try
                {
                    _DBBase.tFolder.DbAccess.StoredProcedure("Porc_skydrive_directory_destroy", new string[] { "did" }, new object[] { folder_uuid }).ExecuteNonQuery();
                    
                }
                catch (Exception e) {
                    code = 2;
                    message = "删除失败";
                }
            }
            else
            {
                code = 1;
                message = "参数错误[文件夹不存在或没有权限]";
                
            }

            return new KeyValuePair<int,string>(code,message);
        }
        //文件夹是否存在
        public static bool isExitsFolder(string fid) {
            return _DBBase.tFolder.Select(_DBBase.tFolder.folder_id).Where(_DBBase.tFolder.folder_uuid == fid).Length > 0;
        }
        //上传到网盘


        //文件重命名
        public static KeyValuePair<int, string> renameFile(int uid, string file_uuid,string filename)
        {
            int code = 0;
            string message = "修改成功";
            var objfile = _DBBase.tFile.Select().Where(_DBBase.tFile.file_uuid == file_uuid && _DBBase.tFile.valid == true).ToSingleObject<tFile>();
            if (objfile==null)
            {
                code = 1;
                message = "参数错误[文件id不存在]";
            }
            else if (objfile.file_name == filename) { 
                
            }
            else if (_DBBase.tFile.Select().Where(_DBBase.tFile.folder_uuid == objfile.folder_uuid && _DBBase.tFile.file_name == filename).Length > 0)
            {
                code = 2;
                message = "参数错误[文件名已存在]";
            }
            else
            {
                code = _DBBase.tFile.Update
                    .AddColumn(_DBBase.tFile.file_name, filename)
                    .Where(_DBBase.tFile.file_uuid == file_uuid
                    && _DBBase.tFile.file_owner == uid)
                    .Execute() > 0 ? 0 : 3;
                if (code == 3)
                {
                    message = "修改失败";
                }
            }
            return new KeyValuePair<int, string>(code, message);
        }

        //删除网盘文件
        public static KeyValuePair<int,string> delFile(int uid, string file_uuid)
        {
            int code = _DBBase.tFile.Update
                .AddColumn(_DBBase.tFile.valid, false)
                .Where(_DBBase.tFile.file_uuid.In(file_uuid.Split(','))
                && _DBBase.tFile.file_owner == uid)
                .Execute() > 0 ? 0 : 1;
            return new KeyValuePair<int,string>(code,"");
        }

        //查看一个资源文件
        public static fileModel showFile(int uid, string file_uuid)
        {
            var fileobj = _DBBase.tFile.Select()
                .Where(_DBBase.tFile.file_uuid == file_uuid
                && _DBBase.tFile.file_owner == uid).ToSingleObject<tFile>();
            if (fileobj == null)
            {
                return null;
            }
            else {
                return new fileModel { 
                    id =fileobj.file_uuid,
                    title = fileobj.file_name,
                    filetype = fileobj.file_type,
                    des = fileobj.file_descp,
                    filesize = (long)fileobj.file_size,
                    dtime = fileobj.create_time.ToString("yyyy-MM-dd HH:mm:ss"),
                    filepath =fileobj.file_path
                };
            }
        }

        //分享到校本资源库

        //分享到资源中心

        public static string FilePath(string path,string schid)
        {
            string retstring = "";
            var hostobj = _DBBase.Base_Config.Select(_DBBase.Base_Config.HostAndPort).Where(_DBBase.Base_Config.DepID == schid).Top(1).ToSingleObject<Base_Config>();
            string host = hostobj == null ? "" : hostobj.HostAndPort;
            //host.IndexOf("{#server_image#}")
            if (host!=""&& path!=null)
            {

                if (Regex.IsMatch(path, "{#server_image#}"))
                {
                    retstring = path.Replace("{#server_image#}", "http://" + host + "/uploadfiles/image");
                }
                if (Regex.IsMatch(path, "{#server_video#}"))
                {
                    retstring = path.Replace("{#server_video#}", "http://" + host + "/uploadfiles/video");
                }
                if (Regex.IsMatch(path, "{#server_html#}"))
                {
                    retstring = path.Replace("{#server_html#}", "http://" + host + "/uploadfiles/html");
                }
                if (Regex.IsMatch(path, "{#server_file#}"))
                {
                    retstring = path.Replace("{#server_file#}", "http://" + host + "/uploadfiles/file");
                }
                
            }
            else {
                retstring = path;
            }
            return retstring;
        }
    }
}
