using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitCourse.PageObjects
{
    public class RegisterPage
    {
        IWebDriver driver;
        //Constructor donde se le asigna el driver que recibimos como parametro a nuestro driver variable de clase
        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //Atributos
        [FindsBy(How = How.CssSelector, Using = "input[name='name']")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name='email']")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[id='exampleInputPassword1']")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[id='exampleCheck1']")]
        public IWebElement IcecreamChecbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name='bday']")]
        public IWebElement DoBField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value='Submit']")]
        public IWebElement SubmitBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[class='alert alert-success alert-dismissible'] strong")]
        public IWebElement SuccessMsg { get; set; }

        [FindsBy(How = How.CssSelector, Using = "select[id='exampleFormControlSelect1']")]
        public IWebElement GenderDropdown { get; set; }

        public void SelectGender(string Gender)
        {
            var GenderDropdown = driver.FindElement(By.CssSelector("select[id='exampleFormControlSelect1']"));
            var selectElement = new SelectElement(GenderDropdown);
            selectElement.SelectByText(Gender);
        }

        public void SelectStatus(string Status)
        {   
            if (Status == "Student")
            {
                driver.FindElement(By.CssSelector("input[id='inlineRadio1']")).Click();
            }
            else if (Status == "Employed")
            {
                driver.FindElement(By.CssSelector("input[id='inlineRadio2']")).Click();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
