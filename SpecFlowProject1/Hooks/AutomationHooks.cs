using OpenQA.Selenium;
using System;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = false)]
namespace Specflow_Automation.Hooks
{
    [Binding]
    public class AutomationHooks
    {
      public IWebDriver driver;

        [AfterScenario]
        public void EndScenario()
        {
            if(driver != null)
                driver.Quit();
        }
    }
}
