using DapperDAL;
using Dto;
using System;

namespace ConsoleTest
{
    class Program
    {
        public static UserInfoDAL Dal => new UserInfoDAL();
        static void Main(string[] args)
        {
            //InsertTest();
            SelectTest();
            Console.Read();
        }

        public static void InsertTest()
        { 
            var entity = new UserInfo() { Email = "123@qq.com", LoginPwd = "111111" };
            var data = Dal.Add(entity);        
        }

        public static void SelectTest()
        {
           var data = Dal.QueryList(" Email='163@163.com' ");
            //Console.WriteLine(data);
        }

    }
}
