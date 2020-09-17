using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Code
{
    class FakeAppUserRepository : IAppUserRepository
    {
        private Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if(AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();

                // Default AppUsers created here.
                AppUser testAppUserOne = new AppUser();
                testAppUserOne.UserName = "testUserName";
                testAppUserOne.Password = "1234";
                testAppUserOne.FirstName = "John";
                testAppUserOne.LastName = "Smith";
                testAppUserOne.EmailAddress = "johnsmith@email.com";
                testAppUserOne.IsAuthenticated = false;

                AppUser testAppUserTwo = new AppUser();
                testAppUserTwo.UserName = "testUserName2";
                testAppUserTwo.Password = "password";
                testAppUserTwo.FirstName = "Sarah";
                testAppUserTwo.LastName = "Jones";
                testAppUserTwo.EmailAddress = "sarahjones@email.com";
                testAppUserTwo.IsAuthenticated = false;
            }
        }
        public bool Login(string UserName, string Password)
        {
            AppUser user = GetByUserName(UserName);
            if(user == null)
            {
                return false;
            }
            if(user.Password.Equals(Password))
            {
                setAuthentication(user.UserName, true);
            }
            else
            {
                setAuthentication(user.UserName, false);
            }
            return user.IsAuthenticated;
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach(KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
            if(users.Count > 0)
            {
                return users;
            }
            return null;
        }

        public void setAuthentication(string userName, bool isAuthenticated)
        {
            AppUser user = GetByUserName(userName);
            if (user != null)
            {
                user.IsAuthenticated = isAuthenticated;
            }
        }

        public AppUser GetByUserName(string UserName)
        {
            foreach(KeyValuePair<string, AppUser> user in AppUsers)
            {
                if(user.Key.Equals(UserName))
                {
                    return user.Value;
                }
            }
            return null;
        }
        static void Main()
        {

        }
    }
}
