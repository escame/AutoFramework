using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using GoogleSearchTest.Pages;
using Frw.Base;

namespace GoogleSearchTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://www.google.com";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            string searchTerm = "Manual testing is long";

            SearchPage page = new SearchPage();
            ResultPage resultPage = page.SearchFor(searchTerm);
        }
    }
}
