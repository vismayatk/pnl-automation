using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumNUnitExtentReport.PageMethods
{
    class Registrationpage
    {
        private IWebDriver driver;

        //path

        String signup = "//*[@id=\"app\"]/div[1]/div/div[2]/div/form/div[1]/div/div/div[5]/p/a";
        string companyname = "//*[@id=\"app\"]/div[1]/div/div/div/div[1]/div/div/div/div[1]/form/div/div[1]/div[1]/input";
        string clientname = "//*[@id=\"app\"]/div[1]/div/div/div/div[1]/div/div/div/div[1]/form/div/div[3]/div[1]/input";
        string email = "//*[@id=\"app\"]/div[1]/div/div/div/div[1]/div/div/div/div[1]/form/div/div[3]/div[1]/input";
        string country = "//*[@id=\"customer-country-drop-down-select\"]/div[1]";
        string searchcountry = "//*[@id=\"dropdown-search-box-customer-country-drop-down-select\"]";
        string india = "//*[@id=\"list-item-101\"]/a";
        string mobno = "//*[@id=\"app\"]/div[1]/div/div/div/div[1]/div/div/div/div[1]/form/div/div[6]/div/div[1]/input";

        public Registrationpage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://test.pnl.progbiz.io");
        }

        public void registerBtn()
        {
            driver.FindElement(By.XPath(signup)).Click();
           
        }  
        public void companyName(string text)
        {
            driver.FindElement(By.XPath(companyname)).SendKeys(text);
        }
        public void clientName(string text)
        {
            driver.FindElement(By.XPath(clientname)).SendKeys(text);
        }
        public void clientEmail(string text)
        {
            driver.FindElement(By.XPath(email)).SendKeys(text);
            
        }
        public void CountryAdd(string text) 
        {
            driver.FindElement(By.XPath(country)).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(searchcountry)).SendKeys(text);
            driver.FindElement(By.XPath(india)).Click();

        }
        public void MobileNumber(string text)
        {
            driver.FindElement(By.XPath(mobno)).SendKeys(text);
        }
    }
}
