﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();
            TurnOnWait();

            //Maximise the window
            driver.Manage().Window.Maximize();
        }

        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }

        public static object WebDriver { get; internal set; }


        //Implicit Wait
        public static void TurnOnWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        public static void NavigateUrl(string url)
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        internal static void NavigateUrl()
        {
            driver.Navigate().GoToUrl(BaseUrl); 
            //throw new NotImplementedException();
        }

        //Close the browser
        public void Close()
        {
            driver.Quit();
        }

    }
}
