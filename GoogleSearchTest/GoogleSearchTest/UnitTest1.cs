using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using GoogleSearchTest.Pages;
using Frw.Base;

namespace GoogleSearchTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://www.google.com";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            string searchTerm = "Manual testing is long";

            //SearchPage page = new SearchPage();
            //CurrentPage = page.SearchFor(searchTerm);
            //Assert.IsTrue(((ResultPage)CurrentPage).IsResultFound(), "Search not found!");

            CurrentPage = GetInstance<SearchPage>();
            CurrentPage = CurrentPage.As<SearchPage>().SearchFor(searchTerm);

            var found = CurrentPage.As<ResultPage>().IsResultFound();
            Assert.IsTrue(found, "Search not found!");
        }
    }
}
