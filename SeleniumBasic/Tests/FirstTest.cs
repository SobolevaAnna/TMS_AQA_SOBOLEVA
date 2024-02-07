using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
        IWebElement weight = Driver.FindElement(By.Name("weight"));
        IWebElement height = Driver.FindElement(By.Name("height"));
        IWebElement button = Driver.FindElement(By.Id("calc-mass-c"));

        height.SendKeys("183");
        weight.SendKeys("58");
        button.Click();

        Thread.Sleep(2000);
        IWebElement result = Driver.FindElement(By.Id("imt-result"));
        Assert.That(result.Text, Is.EqualTo("17.3 - Недостаточная (дефицит) масса тела"));
    }
    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(0);
        
        IWebElement age = Driver.FindElement(By.Id("age"));
        age.SendKeys("22");

        IWebElement selectWebSexElement = Driver.FindElement(By.Id("sex"));
        SelectElement selectSex = new SelectElement(selectWebSexElement);
        selectSex.SelectByIndex(1);

        IWebElement selectWebElement = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectcreat = new SelectElement(selectWebElement);
        selectcreat.SelectByValue("mg");
        
        IWebElement cr = Driver.FindElement(By.Id("cr"));
        cr.SendKeys("1");

        IWebElement selectWebRaceElement = Driver.FindElement(By.Id("race"));
        SelectElement selectrace = new SelectElement(selectWebRaceElement);
        selectrace.SelectByText("Другая");

        IWebElement mass = Driver.FindElement(By.Id("mass"));
        mass.SendKeys("52");

        IWebElement grow = Driver.FindElement(By.Id("grow"));
        grow.SendKeys("170");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();

        Thread.Sleep(5000);
        Assert.That(Driver.FindElement(By.Id("result")).Text,
            Is.EqualTo("MDRD\r\n69.33 мл/мин/1.73м2 - Незначительно сниженный уровень СКФ (C2)\r\nДля расчёта СКФ по формуле MDRD необходимы параметры: уровень креатинина, возраст, пол, раса\r\nCKD-EPI\r\n79.9 мл/мин/1.73м2 - Незначительно сниженный уровень СКФ (C2)\r\nДля расчёта СКФ по формуле CKD-EPI необходимы параметры: уровень креатинина, возраст, пол, раса\r\nФормула Кокрофта-Голта\r\n72.44 мл/мин\r\nДля расчёта СКФ по формуле Кокрофта-Голта необходимы параметры: уровень креатинина, возраст, пол, вес\r\nФормула Шварца\r\nФормула Шварца используется для расчёта СКФ у детей и взрослых до 21 года. Для расчёта необходимы параметры: уровень креатинина, возраст, пол, рост"));
    }
}