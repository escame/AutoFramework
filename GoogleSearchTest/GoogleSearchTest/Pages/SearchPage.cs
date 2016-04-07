using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoogleSearchTest.Pages
{
    class SearchPage : BasePage
    {
        //Initialize page
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        //Object Elements for SearchPage
        [FindsBy(How = How.Name, Using = "q")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        public IWebElement btnSubmit { get; set; }
    }
}
