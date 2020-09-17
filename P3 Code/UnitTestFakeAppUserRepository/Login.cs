using System;
using P3Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class LoginFail
    {
        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            //Arrange
            const string USERNAME = "testUserName";
            const string PASSWORD = "1234678123123123";
            FakeAppUserRepository FakeUser = new FakeAppUserRepository();

            //Act
            Boolean Auth = FakeUser.Login(USERNAME, PASSWORD);

            //Assert
            Assert.IsFalse(Auth);

        }
 
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccess()
        {
            //Arrange
            const string USERNAME = "testUserName2";
            const string PASSWORD = "password";
            FakeAppUserRepository FakeUser = new FakeAppUserRepository();

            //Act
            Boolean Auth = FakeUser.Login(USERNAME, PASSWORD);

            //Assert
            Assert.IsTrue(Auth);

        }
    }
}
