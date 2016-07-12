using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.CreateGroup();
        }
    }
}

