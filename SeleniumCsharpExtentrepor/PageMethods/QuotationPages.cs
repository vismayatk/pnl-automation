using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace SeleniumNUnitExtentReport.PageMethods
{
    class QuotationPages
    {
        private IWebDriver driver;

        //path

        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";
        string sidemenu = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[13]/a/i";
        String quotation = "//*[@id=\"app\"]/div[1]/div[1]/div[2]/div[2]/div[2]/ul/li[12]/a/span/span";
        string newqtn = "//*[@id=\"app\"]/div/div[1]/div[3]/div/div[1]/div/div/div[1]/div/div/button";
        string custmbutton = "//*[@id=\"customer-drop-down\"]/div[1]";
        string addnwcustomer = "//*[@id=\'items-list-customer-drop-down\']/li[3]/a";
        string custmname = "//*[@id=\"cst-name-box\"]";
        string mobno = "//*[@id=\"new-customer-modal\"]/div/form/div/div[2]/div/div[5]/div/div/div/input";
        string cemail = "//*[@id=\"new-customer-modal\"]/div/form/div/div[2]/div/div[6]/div/div/div/input";
        string submit = "//*[@id=\"new-customer-modal\"]/div/form/div/div[3]/button[1]";
        string addnwaddress = "//*[@id=\"app\"]/div[1]/div[1]/div[3]/div/form/div[1]/div/div[1]/div/div[2]/div[2]/div[1]/div/div/button/span";
        string password1 = "//*[@id=\"password-field\"]";
        string confirmpass = "//*[@id=\"confirm-password-field\"]";
        public QuotationPages(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://whatsapp.progbiz.io/");
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


            Thread.Sleep(10000);
            IWebElement qtn = driver.FindElement(By.XPath(sidemenu));

            qtn.Click();
            driver.FindElement(By.XPath(quotation)).Click();
            driver.FindElement(By.XPath(newqtn)).Click();
            driver.FindElement(By.XPath(custmbutton)).Click();

            Thread.Sleep(10000);
            driver.FindElement(By.XPath(addnwcustomer)).Click();

        }

            public void customerName(string text)
            {
                Thread.Sleep(10000);
                driver.FindElement(By.XPath(custmname)).SendKeys(text);

            }
            public void number(string text)
            {
                driver.FindElement(By.XPath(mobno)).SendKeys(text);
            }
            public void email(string text)
            {
                driver.FindElement(By.XPath(cemail)).SendKeys(text);
                driver.FindElement(By.XPath(submit)).Click();
            }
        public void address(string text) 
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath(addnwaddress)).Click(); 

        }
        public void Password(string text)
        {
            driver.FindElement(By.XPath(confirm)).SendKeys(text);    
        }
        public void confirmPassword(string text)
        {
            driver.FindElement(By.XPath()).Click(); 
        }





        
    }
}
