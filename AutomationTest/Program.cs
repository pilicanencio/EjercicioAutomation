using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.segurodeviajemundial.com.co/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            IWebElement selectElement = driver.FindElement(By.Name("destino"));
            SelectElement select = new SelectElement(selectElement);

            // Select an option by its text
            select.SelectByValue("EU");
            driver.FindElement(By.XPath("//input[@id='fecha_ida']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'19')]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[contains(text(),'24')]")).Click();
            driver.FindElement(By.Name("email")).SendKeys("test@gmail.com");
            driver.FindElement(By.Id("telefono")).SendKeys("3156788812");

            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//span[contains(text(),'COTIZAR GRATIS')]")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//button[contains(text(),'Continuar')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Name("nombres1")).SendKeys("test1");
            driver.FindElement(By.Name("apellidos1")).SendKeys("test1");
            driver.FindElement(By.Name("cedula1")).SendKeys("12345678");
              driver.FindElement(By.Name("fn1")).Click();
             driver.FindElement(By.XPath("//a[contains(text(),'18')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'Paga Aquí')]")).Click();
            Thread.Sleep(5000);

            driver.Quit();
        }
    }
}
