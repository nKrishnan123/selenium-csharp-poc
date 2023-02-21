using Microsoft.VisualBasic;
using NUnit.Framework;
using OpenQA.Selenium;
using Selenium_Specflow_POC.src.main.selenium.factory;
using Selenium_Specflow_POC.src.main.selenium.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_POC.src.main.selenium.baseItem
{
    internal class BaseTest
    {
        protected static ThreadLocal<IWebDriver> tDriver = new ThreadLocal<IWebDriver>();

        protected void SetDriver(IWebDriver driver)
        {
            tDriver.Value = driver;
        }

        public IWebDriver GetDriver()
        {
            return tDriver.Value;
        }

        [SetUp]
        public void StartDriver()
        {
            SetDriver(new DriverManager().InitializeDriver());
            GetDriver().Navigate().GoToUrl(TestConstants.url);
        }

        [TearDown]
        public void QuitDriver() 
        {
            GetDriver().Quit();
        }
    }
}
