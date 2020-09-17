using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class LoginFail
    {
        [TestMethod]
        public void LoginWIthIncorrectCredentialsFail()
        {
            //Arrange
            const string USERNAME = "testUserName";
            const string PASSWORD = "1234";
            FakeAppUserRepository FakeUser = new FakeAppUserRepository();

            //Act
            Boolean Auth = FakeUser.Login(USERNAME, PASSWORD);

            //Assert
            Assert.IsFalse(Auth);

        }
    }
}
