
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
    public class RegistrationTestcases : ReportGeneration
    {

        Registrationpage registrationpage;
        [Test]
        [Category("signin")]
        public void test_signup()
        {
            registrationpage = new Registrationpage(GetDriver());
            registrationpage.goToPage();
            registrationpage.registerBtn();
            registrationpage.companyName("surya silks");
            registrationpage.clientName("test@gamil.co");
            registrationpage.CountryAdd("india");
            registrationpage.MobileNumber("9747832341");
            

        }
    }
}
