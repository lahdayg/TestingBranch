using System;
using TechTalk.SpecFlow;

namespace TrialCommunity.StepDefinition
{
    [Binding]
    public class CommunityBranchTestingSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter all the information")]
        public void WhenIEnterAllTheInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I say jump")]
        public void WhenISayJump()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"It should jump")]
        public void ThenItShouldJump()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
