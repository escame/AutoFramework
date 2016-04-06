﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GoogleSearchTest
{
    [TestClass]
    public class UnitTest1
    {
        string url = "http://www.google.com";

        private IWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl(url);
            string searchTerm = "Manual testing is long";

            searchFor(searchTerm);
        }

        public void searchFor(string searchTerm)
        {
            _driver.FindElement(By.Name("q")).SendKeys(searchTerm);

            _driver.FindElement(By.Name("btnK")).Submit();
        }
    }
}
