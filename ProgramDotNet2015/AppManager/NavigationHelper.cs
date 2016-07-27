using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAdressbookTests
{
    public class NavigationHelper : HelperBase
    {
        protected string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            { return;  }
            else
            { 
                driver.FindElement(By.LinkText("groups")).Click();
            }
        }

        public NavigationHelper GoToHomePage()
        {
            if(driver.Url == baseURL + "/addressbook/")
            {
                return this;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
            return this;
        }

        public void GoToContactsPage()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void ReturnToContactsPage()
        {
            if (driver.Url == baseURL + "/addressbook/edit.php" && 
                IsElementPresent(By.Name("")))
            {
                driver.FindElement(By.LinkText("home page")).Click();
            }
        }

        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
    }
}
