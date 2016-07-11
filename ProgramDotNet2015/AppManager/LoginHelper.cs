﻿using OpenQA.Selenium;

namespace WebAdressbookTests
{
   public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {}

        public void Login(AccountData accountData)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(accountData.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(accountData.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}
