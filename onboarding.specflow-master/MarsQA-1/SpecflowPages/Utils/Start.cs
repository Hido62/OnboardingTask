using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;
using RelevantCodes.ExtentReport;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {
        public object LogStatus { get; private set; }

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(@"D:\MarsQA-1OnboardingTask\OnboardingTask\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Mars.xlsx", "Credentials");

            //call the SignIn class
            SignIn.SigninStep();
            //ExtentReports();
            //test = Extent.StartTest("index");
        }

        //private void ExtentReports()
        //{
        //    throw new NotImplementedException();
        //}

        [Test]
        public void CreateLanguage()
        {
            LanguagePage languageObj = new LanguagePage();
            languageObj.CreateLanguage();

            languageObj.UpdateLanguage();

            languageObj.Deletelanguage();

        }

      

        


        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCaptureFromPath(img));

            //Close the browser
            Close();

            // end test. (Reports)
            Extent.EndTest(test);

            //calling Flush writes everything to the log file (Reports)
            Extent.Flush();


        }
    }
}
