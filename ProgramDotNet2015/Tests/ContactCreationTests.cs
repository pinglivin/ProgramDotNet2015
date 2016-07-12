using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            applicationManager.Contact.CreateContact();
            applicationManager.Navigator.ReturnToContactsPage();
         }
    }
}
