using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestProject4
{
    [TestClass]
    public class verifyHomepage
    {
        IWebDriver driver;
     [TestMethod]
        public void Playground_verifyForms()
        {
            //IwebElement iwebElement = (IwebElement)driver.FindElement(By.TagName("h1"));
            //Arrange 
          //Assert.IsTrue(true); 
            Forms formspage = new Forms(driver);
             formspage.OpenPage();
             formspage.enterName();
             formspage.enterEmail();
            formspage.selectState();
            formspage.clickAgree();
            formspage.clickSubmitBtn ();
            Assert.IsTrue(false);
           
        }

        [TestInitialize()]
        public void setup()
        {
            var options = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options)
            {
                Url = "https://d18u5zoaatmpxx.cloudfront.net/#/forms"
            };
            driver.Manage().Window.Maximize();

        }

        [TestCleanup()]
        public void Cleanup()
        {
            driver.Quit();
        }
    }

    
}
