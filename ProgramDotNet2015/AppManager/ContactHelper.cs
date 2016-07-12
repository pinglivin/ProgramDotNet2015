using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAdressbookTests
{
    public class ContactHelper : HelperBase
    { 
        public ContactHelper(ApplicationManager manager) : base(manager)
        {}

        public ContactHelper FillContactForm(ContactData contactData)
        {
            Type(By.Name("firstname"), contactData.Name);
            Type(By.Name("lastname"), contactData.LastName);
            Type(By.Name("company"), contactData.Company);
            Type(By.Name("mobile"), contactData.Mobile);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            Type(By.Name("byear"), contactData.Year);
            return this;
        }

        public ContactHelper InitContactCreation()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }

        public ContactHelper submitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }

        public void CreateContact()
        {
            manager.Contact.InitContactCreation()
              .FillContactForm(new ContactData("name", "lastName", "company", "79001011010", "1980"))
              .submitContactCreation();
        }

        public ContactHelper SelectContact()
        {
            driver.FindElement(By.Name("selected[]")).Click();
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
                .submitContactCreation();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper RemovalContact()
        {
            return this;
        }
    }    
}
