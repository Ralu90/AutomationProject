using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomationProject.Session3
{
    public class PracticeForms
    {

        IWebDriver Driver;

        [Test]
        public void Test3()
        {

            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demoqa.com");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = Driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
            formsButton.Click();

            IWebElement elementPracticeForms = Driver.FindElement(By.XPath("//*[text()='Practice Form']"));
            elementPracticeForms.Click();

            IWebElement genderMale = Driver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement genderFemale = Driver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
            IWebElement genderOther = Driver.FindElement(By.XPath("//label[@for='gender-radio-3']"));

            string gender = "Male";

            if (gender.Equals("Male"))
            {
                genderMale.Click();
            }
            else if (gender.Equals("Female"))
            {
                genderFemale.Click();
            }
            else
            {
                genderOther.Click();
            }

            /* switch (gender)
             {
                 case "Male":
                     genderMale.Click();
                     break;

                 case "Female":
                     genderFemale.Click();
                     break;

                 case "Other":
                     genderOther.Click();
             }*/

           
            IWebElement dateofBirth = Driver.FindElement(By.Id("dateOfBirthInput"));
            dateofBirth.Click();

            IWebElement monthOfBirth = Driver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
            SelectElement monthDropdown = new SelectElement(monthOfBirth);
            monthDropdown.SelectByValue("0");

            IWebElement yearofBirth = Driver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
            SelectElement yearDropdown = new SelectElement(yearofBirth);
            yearDropdown.SelectByValue("1990");

            IWebElement dayofBirth = Driver.FindElement(By.XPath("//*[@class='react-datepicker__day react-datepicker__day--031' and not (contains (@class, '--outside-month'))]"));
            dayofBirth.Click();


            IWebElement subjectAutocomplete = Driver.FindElement(By.Id("subjectsInput"));
            subjectAutocomplete.SendKeys("Chemistry");
            subjectAutocomplete.SendKeys(Keys.Enter);
            subjectAutocomplete.SendKeys("E");
            subjectAutocomplete.SendKeys(Keys.ArrowDown);
            subjectAutocomplete.SendKeys(Keys.ArrowDown);
            subjectAutocomplete.SendKeys(Keys.Enter);
        }
        [TearDown]
      public void TearDown()
      {
          if (Driver != null)
          {
              //Driver.Dispose();
             // Driver.Quit();
          }
      }
    }
}
