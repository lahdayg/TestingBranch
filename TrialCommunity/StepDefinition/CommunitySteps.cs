using System;
using TechTalk.SpecFlow;
using TrialCommunity.PageObject;
using TrialCommunity.Hooks;
using System.Threading;

namespace TrialCommunity.StepDefinition
{
    [Binding]
    public class CommunitySteps
    {

        CommunityClass1 communityClass1;

        public CommunitySteps()
        {
            communityClass1 = new CommunityClass1();
        }





        [Given(@"I navigate to www\.qa(.*)\.gifrt\.com")]
        public void GivenINavigateToWww_Qa_Gifrt_Com(int p0)
        {
            Hooks1.Driver.Navigate().GoToUrl("http://www.qa1.giftrt.com");
            Hooks1.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            communityClass1.ClickLogin();
        }
        
        [When(@"I enter my Username")]
        public void WhenIEnterMyUsername()
        {
            communityClass1.TypeEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            communityClass1.TypePassword();
        }
        
        [When(@"I click on signin")]
        public void WhenIClickOnSignin()
        {
            communityClass1.ClickSignin();
        }
        
        [When(@"I click on Community")]
        public void WhenIClickOnCommunity()
        {
            communityClass1.ClickCommunity();
        }

        
        
        [When(@"I click on create new")]
        public void WhenIClickOnCreateNew()
        {
            communityClass1.ClickCreateNew();
        }
        
        [Then(@"I should be able to create multiple community")]
        public void ThenIShouldBeAbleToCreateMultipleCommunity()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
