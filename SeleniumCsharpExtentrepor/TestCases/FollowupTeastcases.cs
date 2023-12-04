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
using NUnit.Framework;

namespace SeleniumNUnitExtentReport.TestCases
{
    [TestFixture]
    public class FollowupTestcase : ReportGeneration
    {

        FollowupPage followupPage;
        [Test]
        [Category("Followup")]
        public void followup_testcase()
        {
            followupPage = new FollowupPage(GetDriver());
            followupPage.goToPage();
            followupPage.enterUserName("demo");
            followupPage.enterPassword("demo@123");
            followupPage.clickLoginBtn();
           
        }
    }
}
