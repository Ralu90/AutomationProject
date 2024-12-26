using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Homework
{
    public class Homework
    {

        IWebDriver Driver;

        [Test]
        public void testMethod()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement widgetsButton = Driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgetsButton.Click();

            IWebElement autoCompleteButton = Driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
            autoCompleteButton.Click();

            IWebElement multipleColoursField = Driver.FindElement(By.Id("autoCompleteMultipleInput"));
            multipleColoursField.SendKeys("Red");
            multipleColoursField.SendKeys(Keys.Enter);
            multipleColoursField.SendKeys("Green");
            multipleColoursField.SendKeys(Keys.Enter);

            IWebElement singleColourField = Driver.FindElement(By.Id("autoCompleteSingleInput"));
            singleColourField.SendKeys("Yellow");
            singleColourField.SendKeys(Keys.Enter);

            IWebElement removeColor = Driver.FindElement(By.XPath("//*[@class=('css-xb97g8 auto-complete__multi-value__remove')][1]"));
            removeColor.Click();
            multipleColoursField.SendKeys("Purple");
            multipleColoursField.SendKeys(Keys.Enter);

            /*IWebElement rowMultipleColors = Driver.FindElement(By.Id("autoCompleteMultipleInput"));
            Console.WriteLine(rowMultipleColors.Text);

            Assert.True(rowMultipleColors.Text.Contains("Green"));*/

        }
    }
}
