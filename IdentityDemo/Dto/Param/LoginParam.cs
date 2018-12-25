namespace Dto
{
    /// <summary>
    /// 登录模型
    /// </summary>
    public class LoginParam  : BaseParam
    {
        public string Account { get; set; }
        public string Password { get; set; }
    }
}
