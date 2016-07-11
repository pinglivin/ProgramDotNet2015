﻿using NUnit.Framework;

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
            applicationManager.Contact.CreateContact();
            applicationManager.Navigator.ReturnToContactsPage();
         }
    }
}
