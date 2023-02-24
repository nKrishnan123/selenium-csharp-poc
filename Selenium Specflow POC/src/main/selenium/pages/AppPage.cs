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
    internal class AppPage : BasePage
    {
        public By allAppsButton = By.XPath("//button[text()='All apps']");
        public By officeAddInsLink = By.XPath("//*[@data-testid='office-365-apps-OfficeStore']");
        public By allAppsAddInLink = By.XPath("//*[@data-testid='allapps-OfficeStore']");
        public By appsHeading = By.XPath("//h1[text()='All apps']");

        WebDriverWait wait;

        public AppPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void ClickAllApps()
        {
            IWebElement eleAllAppsButton = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(allAppsButton));
            eleAllAppsButton.Click();
        }

        public Boolean AreAllAddInOptionsDisplayed()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(appsHeading));
            IWebElement eleOfficeAddIn = driver.FindElement(officeAddInsLink);
            IWebElement eleAllAddIn = driver.FindElement(allAppsAddInLink);

            return eleOfficeAddIn.Displayed && eleAllAddIn.Displayed;
        }

    }
}
