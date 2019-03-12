using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using TrialCommunity.Hooks;

namespace TrialCommunity.PageObject
{
    public class CommunityClass1
    {
        public CommunityClass1()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }


        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login { get; set; }

        public void ClickLogin()

        {
            login.Click();
        }


        [FindsBy(How = How.XPath, Using = "//input[@ type = 'email']")]
        private IWebElement emailElement { get; set; }

        public void TypeEmail()

        {
            emailElement.SendKeys("lahdayg44@gmail.com");
        }

        [FindsBy(How = How.XPath, Using = "//input[@ type = 'password' and @ name = 'user_password']")]
        private IWebElement passwordElement { get; set; }

        public void TypePassword()

        {
            passwordElement.SendKeys("Omowunmi44");
        }

        [FindsBy(How = How.XPath, Using = "//input[@ value = 'Sign In']")]
        private IWebElement signin { get; set; }

        public void ClickSignin()

        {
            signin.Click();
        }

        [FindsBy(How = How.XPath, Using = "//span[@ class = 'mm-text']")]
        private IWebElement community { get; set; }

        public void ClickCommunity()

        {
            community.Click();
        }

        [FindsBy(How = How.ClassName, Using = "add-new plr--15 mr--10 mr-sm--1-")]
        private IWebElement createnew{ get; set; }

        public void ClickCreateNew()

        {
            createnew.Click();
        }


    }
}
