using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            applicationManager.Navigator.OpenHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.SelectedGroup();
            applicationManager.Group.RemovalGroupsPage(2);
            applicationManager.Navigator.ReturnToGropsPage();
        }
    }
}
