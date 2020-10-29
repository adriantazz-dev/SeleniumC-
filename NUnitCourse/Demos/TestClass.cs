using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnitCourse.BaseClass;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace NUnitCourse
{   [TestFixture]
    public class Tests : BaseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test, Category("Smoke testing")]
        public void TestRadios()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //se crea un WebElement donde se guarda el radio1 para luego darle click
                IWebElement radio1 = driver.FindElement(By.CssSelector("input[Value='radio1']"));
                radio1.Click();
                IWebElement radio2 = driver.FindElement(By.CssSelector("input[Value='radio2']"));
                radio2.Click();
                IWebElement radio3 = driver.FindElement(By.CssSelector("input[Value='radio3']"));
                radio3.Click();
                Assert.IsTrue(radio1.Selected);
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
        [Test, Category("Regression")]
        public void TestAutocomplete()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                IWebElement textfield = driver.FindElement(By.CssSelector("input[id='autocomplete']"));
                textfield.SendKeys("Cos");
                //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
                Thread.Sleep(1000);
                IList<IWebElement> dropdown = driver.FindElements(By.CssSelector("ul[id='ui-id-1'] li div"));
                foreach (var pais in dropdown)
                {
                    string nombre = pais.GetAttribute("innerText");
                    if (nombre == "Costa Rica")
                    {
                        pais.Click();
                        break;
                    }
                }
                string valor = textfield.GetAttribute("value");
                Assert.IsTrue(valor == "Costa Rica");
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
        [Test, Category("Smoke testing")]
        public void TestCheckboxes()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //se crea un WebElement donde se guarda el radio1 para luego darle click
                IWebElement checkbox1 = driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));
                checkbox1.Click();
                IWebElement checkbox2 = driver.FindElement(By.XPath("//input[@id='checkBoxOption2']"));
                checkbox2.Click();
                IWebElement checkbox3 = driver.FindElement(By.XPath("//input[@id='checkBoxOption3']"));
                checkbox3.Click();
                Assert.IsTrue(checkbox1.Selected);
                Assert.IsTrue(checkbox2.Selected);
                Assert.IsTrue(checkbox3.Selected);
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }

        }
        [Test, Category("Smoke testing")]
        public void TestDropdowns()
        {
            //Se crea string para guardar el nombre del metodo para luego usarlo en el report
            string testName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            //Se crea el objeto test
            ExtentTest test = extent.CreateTest(testName).Info("Test started");
            try
            {
                //Se crea un SelectElement para manejar el dropdown
                IWebElement dropdown = driver.FindElement(By.XPath("//select[@id='dropdown-class-example']"));
                SelectElement element = new SelectElement(dropdown);
                element.SelectByText("Option3");
                Assert.AreEqual(element.SelectedOption.GetAttribute("innerText"), "Option3");
                test.Log(Status.Pass, testName + " Passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Error, "Se encontró un error: " + ex.Message);
            }
        }
    }
}