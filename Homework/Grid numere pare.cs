using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;

namespace AutomationProject.Homework
{
    public class Grid_numere_pare
    {
        IWebDriver Driver;

        [Test]

        public void testGrid()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement interactionsButton = Driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsButton.Click();

            List<IWebElement> ListInteraction = Driver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();
            ListInteraction[1].Click();

            IWebElement Grid = Driver.FindElement(By.Id("demo-tab-grid"));
            Grid.Click();

            List<string> numereImpare = new List<string> { "One", "Three", "Five", "Seven", "Nine" };

            List<IWebElement> elements = Driver.FindElements(By.XPath("//li[@class='list-group-item list-group-item-action']")).ToList();

            foreach (IWebElement element in elements)

            {
                string text = element.Text.Trim();
                if (numereImpare.Contains(text))  // Verifică dacă este un număr impar
                {
                    element.Click();  // Click pe elementul impar
                    Thread.Sleep(500);



                }
            }
        }
    }
}
