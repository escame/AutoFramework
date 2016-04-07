using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace GoogleSearchTest.Pages
{
    class ResultPage : BasePage
    {
        public ResultPage(IWebDriver driver) : base(driver)
        {
        }

        //Object Elements for SearchPage
        [FindsBy(How = How.CssSelector, Using = "#ires li.g")]
        public ReadOnlyCollection<IWebElement> searchResults { get; set; }
    }
}
