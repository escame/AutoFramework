using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleSearchTest.Pages;

namespace GoogleSearchTest
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {
        [TestMethod]
        public void TestMethod1()
        {
            string searchTerm = "SpecFlow - Cucumber for .NET";

            CurrentPage = GetInstance<SearchPage>();
            CurrentPage = CurrentPage.As<SearchPage>().SearchFor(searchTerm);

            var found = CurrentPage.As<ResultPage>().GetSearchText();
            Assert.AreEqual(searchTerm, found);
        }
    }
}
