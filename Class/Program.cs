using System;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Class;

Console.WriteLine(new string('-', 80));
Console.WriteLine(new string('-', 80));
Console.WriteLine("Задание 1");
Console.WriteLine(new string('-', 80));
Console.WriteLine(new string('-', 80));

Phone phone1 = new Phone();
Phone phone2 = new Phone("89182309119", "Xiaomi");
Phone phone3 = new Phone("89181791866", "Samsung", 100);

Console.WriteLine(@$"
Телефон 1:
Number: {phone1.Number},
Model: {phone1.Model},
Weight: {phone1.Weight}");

Console.WriteLine(new string('-', 50));

Console.WriteLine(@$"
Телефон 2:
Number: {phone2.Number},
Model: {phone2.Model},
Weight: {phone2.Weight}");

Console.WriteLine(new string('-', 50));

Console.WriteLine(@"
Телефон 3:
Number: {phone3.Number},
Model: {phone3.Model},
Weight: {phone3.Weight}");

phone1.ReceiveCall("Катерина");
phone2.ReceiveCall("Мария Кирилловна");
phone3.ReceiveCall("Иван Сергеевич");

Console.WriteLine(new string('-', 50));

Console.WriteLine(phone1.GetNumber());
Console.WriteLine(phone2.GetNumber());
Console.WriteLine(phone3.GetNumber());

Console.WriteLine(new string('-', 50));

phone1.SendMessage("89180000000", "89180000001");

Console.WriteLine(new string('-', 50));

phone2.SendMessage("89180000002", "89180000003", "89180000004", "89180000005", "89180000006");

Console.WriteLine(new string('-', 80));
Console.WriteLine(new string('-', 80));
Console.WriteLine("Задание 2");
Console.WriteLine(new string('-', 80));
Console.WriteLine(new string('-', 80));

Creditcard creditcard1 = new Creditcard("123456789", 10000);
Creditcard creditcard2 = new Creditcard("123456799", 100);
Creditcard creditcard3 = new Creditcard("123456788", 5000);

creditcard1.CashNowDo();
creditcard2.CashNowDo();
creditcard3.CashNowDo();

creditcard1.PutCash(3000);
creditcard2.PutCash(15578);
creditcard3.WithdrawCash(2000);

creditcard1.CashNow();
creditcard2.CashNow();
creditcard3.CashNow();