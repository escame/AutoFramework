using Frw.Base;
using Frw.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoogleSearchTest.Pages
{
    class SearchPage : BasePage
    {
        //Object Elements for SearchPage
        [FindsBy(How = How.Name, Using = "q")]
        IWebElement txtSearch { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        IWebElement btnSubmit { get; set; }

        public ResultPage SearchFor(string searchTerm)
        {
            txtSearch.SendKeys(searchTerm);
            btnSubmit.Submit();
            DriverContext.Driver.WaitForPageLoaded();
            return GetInstance<ResultPage>();
        }
    }
}
