using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationProject.Session2
{
    public class WebTablesTest

    {
        IWebDriver Driver;

        [Test]
        public void Test2()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementsButton = Driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
            elementsButton.Click();

            IWebElement webTablesButton = Driver.FindElement(By.XPath("//*[text()='Web Tables']"));
            webTablesButton.Click();

            IWebElement addButton = Driver.FindElement(By.Id("addNewRecordButton"));
            addButton.Click();

            IWebElement popupFirstName = Driver.FindElement(By.Id("firstName"));
            popupFirstName.SendKeys("Ale");

            IWebElement popupLastName = Driver.FindElement(By.Id("lastName"));
            popupLastName.SendKeys("Sandu");

            IWebElement popupEmail = Driver.FindElement(By.Id("userEmail"));
            popupEmail.SendKeys("as@email.com");

            IWebElement popupAge = Driver.FindElement(By.Id("age"));
            popupAge.SendKeys("23");

            IWebElement popupSalary = Driver.FindElement(By.Id("salary"));
            popupSalary.SendKeys("13000");   

            IWebElement popupDepartment = Driver.FindElement(By.Id("department"));
            popupDepartment.SendKeys("Finance");

            IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver;

            IWebElement popupSubmit = Driver.FindElement(By.Id("submit"));

            jse.ExecuteScript("arguments[0].click();", popupSubmit);

            //popupSubmit.Submit();   

            IWebElement rowWebTable = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));
            Console.WriteLine(rowWebTable.Text);

            //Assert.True(rowWebTable.Text.Contains("Ale"));
            //Assert.True(rowWebTable.Text.Contains("Sandu"));
            //Assert.True(rowWebTable.Text.Contains("23"));
            //Assert.True(rowWebTable.Text.Contains("as@email.com"));
            //Assert.True(rowWebTable.Text.Contains("13000"));
            //Assert.True(rowWebTable.Text.Contains("Finance"));

            IWebElement firstName = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
            IWebElement lastName = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
            IWebElement age = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
            IWebElement email = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
            IWebElement salary = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
            IWebElement department = Driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

            Assert.That(firstName.Text.Equals("Ale"));
            Assert.That(lastName.Text.Equals("Sandu"));
            Assert.That(age.Text.Equals("23"));
            Assert.That(email.Text.Equals("as@email.com"));
            Assert.That(salary.Text.Equals("13000"));
            Assert.That(department.Text.Equals("Finance"));




        }

        /*[TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Dispose();
                Driver.Quit();
            }
        }*/
    }
}

