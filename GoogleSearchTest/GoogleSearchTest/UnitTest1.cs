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

            searchFor(searchTerm);
        }

        public void searchFor(string searchTerm)
        {
            SearchPage page = new SearchPage();

            page.txtSearch.SendKeys(searchTerm);
            page.btnSubmit.Submit();

            //_driver.FindElement(By.Name("q")).SendKeys(searchTerm);
            //_driver.FindElement(By.Name("btnK")).Submit();
        }
    }
}
