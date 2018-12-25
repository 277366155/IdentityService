using Core;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DapperDAL
{
    public class BaseDAL
    {

        private static IDbConnection _conn;

        protected static string _connStr = "";

        public BaseDAL(string connStr=null)
        {
            _connStr = string.IsNullOrWhiteSpace(connStr)
                ?BaseCore.Configuration.GetConnectionString("MySqlConnection") 
                : connStr;
             
        }

        private static object _locker = new object();

        public static IDbConnection Conn
        {
            get
            {
                if (_conn == null)
                {
                    lock (_locker)
                    {
                        if (_conn == null)
                        {
                            _conn = new MySqlConnection(_connStr);
                        }
                    }
                }

                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
                return _conn;
            }
        }
        /// <summary>
        /// 普通查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="buffered"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public IEnumerable<T> Query<T>(string sql, object param = null,
            IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null,
            CommandType? commandType = null)
        {

            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var result = conn.Query<T>(sql, param, transaction, buffered, commandTimeout, commandType);
                conn.Close();
                conn.Dispose();
                return result;
            }
        }

        /// <summary>
        ///执行update或Insert
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            using (var conn = new MySqlConnection(_connStr))
            {
                conn.Open();
                var result = conn.Execute(sql, param, transaction, commandTimeout, commandType);
                conn.Close();
                conn.Dispose();
                return result;
            }
        }


        ~BaseDAL()
        {
            if (_conn.State != ConnectionState.Closed)
                _conn.Close();
            _conn.Dispose(); 
        }
    }
}
