using OpenQA.Selenium;
using Specflow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EmergencyContactsStepDefinitions
    {
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//span[text()='My Info']")).Click();
        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Emergency Contacts']")).Click();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
        }

        [When(@"I fill the Save Emergency Contact section")]
        public void WhenIFillTheSaveEmergencyContactSection(Table table)
        {
        }

        [When(@"I click on save emergency contact")]
        public void WhenIClickOnSaveEmergencyContact()
        {
        }

        [Then(@"I should see be navigated to emergency contacts containing the emergency contact records")]
        public void ThenIShouldSeeBeNavigatedToEmergencyContactsContainingTheEmergencyContactRecords()
        {
            Console.WriteLine("DONE");
        }
    }
}
