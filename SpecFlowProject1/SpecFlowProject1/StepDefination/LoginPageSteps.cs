using OpenQA.Selenium.Chrome;
using SpecFlowProject1.PageObjects;
using SpecFlowProject1.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class LoginPageSteps : Hooks
    {

        // Login Page object initialization and definition
        LoginPage loginPageObj = new LoginPage();


        [Given(@"I logged into the mars portal")]
        public void GivenILoggedIntoTheMarsPortal()
        {
            // Open chrome browser
            driver = new ChromeDriver();

            loginPageObj.GoToHomePage(driver);
        }
        
        [Given(@"I click on the sign in button")]
        public void GivenIClickOnTheSignInButton()
        {
            loginPageObj.ClickSignInBtn(driver);

        }
        
        [When(@"I enter valid '(.*)', '(.*)' details")]
        public void WhenIEnterValidDetails(string Email, string Password)
        {
            loginPageObj.KeyInCredentials1(driver, Email, Password);
        }
        
        [Then(@"I navigate to the profile page successfully")]
        public void ThenINavigateToTheProfilePageSuccessfully()
        {
            loginPageObj.ClickLoginBtn(driver);
        }
    }
}
