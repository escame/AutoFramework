using Frw.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.ObjectModel;

namespace GoogleSearchTest.Pages
{
    class ResultPage : BasePage
    {
        //Object Elements for SearchPage
        [FindsBy(How = How.CssSelector, Using = "#ires li.g")]
        public ReadOnlyCollection<IWebElement> searchResults { get; set; }
    }
}
