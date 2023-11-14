using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace SimpleAppium
{
    public class Tests
    {
        AppiumDriver driver;

        [SetUp]
        public void Setup()
        {
            AppiumOptions options = new()
            {
                AutomationName = AutomationName.AndroidUIAutomator2,
                PlatformName = "Android",
                PlatformVersion = "11.0",

                DeviceName = "emulator-5554"

            };
            driver = new AndroidDriver(new Uri("http://localhost:4723"), options);
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Dispose();
        }

        [Test]
        public void Test1()
        {
            Assert.That(driver.Context, Is.Not.Null);
        }
    }
}