﻿using NUnit.Framework;
using Selenium_Specflow_POC.src.main.selenium.baseItem;
using Selenium_Specflow_POC.src.main.selenium.pages;
using Selenium_Specflow_POC.src.main.selenium.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Specflow_POC.src.test.tests
{
    [TestFixture]
    internal class LoginTests : BaseTest
    {
        [Test]
        public void LoginToOffice365()
        {
            LoginPage loginPage = new LoginPage(GetDriver());
            HomePage homePage = new HomePage(GetDriver());

            loginPage.NavigateToSignInPage();
            loginPage.login(TestConstants.email, TestConstants.password);
            loginPage.SkipAuth();

            Assert.That(homePage.GetPageHeading(), Is.EqualTo("Welcome to Microsoft 365"));
        }
    }
}
