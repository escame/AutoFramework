using Frw.Base;
using Frw.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GoogleSearchTest.Pages
{
    internal class SearchPage : BasePage
    {
        //Object Elements for SearchPage
        [FindsBy(How = How.Name, Using = "q")]
        IWebElement TxtSearch { get; set; }

        [FindsBy(How = How.Name, Using = "btnK")]
        IWebElement BtnSubmit { get; set; }

        public ResultPage SearchFor(string searchTerm)
        {
            TxtSearch.SendKeys(searchTerm);
            BtnSubmit.Submit();
            DriverContext.Driver.WaitForPageLoaded();
            return GetInstance<ResultPage>();
        }

        internal void CheckIfSearchPageExist()
        {
            TxtSearch.AssertElementPresent();
        }
    }
}
