using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            applicationManager.Navigator.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.CreateGroup();
        }
    }
}

