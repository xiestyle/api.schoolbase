using api.schoolbase.Filters;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace api.schoolbase.Controllers
{
    [Base]
    public abstract class ApiControllerBase : ApiController
    {
        public Dictionary<string, KeyValuePair<string, string>> Ecode =
            new Dictionary<string, KeyValuePair<string, string>>()
            {
                {"010001",new KeyValuePair<string, string>("parameter validation failed", "参数验证失败")},
                {"010002",new KeyValuePair<string, string>("The data operation failed", "数据操作失败")},

                {"020101",new KeyValuePair<string, string>("vcode does not exists", "版本号不存在")},
                {"030101",new KeyValuePair<string, string>("username or password error", "用户名或密码错误")},
                {"030201",new KeyValuePair<string, string>("renewal of failure", "续期失败")},
                {"030301",new KeyValuePair<string, string>("logout failed", "注销失败")},
                
                {"040101",new KeyValuePair<string, string>("failed to get", "获取失败")},
                {"040201",new KeyValuePair<string, string>("the old password is wrong", "原密码错误")},
                {"040202",new KeyValuePair<string, string>("new password can’t be the same width the orginal password", "新密码不能与原密码一样")},
                {"040203",new KeyValuePair<string, string>("failed to modify", "修改失败")},
                {"040301",new KeyValuePair<string, string>("the file type is not supported", "不支持该文件类型")},
                {"040302",new KeyValuePair<string, string>("file size too large", "文件大小过大")},
                {"040303",new KeyValuePair<string, string>("failed to modify", "修改失败")},
                {"040401",new KeyValuePair<string, string>("failed to modify", "修改失败")},
                
                {"050101",new KeyValuePair<string, string>("schid does not exists", "学校id不存在")},
                {"050201",new KeyValuePair<string, string>("schid does not exists", "学校id不存在")},
                {"050301",new KeyValuePair<string, string>("specid does not exists", "专业id不存在")},
                {"050401",new KeyValuePair<string, string>("gid does not exists", "年级id不存在")},
                {"050501",new KeyValuePair<string, string>("sid does not exists", "学科id不存在")},
                
                {"060101",new KeyValuePair<string, string>("did does not exists", "目录id不存在")},
                {"060201",new KeyValuePair<string, string>("name already exists", "目录名称已存在")},
                {"060202",new KeyValuePair<string, string>("failed to create", "创建失败")},
                {"060203",new KeyValuePair<string, string>("did does not exists", "目录id不存在")},
                {"060301",new KeyValuePair<string, string>("did does not exists", "目录id不存在")},
                {"060302",new KeyValuePair<string, string>("name already exists", "目录名称已存在")},
                {"060303",new KeyValuePair<string, string>("failed to modify", "修改失败")},
                {"060401",new KeyValuePair<string, string>("did does not exists", "目录id不存在")},
                {"060402",new KeyValuePair<string, string>("failed to destroy", "删除失败")},

                {"060501",new KeyValuePair<string, string>("the name of the file format error", "文件名格式错误")},
                {"060502",new KeyValuePair<string, string>("file size too large", "文件大小过大")},
                {"060503",new KeyValuePair<string, string>("did does not exists", "目录id不存在")},
                {"060504",new KeyValuePair<string, string>("failed to upload", "上传失败")},

                {"060601",new KeyValuePair<string, string>("fid does not exists", "文件id不存在")},
                {"060602",new KeyValuePair<string, string>("filename already exists", "文件名已存在")},
                {"060603",new KeyValuePair<string, string>("failed to modify", "修改失败")},

                {"060701",new KeyValuePair<string, string>("IDs is too many", "IDs参数太长了")},//待优化
                {"060702",new KeyValuePair<string, string>("failed to destroy", "删除失败")},
                {"060801",new KeyValuePair<string, string>("fid does not exists", "文件id不存在")},
                
                {"070101",new KeyValuePair<string, string>("cid does not exists", "章节id不存在")},
                {"070201",new KeyValuePair<string, string>("", "")},
                {"070301",new KeyValuePair<string, string>("rid does not exists", "资源id不存在")},
                {"070401",new KeyValuePair<string, string>("rid does not exists", "资源id不存在")},
                {"070402",new KeyValuePair<string, string>("you hava a collection of", "你已收藏")},
                {"070501",new KeyValuePair<string, string>("rid does not exists", "资源id不存在")},
                {"070502",new KeyValuePair<string, string>("you hava not had a collection of", "你未收藏过")},
                {"070601",new KeyValuePair<string, string>("rid does not exists", "资源id不存在")},
                {"070701",new KeyValuePair<string, string>("rid does not exists", "资源id不存在")},
                {"070702",new KeyValuePair<string, string>("you have commented on", "你已经评论过了")},

                {"080101",new KeyValuePair<string, string>("", "")},
                {"080201",new KeyValuePair<string, string>("sid does not exists", "学科id不存在")},
                {"080202",new KeyValuePair<string, string>("this year and term not exists your class info", "该学年学期中不存在您的班级信息")},
                {"080301",new KeyValuePair<string, string>("Couresid does not exists", "课程id不存在")},
                {"080401",new KeyValuePair<string, string>("Couresid does not exists", "课程id不存在")},
                {"080402",new KeyValuePair<string, string>("Couresid already exists", "课程已选")},
                {"080403",new KeyValuePair<string, string>("The number of full", "人数已满")},
                {"080501",new KeyValuePair<string, string>("week does not exists", "周不存在")},
                {"080502",new KeyValuePair<string, string>("current week does not in current year and term", "当前周不在当前学年学期范围内")},
                
                {"090101",new KeyValuePair<string, string>("", "")},
                {"090201",new KeyValuePair<string, string>("", "")},
                {"090301",new KeyValuePair<string, string>("", "")}
            };

        protected object GetEMsg(string code)
        {
            return new
            {
                code = code,
                message = Ecode[code].Key,
                messageDetail = Ecode[code].Value
            };
        }
        
        //public object GetErrorMsg(ErroCode code)
        //{

        //    var att = code.GetType().GetField(code.ToString()).GetCustomAttributes(typeof(DesAttribute), true);
        //    string _code = "";
        //    string _message ="";
        //    string _messageDetail="";
        //    if (att.Length > 0)
        //    {
        //        var des = (DesAttribute)att[0];
        //        _code = des.Id;
        //        _message = des.Des;
        //        _messageDetail = des.EnDes;
        //    }
        //    else {
        //        _message = "null";
        //        _messageDetail = "null";
        //    }
        //    return new {
        //        code=_code,
        //        message = _message,
        //        messageDetail = _messageDetail
        //    };
        //}
        /// <summary>
        /// 获取微课缩略图的服务器地址
        /// </summary>
        /// <param name="url">图片地址</param>
        /// <returns></returns>
        protected string getPreImgServerUrl(string url) {
            string retstr = "";
            if (string.IsNullOrEmpty(url))
            {
                retstr = ConfigurationManager.AppSettings["WEB_wk_preview_img"];
            }
            else
            {
                string _url = url.IndexOf('/') == 0 ? url.Substring(1) : url;
                retstr = ConfigurationManager.AppSettings["WEBHost"] + _url;
            }
            return retstr;
        }

        /// <summary>
        /// 获取用户头像的服务器地址
        /// </summary>
        /// <param name="url">图片地址</param>
        /// <returns></returns>
        protected string getUserPhotoServerUrl(string url)
        {
            string retstr = "";
            if (string.IsNullOrEmpty(url))
            {
                retstr = ConfigurationManager.AppSettings["WEB_user_head_pic"];
            }
            else
            {
                string _url = url.IndexOf('/') == 0 ? url.Substring(1) : url;
                retstr = ConfigurationManager.AppSettings["WEBHost"] + _url;
            }
            return retstr;
        }

        /// <summary>
        /// 获取微课的服务器播放地址
        /// </summary>
        /// <param name="url">文件地址</param>
        /// <returns></returns>
        protected string getMicroClassServerUrl(string url)
        {
            string retstr = "";
            retstr = string.IsNullOrEmpty(url) ?"": ConfigurationManager.AppSettings["WEBHost"] + url;
            return retstr;
        }
    }
}