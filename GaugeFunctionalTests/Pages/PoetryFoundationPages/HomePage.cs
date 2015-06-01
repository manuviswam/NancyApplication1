﻿using System;
using GaugeFunctionalTests.drivers;
using GaugeFunctionalTests.Pages.PoetryFoundationPages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace GaugeFunctionalTests.Pages.GetGaugePages
{

    public class HomePage
    {
        private static IWebElement AboutUsLink
        {
            get
            {
                var element =
                    WebDriverSetup.Driver.FindElement(By.LinkText("About Us"));
                return element;
            }
        }

        public AboutUsPage OpenAboutUsPage()
        {
            AboutUsLink.Click();          
            return new AboutUsPage();
        }
      
    }
}