using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUP.Utilities;

namespace TurnUP.TurnUp
{
    public class HomePage
    {
        public void GoToTMpage(IWebDriver driver)
        {
            //Go to administration page
            IWebElement administrationOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationOption.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 3);

            //Go to Time & Materials page
            IWebElement timeMaterialsOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialsOption.Click();
        }
    }
}
