using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumCsharpExtentrepor.PageMethods
{
    class ItemPages
    {
        private IWebDriver driver;

        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";

        string item = "//*[@id=\"app\"]/div/div[1]/div[2]/div[2]/div[2]/ul/li[14]/a/span/span";
        string sidemenu = "//*[@id=\"app\"]/div/div[1]/div[2]/div[2]/div[2]/ul/li[14]/a";
        string itemAddBtn = "//*[@id=\'app\']/div/div[1]/div[3]/div/div[1]/div/div/div[1]/div/div/button";
        string itemname = "//*[@id=\"item-name-text-box\"]";
        string itemcode = "//*[@id=\"item-code-text-box\"]";
        string unint = "//*[@id=\"app\"]/div[1]/div[1]/div[3]/div/div[1]/div/div/div/div[2]/form[2]/div[1]/div/div/div/div[1]";
        string pax = "//*[@id=\"list-item-110\"]/a";

        string taxintra = "inter-tax-drop-down";
        string addtax = "//*[@id=\'items-list-inter-tax-drop-down\']/li[2]/a/i";
        string taxcategory = "//*[@id=\'tax-category-text-box\']";
        string Addcategory = "//*[@id=\'tax-category-modal\']/div/form/div/div[2]/div[2]/div/table/tfoot/tr/td[2]/div/button/i";
        string taxcategoryitem = "tax-category-text-box";
        string taxpercentage = "item-um-unit-box";
        string submit = "//*[@id=\'tax-category-item-modal\']/div/form/div/div[3]/button[1]";
        string sellingprice = "//*[@id=\'item-um-unit-box\']";
        string save = "//*[@id=\'app\']/div[1]/div[1]/div[3]/div/div[2]/button";
        string size = "//*[@id=\'app\']/div[1]/div[1]/div[3]/div/div[1]/div/div/div/div[2]/form[2]/div[3]/div/div/div/div[1]";
        string itemsize = "//*[@id=\"app\"]/div[1]/div[1]/div[3]/div/form/div[2]/button[2]";

        public ItemPages(IWebDriver driver)
        {
            this.driver = driver;
        }
        
       
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://test.pnl.progbiz.io/");
        }

        public void enterUserName(string text)
        {
            driver.FindElement(By.XPath(userID)).SendKeys(text);
        }
        public void enterPassword(string text)
        {
            driver.FindElement(By.XPath(password)).SendKeys(text);
        }
        public void clickLoginBtn()
        {
            driver.FindElement(By.XPath(loginBtn)).Click();
        }
        public void itemBtn()
        {
            driver.FindElement(By.XPath(sidemenu)).Click();

            IWebElement element = driver.FindElement(By.XPath(item));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Perform();
            System.Threading.Thread.Sleep(500);
            element.Click();
            driver.FindElement(By.XPath(itemAddBtn)).Click();

        }

        public void itemName(string text)
        {
            driver.FindElement(By.XPath(itemname)).SendKeys(text);
        }

        public void itemCode(string text)
        {
            driver.FindElement(By.XPath(itemcode)).SendKeys(text);
        }
        public void itemUnit()
        {

            IWebElement dropdownMenu = driver.FindElement(By.XPath(unint));
            Actions actions = new Actions(driver);
            actions.MoveToElement(dropdownMenu).Perform();
            System.Threading.Thread.Sleep(500);
            dropdownMenu.Click();
            driver.FindElement(By.XPath(pax)).Click();


            //IWebElement divElement = driver.FindElement(By.Id(taxintra));
            ////divElement.Click();
            //Actions actions1 = new Actions(driver);
            //actions.MoveToElement(divElement).Perform();
            //System.Threading.Thread.Sleep(500);
            //divElement.Click();
            //driver.FindElement(By.XPath(addtax)).Click();

        }

        //public void intrataxModal(string text)
        //{
        //    driver.FindElement(By.XPath(taxcategory)).SendKeys(text);
        //    driver.FindElement(By.XPath(Addcategory)).Click();
        //}
        //public void addtaxCategory(string text)
        //{
            
        //    var element = driver.FindElement(By.Id("my-element-id"));
            
        //}
        public void addtaxpercetage()
        {
            //Thread.Sleep(10000);
            //driver.FindElement(By.Id(taxpercentage)).SendKeys(text);
            //driver.FindElement(By.XPath(submit)).Click();


            
            IWebElement sizes = driver.FindElement(By.XPath(size));
            Actions actions = new Actions(driver);
            actions.MoveToElement(sizes).Perform();
            System.Threading.Thread.Sleep(500);
            sizes.Click();
            driver.FindElement(By.XPath(itemsize)).Click();

            // driver.FindElement(By.XPath(sellingprice)).SendKeys(text);
            driver.FindElement(By.XPath(save)).Click();

        }

        



    }
}




