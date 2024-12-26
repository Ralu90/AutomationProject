using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Session1
{
    public class TextBoxTest
    {

        IWebDriver Driver;


        [Test]
        public void Test1()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementsButton = Driver.FindElement(By.XPath("//h5[text()='Elements']"));
            elementsButton.Click();

            IWebElement elementTextBoxButton = Driver.FindElement(By.XPath("//*[text()='Text Box']"));
            elementTextBoxButton.Click();

            IWebElement elementFirstName = Driver.FindElement(By.Id("userName"));
            elementFirstName.SendKeys("Raluca Frisan");

            IWebElement elementEmail = Driver.FindElement(By.Id("userEmail"));
            elementEmail.SendKeys("test@test.com");

            IWebElement elementCurrentAddress = Driver.FindElement(By.Id("currentAddress"));
            elementCurrentAddress.SendKeys("str Rozelor, nr 23");

            IWebElement elementPermanentAddress = Driver.FindElement(By.Id("permanentAddress"));
            elementPermanentAddress.SendKeys("str Rozelor, nr 23");

        }

        /*[TearDown]
        public void TearDown()
        {
            Driver.Quit();
            Driver.Close();

        }*/
    }
}