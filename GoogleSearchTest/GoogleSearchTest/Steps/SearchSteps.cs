using Frw.Base;
using GoogleSearchTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GoogleSearchTest.Steps
{
    [Binding]
    public class SearchSteps : BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<SearchPage>();
        }


        [Then(@"I should be on the home page")]
        [Given(@"I am on the home page")]
        public void ThenIShouldBeOnTheHomePage()
        {
            CurrentPage.As<SearchPage>().CheckIfSearchPageExist();
        }

        [Given(@"I have entered ""(.*)"" into the keyword textbox")]
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
