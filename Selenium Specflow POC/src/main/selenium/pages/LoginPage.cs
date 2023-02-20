using OpenQA.Selenium;
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

        public By searchBox = By.XPath("//*[@title='Search']");
        public By searchButton = By.XPath("//div[@class='lJ9FBc']//input[@name='btnK']");
        public By luckyButton = By.XPath("//div[@class='lJ9FBc']//input[@name='btnI']");
        public LoginPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
        }

        public void EnterSearchText(String text)
        {
            driver.FindElement(searchBox).Click();
            driver.FindElement(searchBox).SendKeys(text);
        }

        public void ClickSearch()
        {
            driver.FindElement(searchButton).Click();
        }

        public void ClickLucky()
        {
            driver.FindElement(luckyButton).Click();
        }
 
    }
}
