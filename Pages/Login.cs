using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_prac.Pages
{
    public class Login : Selenium_Methods.Selenium_Methods
    {
        //Locating Elements of Login-Page
        By Email =    By.XPath("//input[@type='email']");
        By Password = By.CssSelector("input[type=password]");
        By Click_btn = By.Id("login");

        public void initializeAndGoTo(string url)
        {
            InitializeDriver();
            GoToURL(url);
        }

        public void EnterEmailOnLoginPage(string username)
        {
            WaitForWebElementDisplayed(Email);
            EnterValueinWebElement(Email, username);
        }
        public void EnterPasswordOnLoginPage(string password)
        {
            WaitForWebElementDisplayed(Password);
            EnterValueinWebElement(Password,password);
        }
        public void ClickLoginButtonOnLoginPage()
        {
            WaitForWebElementDisplayed(Click_btn);
            ClickOnWebElement(Click_btn);
        }
       

    }
}
