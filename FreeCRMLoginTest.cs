using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitDemo
{

    [TestFixture]
    class FreeCRMLoginTest
    {

        IWebDriver driver = null;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(@"C:\Automation\Drivers");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            driver.Navigate().GoToUrl("https://freecrm.com");
        }

        [Test]
        public void LoginTest()
        {
            IWebElement btnLogin = driver.FindElement(By.XPath("//span[contains(.,'Log In')]"));

            btnLogin.Click();


            driver.FindElement(By.XPath("//input[@name='email'] ")).SendKeys("ronbary100@gmail.com");
            driver.FindElement(By.XPath("//input[@name='password'] ")).SendKeys("Ronb18nor11");

            driver.FindElement(By.XPath("//div[@class='ui fluid large blue submit button']")).Click();



            /*
             * 
 
                Example how to use dropdown select

             // select the drop down list
             var education = driver.FindElement(By.Name("education"));
             //create select element object 
             var selectElement = new SelectElement(education);

             //select by value
             selectElement.SelectByValue("Jr.High"); 
             // select by text
             selectElement.SelectByText("HighSchool");


             * 
             */



        }



        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }



    }
}
