using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class LanguagePage 
    {
        public void CreateLanguage()
        {

            //Locate and click on Language add new button
            Driver.driver.FindElement(By.XPath("(//th[@class='right aligned']/div)[1]")).Click();

            //Locate the language textbox and add the language
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='name']")).SendKeys("Edo");
           
            //identify the "Choose language level" dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")).Click();

            //Click on add new button
            Driver.driver.FindElement(By.XPath("")).Click();

            //Identify language level tad and select level

            //Click on the add button

            //Locate the language textbox and add the language
            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='name']")).SendKeys("Edo");

            Driver.driver.FindElement(By.XPath("//input[@type='text' and @name='name']")).SendKeys("English");

            //identify the "Choose language level" dropdown
            Driver.driver.FindElement(By.XPath("//select[@class='ui dropdown' and @name='level']")).Click();


            //select the language level and click
            Driver.driver.FindElement(By.XPath("//select/option[5]")).Click();
        }

        public void UpdateLanguage()
        {

        }

        public void Deletelanguage()
        {

        }
    }
}
