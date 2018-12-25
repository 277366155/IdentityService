using Dto;

namespace IdentityService
{
    public interface IIdentityService
    {
        /// <summary>
        /// 登录时获取UserToken和Token
        /// </summary>
        /// <param name="loginTokenParam"></param>
        /// <returns></returns>
        LoginResult GetLoginToken(LoginTokenParam param);

        /// <summary>
        /// 获取当前用户+服务的token
        /// </summary>
        /// <param name="serviceTokenParam"></param>
        /// <returns></returns>
        Result<string> GetServiceToken(ServiceTokenParam param);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginParam"></param>
        /// <returns></returns>
        Result<LoginResult> Login(LoginParam param);

        /// <summary>
        /// 校验token合法性
        /// </summary>
        /// <returns></returns>
        Result<bool> CheckServiceToken(CheckTokenParam param);

        /// <summary>
        /// 服务内部使用的token校验方法
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        bool CheckToken(CheckTokenParam param);
    }
}
