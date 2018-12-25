using System;
using Dto;

namespace IdentityService
{
    public class IdentityServiceImpl : IIdentityService
    {
        public Result<bool> CheckServiceToken(CheckTokenParam param)
        {
            throw new NotImplementedException();
        }

        public bool CheckToken(CheckTokenParam param)
        {
            throw new NotImplementedException();
        }

        public LoginResult GetLoginToken(LoginTokenParam param)
        {
            throw new NotImplementedException();
        }

        public Result<string> GetServiceToken(ServiceTokenParam param)
        {
            throw new NotImplementedException();
        }

        public Result<LoginResult> Login(LoginParam param)
        {
            throw new NotImplementedException();
        }
    }
}
