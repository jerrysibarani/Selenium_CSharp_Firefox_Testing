using System;
using System.Collections.Generic;
using System.Text;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
//using System.Threading.Tasks;
//using System.Threading;

namespace SeleniumTesting
{
    public class openGithub
    {

        public static void doTesting()
        {
            try
            {
                string web_url = "https://github.com/login";

                FirefoxDriverService svc = FirefoxDriverService.CreateDefaultService(@"D:\Service\geckodriver", "geckodriver.exe");
                svc.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                IWebDriver fdr = new FirefoxDriver(svc);

                fdr.Navigate().GoToUrl(web_url);
                fdr.Manage().Window.Maximize();
                IWebElement e1 = fdr.FindElement(By.Name("login")); e1.SendKeys("admin");
                IWebElement e2 = fdr.FindElement(By.Name("password")); e2.SendKeys("admin");

                IWebElement exec = fdr.FindElement(By.Name("commit"));
                exec.Click();

            }
            catch (Exception e)
            {
                Console.Write("Error Please Check: " + e.ToString());

            }

        }

    }
}
