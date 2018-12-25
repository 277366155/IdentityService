using Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperDAL
{
    public class UserInfoDAL:BaseDAL
    {
        public UserInfoDAL(string connStr=null):base(connStr)
        {
        }
        public int Add(UserInfo userInfo)
        {
            var insertSql = "INSERT INTO `userinfo` ( `Email`, `PhoneNumber`, `LoginPwd`) VALUES (@Email,@PhoneNumber,@LoginPwd);";
            return base.Execute(insertSql, userInfo);
        }

        public IEnumerable<UserInfo> QueryList(string filter,Object param=null)
        {
            var selectSql = "select UserId,Email,PhoneNumber from UserInfo where 1=1 ";
            selectSql+= string.IsNullOrWhiteSpace(filter) ? " ;" : $" and {filter} ;";

           return  base.Query<UserInfo>(selectSql,param);
        }
    }
}
