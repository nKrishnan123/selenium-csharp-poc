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
    internal class HomePage : BasePage
    {
        public By headingTxt = By.XPath("//*[@id='hero-heading']");
        public By appPageIcon = By.XPath("//span[text()='Apps']");

        WebDriverWait wait;

        public HomePage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public string GetPageHeading()
        {
            IWebElement eleHeading = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(headingTxt));
            return eleHeading.Text;
        }

        public void NavigateToAppPage()
        {
            driver.FindElement(appPageIcon).Click();
        }
    }
}
