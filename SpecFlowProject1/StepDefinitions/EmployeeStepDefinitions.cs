using OpenQA.Selenium;
using Specflow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace Specflow_Automation.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        private AutomationHooks hooks;
        public EmployeeStepDefinitions(AutomationHooks hooks)
        {
            this.hooks = hooks;
        }

        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            hooks.driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            hooks.driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        }

        [When(@"I add all details")]
        public void WhenIAddAllDetails(Table table)
        {

            string fName = table.Rows[0]["firstname"];
            string mName = table.Rows[0]["middle_name"];
            string lName = table.Rows[0]["last_name"];
            string toggleLoginDetai = table.Rows[0]["toggle_login_details"];
            string UserName = table.Rows[0]["username"];
            string password = table.Rows[0]["password"];
            string confirmPassword = table.Rows[0]["confirm_password"];
            string status = table.Rows[0]["status"];
            hooks.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            hooks.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            if (toggleLoginDetai.Equals("on"))
            {
                hooks.driver.FindElement(By.XPath("//span[contains(@class,'oxd-switch-input')]")).Click();
                hooks.driver.FindElement(By.XPath("//label[contains(text(),'Username')]/following::input")).SendKeys(UserName);
                hooks.driver.FindElement(By.XPath("//label[contains(text(),'Password')]/following::input")).SendKeys(password);
                hooks.driver.FindElement(By.XPath("//label[contains(text(),'Confirm Password')]/following::input")).SendKeys(confirmPassword);
                if (status.ToLower().Equals("disabled"))
                {
                    hooks.driver.FindElement(By.XPath("//label[text()='Disabled']")).Click();
                }
                else
                {
                    hooks.driver.FindElement(By.XPath("//label[text()='Enabled']")).Click();
                }
            }
        }


        [When(@"I click on save option")]
        public void WhenIClickOnSaveOption()
        {
            hooks.driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        [Then(@"I should navigate to personal details")]
        public void ThenIShouldNavigateToPersonalDetails()
        {
            Console.WriteLine("add employee");
        }
    }
}
