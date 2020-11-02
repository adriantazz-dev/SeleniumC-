using AventStack.ExtentReports;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;
using NUnitCourse.BaseClass;
using NUnitCourse.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse.TestScripts
{  
    [TestFixture]
    public class TestRegisterPage : BaseTest
    {   
        [Test, Category("RegisterPage")]
        public void TestRegistration()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");

            try
            {
                var RP = new RegisterPage(driver);
                RP.NameField.SendKeys("Adrian");
                RP.EmailField.SendKeys("Adrian@test.com");
                RP.PasswordField.SendKeys("12345");
                RP.IcecreamChecbox.Click();
                RP.SelectGender("Male");
                RP.SelectStatus("Student");
                RP.DoBField.SendKeys("03/21/1992");
                RP.SubmitBtn.Click();
                var msg = RP.SuccessMsg.Text;
                Assert.IsTrue(msg == "Success!");
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {

                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
    }
}
