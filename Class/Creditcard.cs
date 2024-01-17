using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class;

public class Creditcard
{
    public string AccountNumber;
    public int SumNow;

    public Creditcard(string number, int sum)
    {
        AccountNumber = number;
        SumNow = sum;
    }

    public void CashNowDo()
    {
        Console.WriteLine($"На карте {AccountNumber} в настоящий момент {SumNow}");
    }

    public void PutCash(int cash)
    {
        SumNow += cash;
        Console.WriteLine($"Вы внесли на счет {cash}");
    }
    public void WithdrawCash(int cash)
    {
        if (SumNow >= cash)
        {
            SumNow -= cash;
            Console.WriteLine($"Вы сняли со счета {cash}");
        }
        else
        {
            Console.WriteLine("На счете недостаточно средств");
        }
    }
    public void CashNow()
    {
        Console.WriteLine($"На карте {AccountNumber} в настоящий момент {SumNow}");
    }
}