using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;

namespace NUnitCourse.PageObjects
{
    public class PracticePage
    {
        IWebDriver driver;
        //Constructor donde se le asigna el driver que recibimos como parametro a nuestro driver variable de clase
        public PracticePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Atributos
        #region Radios
        [FindsBy(How = How.CssSelector, Using = "input[Value='radio1']")]
        public IWebElement radio1 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[Value='radio2']")]
        public IWebElement radio2 { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[Value='radio3']")]
        public IWebElement radio3 { get; set; }
        #endregion

        #region CheckBoxes
        [FindsBy(How = How.XPath, Using = "//input[@id='checkBoxOption1']")]
        public IWebElement Checkbox1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='checkBoxOption2']")]
        public IWebElement Checkbox2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='checkBoxOption3']")]
        public IWebElement Checkbox3 { get; set; }
        #endregion

        #region Autocomplete
        [FindsBy(How = How.CssSelector, Using = "input[id = 'autocomplete']")]
        public IWebElement Textfield { get; set; }

        [FindsBy(How = How.CssSelector, Using = "ul[id='ui-id-1'] li div")]
        public IList<IWebElement> Dropdown { get; set; }
        #endregion

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Home')]")]
        public IWebElement HomePage { get; set; }

        //Metodos
        public void NavigateToHomePage()
        {
            //instrucciones para ir a siguiente pagina
            HomePage.Click();
        }
    }
}
