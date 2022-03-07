using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace TestProject4
{
    class PopUp
    {

        IWebDriver driver;
        public IWebElement popup => driver.FindElement(By.ClassName("popup-message"));
        public PopUp(IWebDriver driver)
        {
            this.driver = driver;
        }


       
    }
}
