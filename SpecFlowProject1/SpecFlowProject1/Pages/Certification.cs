using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.PageObjects
{
    class Certification
    {

        private IWebDriver driver;

        public void AddNewCertBtn(IWebDriver driver)
        {
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div", 4);
            IWebElement certBtn = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            certBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver driver)
        {
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidCert1(IWebDriver driver, string Certificate, string From)
        {
            this.driver = driver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationName", 2);
            IWebElement certTextBox = driver.FindElement(By.Name("certificationName"));
            certTextBox.Click();

            //certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = driver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();

            //certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddCertification(IWebDriver driver, string Certificate, string From, string Year)
        {
            this.driver = driver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationName", 2);
            IWebElement certTextBox = driver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            //certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = driver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            //certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(Year);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddCertification2(IWebDriver driver, string Certificate, string From, string SecondYear)
        {
            this.driver = driver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationName", 2);
            IWebElement certTextBox = driver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = driver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(SecondYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetCertification(IWebDriver driver)
        {
            IWebElement certification1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            return certification1.Text;
        }

        public string GetFrom(IWebDriver driver)
        {
            IWebElement from1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            return from1.Text;
        }

        public string GetYear(IWebDriver driver)
        {
            IWebElement year1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            return year1.Text;
        }

        public void EditNewCertBtn(IWebDriver driver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i", 4);
            IWebElement certPenIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
            certPenIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditCertification(IWebDriver driver, string Certificate, string From, string Year)
        {
            this.driver = driver;

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationName", 2);
            IWebElement certTextBox = driver.FindElement(By.Name("certificationName"));
            certTextBox.Click();
            certTextBox.Clear();
            certTextBox.SendKeys(Certificate);

            // Identify the certification textbox enter valid certification
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationFrom", 2);
            IWebElement certTextBox1 = driver.FindElement(By.Name("certificationFrom"));
            certTextBox1.Click();
            certTextBox1.Clear();
            certTextBox1.SendKeys(From);

            // Identify the year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "certificationYear", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            levelDDList.SelectByValue(Year);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteNewCertBtn(IWebDriver driver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i", 4);
            IWebElement deleteBtn = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
            deleteBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetCertification2(IWebDriver driver)
        {
            IWebElement certification2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]"));
            return certification2.Text;
        }

        public string GetFrom2(IWebDriver driver)
        {
            IWebElement from2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
            return from2.Text;
        }

        public string GetYear2(IWebDriver driver)
        {
            IWebElement year2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[3]"));
            return year2.Text;
        }
    }
}
