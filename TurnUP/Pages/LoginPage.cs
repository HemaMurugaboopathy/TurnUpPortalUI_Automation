using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUP.Utilities;

namespace TurnUP.TurnUp
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {

            // Launch TurnUpPortal and navigate to the login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
            Thread.Sleep(1000);
            Wait.WaitToExist(driver, "Id", "UserName", 3);

            // Identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify  log in button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

           
        }


    }
}
