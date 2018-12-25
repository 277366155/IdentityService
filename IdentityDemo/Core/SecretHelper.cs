using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Core
{
    public class SecretHelper
    {
        /// <summary>
        /// 排除空字符串/null值之后，倒序排列，hash
        /// </summary>
        /// <param name="key"></param>
        /// <param name="paramArrary"></param>
        /// <returns></returns>
        public string GetSign(string key, string[]  paramArrary)
        {
            StringBuilder paramStr = new StringBuilder();
            paramArrary
                .OrderByDescending(a => a).ToList()
                .ForEach(a =>
                {
                    if (!string.IsNullOrWhiteSpace(a))
                    {
                        paramStr.Append(a);
                    }
                });
            return SHA1(paramStr.ToString());
        }
        
        /// <summary>
        /// hash加密
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public string SHA1(string content, Encoding encode=null)
        {
            encode = encode == null ? Encoding.UTF8 : encode;
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] bytes_in = encode.GetBytes(content);
            byte[] bytes_out = sha1.ComputeHash(bytes_in);
            sha1.Dispose();
            string result = BitConverter.ToString(bytes_out);
            result = result.Replace("-", "");
            return result;
        }
    }
}
