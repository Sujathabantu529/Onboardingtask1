using NUnit.Framework;
using Onboardingtask1.Drivers;
using Onboardingtask1.Pages;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Onboardingtask1.StepDefinition
{
    [Binding]
    public class MarsQAStepDefinitions : Commondriver
    {

        LoginPage loginPageObj;
        ProfilePage profilePageObj;
        public MarsQAStepDefinitions()
        {
            driver = new ChromeDriver();
            loginPageObj = new LoginPage();
            profilePageObj = new ProfilePage();

        }
        [Given(@"I logged into Mars QA successfully")]
        public void GivenILoggedIntoMarsQASuccessfully()
        {
            //loginpage object initialization and definition
            loginPageObj.LoginActions(driver);


        }

        [When(@"I navigate skills tab and add the skills")]
        public void WhenINavigateSkillsTabAndAddTheSkills()
        {
            //profile page addskills object initialization and definition
            profilePageObj.AddSkills(driver);

        }

        [Then(@"The skills should be added to the profile page successfully")]
        public void ThenTheSkillsShouldBeAddedToTheProfilePageSuccessfully()
        {
            string addedskill = profilePageObj.alertWindow(driver);

            Assert.That(addedskill == "Dance2 has been added to your skills", "Dance2 has not been matched correctly");


        }
        [When(@"I navigate to skills tab and update skills")]
        public void WhenINavigateToSkillsTabAndUpdateSkills()
        {
            profilePageObj.UpdateSkills(driver);
        }
        [Then(@"The skills should be updated sucessfully")]
        public void ThenTheSkillsShouldBeUpdatedSucessfully()
        {

            string updatedskill = profilePageObj.alertWindow(driver);
            Assert.That(updatedskill == "Dance4 has been updated to your skills", "Dance has not been matched correctly");


        }

        [When(@"I navigate to skills tab and delete skills")]
        public void WhenINavigateToSkillsTabAndDeleteSkills()
        {
            profilePageObj.DeleteSkills(driver);
        }

        [Then(@"The skills should be deleted sucessfuly")]
        public void ThenTheSkillsShouldBeDeletedSucessfuly()
        {
            string deletedskill = profilePageObj.alertWindow(driver);
            Assert.That(deletedskill == "Dance4 has been deleted", "Actual data and expected data do Not match");

        }

        [When(@"I navigate language tab and add new '([^']*)' and '([^']*)'")]
        public void WhenINavigateLanguageTabAndAddNewAnd(string language, string level)
        {

            profilePageObj.AddLanguage(driver, language, level);


        }

        [Then(@"'([^']*)' and '([^']*)'should be add successfully in the language tab")]
        public void ThenAndShouldBeAddSuccessfullyInTheLanguageTab(string language, string level)
        {
            string addedLanguage = profilePageObj.GetAddLanguage(driver);
            string addedLanguageLevel = profilePageObj.GetAddLanguageLevel(driver);

            Assert.That(addedLanguage == language, "Actual language and expected language do not match.");
            Assert.That(addedLanguageLevel == level, "Actual level and expected level do not match.");




        }



    }




}
