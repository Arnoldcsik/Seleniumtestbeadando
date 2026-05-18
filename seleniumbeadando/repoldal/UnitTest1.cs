using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace repoldal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArgument("start-maximized"); // Böngésző maximalizálása
            IWebDriver driver = new ChromeDriver(options);
            //Console.WriteLine("Hello, World!");


            try
            {
                driver.Navigate().GoToUrl("http://localhost/urlap.html");




                var nameInput = driver.FindElement(By.Id("name"));
                nameInput.SendKeys("Teszt Elek");

                var countryDropdown = driver.FindElement(By.Id("country"));
                SelectElement select = new SelectElement(countryDropdown);

                //Kiválasztás value alapján
                //select.SelectByValue("DE");
                select.SelectByText("Németország");

                var emailInput = driver.FindElement(By.Id("email"));
                emailInput.SendKeys("TesztElek1@gmail.com");

                var passInput = driver.FindElement(By.Id("password"));
                passInput.SendKeys("12345678");

                var genderInput = driver.FindElement(By.Id("male"));
                genderInput.Click();

                var cheaterinput = driver.FindElement(By.Id("repname"));
                cheaterinput.SendKeys("Hazugbalog34");

                var c1Input = driver.FindElement(By.Id("cheat1"));
                c1Input.Click();

                var c4Input = driver.FindElement(By.Id("cheat4"));
                c4Input.Click();

                var fileInput = driver.FindElement(By.Id("upload"));

                //fájl feltöltése (teljes elérési út!)
                fileInput.SendKeys(@"C:\Users\Asus2026\Downloads\IOS.pdf");

                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("document.getElementById('repdate').value='1990-05-15';");

                var repInput = driver.FindElement(By.Id("repdesc"));
                repInput.SendKeys("Ez a játékosnak aimbotja van ami videót beküldtem megmagyarázza.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: " + ex.Message);
            }
            finally
            {
                //driver.Quit();
            }
        }
    }
}
