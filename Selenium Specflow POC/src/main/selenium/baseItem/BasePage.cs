﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_POC.src.main.selenium.baseItem

{
    internal class BasePage
    {
        public IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

    }
}