using GiftreteRegistration.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GiftreteRegistration.StepDefination
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;
        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }

        [Given(@"I navigate to the site ""(.*)""")]
        public void GivenINavigateToTheSite(string p0)
        {

            registrationPage.NavigateToUrl();
        }
        
        [When(@"I click on the create account button")]
        public void WhenIClickOnTheCreateAccountButton()
        {
            registrationPage.ClickCreateAccount();
        }
        
        [When(@"I enter the first name ""(.*)""")]
        public void WhenIEnterTheFirstName(string name)
        {
            registrationPage.EnterFirstName(name);
        }
        
        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string lastname)
        {
            registrationPage.EnterLastName(lastname);
        }
        
        [When(@"I enter  email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter mobile number ""(.*)""")]
        public void WhenIEnterMobileNumber(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter confirm password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
