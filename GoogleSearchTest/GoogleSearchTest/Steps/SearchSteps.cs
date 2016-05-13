using Frw.Base;
using GoogleSearchTest.Pages;
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
        public void GivenIHaveEnteredIntoTheKeywordTextbox(string p0)
        {
            CurrentPage.As<SearchPage>().SearchFor(p0);
        }

        [When(@"I press the search button")]
        public void WhenIPressTheSearchButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see a list of articles related to BDD")]
        public void ThenIShouldSeeAListOfArticlesRelatedToBDD()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
