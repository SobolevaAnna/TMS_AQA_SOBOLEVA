using NUnit.Framework.Legacy;

namespace NUnitTest;

public class TestCaseExample
{
    [TestCase(2.2, -2, -1.1)]
    [TestCase(17.22, 4.1, 4.2)]
    [TestCase(16, 4, 4)]
    [Category("Positive")]
    [Category("TestInt")]
    [Order(1)]
    [Severity(SeverityLevel.Critical)]
    public void Test1(double x, double y, double result)
    {
        Assert.That(Calc.Div(x, y), Is.EqualTo(result));
    }

    [TestCase(12, 4, ExpectedResult = 3)]
    [TestCase(20, -2, ExpectedResult = -10)]
    [Category("Positive")]
    [Category("TestDouble")]
    [Order(2)]
    [Severity(SeverityLevel.Major)]
    public int Test2(int x, int y)
    {
        return Calc.Div(x, y);
    }

    public static object[] DivideCasesInt =
    {
        new object[] { 12, 3, 4 },
        new object[] { 10, 5, 2 }
    };

    [TestCaseSource(nameof(DivideCasesInt))]
    [Category("Positive")]
    [Category("TestInt")]
    [Severity(SeverityLevel.Normal)]
    public void DivideTest(int n, int d, int q)
    {
        Assert.That(n / d, Is.EqualTo(q));
    }

    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCases))]
    [Category("Positive")]
    [Category("TestDouble")]
    [Severity(SeverityLevel.Minor)]
    public void ExternalDataTest(double n, double d, double q)
    {
        Assert.That(n / d, Is.EqualTo(q));
    }

    [Test(ExpectedResult = 4)]
    [Category("Positive")]
    [Category("TestInt")]
    [Order(1)]
    [Repeat(3)]
    [Severity(SeverityLevel.Major)]
    public int ExpectedResultTestInt()
    {
        return 2 + 2;
    }

    [Test(ExpectedResult = 2.4)]
    [Category("Positive")]
    [Category("TestDouble")]
    [Severity(SeverityLevel.Critical)]
    public double ExpectedResultTestDouble()
    {
        return 2.1 + 2.3;
    }

    private int i = 0;

    [Test]
    [Description("Успешное выполнение теста, при результате не равном 3")]
    [Category("Positive")]
    [Category("TestInt")]
    [Severity(SeverityLevel.Critical)]
    [Retry(4)]
    public void RetryTest(
       [Random(5, 100, 2)] int numberInt1,
       [Random(5, 10, 2)] int numberInt2)
    {
        i = numberInt1 / numberInt2;
        Console.WriteLine($"{this}: RandomAndValuesTest... {i}");
        if (i != 3) Assert.Pass();
            else Assert.Fail();
    }

    [TestCase(9, 3, ExpectedResult = 3)]
    [Ignore("Ignoring these tests for now.")]
    public int IgnoreTest(int x, int y)
    {
        return Calc.Div(x, y);
    }

    [Test]
    [Description("Тест на проверку ошибки деления на ноль")]
    [Category("Negative")]
    [Category("TestInt")]
    [Order(3)]
    [Severity(SeverityLevel.Critical)]
    public void ErrorTest1()
    {
        Assert.Throws<DivideByZeroException>(() => Calc.Div(10, 0));
    }

    [Test]
    [Description("Тест на проверку ошибки деления на ноль")]
    [Category("Negative")]
    [Category("TestDouble")]
    [Severity(SeverityLevel.Critical)]
    public void ErrorTest2()
    {
        Assert.That(double.IsInfinity(Calc.Div(7.3, 0)));
    }

}