using AventStack.ExtentReports;
using NUnit.Framework;
using NUnitCourse.BaseClass;
using NUnitCourse.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace NUnitCourse.TestScripts
{
    [TestFixture]
    public class Module1 : BaseTest
    {
        [Test, Category("PracticePage")]
        public void TestRadios()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //Se crea objeto PracticePage y se le envia el driver que heredamos de BaseTest
                var PracticePage = new PracticePage(driver);
                PracticePage.radio1.Click();
                Assert.IsTrue(PracticePage.radio1.Selected);
                PracticePage.radio2.Click();
                Assert.IsTrue(PracticePage.radio2.Selected);
                PracticePage.radio3.Click();
                Assert.IsTrue(PracticePage.radio3.Selected);
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
        [Test, Category("PracticePage")]
        public void TestAutocomplete()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //Se crea objeto PracticePage y se le envia el driver que heredamos de BaseTest
                var PracticePage = new PracticePage(driver);
                PracticePage.Textfield.SendKeys("Cos");
                Thread.Sleep(500);
                foreach (var pais in PracticePage.Dropdown)
                {
                    string nombre = pais.GetAttribute("innerText");
                    if (nombre == "Costa Rica")
                    {
                        pais.Click();
                        break;
                    }
                }
                string valor = PracticePage.Textfield.GetAttribute("value");
                Assert.IsTrue(valor == "Costa Rica");
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {

                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
        [Test, Category("PracticePage")]
        public void TestCheckboxes()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //Se crea objeto PracticePage y se le envia el driver que heredamos de BaseTest
                var PracticePage = new PracticePage(driver);
                PracticePage.Checkbox1.Click();
                PracticePage.Checkbox2.Click();
                PracticePage.Checkbox3.Click();
                Assert.IsTrue(PracticePage.Checkbox1.Selected);
                Assert.IsTrue(PracticePage.Checkbox2.Selected);
                Assert.IsTrue(PracticePage.Checkbox3.Selected);
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
    }
}
