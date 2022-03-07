using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace TestProject4
{
    internal class PlanetPage
    {
        private IWebDriver driver;
        List<Planet> planets = new List<Planet>();
        public PlanetPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal IEnumerable<Planet> getPlantes()
        {
            var   allPlanets = driver.FindElements(By.ClassName("planet"));
            foreach (IWebElement  planet in allPlanets)
            {
                planets.Add(new Planet(planet));
            }
          return planets;
        }

        internal Planet GetPlant(Predicate<Planet> IMatchStrategy)
        {
            foreach (var planet in getPlantes())
            {
                if (IMatchStrategy.Invoke(planet)) {
                    return planet;
                }
            }
            throw new NotFoundException("Planet not founded");
        }
        internal Planet GetLargestDistance(Predicate<Planet> IMatchStrategy)
        {
            foreach (var planet in getPlantes())
            {
               if (IMatchStrategy.Invoke(planet))
                {
                    return planet;
                }
            }
            throw new NotFoundException("Planet not founded");
        }

    }
}