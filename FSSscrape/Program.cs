using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace FSSscrape
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "";

            using (var driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://www.fansharesports.com/shared/signIn?redirectUrl=%2Fgolf%2Ftrends");

                var userName = driver.FindElementById("email");
                var passWord = driver.FindElementById("password");
                var logIn = driver.FindElementById("submit");

                userName.SendKeys("caiderwaider@hotmail.com");
                passWord.SendKeys("DKscrape");
                logIn.Click();

                System.Threading.Thread.Sleep(25);

                //var contentWrap = driver.FindElementById("content-wrap");

                driver.Navigate().GoToUrl("https://www.fansharesports.com/golf/analytics/tags");

                

                var main = driver.FindElementById("main");

                test = main.Text;

                

                

            }

            Console.WriteLine(test);
            Console.ReadLine();
            
        }
    }
}
