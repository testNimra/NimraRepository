using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SpecFlowProject_prac.Pages
{
    public class TransactionProcesses :Selenium_Methods.Selenium_Methods
    {
        By AddTransactionProcessesElement = By.CssSelector("button[title='Add Transaction Process']");
        By NameElement = By.CssSelector("[ng-model='newSetup\\.description']");
        By TypeElement = By.XPath("/html//div[@id='addSubmissionSetup']//form[@name='addProcessSubmissionForm']/div[2]/select");
        By GLReferenceElement = By.CssSelector("select[name='source']");
        By WorkflowsElement = By.CssSelector(" div.dropdown");
        By SaveButtonElement = By.CssSelector(".btn.btn-info > span:nth-of-type(1)");
        By liElement = By.CssSelector(" [multiple] .dropdown-menu li");

        public void ClickAddTransactionProcessesElementOnTransactionProcessPage()
        {
            WaitForWebElementDisplayed(AddTransactionProcessesElement);
            ClickOnWebElement(AddTransactionProcessesElement);
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public string GLReference { get; set; }
        public string  Workflows { get; set; }

        public void EnterNameOnAddProcessTransactionSetupDialog(string name)
        {
            WaitForWebElementDisplayed(NameElement);
            EnterValueinWebElement(NameElement, name);
        }
        public void SelectTypeOnAddProcessTransactionSetupDialog(string typevalue)
        {
            WaitForWebElementDisplayed(TypeElement);
            ClickOnWebElement(TypeElement);
            SelectElement select = new SelectElement(driver.FindElement(TypeElement));
            select.SelectByText(typevalue);
        }
        public void SelectGLReferenceOnAddProcessTransactionSetupDialog(string GLvalue)
        {
            WaitForWebElementDisplayed(GLReferenceElement);
            ClickOnWebElement(GLReferenceElement);
            SelectElement select = new SelectElement(driver.FindElement(GLReferenceElement));
            select.SelectByText(GLvalue);
            ClickOnWebElement(GLReferenceElement);
        }
        public void SelectWorkflowsOnAddProcessTransactionSetupDialog(string workflowvalues)
        {
            WaitForWebElementDisplayed(WorkflowsElement);
            ClickOnWebElement(WorkflowsElement);
            EnterValueinWebElement(WorkflowsElement, workflowvalues);
           
       
        ClickOnWebElement(WorkflowsElement);
          
        }

        public void UserClicksSaveButtonOnAddProcessTransactionSetupDialog()
        {
            ClickOnWebElement(SaveButtonElement);
        }

    }
}
