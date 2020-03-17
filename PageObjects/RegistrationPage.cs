using GiftreteRegistration.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteRegistration.PageObjects
{
    class RegistrationPage

    {
        IWebDriver driver;

        IWebElement createAccount => driver.FindElement(By.XPath("//section[1]/nav/div/div[1]/a[2]"));
        IWebElement firstName => driver.FindElement(By.Id("first_name"));
        IWebElement lastName => driver.FindElement(By.XPath("//*[@id='last_name';]"));

        IWebElement emailAddress => driver.FindElement(By.Id("email"));

        IWebElement mobileNumber => driver.FindElement(By.CssSelector("#mobile"));

        public void EnterMobileNumber(int mobile)
        {
            mobileNumber.SendKeys(mobile);
        }

        public void EnterEmailAddress(string emailtext)
        {
            emailAddress.SendKeys(emailtext);
        }
        public void EnterLastName(string lastname)
        {
            lastName.SendKeys(lastname);
        }

        public void EnterFirstName(string firstname)
        {Address
            firstName.SendKeys(firstname);
        }
        public void ClickCreateAccount()
        {
            createAccount.Click();
        }

        
        public RegistrationPage()
        {
            driver = Hook.driver;
            
        }

        public void  NavigateToUrl()
        {
            driver.Navigate().GoToUrl("https://www.giftrete.com/");
        }
            
    }
}
