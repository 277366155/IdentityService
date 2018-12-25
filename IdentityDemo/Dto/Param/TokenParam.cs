namespace Dto
{
    /// <summary>
    /// 登录时获取token信息参数
    /// </summary>
    public class LoginTokenParam : BaseParam
    {
        public TokenTypeEnum TokenType { get; set; }
    }

    /// <summary>
    /// 获取当前用户+服务token信息参数
    /// </summary>
    public  class ServiceTokenParam: LoginTokenParam
    {
        public string UserToken { get; set; }

        public string MethodName { get; set; }

    }

    /// <summary>
    /// 校验token参数
    /// </summary>
    public class CheckTokenParam : ServiceTokenParam
    { }
}
