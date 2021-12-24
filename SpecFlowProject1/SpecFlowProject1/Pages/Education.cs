using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowProject1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject1.PageObjects
{
    class Education
    {

        private IWebDriver driver;

        public void AddNewEducationBtn(IWebDriver driver)
        {
            // Click on the "Add new" button of certification
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div", 4);
            IWebElement certBtn = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            certBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetNotification(IWebDriver driver)
        {
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//div[@class='ns-box-inner']", 4);
            IWebElement Notification = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return Notification.Text;
        }

        public void AddInvalidEducation1(IWebDriver driver, string UniversityName, string CountryUniversity, string GraduationYear)
        {
            this.driver = driver;

            // Identify the university name textbox and enter valid university name
            WaitHelpers.WaitForElementPresent(driver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();

            //UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddEducation(IWebDriver driver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.driver = driver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(driver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            //UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(driver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(driver, "Name", "degree", 2);
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            //degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public void AddEducation2(IWebDriver driver, string UniversityName, string CountryUniversity, string Title, string Degree, string SecondGraduationYear)
        {
            this.driver = driver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(driver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(driver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(driver, "Name", "degree", 2);
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(SecondGraduationYear);

            // Click on "Add" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Add']", 5);
            IWebElement addBtn = driver.FindElement(By.XPath("//input[@value='Add']"));
            addBtn.Click();
        }

        public string GetCountryUni(IWebDriver driver)
        {
            IWebElement countryUni1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
            return countryUni1.Text;
        }

        public string GetUniversityName(IWebDriver driver)
        {
            IWebElement universityName1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
            return universityName1.Text;
        }

        public string GetTitle(IWebDriver driver)
        {
            IWebElement title1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
            return title1.Text;
        }

        public string GetDegree(IWebDriver driver)
        {
            IWebElement degree1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
            return degree1.Text;
        }

        public string GetGraduationYear(IWebDriver driver)
        {
            IWebElement graduationYear1 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));
            return graduationYear1.Text;
        }

        public void EditEducationBtn(IWebDriver driver)
        {
            // Click on edit pen icon of the language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i", 4);
            IWebElement certPenIcon = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            certPenIcon.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public void EditEducation(IWebDriver driver, string UniversityName, string CountryUniversity, string Title, string Degree, string GraduationYear)
        {
            this.driver = driver;

            // Identify the university name textbox enter valid university name
            WaitHelpers.WaitForElementPresent(driver, "Name", "instituteName", 2);
            IWebElement UniversityNameTextBox = driver.FindElement(By.Name("instituteName"));
            UniversityNameTextBox.Click();
            UniversityNameTextBox.Clear();
            UniversityNameTextBox.SendKeys(UniversityName);

            // Identify the country of university from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "country", 2);
            SelectElement levelDDList = new SelectElement(driver.FindElement(By.Name("country")));
            levelDDList.SelectByValue(CountryUniversity);

            // Identify the title from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "title", 2);
            SelectElement levelDDList1 = new SelectElement(driver.FindElement(By.Name("title")));
            levelDDList1.SelectByValue(Title);

            // Identify the degree textbox enter valid degree
            WaitHelpers.WaitForElementPresent(driver, "Name", "degree", 2);
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.Click();
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(Degree);

            // Identify the graduation year from the dropdown list
            WaitHelpers.WaitForElementPresent(driver, "Name", "yearOfGraduation", 2);
            SelectElement levelDDList2 = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            levelDDList2.SelectByValue(GraduationYear);

            // Click on "Update" button
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "//input[@value='Update']", 5);
            IWebElement updateBtn = driver.FindElement(By.XPath("//input[@value='Update']"));
            updateBtn.Click();
        }

        public void DeleteEducationBtn(IWebDriver driver)
        {
            // Click on the "Delete" button of language
            WaitHelpers.WaitForElementToBeClickable(driver, "XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i", 4);
            IWebElement deleteBtn = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            deleteBtn.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string GetCountryUni2(IWebDriver driver)
        {
            IWebElement countryUni2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[1]"));
            return countryUni2.Text;
        }

        public string GetUniversityName2(IWebDriver driver)
        {
            IWebElement universityName2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[2]"));
            return universityName2.Text;
        }

        public string GetTitle2(IWebDriver driver)
        {
            IWebElement title2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[3]"));
            return title2.Text;
        }

        public string GetDegree2(IWebDriver driver)
        {
            IWebElement degree2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[4]"));
            return degree2.Text;
        }

        public string GetGraduationYear2(IWebDriver driver)
        {
            IWebElement graduationYear2 = driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[5]"));
            return graduationYear2.Text;
        }
    }
}
