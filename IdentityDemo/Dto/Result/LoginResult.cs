namespace Dto
{
    public  class LoginResult
    {
        /// <summary>
        /// 用户身份
        /// </summary>
        public string UserToken { get; set; }

        /// <summary>
        /// 用户+服务token
        /// </summary>
        public string Token { get; set; }
    }
}
