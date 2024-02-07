using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace SeleniumBasic.Tests;

public class LaminateTest : BaseTest
{
    [Test]
    public void CalcLaminateTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement roomLength = Driver.FindElement(By.Id("ln_room_id"));
        roomLength.Clear();
        roomLength.SendKeys("400");

        IWebElement roomWidth = Driver.FindElement(By.Id("wd_room_id"));
        roomWidth.Clear();
        roomWidth.SendKeys("250");

        IWebElement lnlam = Driver.FindElement(By.Id("ln_lam_id"));
        lnlam.Clear();
        lnlam.SendKeys("1470");

        IWebElement wdlam = Driver.FindElement(By.Id("wd_lam_id"));
        wdlam.Clear();
        wdlam.SendKeys("300");

        IWebElement npacking = Driver.FindElement(By.Id("n_packing"));
        npacking.Clear();
        npacking.SendKeys("20");

        IWebElement area = Driver.FindElement(By.Id("area"));
        area.Clear();
        area.SendKeys("5");

        Driver.FindElement(By.Id("direction-laminate-id3")).Click();

        IWebElement methodlaminate = Driver.FindElement(By.Id("laying_method_laminate"));
        SelectElement selectmethodlaminate = new SelectElement(methodlaminate);
        selectmethodlaminate.SelectByValue("2");

        IWebElement field = Driver.FindElement(By.Id("min_length_segment_id"));
        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].setAttribute('value', '300')", field);

        IWebElement fieldtwo = Driver.FindElement(By.Id("btn_calculate"));
        ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].setAttribute('value', '10')", fieldtwo);
        
        Driver.FindElement(By.Id("btn_calculate")).Click();

        Thread.Sleep(5000);
        Assert.That(Driver.FindElement(By.CssSelector(".calc-result")).Text, 
            Is.EqualTo("Требуемое количество плашек ламината: 26\r\nКоличество упаковок ламината: 2\r\nСтоимость ламината: 0 руб\r\nВес ламината: 0 кг"));
    }
    
}