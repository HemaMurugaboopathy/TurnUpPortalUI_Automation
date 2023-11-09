using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUP.TurnUp
{
    public class TMPage
    {
        public void Create_TimeRecord(IWebDriver driver)
        {
            //Click Create new button
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();

            //Select Time in typecode dropdown option
            IWebElement typdeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typdeCode.Click();

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            timeOption.Click();

            //Enter code in Code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("October2023");

            //Enter description in Description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Sample description");

            //Enter price in Price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("12");

            //Click save button
            IWebElement saveSelect = driver.FindElement(By.Id("SaveButton"));
            saveSelect.Click();
            Thread.Sleep(1000);

            //Check whether the entered data has been succesfully recorded
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "October2023")
            {
                Console.WriteLine("New record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Record has not been created.");
            }

        }
        public void Edit_TimeRecord(IWebDriver driver)
        {

            //Click the edit time & material
            IWebElement editOption = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            editOption.Click();
            Thread.Sleep(1000);

            //Enter the code to be edited
            IWebElement editcodeTextbox = driver.FindElement(By.Id("Code"));
            editcodeTextbox.Clear();
            editcodeTextbox.SendKeys("Oct2023");
            Thread.Sleep(1000);

            //Click save button
            IWebElement saveUpdated = driver.FindElement(By.Id("SaveButton"));
            saveUpdated.Click();
            Thread.Sleep(1000);

            //Check whether the data has been succesfully edited
            IWebElement LastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement updatedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
        }
        public void Delete_TimeRecord(IWebDriver driver)
        {

            //Click the delete button 
            IWebElement deleteOption = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            deleteOption.Click();
        }
    }
}
