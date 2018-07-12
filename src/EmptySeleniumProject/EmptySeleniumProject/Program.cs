using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptySeleniumProject
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IWebDriver webDriver = new ChromeDriver())
            {
                webDriver.Navigate().GoToUrl("http://bbc.co.uk/news");
            }
        }
    }
}
