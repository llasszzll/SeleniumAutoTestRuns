using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAutoTestRuns
{
    internal class Program

        
    {
        static void Main(string[] args)
        {
            // 1 Create reference for Chrome Browser
            IWebDriver driver = new ChromeDriver();

            // 2 Go To URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com");

            // Full Screen Browser
            driver.Manage().Window.FullScreen();

            // Automate Login
            IWebElement username = driver.FindElement(By.Id("user-name"));
            username.Click();
            username.SendKeys("standard_user");

            IWebElement password = driver.FindElement(By.Id("password"));
            password.Click();
            password.SendKeys("secret_sauce");

            IWebElement login = driver.FindElement(By.Id("login-button"));
            login.Click();

            IWebElement backpack = driver.FindElement(By.XPath("//*[@id=\"item_4_title_link\"]/div"));
            backpack.Click();


            IWebElement addCart = driver.FindElement(By.XPath("//*[@id=\"inventory_item_container\"]/div/div/div/button"));

            addCart.Click();

            // driver.Quit();
        }


    }
}
