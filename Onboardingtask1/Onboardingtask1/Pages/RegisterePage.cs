﻿//using Onboardingtask1.Utilities;
//using OpenQA.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Onboardingtask1.Pages
//{
//     class RegisterePage : Wait
//    {

//        public void registeractions(IWebDriver driver)
//        {

//            driver.Manage().Window.Maximize();


//            //Launch MarsQA Website
//            driver.Navigate().GoToUrl("http://localhost:5000/");

//            //Identify the join button and click on it
//            WaitTobeClickable(driver, "XPath", "//*[@id=\"home\"]/div/div/div[1]/div/button", 10);
//            IWebElement joinbutton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
//            joinbutton.Click();


//            //Identify the name textbox and enter the valid name
//            WaitForELementToExist(driver, "XPath", "/html/body/div[2]/div/div/form/div[1]/input", 10);
//            IWebElement nametextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
//            nametextbox.SendKeys("Sujatha");

//            //Identify the last name textbox and enter the valid last name
//            IWebElement lastnametextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
//            lastnametextbox.SendKeys("Patharla");

//            //Get Timestamp and generate unique email
//            var Timestamp = Stopwatch.GetTimestamp();
//            var email = "Sujathabantu" + Timestamp.ToString() + "@gmail.com";

//            //Identify the Emailid textbox and enter the valid Emailid
//            IWebElement emailidtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
//            emailidtextbox.SendKeys(email);

//            //Identify the password textbox and enter the valid password
//            IWebElement passwordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
//            passwordtextbox.SendKeys("Avira@3451");

//            //Identify the reenter password textbox and enter the valid password
//            IWebElement reenterpasswordtextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
//            reenterpasswordtextbox.SendKeys("Avira@3451");

//            //Click on terms and conditions checkbox
//            IWebElement termsandconditionscheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
//            termsandconditionscheckbox.Click();

//            //Click on join button
//            WaitTobeClickable(driver, "Id", "submit-btn", 7);
//            IWebElement joinbutton1 = driver.FindElement(By.Id("submit-btn"));
//            joinbutton1.Click();
//            WaitForELementToExist(driver, "CssSelector", "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success.ns-show > div", 3);
//        }
//        public string alertWindow(IWebDriver driver)
//        {

//            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);
//            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
//            return confirmationAlert.Text;

//        }

//    }
//}

