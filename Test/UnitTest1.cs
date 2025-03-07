using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        IWebDriver driver =new ChromeDriver();
        driver.Navigate().GoToUrl("https://demoqa.com/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);
        driver.Quit();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
