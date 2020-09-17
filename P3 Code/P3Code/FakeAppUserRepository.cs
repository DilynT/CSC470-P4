using System;
using System.Collections.Generic;
using System.Text;

namespace P3Code
{
    public class FakeAppUserRepository : IAppUserRepository
    {
        private static Dictionary<string, AppUser> AppUsers;

        public FakeAppUserRepository()
        {
            if (AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();

                // Default AppUsers created here.
                // Default AppUsers created here.
                AppUsers.Add("testUserName", new AppUser
                {
                    UserName = "testUserName",
                    Password = "1234",
                    FirstName = "John",
                    LastName = "Smith",
                    EmailAddress = "johnsmith@email.com",
                    IsAuthenticated = false
                });

                AppUsers.Add("testUserName2", new AppUser
                {
                    UserName = "testUserName2",
                    Password = "password",
                    FirstName = "Sarah",
                    LastName = "Jones",
                    EmailAddress = "sarahjones@email.com",
                    IsAuthenticated = false
                });

                AppUsers.Add("testUserName3", new AppUser
                {
                    UserName = "testUserName3",
                    Password = "password1!",
                    FirstName = "Sarah",
                    LastName = "Jones",
                    EmailAddress = "sarahjones@email.com",
                    IsAuthenticated = false
                });
            }
        }
        public bool Login(string UserName, string Password)
        {
            AppUser user = new AppUser();
            user = GetByUserName(UserName);
            if (user == null)
            {
                return false;
            }
            else
            {
                if (user.Password.Equals(Password))
                {
                    setAuthentication(user.UserName, true);
                }
                else
                {
                    setAuthentication(user.UserName, false);
                }
            }
            return user.IsAuthenticated;
        }

        public List<AppUser> GetAll()
        {
            List<AppUser> users = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                users.Add(user.Value);
            }
/*            if (users.Count > 0)
            {
                return users;
            }*/
            return users;
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
            foreach (KeyValuePair<string, AppUser> user in AppUsers)
            {
                if (user.Key.Equals(UserName))
                {
                   return user.Value;
                }
            }
            return null;
        }

    }
}
