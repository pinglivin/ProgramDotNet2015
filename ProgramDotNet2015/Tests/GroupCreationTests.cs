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
            applicationManager.Group.InitGroupCreation();
            applicationManager.Group.FillGroupForm(new GroupData("group_name", "group_header", "group_footer"));
            applicationManager.Group.SubmitGroupCreation();
            applicationManager.Navigator.ReturnToGropsPage();
        }
    }
}

