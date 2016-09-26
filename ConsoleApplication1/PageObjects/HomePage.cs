using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace S3Group.Google.PageObjects
{
    class HomePage
    {

        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement SearchButton { get; set; }
    }
}
