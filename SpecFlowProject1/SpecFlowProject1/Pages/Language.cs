using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.PageObjects
{
    class Language
    {
        private IWebDriver driver;

        public void AddNewLanguageBtn(IWebDriver driver)
        {
            // Click on the "Add new" button of language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 4);
            IWebElement languageBtn = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            languageBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver driver)
        {
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidLanguage1(IWebDriver driver)
        {
            this.driver = driver;

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddInvalidLanguage2(IWebDriver driver, string Level)
        {
            this.driver = driver;

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddInvalidLanguage3(IWebDriver driver, string Language)
        {
            this.driver = driver;

            WaitHelpers.WaitForElementPresent(driver, "Name", "name", 2);
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddLanguage(IWebDriver driver, string Language, string Level)
        {
            this.driver = driver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(driver, "Name", "name", 2);
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.Click();
            //languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddLanguage2(IWebDriver driver, string Language, string SecondLevel)
        {
            this.driver = driver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(driver, "Name", "name", 2);
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(SecondLevel);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetLanguage(IWebDriver driver)
        {
            IWebElement language1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            return language1.Text;
        }

        public string GetLevel(IWebDriver driver)
        {
            IWebElement level1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            return level1.Text;
        }

        public void EditNewLanguageBtn(IWebDriver driver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i", 4);
            IWebElement languagePenIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            languagePenIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditLanguage(IWebDriver driver, string Language, string Level)
        {
            this.driver = driver;

            // Identify the language textbox enter valid language
            WaitHelpers.WaitForElementPresent(driver, "Name", "name", 2);
            IWebElement languageTextBox = driver.FindElement(By.Name("name"));
            languageTextBox.Click();
            languageTextBox.Clear();
            languageTextBox.SendKeys(Language);

            // Identify the level from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "level", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("level")));
            levelDDList.SelectByValue(Level);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteNewLanguageBtn(IWebDriver driver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i", 4);
            IWebElement languageBtn = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            languageBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetLanguage2(IWebDriver driver)
        {
            IWebElement language2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
            return language2.Text;
        }

        public string GetLevel2(IWebDriver driver)
        {
            IWebElement level2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[2]"));
            return level2.Text;
        }
    }
}
