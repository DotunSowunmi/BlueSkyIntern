using System;
using TechTalk.SpecFlow;

namespace BlueskyProject.StepDefinitions
{   
    [Binding]
    public class RegistrationSteps


    {
        [When(@"I enter a wrong password ""(.*)"" for the confirm password")]
        public void WhenIEnterAWrongPasswordForTheConfirmPassword(string p0)
        {
            
        }

        [When(@"I enter the First name ""(.*)""")]
        public void WhenIEnterTheFirstName(string p0)
        {
            
        }

        [When(@"I enter the password ""(.*)""")]
        public void WhenIEnterThePassword(string p0)
        {
            
        }

        [Then(@"I should NOT be logged in")]
        public void ThenIShouldNOTBeLoggedIn()
        {
           
        }


        [When(@"I enter the Last name ""(.*)""")]
        
        //public void WhenIEnterTheLastName(string p0)
          [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        { 
            
        }


        [When(@"I enter a wrong password for the confirm password")]
        public void WhenIEnterAWrongPasswordForTheConfirmPassword()
        {
            
        }


        [Given(@"I navigate to the website")]
         public void GivenINavigateToTheWebsite()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click on the Register button")]
        public void GivenIClickOnTheRegisterButton()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the First name")]
        public void WhenIEnterTheFirstName()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the Last name")]
        
        public void WhenIEnterTheLastName()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the password")]
        public void WhenIEnterThePassword()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the confirm password")]
        public void WhenIEnterTheConfirmPassword()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I click the sign Up button")]
        public void WhenIClickTheSignUpButton()
        {
           // ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
           // ScenarioContext.Current.Pending();
        }
    }
}
