using NUnit.Framework;
using NUnitCourse.BaseClass;
using NUnitCourse.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse
{
    public class Attributes
    {
        //uso de diferentes browsers y ejecutar tests en order personalizado
        IWebDriver driver;

        [Test, Order(3), Category("OrderSkipAttribute")]
        [Author("Adrian", "adriantazz@gmail.com")]
        [Description("Description")]
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
        [Test, Order(2), Category("OrderSkipAttribute")]
        public void TestCheckboxes2()
        {
            var Driver = new BrowserUtility().InitF(driver);
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
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestCheckboxes3()
        {
            Assert.Ignore("IE sucks"); //Para hacer skip de este test
            var Driver = new BrowserUtility().InitI(driver);
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
