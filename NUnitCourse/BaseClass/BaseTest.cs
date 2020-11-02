using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnitCourse.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//Para eliminar el error de delete chromedriver: cmd > taskkill /f /im chromedriver.exe
namespace NUnitCourse.BaseClass
{
    public class BaseTest
    {
        //se crea el objeto driver
        public IWebDriver driver;
        public ExtentReports extent;

        [OneTimeSetUp] //[SetUp] = Se ejecuta antes de cada test
        public void Open()
        {
            //Se inicializa el reporter
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter("C:\\Users\\FF_AdrianC\\source\\repos\\Selenium\\NUnitCourse\\ExtentReports\\report.html");
            extent.AttachReporter(htmlReporter);
            //se inicializa el driver
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/angularpractice/";
        }
        [OneTimeTearDown] //[TearDown] = Se ejecuta despues de cada test
        public void Close()
        {
            ITakesScreenshot ts = driver as ITakesScreenshot;
            Screenshot screenshot = ts.GetScreenshot();
            screenshot.SaveAsFile("C:\\Users\\FF_AdrianC\\source\\repos\\Selenium\\NUnitCourse\\ScreenShots\\s1.png", ScreenshotImageFormat.Png);
            extent.Flush();
            driver.Quit();
        }
    }
}
