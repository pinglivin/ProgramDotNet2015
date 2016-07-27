using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System;

namespace WebAdressbookTests
{
    public class ContactHelper : HelperBase
    {
        private bool acceptNextAlert = true;
        public ContactHelper(ApplicationManager manager) : base(manager)
        {}

        public ContactHelper FillContactForm(ContactData contactData)
        {
            Type(By.Name("firstname"), contactData.Name);
            Type(By.Name("lastname"), contactData.LastName);
            Type(By.Name("company"), contactData.Company);
            Type(By.Name("mobile"), contactData.Mobile);
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }

        public ContactHelper CreateContact()
        {
            manager.Contact.InitContactCreation()
              .FillContactForm(new ContactData("name", "lastName", "company", "79001011010"))
              .SubmitContactCreation();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.Id(""+index+"")).Click();
            return this;
        }

        public ContactHelper InitContactModification(int index)
        {
            driver.FindElement(By.XPath("(//input[@title ='Edit'])[" + index + "]")).Click();
            return this;
        }

        public ContactHelper ModificationContact(string name, string lastName, string company, string mobile, string year)
        {
            manager.Contact.InitContactCreation()
                .FillContactForm(new ContactData("aaa", "bbb", "ccc", "322323", "1921"))
                .SubmitContactCreation();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper RemovalContact(int index)
        {
            manager.Contact.SelectContact(index)
                .InitContactRemoval()
                .SubmitContactRemoval();
            return this;
        }

        public ContactHelper SubmitContactRemoval()
        {
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
       }

        public ContactHelper InitContactRemoval()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
    }    
}
