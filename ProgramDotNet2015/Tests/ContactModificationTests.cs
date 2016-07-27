using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Contact.ModificationContact("aaa", "vvv", "ccc", "79235555", "1223");
            applicationManager.Navigator.GoToContactsPage();
        }
    }
}
