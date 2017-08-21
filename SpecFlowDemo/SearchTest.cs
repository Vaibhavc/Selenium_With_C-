using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecFlowDemo
{
    [TestFixture]
    public class GoogleTest
    {
        IWebDriver driver;


        public GoogleTest() {
            driver = new ChromeDriver();
                    }


    public void openApp()
        {
            driver.Url = "https://google.com";
            driver.Manage().Window.Maximize();
        }

        public void search(String text) {
            IWebElement searchTxt = driver.FindElement(By.Name("q"));
                searchTxt.SendKeys(text);
            searchTxt.Submit();

                 }


        public void verifyLinkPresent() {

            IWebElement link = driver.FindElement(By.LinkText("Digital Testing & Automation Services & Solutions I Infostretch"));
            Assert.IsTrue(link.Displayed);
            driver.Quit();
        }

    }
}
