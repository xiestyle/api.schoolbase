using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using api.schoolbase.entities.DBBase;
using api.schoolbase.entities.DBUser;
using api.schoolbase.entities.DBSchool;
using api.schoolbase.bll.model;

namespace api.schoolbase.bll
{
    public class user
    {
        

        //原密码是否正确
        public static bool isOldPwd(int uid, string opwd)
        {
            return _DBUser.tUser.Select(_DBUser.tUser.user_id).Where(_DBUser.tUser.user_id == uid && _DBUser.tUser.pwd == opwd).Length > 0;
        }

        //修改密码
        public static bool changePwd(int uid, string pwd)
        {
            return _DBUser.tUser.Update.AddColumn(_DBUser.tUser.pwd, pwd).Where(_DBUser.tUser.user_id == uid).Execute() > 0;
        }

        public static long getUidByToken(string token)
        {
            var tokenobj = _DBBase.WxToken.Select()
                .Where(_DBBase.WxToken.token == token)
                .ToSingleObject<WxToken>();
            if (tokenobj == null)
            {
                return 0;
            }
            else {
                return tokenobj.userid;
            }
        }

        public static userModel getUserByToken(string token)
        {
            var tokenobj = _DBBase.WxToken.Select()
                .Where(_DBBase.WxToken.token == token)
                .ToSingleObject<WxToken>();
            if (tokenobj == null)
            {
                return null;
            }
            else
            {
                long uid = tokenobj.userid;
                var tuserobj =_DBUser.tUser.Select().Where(_DBUser.tUser.user_id == uid).ToSingleObject<tUser>();
                var tuserexobj = _DBBase.tUser_ex.Select().Where(_DBBase.tUser_ex.UID == uid).ToSingleObject<tUser_ex>();
                if (tuserobj != null && tuserexobj!=null)
                {
                    var schoolobj = _DBBase.Base_DepInfo.Select().Where(_DBBase.Base_DepInfo.DepID == tuserexobj.DepID).ToSingleObject<Base_DepInfo>();

                    return new userModel
                    {
                        uid = uid,
                        userid = tuserobj.email,
                        usertype =tuserexobj.UserType, 
                        name = "",
                        nickname =tuserobj.fullname,
                        headpic = tuserexobj.Photo,
                        sex = tuserexobj.UserSex,
                        tel = tuserexobj.UserTel,
                        schid = schoolobj==null?"":schoolobj.DepID,
                        schname = schoolobj==null?"":schoolobj.DepName,
                        bdate = tuserexobj.UserBirthday??DateTime.MinValue,
                        sign =tuserobj.personmsg
                    };
                }
                else {
                    return null;
                }
            }

        }
        public static bool modifyUser(long uid,long utype,string nickname,int sex,string tel,string bdate,string sign) {
            //using (var trans = new TransactionScope())
            //{
            var sql1 = _DBUser.tUser.Update;
            if (nickname != null)
            {
                sql1.AddColumn(_DBUser.tUser.fullname, nickname);
            }
            if (sign != null)
            {
                sql1.AddColumn(_DBUser.tUser.personmsg, sign);
            }
            if (nickname != null || sign != null)
            {
                bool _f =sql1.Where(_DBUser.tUser.user_id == uid).Execute()>0;
                if (!_f) return false;
            }
            
            if (utype == 129) {
                var sql2 = _DBSchool.IAM_Teacher.Update
                    .AddColumn(_DBSchool.IAM_Teacher.TeaSex,sex);
                if (tel != null) {
                    sql2.AddColumn(_DBSchool.IAM_Teacher.TeaTel, tel);
                }
                if (bdate != null) {
                    sql2.AddColumn(_DBSchool.IAM_Teacher.TeaBirth, bdate);
                }
                bool _f =sql2.Where(_DBSchool.IAM_Teacher.TeaSerID == uid).Execute()>0;
                if (!_f) return false;
            }
            else if (utype == 2049) {
                var sql2 = _DBSchool.IAM_Student.Update
                    .AddColumn(_DBSchool.IAM_Student.StuSex, sex);
                if (tel != null)
                {
                    sql2.AddColumn(_DBSchool.IAM_Student.StuTel, tel);
                }
                if (bdate != null)
                {
                    sql2.AddColumn(_DBSchool.IAM_Student.StuBirth, bdate);
                }
                bool _f = sql2.Where(_DBSchool.IAM_Student.StuSerID==uid).Execute() > 0;
                if (!_f) return false;
            }
            
            //    trans.Complete();
            //}
            
            return true;
        }

    }
}
