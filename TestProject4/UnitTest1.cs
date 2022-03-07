using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject4
{
    [TestClass]
    public class verifyHomepage
    {
        IWebDriver driver;
     [TestMethod]
        public void Playground_verifyForms()
        {

            //Arrange 

          
            //Forms formspage = new Forms(driver);
             //formspage.OpenPage();
             //formspage.enterName();
             //formspage.enterEmail();
            //formspage.selectState();
            //formspage.clickAgree();
            //formspage.clickSubmitBtn ();
            //
            ///fdg
            ///
        //    Planet pl = new Planet(driver);
//            pl.ClickExpolreBtn();


            //IWebElement popupMessage = driver.FindElement(By.ClassName("popup-message"));



            ;

            //Assert
            Assert.AreEqual("Exploring Earth", driver.FindElement(By.ClassName("popup-message")).Text);


        }

        [TestInitialize()]
        public void setup()
        {
            driver = new ChromeDriver(@"C:\Tools\chromedriver98");
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/planets";
            driver.Manage().Window.Maximize();

        }

        [TestCleanup()]
        public void Cleanup()
        {
          //  driver.Quit();
        }
    }

    
}
