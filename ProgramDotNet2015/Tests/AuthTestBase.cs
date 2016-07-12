using NUnit.Framework;


namespace WebAdressbookTests
{
    public class AuthTestBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
