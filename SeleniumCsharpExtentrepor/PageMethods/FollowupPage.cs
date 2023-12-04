using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumCsharpExtentrepor.PageMethods
{
    class  FollowupPage
    {
        private IWebDriver driver;

        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";
        string followupPage = "//*[@id=\"app\"]/div/div[1]/div[2]/div[2]/div[2]/ul/li[10]/a/span/span";
        string sidemenu = "//*[@id=\'app\']/div/div[1]/div[2]/div[2]/div[2]/ul/li[13]/a/i";
        string customer1 = "//*[@id=\"app\"]/div/div[1]/div[3]/div/div[1]/div/div/div[2]/table/tbody/tr[1]/td[2]";
        string followupbtn = "//*[@id=\"app\"]/div[1]/div[1]/div[3]/div/div[1]/div/div[2]/div[1]/div/a[2]";


        public FollowupPage(IWebDriver driver)
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
            driver.FindElement(By.XPath(sidemenu)).Click();
            driver.FindElement(By.XPath(followupPage)).Click();
            driver.FindElement(By.XPath(customer1)).Click();
            driver.FindElement(By.XPath(followupbtn)).Click();




        }


    }
}