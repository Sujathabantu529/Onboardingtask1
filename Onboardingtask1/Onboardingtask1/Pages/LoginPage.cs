using Onboardingtask1.Drivers;
using Onboardingtask1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;



namespace Onboardingtask1.Pages
{
    public class LoginPage : Commondriver

    {
        //Finding Elements by XPath
        //Navigate to signin button and click on it


        private IWebElement signinbutton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement emailaddersstextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement passwordtextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement loginbutton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));





        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            // Launch MarsQA Website
            driver.Navigate().GoToUrl("http://localhost:5000/");




            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 10);
            //Navigate to signin button and click on it
            signinbutton.Click();



            Wait.WaitTobeClickable(driver, "XPath", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 10);
            //Identify email address textbox and enter the valid email address
            emailaddersstextbox.SendKeys("sujathabantu529@gmail.com");



            //Identify passwordtextbox and enter the valid password
            passwordtextbox.SendKeys("Avira@3451");


            loginbutton.Click();

            Wait.WaitTobeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 10);





        }
        public string alertWindow(IWebDriver driver)
        {

            Wait.WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}  












 