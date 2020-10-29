using NUnit.Framework;
using NUnitCourse.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)] //Nos permite hacer tests en paralelo
    class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestCheckboxes()
        {
            var Driver = new BrowserUtility().InitC(driver);
            //se crea un WebElement donde se guarda el radio1 para luego darle click
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
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestCheckboxes2()
        {
            var Driver = new BrowserUtility().InitC(driver);
            //se crea un WebElement donde se guarda el radio1 para luego darle click
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
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestCheckboxes3()
        {
            var Driver = new BrowserUtility().InitC(driver);
            //se crea un WebElement donde se guarda el radio1 para luego darle click
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
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestCheckboxes4()
        {
            var Driver = new BrowserUtility().InitC(driver);
            //se crea un WebElement donde se guarda el radio1 para luego darle click
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
    }
}
