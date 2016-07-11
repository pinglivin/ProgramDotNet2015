using NUnit.Framework;

namespace WebAdressbookTests
{ 
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.ModificationGroup(2, "aaa", "bbb", "ccc");
        }
    }
}
