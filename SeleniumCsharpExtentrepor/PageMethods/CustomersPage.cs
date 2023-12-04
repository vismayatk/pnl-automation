using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumCsharpExtentrepor.PageMethods
{
    class Enquiry
    {
        private IWebDriver driver;


        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";
        String menuDashboard = "//*[@id=\"app\"]/div/div[1]/div[3]/div/div[1]/div[1]";
        String customerbtn = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[13]/a/span/span";
        string sidemenu = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[13]/a/i";
        String addcutomerBtn = "//*[@id=\'app\']/div/div[1]/div[3]/div/div[1]/div/div/div[1]/div/div/button";
        string getUserName = "//*[@id=\'cst-name-box\']";
        string contact = "//*[@id=\"app\"]/div/div[1]/div[3]/div/form/div[1]/div/div/div/div[2]/div[5]/div/div/div/input";
        string save = "//*[@id=\"app\"]/div/div[1]/div[3]/div/form/div[2]/button[1]";
        string customerview = "//*[@id=\"app\"]/div/div[1]/div[3]/div/div[1]/div/div[2]/div[2]/div/div/div/div/div[2]";

        public Enquiry(IWebDriver driver)
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
        //public Boolean verifyDashboard()
        //{
        //    Boolean res = driver.FindElement(By.XPath(menuDashboard)).Displayed;
        //    return res;
        //}
       
        public void customersBtn( )
        { 
            driver.FindElement(By.XPath(sidemenu)).Click();
            driver.FindElement(By.XPath(customerbtn)).Click();
           
        }

        public void addCutomBtn()
        {
            driver.FindElement(By.XPath(addcutomerBtn)).Click();

        }
        public void userName(String text)
        {
            driver.FindElement(By.XPath(getUserName)).SendKeys(text);
        }
        public void contactPerson(String text)
        {
            driver.FindElement(By.XPath(contact)).SendKeys(text);
        }
        public void savebtn( )
        {
            driver.FindElement(By.XPath(save)).Click();
        }
        public Boolean customerView()
        {
            Boolean res = driver.FindElement(By.XPath(customerview)).Displayed;
            return res;
        }
        public void closeBrowser()
        {
             driver.Quit();
        }
    }
}
