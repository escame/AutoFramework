using Frw.Base;
using GoogleSearchTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GoogleSearchTest.Steps
{
    [Binding]
    internal class ExtendedSteps : BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<SearchPage>();
        }

        [Then(@"I should be on the home page")]
        public void ThenIShouldBeOnTheHomePage()
        {
            CurrentPage.As<SearchPage>().CheckIfSearchPageExist();
        }
    }
}
