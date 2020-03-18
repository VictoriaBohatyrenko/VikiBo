using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace VikiboAutomationST
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
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            //находим элемент (кнопка вход) по XPath и нажимаем на него
            driver.FindElement(By.XPath("//a[text() = 'Вход']")).Click();

            // находим элемент (поле ввода логин) по XPath и вводим в него текст
            driver.FindElement(By.Name("username")).SendKeys("likedream277@gmail.com");

            // находим элемент (поле ввода пароль) по XPath и вводим в него текст
            driver.FindElement(By.Name("password")).SendKeys("192837465");

            //находим элемент (кнопка вход) по XPath и нажимаем на него
            driver.FindElement(By.XPath("//button[@type = 'submit']")).Click();

            //находим элемент (книпка не сейчас) по XPath и нажимаем на него
            driver.FindElement(By.XPath("//button[text() = 'Не сейчас']")).Click();

            //находим элемент (поле поиска) по XPath и вводим в него текст
            driver.FindElement(By.XPath("//input[@placeholder  = 'Поиск']")).SendKeys("#travel");

            //Нажимаем еа кнопку по XPath 
            driver.FindElement(By.XPath("//a[@href = '/explore/tags/travel/']")).Click();

            //Нажимаем на фото
            

            Console.ReadLine();
        }
    }
}
