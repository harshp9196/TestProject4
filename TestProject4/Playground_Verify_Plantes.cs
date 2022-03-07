using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace TestProject4
{

    [TestClass]

    public class Playground_Verify_Plantes
    {
        IWebDriver driver;

        [TestMethod]
        public void Playground_verifyPlanets()
        {
            PlanetPage planetPage = new PlanetPage(driver);
            planetPage.getPlantes();
            planetPage.GetPlant(p =>  p.Name == "Earth");
          //  Assert.AreEqual("Exploring Earth", driver.FindElement(By.ClassName("popup-message")).Text);
        }

        [TestMethod]

        public void Playground_FindLongestDitance()
        {
            PlanetPage planetPage = new PlanetPage(driver);
            planetPage.getPlantes();
            //planetPage.farrestPlanet();
        //   planetPage.GetPlant(p => p.Distance == 12332);
        }

        [TestInitialize()]
        public void Setup()
        {
            var options  = new ChromeOptions();
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            driver.Url = "https://d18u5zoaatmpxx.cloudfront.net/#/planets";
            driver.Manage().Window.Maximize();
        }

        [TestCleanup()]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
