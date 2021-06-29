using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestingSelenium
{
    class Program
    {

   
        public static void testingDo()
        {
           try{
                // string weburl_ = "http://localhost:777"; //local
                string weburl_ = "http://jerrysibarani.com"; //online

                FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"D:\A My Youtube Channel\Testing Automation", "geckodriver.exe");
                service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                IWebDriver fdr = new FirefoxDriver(service);

                fdr.Navigate().GoToUrl(weburl_ + "/androidserverapi/");
                fdr.Manage().Window.Maximize();
                IWebElement e1 = fdr.FindElement(By.Name("username")); e1.SendKeys("admin");
                IWebElement e2 = fdr.FindElement(By.Name("password")); e2.SendKeys("admin");

                IWebElement exec1 = fdr.FindElement(By.Id("mylogin"));
                exec1.Click();

                fdr.Navigate().GoToUrl(weburl_ + "/androidserverapi/index.php/Kamus_c/");
                fdr.Navigate().GoToUrl(weburl_ + "/androidserverapi/index.php/Kamus_c/add_view/");

                IWebElement e3 = fdr.FindElement(By.Name("word")); e3.SendKeys("liburan");
                IWebElement e4 = fdr.FindElement(By.Name("description")); e4.SendKeys("segera tiba");

                IWebElement exec2 = fdr.FindElement(By.Id("savekamus"));
                exec2.Click();

                fdr.Navigate().GoToUrl(weburl_ + "/androidserverapi/index.php/home/logout");

                Thread.Sleep(3000);
                //close the browser  
                // driver.Close();
                Console.Write("Testing automation selesai!!!");
                // Console.WriteLine("Done Testing!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Consent To:" + ex.ToString());
            }    
        }
        

        static void Main(string[] args)                        
        {

            testingDo();          
            
        }
    }
}
