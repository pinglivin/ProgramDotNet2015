using NUnit.Framework;

namespace WebAdressbookTests
{ 
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.ModificationGroup(2, "aaa", "bbb", "ccc");
            applicationManager.Navigator.GoToGroupsPage();
        }
    }
}
