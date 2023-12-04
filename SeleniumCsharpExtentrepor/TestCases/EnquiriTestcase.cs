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
using System.Security.Cryptography;

namespace SeleniumNUnitExtentReport.TestCases
{
    [TestFixture]
    public class EnquiriTestcase : ReportGeneration
    {

        EnquiriPages enquiriPages;
        [Test]
        [Category("Login")]
        public void enquiry_testcase()
        {
            enquiriPages = new EnquiriPages(GetDriver());
            enquiriPages.goToPage();
            enquiriPages.enterUserName("demo");
            enquiriPages.enterPassword("demo@123");
            enquiriPages.clickLoginBtn();

            enquiriPages.enquirybtn();
            enquiriPages.customerdropdwn();

            //enquiriPages.customerName("Shilpa");
            //enquiriPages.number("9843434");
            //enquiriPages.email("shilpa@gmail.co");

            enquiriPages.itemAdd();
            enquiriPages.itemName();


            //enquiriPages.itemName("Foodbiz");
            //enquiriPages.itemCode("fdbiz");
            //enquiriPages.itemUnit();
            // enquiriPages.addtaxpercetage();



        }

    }
}
