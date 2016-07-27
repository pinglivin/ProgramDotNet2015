using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            applicationManager.Navigator.GoToContactsPage();
            applicationManager.Contact.RemovalContact(3);
            applicationManager.Navigator.ReturnToContactsPage();
        }
    }
}
