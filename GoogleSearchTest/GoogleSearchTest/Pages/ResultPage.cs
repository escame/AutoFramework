using Frw.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace GoogleSearchTest.Pages
{
    internal class ResultPage : BasePage
    {
        //Object Elements for SearchPage
        [FindsBy(How = How.XPath, Using = "//h3/a")]
        public IWebElement SearchResults { get; set; }

        public object GetSearchText()
        {
            return SearchResults.Text;
        }
    }
}
