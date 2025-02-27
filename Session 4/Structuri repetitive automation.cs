using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationProject.Session_4
{
    public class Structuri_repetitive_automation
    {
        IWebDriver Driver;

        [Test]

        public void StructuriRepetiteveMetoda()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement interactionsButton = Driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsButton.Click();

            List<IWebElement> ListInteraction = Driver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();
            ListInteraction[0].Click();

            List<IWebElement> ListSortable = Driver.FindElements(By.XPath("//div[@class='vertical-list-container mt-4']/div")).ToList();
            //Console.WriteLine(ListSortable[0].Text);

            for (int i = 0; i < ListSortable.Count; i++)
                Console.WriteLine(ListSortable[i].Text);

        }

        [Test]
        public void Test2()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = Driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formsButton.Click();

            IWebElement practiceformButton = Driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceformButton.Click();

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver;
            js1.ExecuteScript("window.scrollTo(0,500)");

            IWebElement sportsElement = Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            IWebElement readingElement = Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
            IWebElement musicElement = Driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));

           List<IWebElement> hobbiesList = new List<IWebElement>();
            hobbiesList.Add(sportsElement);
            hobbiesList.Add(readingElement);
            hobbiesList.Add(musicElement);

            string[] array = ["Sports", "Music"];

            foreach (IWebElement hobby in hobbiesList) 
            { 
              foreach (string item in array)
                {
                    if (hobby.Text.Equals(item))
                    {
                        hobby.Click();
                    }
                }
            }
        }

        [Test]

        public void Test3()
        {
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = Driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formsButton.Click();

            IWebElement practiceformButton = Driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceformButton.Click();

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver;
            js1.ExecuteScript("window.scrollTo(0,500)");

            IWebElement subjectsField = Driver.FindElement(By.Id("subjectsInput"));

            subjectsField.SendKeys("Math");
            subjectsField.SendKeys(Keys.Enter);

            subjectsField.SendKeys("Chemistry");
            subjectsField.SendKeys(Keys.Enter);

            subjectsField.SendKeys("English");
            subjectsField.SendKeys(Keys.Enter);

            List<IWebElement> removeSubjects = Driver.FindElements(By.XPath("//div[@class='css-xb97g8 subjects-auto-complete__multi-value__remove']")).ToList();
            bool subjectFlag = true;

            while (subjectFlag)
            {
                foreach (IWebElement element in removeSubjects)
                {
                    element.Click();
                    Thread.Sleep(1000);
                }
                subjectFlag = false;
            }
            
        



            // Actions actions = new Actions(Driver);

            //List<string> subjects = new List<string> { "English", "Maths", "Chemistry", "Physics" };
            // foreach (var subject in subjects)
            /*{
                //Click on the input element
                actions.Click(subjectsField)
                    .SendKeys(subject)                      //send the subject name
                    .Pause(TimeSpan.FromMilliseconds(500))  //Pause for the dropdown to show
                    .SendKeys(Keys.Enter)                   //Select the subject from the dropdown
                    .Build()
                    .Perform();                             //Perform the action

                System.Threading.Thread.Sleep(500);//

            }*/




        }

    }
}
