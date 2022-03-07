using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject4
{
    class HomePageTests
    {
        IWebDriver driver;
        // IWebElement<headerElemnts>  
        public HomePageTests(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement submitBtn => driver.FindElement(By.Id("submit"));
        public IWebElement popup => driver.FindElement(By.ClassName("popup-message"));
        public IWebElement forename => driver.FindElement(By.Id("forename"));

        internal bool isPopupDisplayed()
        {

            if (popup.Text == "Hello Harsh")
                return true;
            else
                return
                    false;
        }

        public void ClickSubmitBtn()
        {
            submitBtn.Click();
            //new WebDriverWait(driver, TimeSpan(2));
        }
        public void EnterForename()
        {
            forename.SendKeys("Harsh");
        }

    }

}
