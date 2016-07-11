using NUnit.Framework;

namespace WebAdressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Contact.InitContactCreation();
            applicationManager.Contact.FillContactForm(new ContactData("name", "lastName", "company"));
            applicationManager.Contact.submitContactCreation();
            applicationManager.Navigator.ReturnToContactsPage();
         }
    }
}
