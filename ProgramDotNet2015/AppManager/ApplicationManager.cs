using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;


namespace WebAdressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        
        protected LoginHelper loginHelper;
        protected ContactHelper contactHelper;
        protected GroupHelper groupHelper;
        protected NavigationHelper navigationHelper;


        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";


            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        public string BaseURL
        {
            get
            {
                return baseURL;
            }
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public GroupHelper Group
        {
            get
            {
                return groupHelper;
            }
        }

        public ContactHelper Contact
        {
            get
            {
                return contactHelper;
            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }
}
