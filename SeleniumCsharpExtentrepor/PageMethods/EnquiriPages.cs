using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace SeleniumNUnitExtentReport.PageMethods
{
    class EnquiriPages
    {
        private IWebDriver driver;

        //path


        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";
        String enquiry = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[11]/a/span/span";
        string sidemenu = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[13]/a/i";
        string enqbtn = "//*[@id=\'app\']/div/div[1]/div[3]/div/div[1]/div/div/div[1]/div/div/button[2]";
        string lead = "//*[@id=\'lead-quality-select\']";
        string cold = "//*[@id=\'lead-quality-select\']/option[4]";
        string customer = "//*[@id=\'enquiry-customer-drop-down-select\']/div[1]";
        string addcustomer = "//*[@id=\'items-list-enquiry-customer-drop-down-select\']/li[3]/a";
        string vivek = "//*[@id=\"list-item-852\"]/a";
        string custmname = "//*[@id=\"cst-name-box\"]";
        string mobno = "//*[@id=\'new-customer-modal\']/div/form/div/div[2]/div/div[5]/div/div/div/input";
        string cemail = "//*[@id=\'new-customer-modal\']/div/form/div/div[2]/div/div[6]/div/div/div/input";
        string submit = "//*[@id=\'new-customer-modal\']/div/form/div/div[3]/button[1]";
        string item = "//*[@id=\"footer-item-select-drop-down\"]/div[1]";
        string additem = "//*[@id=\"items-list-footer-item-select-drop-down\"]/li[3]/a";
        string itemname = "//*[@id=\"item-name-text-box\"]";
        string itemcode = "//*[@id=\"item-code-text-box\"]";
        string unint = "//*[@id=\"new-item-modal\"]/div/div/div[2]/form[2]/div[1]/div/div/div/div[1]";
        string box = "//*[@id=\"list-item-104\"]/a";
        string size = "//*[@id=\'new-item-modal\']/div/div/div[2]/form[2]/div[3]/div/div/div/div[1]";
        string itemsize = "//*[@id=\"items-list-\"]/li[3]/a";
        string saves = "//*[@id=\"new-item-modal\"]/div/div/div[3]/button[1]";
        string add = "//*[@id=\"footer-add-button\"]/i";
        string rmail = "//*[@id=\"assignee-1353\"]";
        string saving = "//*[@id=\"app\"]/div[1]/div[1]/div[3]/div/form/div[2]/button[1]";
        string keralapkg = "//*[@id=\"list-item-213\"]/a";



        public EnquiriPages(IWebDriver driver)
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

        public void enquirybtn()
        {
            driver.FindElement(By.XPath(sidemenu)).Click();
            driver.FindElement(By.XPath(enquiry)).Click();

            IWebElement enqry = driver.FindElement(By.XPath(enqbtn));
            //Actions actions = new Actions(driver);
            //actions.MoveToElement(enqry).Perform();
            //System.Threading.Thread.Sleep(500);
            enqry.Click();
            //driver.FindElement(By.XPath(cold)).Click();

        }

        public void customerdropdwn()
        {
            IWebElement custmr = driver.FindElement(By.XPath(customer));
            Actions actions = new Actions(driver);
            actions.MoveToElement(custmr).Perform();
            System.Threading.Thread.Sleep(500);
            custmr.Click();
            //driver.FindElement(By.XPath(addcustomer)).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(vivek)).Click();
        }

        //-----adding customer in enquiry page-----//


        //public void customerName(string text)
        //{
        //    Thread.Sleep(10000);
        //    driver.FindElement(By.XPath(custmname)).SendKeys(text);

        //}
        //public void number(string text)
        //{
        //    driver.FindElement(By.XPath(mobno)).SendKeys(text);
        //}
        //public void email(string text)
        //{
        //    driver.FindElement(By.XPath(cemail)).SendKeys(text);
        //    driver.FindElement(By.XPath(submit)).Click();
        //}


        //-----item new item adding in enquiry page-------// 


        public void itemAdd()
        {
            IWebElement items = driver.FindElement(By.XPath(item));
            Actions actions = new Actions(driver);
            actions.MoveToElement(items).Perform();
            System.Threading.Thread.Sleep(500);
            items.Click();
            //driver.FindElement(By.XPath(additem)).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(keralapkg)).Click();

        }


        //public void itemName(string text)
         public void itemName()
        {
            //    driver.FindElement(By.XPath(itemname)).SendKeys(text);
            //}

            //public void itemCode(string text)
            //{
            //    driver.FindElement(By.XPath(itemcode)).SendKeys(text);
            //}
            //public void itemUnit()
            //{

            //    IWebElement dropdownMenu = driver.FindElement(By.XPath(unint));
            //    Actions actions = new Actions(driver);
            //    actions.MoveToElement(dropdownMenu).Perform();
            //    System.Threading.Thread.Sleep(500);
            //    dropdownMenu.Click();
            //    driver.FindElement(By.XPath(box)).Click();
            //driver.FindElement(By.XPath(saves)).Click();



            driver.FindElement(By.XPath(add)).Click();
            driver.FindElement(By.XPath(rmail)).Click();

            IWebElement enqrysave = driver.FindElement(By.XPath(saving));
            Actions actions = new Actions(driver);
            actions.MoveToElement(enqrysave).Perform();
            Thread.Sleep(500);
            enqrysave.Click();

        }


        
    }

         //-------taxcategory field for new item------//


    //public void addtaxpercetage()
    //{
    //    //Thread.Sleep(10000);
    //    //driver.FindElement(By.Id(taxpercentage)).SendKeys(text);
    //    //driver.FindElement(By.XPath(submit)).Click();



    //    IWebElement sizes = driver.FindElement(By.XPath(size));
    //    Actions actions = new Actions(driver);
    //    actions.MoveToElement(sizes).Perform();
    //    System.Threading.Thread.Sleep(500);
    //    sizes.Click();
    //    driver.FindElement(By.XPath(itemsize)).Click();

    //    // driver.FindElement(By.XPath(sellingprice)).SendKeys(text);
    //    driver.FindElement(By.XPath(save)).Click();

    //}
}
