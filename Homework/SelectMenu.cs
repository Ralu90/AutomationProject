using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Homework
{
   public class SelectMenu
    {
        IWebDriver Driver;

        [Test]
        public void testSelectMenu()
        {
           Driver = new ChromeDriver();
           Driver.Navigate().GoToUrl("https://demoqa.com/");
           Driver.Manage().Window.Maximize();

           IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           js.ExecuteScript("window.scrollTo(0,1000)");

           IWebElement widgetsButton = Driver.FindElement(By.XPath("//h5[text()='Widgets']"));
           widgetsButton.Click();

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver;
            js1.ExecuteScript("window.scrollTo(0,2000)");

            IWebElement selectMenuButton = Driver.FindElement(By.XPath("//*[text()='Select Menu']"));
            selectMenuButton.Click();

            //js1.ExecuteScript("window.scrollTo(0,300)");

            IWebElement selectValueButton = Driver.FindElement(By.Id("withOptGroup"));
            selectValueButton.Click();

            
            
            
            /*IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;
             IWebElement selectValueButton = Driver.FindElement(By.Id("withOptGroup"));

            jse.ExecuteScript("arguments[0].click();", selectValueButton);*/
        }
    }
}
