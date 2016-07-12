using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginIsValidCredentials()
        {
            //prepare
            applicationManager.Auth.Logout();

            //action
            AccountData admin = new AccountData("admin", "secret");
            applicationManager.Auth.Login(admin);

            //verification
            Assert.IsTrue(applicationManager.Auth.IsLoginIn(admin));
        }

        [Test]
        public void LoginIsInvalidCredentials()
        {
            //prepare
            applicationManager.Auth.Logout();

            //action
            AccountData admin = new AccountData("admin", "123456");
            applicationManager.Auth.Login(admin);

            //verification
            Assert.IsFalse(applicationManager.Auth.IsLoginIn(admin));
        }
    }
}
