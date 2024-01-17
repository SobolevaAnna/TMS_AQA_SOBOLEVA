using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class;

public class Phone
{
    public string Number;
    public string Model;
    public double Weight;

    public Phone() { }

    public Phone(string number, string model)
    {
        Number = number;
        Model = model;
    }

    public Phone(string number, string model, double weight) : this(number, model)
    { Weight = weight; }

    public void ReceiveCall(string name)
    {
        Console.WriteLine($"Вам звонит {name}");
    }

    public string GetNumber() => Number;

    public void SendMessage(params string[] numbers)
    {
        foreach (string n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}
