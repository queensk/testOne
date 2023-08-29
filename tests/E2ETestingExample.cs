using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests
{
    [TestFixture]
    public class E2ETestingExample
    {
        [Test]
        public void TestLoginAndProfile()
        {
            // Create an instance of ChromeDriver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the URL of the web application
            driver.Navigate().GoToUrl("http://localhost:5001/Account/Login]");

            // Find and enter some text in the username input field
            IWebElement usernameInput = driver.FindElement(By.Id("username"));
            usernameInput.SendKeys("testuser");

            // Find and enter some text in the password input field
            IWebElement passwordInput = driver.FindElement(By.Id("password"));
            passwordInput.SendKeys("testpass");

            // Find and click on the login button
            IWebElement loginButton = driver.FindElement(By.Id("login"));
            loginButton.Click();

            // Find and verify that a welcome message is displayed
            IWebElement welcomeMessage = driver.FindElement(By.Id("welcome"));
            Assert.That(welcomeMessage.Text, Is.EqualTo("Welcome, testuser!"));

            // Find and click on the profile link
            IWebElement profileLink = driver.FindElement(By.Id("profile"));
            profileLink.Click();

            // Find and verify that a profile page is displayed
            IWebElement profilePage = driver.FindElement(By.Id("profile-page"));
            Assert.IsTrue(profilePage.Displayed);

            // Close and quit the web browser
            driver.Dispose();
        }
    }
}
