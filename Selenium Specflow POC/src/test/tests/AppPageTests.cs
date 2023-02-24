using NUnit.Framework;
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
    internal class AppPageTests : BaseTest
    {
        [Test]
        public void ViewAllApps()
        {
            LoginPage loginPage = new LoginPage(GetDriver());
            HomePage homePage = new HomePage(GetDriver());
            AppPage appPage = new AppPage(GetDriver());

            loginPage.NavigateToSignInPage();
            loginPage.login(TestConstants.email, TestConstants.password);
            loginPage.SkipAuth();
            homePage.NavigateToAppPage();
            appPage.ClickAllApps();
            Assert.True(appPage.AreAllAddInOptionsDisplayed());
        }
    }
}
