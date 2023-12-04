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

namespace SeleniumNUnitExtentReport.TestCases
{
    [TestFixture]
    public class CustomersTestcase : ReportGeneration
    {
        Enquiry enquiry;



        [Test]
        [Category("Customers")]
        public void add_customers()
        {
            enquiry = new Enquiry(GetDriver());
            enquiry.goToPage();

            enquiry.enterUserName("demo");
            enquiry.enterPassword("demo@123");
            enquiry.clickLoginBtn();


            enquiry.customersBtn();
            enquiry.addCutomBtn();
            enquiry.userName("Deeptha");
            enquiry.contactPerson("1234887899");
            enquiry.savebtn();
            Assert.IsTrue(enquiry.customerView());
            enquiry.closeBrowser();
        }


        [Test]
        [Category("Customers")]
        public void addinvalid_customers()
        {
            enquiry = new Enquiry(GetDriver());
            enquiry.goToPage();

            enquiry.enterUserName("demo");
            enquiry.enterPassword("demo@123");
            enquiry.clickLoginBtn();

            //enquiry.closeBrowser();
            enquiry.customersBtn();
            enquiry.addCutomBtn();
            enquiry.userName("=====");
            enquiry.contactPerson("====");
            enquiry.savebtn();
            Assert.IsTrue(enquiry.customerView());
            enquiry.closeBrowser();
        }
    }
}

