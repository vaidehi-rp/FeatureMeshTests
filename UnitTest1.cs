
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;

namespace MockUILib.Tests
{
    
public class UnitTest1
    {
        String test_url = "https://featuremeshreactui.azurewebsites.net/";
        //String itemName = "Yey, Let's add it to list";

        [Theory]
        [InlineData(BrowserType.Edge)]

        public void NavigateApp(BrowserType browserType)
        {
            using (var driver = WebDriverInfra.Create_Browser(browserType))
            {
                driver.Navigate().GoToUrl(test_url);

                driver.Manage().Window.Maximize();

                Assert.Equal("React App", driver.Title);
            }
        }
    }
}


        