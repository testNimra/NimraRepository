using Fyp_Arshi.Helper_Functions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject_prac.Pages
{
    public class LoginVerification : Selenium_Methods.Selenium_Methods
    {
        string appUsername = "abdul@finboa.com";
        string emailPassword = "$Pak35tan$2025";
        string otpToken = string.Empty;
        By OTP_Textbox= By.Id("otp");
        By Authenticate_Button = By.ClassName("reply-button");

        public string GetOTP()
        {
            otpToken = HelperFunction.GetEmailAuthenticationCode2(appUsername, emailPassword);
            return otpToken;
        }

        public void EnterOTPOnLoginVerificationDialog(string otpCode)
        {
            WaitForWebElementDisplayed(OTP_Textbox);
            EnterValueinWebElement(OTP_Textbox, otpCode);
        }

        public void ClickAuthenticateButtonOnLoginVerificationDialog()
        {
            WaitForWebElementDisplayed(Authenticate_Button);
            ClickOnWebElement(Authenticate_Button);  
        }
    }
}
