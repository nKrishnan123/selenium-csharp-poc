using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium_Specflow_POC.src.main.selenium.baseItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_POC.src.main.selenium.pages
{
    internal class LoginPage : BasePage
    {

        public By signInIcon = By.XPath("//*[@id='meControl']//*[text()='Sign in']");
        public By emailTxtBox = By.XPath("//*[@name='loginfmt']");
        public By nextButton = By.XPath("//*[@value='Next']");
        public By pwdTxtBox = By.XPath("//*[@name='passwd']");
        public By signInButton = By.XPath("//*[@value='Sign in']");
        public By askLaterButton = By.XPath("//*[@id='btnAskLater']");
        public By staySignedInButton = By.XPath("//*[@id='idBtn_Back']");

        WebDriverWait wait;

        public LoginPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void NavigateToSignInPage()
        {
            IWebElement eleSignInIcon = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(signInIcon));
            eleSignInIcon.Click();
            
        }

        public void login(string email, string pwd)
        {
            EnterEmail(email);
            EnterPassword(pwd);
        }

        public void EnterEmail(string email)
        {
            IWebElement eleEmail = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(emailTxtBox));

            eleEmail.Click();
            eleEmail.SendKeys(email);
            driver.FindElement(nextButton).Click();
        }

        public void EnterPassword(string pwd)
        {
            IWebElement elePassword = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(pwdTxtBox));
            elePassword.Click();
            elePassword.SendKeys(pwd);
            driver.FindElement(signInButton).Click();
        }

        public void SkipAuth()
        {
            IWebElement eleAskLater = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(askLaterButton));
            eleAskLater.Click();

            IWebElement eleStaySignedIn = wait.Until(
                SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(staySignedInButton));
            eleStaySignedIn.Click();
        }
 
    }
}
