using OpenQA.Selenium;
using Selenium_Specflow_POC.src.main.selenium.baseItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_POC.src.main.selenium.pages
{
    internal class SearchResultsPage : BasePage
    {
        public By resultsLocator = By.XPath("//a[@href]//h3");

        public SearchResultsPage(IWebDriver driver) : base(driver) 
        {
            this.driver = driver;
        }

        public Boolean VerifyResultsContains(String text) 
        {
            Boolean flag = false;
            IList<IWebElement> results = driver.FindElements(resultsLocator);

            foreach (IWebElement element in results)
            {
                if (element.Text.Equals(text))
                {
                    flag= true;
                }
            }

            return flag;
        }

        public String getPageURL()
        {
            return driver.Url;
        }
    }
}
