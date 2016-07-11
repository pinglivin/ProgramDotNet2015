using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAdressbookTests

{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {}

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData groupData)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(groupData.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(groupData.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(groupData.Footer);
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper SelectedGroup()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }

        public GroupHelper RemovalGroupsPage(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;

        }

        public GroupHelper CreateGroup()
        {
            manager.Group.InitGroupCreation()
                        .FillGroupForm(new GroupData("group_name", "group_header", "group_footer"))
                        .SubmitGroupCreation()
                        .ReturnToGroupsPage();
            return this;
        }

        public GroupHelper RemovalGroup(int index)
        {
            manager.Group.SelectedGroup()
            .RemovalGroupsPage(index)
            .ReturnToGroupsPage();
            return this;
        }

        public GroupHelper ModificationGroup(int index, string name, string header, string footer)
        {
            manager.Group.SelectedGroup()
                .InitGroupModification(index)
                .FillGroupForm(new GroupData(name, header, footer))
                .SubmitGroupModification()
                .ReturnToGroupsPage();
            return this;
        }

        public GroupHelper InitGroupModification(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='edit'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
   }
}
