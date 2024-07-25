using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace MyProject.UiTests
{
    public class UiTests
    {
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                var screenshotPath = Path.Combine(TestContext.CurrentContext.WorkDirectory, "screenshots");
                Directory.CreateDirectory(screenshotPath);
                var screenshotFile = Path.Combine(screenshotPath, $"{TestContext.CurrentContext.Test.Name}.png");
                screenshot.SaveAsFile(screenshotFile);
            }
            _driver.Quit();
        }

        [Test]
        public void ExampleTest()
        {
            _driver.Navigate().GoToUrl("https://example.com");
            Assert.AreEqual("Example Domain", _driver.Title);
        }
    }
}
