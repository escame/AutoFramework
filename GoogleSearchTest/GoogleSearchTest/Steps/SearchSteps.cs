using Frw.Base;
using GoogleSearchTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GoogleSearchTest.Steps
{
    [Binding]
    public class SearchSteps : BaseStep
    {
        [Then(@"I have entered ""(.*)"" into the keyword textbox")]
        public void GivenIHaveEnteredIntoTheKeywordTextbox(string searchTerm)
        {
            CurrentPage = CurrentPage.As<SearchPage>().SearchFor(searchTerm);
        }

        [Then(@"I should see a list of articles related to ""(.*)""")]
        public void ThenIShouldSeeAListOfArticlesRelatedTo(string searchTerm)
        {
            var found = CurrentPage.As<ResultPage>().GetSearchText();
            Assert.AreEqual(searchTerm, found);
        }
    }
}
