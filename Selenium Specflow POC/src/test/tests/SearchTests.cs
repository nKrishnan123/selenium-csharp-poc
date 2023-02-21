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
    internal class SearchTests : BaseTest
    {
        [Test]
        public void Search()
        {
            LoginPage login = new LoginPage(GetDriver());
            SearchResultsPage searchResults = new SearchResultsPage(GetDriver());

            login.EnterSearchText("Microsoft");
            login.ClickSearch();
            Assert.That(searchResults.VerifyResultsContains("Microsoft – Cloud, Computers, Apps & Gaming"));
        }

        [Test]
        public void ImFeelingLuckyTest()
        {
            LoginPage login = new LoginPage(GetDriver());
            SearchResultsPage searchResults = new SearchResultsPage(GetDriver());

            login.EnterSearchText("Microsoft");
            login.ClickLucky();
            Assert.That(TestConstants.endpoint, Is.EqualTo(searchResults.getPageURL()));
        }
    }
}
