using NUnit.Framework;
using NUnitCourse.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse
{
    [TestFixture]
    public class DataDrivenTesting
    {
        [Test]
        [TestCaseSource("Environment")] //Recibe la lista de abajo
        public void TestCheckboxes(string url)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Url = url;
            IWebElement checkbox1 = Driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));
            checkbox1.Click();
            IWebElement checkbox2 = Driver.FindElement(By.XPath("//input[@id='checkBoxOption2']"));
            checkbox2.Click();
            IWebElement checkbox3 = Driver.FindElement(By.XPath("//input[@id='checkBoxOption3']"));
            checkbox3.Click();
            Assert.IsTrue(checkbox1.Selected);
            Assert.IsTrue(checkbox2.Selected);
            Assert.IsTrue(checkbox3.Selected);
            Driver.Close();
        }
        //Parametros que se pueden enviar al metodo TestCheckboxes
        static IList Environment()
        {
            ArrayList lista = new ArrayList();
            lista.Add("https://rahulshettyacademy.com/AutomationPractice/");
            lista.Add("https://www.rahulshettyacademy.com/#/index");
            lista.Add("https://www.rahulshettyacademy.com/#/mentorship");
            return lista;
        }

        private static object BrowserUtility()
        {
            throw new NotImplementedException();
        }
    }
}
