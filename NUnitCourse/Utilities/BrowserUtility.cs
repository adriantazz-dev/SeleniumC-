using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse.Utilities
{
    public class BrowserUtility
    {

        public IWebDriver InitC(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Url = driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            return driver;
        }
        public IWebDriver InitF(IWebDriver driver)
        {
            driver = new FirefoxDriver();
            driver.Url = driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            return driver;
        }
        public IWebDriver InitI(IWebDriver driver)
        {
            driver = new InternetExplorerDriver();
            driver.Url = driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            return driver;
        }
    }
}
