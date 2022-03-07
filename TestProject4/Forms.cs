using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestProject4
{
    class Forms
    {
        IWebDriver driver;
        public Forms(IWebDriver driver)
        {
            this.driver = driver;
        }


        public IWebElement name => driver.FindElement(By.Id("name"));
       public IWebElement email => driver.FindElement(By.Id("email"));
        public IWebElement state => driver.FindElement(By.Id("state"));
      public IWebElement checkbox => driver.FindElement(By.ClassName("v-input--selection-controls__ripple"));

        public IWebElement navBar => driver.FindElement(By.CssSelector("[aria-label='forms']"));

        IReadOnlyCollection <IWebElement> spanElemnts => driver.FindElements(By.TagName("button"));
       
        // public IWebElement form = driver.FindElement(By.CssSelector("[aria-label='forms']"));

        internal void OpenPage()
        {

              navBar.Click();
        }

public IWebElement submit => driver.FindElement(By.CssSelector(""));
        
        internal void enterName()
        {
            name.SendKeys("Harsh");
        }

        internal void enterEmail()
        {
            email.SendKeys("hp.patel97@gmail.com");
        }

        internal void clickSubmitBtn()
        {

             new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //Until(ExpectedConditions.ElementExists(By.CssSelector("span.v-btn__content")))
            IWebElement submitbtn = null;

            foreach (IWebElement spanElemnt in spanElemnts)
            {

                Console.WriteLine(spanElemnt.Text);

                if (spanElemnt.Text == "SUMBIT") {

                    submitbtn = spanElemnt;
                    break;

                    
                }
               
            }
            submitbtn.Click();
        }

        internal void clickAgree()
        {
            checkbox.Click();
        }

        internal void selectState()
        {
          //  state.Click();
            state.SendKeys("s");
           // state.Click();
        }
    }
}
