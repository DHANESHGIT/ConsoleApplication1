using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace S3Group.Google.PageObjects
{
    class LoginPage
    {
        [FindsBy(How=How.Name,Using ="Email")]
        public IWebElement EmailId { get; set; }

        [FindsBy(How = How.Id, Using = "next")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Id, Using = "Passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "signIn")]
        public IWebElement SignIn { get; set; }
    }
}
