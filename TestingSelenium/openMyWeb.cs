using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTesting
{
   public class openMyWeb
    {
        public static void doTesting()
        {
            try
            {
                string web_url = "http://localhost/androidserverapi/login";
                string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
                               
                FirefoxDriverService svc = FirefoxDriverService.CreateDefaultService(exePath);
                //FirefoxDriverService svc = FirefoxDriverService.CreateDefaultService(@"D:\Service\geckodriver", "geckodriver.exe");

                svc.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                IWebDriver fdr = new FirefoxDriver(svc);

                fdr.Navigate().GoToUrl(web_url);
                fdr.Manage().Window.Maximize();
                IWebElement e1 = fdr.FindElement(By.Name("username")); e1.SendKeys("admin");
                IWebElement e2 = fdr.FindElement(By.Name("password")); e2.SendKeys("admin");

                IWebElement exec = fdr.FindElement(By.Id("myLogin"));
                exec.Click();

                fdr.Navigate().GoToUrl("http://localhost/androidserverapi/index.php/Kamus_c/add_view/");
                IWebElement e3 = fdr.FindElement(By.Name("word")); e3.SendKeys("testing4");
                IWebElement e4 = fdr.FindElement(By.Name("description")); e4.SendKeys("testing5");
                IWebElement exec2 = fdr.FindElement(By.Id("savekamus"));
                exec2.Click();
                
                fdr.Navigate().GoToUrl("http://localhost/androidserverapi/index.php/Home/logout");

                Console.Write("Testing selesai..!");

            }
            catch (Exception e)
            {
                Console.Write("Error Please Check: " + e.ToString());
            }

        }

    }
}
