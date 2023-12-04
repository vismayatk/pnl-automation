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
    public class QuotationTestcase : ReportGeneration
    {

        QuotationPages quotationpages;
        [Test]
        [Category("Login")]
        public void quotation_testcase()
        {
            quotationpages = new QuotationPages(GetDriver());
            quotationpages.goToPage();
            quotationpages.enterUserName("demo");
            quotationpages.enterPassword("demo@123");
            quotationpages.clickLoginBtn();

            quotationpages.customerName("dilna");
            quotationpages.number("234234");
            quotationpages.email("vdf@ffv.fdv");


        }
    }
}

