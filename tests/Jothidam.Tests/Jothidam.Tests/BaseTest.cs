using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace Jothidam.Tests
{
    public class BaseTest : IDisposable
    {
        protected AndroidDriver Driver;

        public BaseTest()
        {
            var options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AutomationName = "UiAutomator2";
            options.DeviceName = "emulator-5554";

            string appPath = Environment.GetEnvironmentVariable("APPIUM_APP_PATH")
                ?? @"C:\Users\PMLS\appiumrelated\app-prod-release.apk";

            options.App = appPath;

            // Appium v5 handles prefixes automatically for additional options
            options.AddAdditionalAppiumOption("appPackage", "com.perurinc.virichiprovider");
            options.AddAdditionalAppiumOption("appActivity", "com.perurinc.virichiprovider.MainActivity");

            Driver = new AndroidDriver(new Uri("http://127.0.0.1:4723/"), options);
        }

        public void Dispose()
        {
            Driver?.Quit();
        }
    }
}