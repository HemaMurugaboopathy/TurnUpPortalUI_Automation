using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using TurnUP.TurnUp;

public class program
{
    private static void Main(string[] args)
    {
        // open chrome browser
        IWebDriver driver = new ChromeDriver();

        //LoginPage object initialization and definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver);

        //HomePage object initialization and definition
        HomePage homePageobj = new HomePage();
        homePageobj.GoToTMpage(driver);

        //TMPage object initialization and definition
        TMPage tmPageobj = new TMPage();
        tmPageobj.Create_TimeRecord(driver);
        tmPageobj.Edit_TimeRecord(driver);
        tmPageobj.Delete_TimeRecord(driver);

    }
}




