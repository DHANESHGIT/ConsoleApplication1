using NUnit.Framework;
using S3Group.Google.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using S3Group.Google.FactoryWrapper;
using System.Configuration;


namespace S3Group.Google.TestCases
{
    class GoogleTest
    {
        [Test]
        public void Test()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            var homePage = new HomePage();
            PageFactory.InitElements(BrowserFactory.Driver, homePage);
            homePage.SearchBox.SendKeys("gmail");
            
            var loginPage = new LoginPage();
            PageFactory.InitElements(BrowserFactory.Driver, loginPage);
            loginPage.EmailId.SendKeys("dhaneshkumarro@gmail.com");
            loginPage.NextButton.Click();
            loginPage.Password.SendKeys("Test@123");
            loginPage.SignIn.Click();

        }
    }
}
