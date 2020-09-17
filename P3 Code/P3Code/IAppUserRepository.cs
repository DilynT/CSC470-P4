using System;
using System.Collections.Generic;
using System.Text;

namespace P3Code
{
    public interface IAppUserRepository
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetAll();
        void setAuthentication(string UserName, bool IsAuthenticated);
        AppUser GetByUserName(string UserName);
    }

}
