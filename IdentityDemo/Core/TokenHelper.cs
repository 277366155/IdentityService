using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class TokenHelper
    {
        public string GetToken()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
