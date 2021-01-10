using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Services.Users
{
    public class FakeUserInfoService : IUserInfoService
    {
        public string GetUserAgent()
        {
            return "1";
        }

        public string GetUserIp()
        {
            return "1";
        }

        public int UserId()
        {
            return 1;
        }
    }
}
