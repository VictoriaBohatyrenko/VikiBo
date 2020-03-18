using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace VikiboAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем хром драйвер
            var driver = new ChromeDriver();

            //делаем окно браузера во весь экран
            driver.Manage().Window.Maximize();

            //устанавливаем время ожидания появления элементов (кнопок, полей и т.д.) на странице (30 секунд)
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            //переходим на сайт
            driver.Navigate().GoToUrl("https://www.the-village.com.ua/");

            //находим элемент (кнопка поиска) по XPath и нажимаем на него
            driver.FindElement(By.XPath("//div[@role = 'toggle_search']")).Click();

            //находим элемент (строка поиска) по Name и вводим в него текст поиска
            driver.FindElement(By.Name("query")).SendKeys("Глінтвейн та хот - доги по 33 грн");

            //находим элемент (кнопка Найти) по XPath и нажимаем на него
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            //находим первую статью в ленте по XPath и нажимаем по ней
            driver.FindElement(By.XPath("//a[h2[text() = 'Глінтвейн та хот-доги по 33 грн у «Цветочная Мафия» на Майдані']]")).Click();

            Console.ReadLine();
        }
    }
}
