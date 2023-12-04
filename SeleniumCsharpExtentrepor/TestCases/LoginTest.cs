using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumNUnitExtentReport.Config;
using SeleniumNUnitExtentReport.PageMethods;
using Microsoft.AspNetCore.Hosting;
using AventStack.ExtentReports;
using SeleniumCsharpExtentrepor.PageMethods;
using System.Web.UI.WebControls;

namespace SeleniumNUnitExtentReport.TestCases
{
    [TestFixture]
    public class LoginTest : ReportGeneration
    {
        LoginPage loginPage;

        [Test]
        [Category("Login")]
        public void test_validLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();

            loginPage.enterUserName("demo");
            loginPage.enterPassword("demo@123");
            loginPage.clickLoginBtn();
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();
        }

        [Test]
        [Category("Login")]
        public void test_invalidLogin()
        {
            loginPage = new LoginPage(GetDriver());
            loginPage.goToPage();

            loginPage.enterUserName("vismaya");
            loginPage.enterPassword("vismaya");
            loginPage.clickLoginBtn();
            Assert.IsFalse(loginPage.verifyDashboard());
            Assert.IsTrue(loginPage.verifyDashboard());
            loginPage.closeBrowser();


        }


    }
}
