using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class Login 

    {
        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            // ScenarioContext.Current.Pending();
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();

        }

        [Given(@"I am on the language tab")]
        public void GivenIAmOnTheLanguageTab()
        {
            //ScenarioContext.Current.Pending();
            //Locate and click on Language tab
            Driver.driver.FindElement(By.XPath("(//th[@class='right aligned']/div)[1]")).Click();

            //Locate the language textbox and add the language
           // Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='name']")).SendKeys("Edo");
        }

        [Given(@"I enter my details")]
        public void GivenIEnterMyDetails()
        {
            //ScenarioContext.Current.Pending();

            //identify "add language" tab and enter language choice
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='name']")).SendKeys("English");

            //identify the "Choose language level" dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")).Click();
                     

            //select the language level and click
            Driver.driver.FindElement(By.XPath("//select/option[5]")).Click();
            
        }

        [When(@"I click on the add new button")]
        public void WhenIClickOnTheAddNewButton()
        {
            //ScenarioContext.Current.Pending();
            Driver.driver.FindElement(By.XPath("//input[@type= 'button' and @class='ui teal button']")).Click();

        }

        [Then(@"My details should be successfully added")]
        public void ThenMyDetailsShouldBeSuccessfullyAdded()
        {
            ScenarioContext.Current.Pending();
        }



    }
}
