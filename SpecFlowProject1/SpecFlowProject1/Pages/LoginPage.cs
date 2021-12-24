using OpenQA.Selenium;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.PageObjects
{
    class LoginPage 
    {

        public void GoToHomePage(IWebDriver driver)
        {
            // Launch turn up portal and maximize window
            driver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
        }

        public void ClickSignInBtn(IWebDriver driver)
        {
            // Identify Sign In button and click
            //WaitHelpers.WaitForElementToBeClickable(testDriver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            loginButton.Click();
        }

        public void KeyInCredentials1(IWebDriver driver, string Email, string Password)
        {
            // Identify the email textbox enter valid email
            WaitHelpers.WaitForElementPresent(driver, "Name", "email", 2);
            IWebElement emailTextBox = driver.FindElement(By.Name("email"));
            emailTextBox.SendKeys(Email);

            // Identify password textbox enter valid password
            WaitHelpers.WaitForElementPresent(driver, "Name", "password", 2);
            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            passwordTextBox.SendKeys(Password);
        }

        public void ClickLoginBtn(IWebDriver driver)
        {
            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 2);
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }

        public void LoginPageSteps(IWebDriver driver)
        {
            // Launch turn up portal and maximize window
            driver.Navigate().GoToUrl(ConstantHelpers.BaseUrl);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);

            // Identify Sign In button and click
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//*[@id='home']/div/div/div[1]/div/a", 2);
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            loginButton.Click();

            // Identify the email textbox enter valid email
            //WaitHelpers.WaitForElementPresent(testDriver, "Name", "email", 2);
            IWebElement emailTextBox = driver.FindElement(By.Name("email"));
            string Email = "jlfuturistictech@hotmail.com";
            emailTextBox.SendKeys(Email);

            // Identify password textbox enter valid password
            //WaitHelpers.WaitForElementPresent(testDriver, "Name", "password", 2);
            IWebElement passwordTextBox = driver.FindElement(By.Name("password"));
            string Password = "JialeQA2021";
            passwordTextBox.SendKeys(Password);

            // Identify login button and click
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[4]/button", 3);
            IWebElement loginBtn = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginBtn.Click();
        }
    }
}
