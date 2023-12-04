using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitExtentReport.PageMethods
{
    class LoginPage
    {
        private IWebDriver driver;

        String userID = "//*[@id=\'txtUserName\']";
        String password = "//*[@id=\'Password-toggle\']/input";
        String loginBtn = "//*[@id=\'app\']/div[1]/div/div[2]/div/form/div[1]/div/div/div[4]/button";
        String menuDashboard = "//*[@id=\"app\"]/div/div[1]/div[3]/div/div[1]/div[1]";

        public LoginPage(IWebDriver driver)
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
        }
        public Boolean verifyDashboard()
        {
            Boolean res = driver.FindElement(By.XPath(menuDashboard)).Displayed;
            return res;
        }
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}