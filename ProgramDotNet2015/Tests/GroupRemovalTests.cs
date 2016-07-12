using NUnit.Framework;


namespace WebAdressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Group.RemovalGroup(2);
        }
    }
}
