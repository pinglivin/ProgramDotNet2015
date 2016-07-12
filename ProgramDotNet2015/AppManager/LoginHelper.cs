using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace WebAdressbookTests
{
   public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {}

        public void Login(AccountData accountData)
        {
            if (IsLoginOn())
            {
                if(IsLoginIn(accountData))
                {
                    return;
                }
                Logout();

            }
            Type(By.Name("user"), accountData.Username);
            Type(By.Name("pass"), accountData.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private bool IsLoginOn()
        {
            return IsElementPresent(By.Name("logout"));
            throw new NotImplementedException();
        }

        public void Logout()
        {
            if (IsLoginOn())
            {
                driver.FindElement(By.Name("logout")).Click();
            }
        }

        public bool IsLoginIn(AccountData accountData)
        {
            return IsLoginOn() && 
                driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text == "("+ accountData.Username + ")";
            throw new NotImplementedException();
        }
    }
}
