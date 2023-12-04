using NUnit.Framework;
using RazorEngine.Templating;
using SeleniumCsharpExtentrepor.PageMethods;
using SeleniumNUnitExtentReport.Config;
using SeleniumNUnitExtentReport.PageMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCsharpExtentrepor.TestCases
{
    [TestFixture]
    public class ItemTestcases : ReportGeneration
    {

        ItemPages itempages;


        [Test]
        [Category("Item")]
        public void item_testcase()
        {
            itempages = new ItemPages(GetDriver());
            itempages.goToPage();

            itempages.enterUserName("demo");
            itempages.enterPassword("demo@123");
            itempages.clickLoginBtn();
            itempages.itemBtn();
            // itempages.itemAdd();
            itempages.itemName("Foodbiz");
            itempages.itemCode("fdbiz");
            itempages.itemUnit();
            //itempages.intrataxModal("GST");
            //itempages.addtaxCategory("CGST");
            //itempages.addtaxpercetage("20%");
            itempages.addtaxpercetage();

        }


    }
}
