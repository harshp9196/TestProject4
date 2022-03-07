using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Globalization;

namespace TestProject4
{
    class Planet
    {
        IWebElement thisElement;
        public Planet(IWebElement driver)
        {
            this.thisElement = driver;
        }
        public string Name => thisElement.FindElement(By.ClassName("name")).Text;
        public string ExporeBtn => thisElement.FindElement(By.TagName("button")).Text;
        public long Distance
        {

            get
            { 
                var distanceText = thisElement.FindElement(By.ClassName("distance")).Text;
                distanceText = distanceText.Split(' ')[0];
                return long.Parse(distanceText, NumberStyles.AllowThousands);
            }

        }




    }
}
