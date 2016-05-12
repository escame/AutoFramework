﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using GoogleSearchTest.Pages;
using Frw.Base;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using Frw.Config;
using Frw.Extensions;

namespace GoogleSearchTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        public void OpenBrowser(BrowserType browserType = BrowserType.Firefox)
        {
            switch (browserType)
            {
                case BrowserType.IE:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            ConfigReader.SetFrameworkSettings();

            OpenBrowser(Settings.BrowserType);
            DriverContext.Browser.GoToUrl(Settings.URL);

            string searchTerm = "SpecFlow - Cucumber for .NET";

            CurrentPage = GetInstance<SearchPage>();
            CurrentPage = CurrentPage.As<SearchPage>().SearchFor(searchTerm);

            var found = CurrentPage.As<ResultPage>().GetSearchText();
            Assert.AreEqual(searchTerm, found);
        }
    }
}
