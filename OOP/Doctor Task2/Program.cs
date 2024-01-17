using System;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using figur;
using park;
using clinic;
using System.Diagnostics;
using System.Drawing;
using System.Numerics;


Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));
Console.WriteLine("Задание 1");
Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));

Figure[] figures =
{
    new Rectangles(0.5f, 8),
    new Square(5),
    TriangCreator.CreateTriangle(3, 4, 5),
    TriangCreator.CreateTriangle(3, 4, 5),
    TriangCreator.CreateTriangle(3, 4, 5),
    TriangCreator.CreateTriangle(3, 4, 5),
};
foreach (var figure in figures)
    figure.PrintInfo();

Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));
Console.WriteLine("Задание 2");
Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));

TreatmentPlan treatmentPlanSurgical = new TreatmentPlan(1);
TreatmentPlan treatmentPlanDental = new TreatmentPlan(2);
TreatmentPlan treatmentPlanTherapeutic = new TreatmentPlan(3);

Patient[] patients =
{
            new Patient("Попов Андрей Максимович", treatmentPlanSurgical),
            new Patient("Матвеев Денис Сергеевич", treatmentPlanDental),
            new Patient("Выграновская Кира Эдуардовна", treatmentPlanTherapeutic)
        };
Console.WriteLine(new string('-', 60));

foreach (var patient in patients)
{
    Console.WriteLine($"Пациент {patient.FIO}");
    patient.AppointDoctor();
    Console.WriteLine(new string('-', 50));
}

Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));
Console.WriteLine("Задание 3");
Console.WriteLine(new string('-', 60));
Console.WriteLine(new string('-', 60));

Transport[] transport =
{
        new Train("Хибины", 237, new DateTime(2024, 01, 13, 03, 10, 00), 73),
        new Train("Казань", 1552, new DateTime(2024, 01, 03, 03, 10, 00), 300),
        new Bus("Краснодар", 193, new DateTime(2024, 01, 17, 13, 15, 00), 7),
        new Planes("Кострома", 1152, new DateTime(2024, 02, 01, 21, 06, 00), 133),
        new Planes("Владивосток", 860, new DateTime(2024, 01, 30, 19, 15, 00), 186),
        new Speedboat("Стамбул", 667, new DateTime(2024, 01, 26, 03, 10, 00), 20),
};

for (int i = 0; i < transport.Length; i++)
{
    TransportService.PrinttransortType(transport[i]);
    transport[i].PrintInfo();
    Console.WriteLine(new string('-', 50));
}

Array.Sort(transport, (x, y) => x.NumberSeats.CompareTo(y.NumberSeats));

for (int i = 0; i < transport.Length; i++)
    Console.WriteLine($"{i} : {transport[i].Number}, {transport[i].Destination}, {transport[i].DepartureTime}, {transport[i].NumberSeats} ");

String userDestination;
Console.WriteLine("Введите пункт назначения");
userDestination = Console.ReadLine();

DateTime userDateTime;
Console.WriteLine("Введите дату в формате dd.MM.YYYY HH:MM:SS");
userDateTime = Convert.ToDateTime(Console.ReadLine());

int flag = 0;
for (int i = 0; i < transport.Length; i++)
    if (transport[i].DepartureTime == userDateTime && transport[i].Destination == userDestination)
    {
        Console.WriteLine($"Ваш транспорт: {transport[i].Number}, {transport[i].Destination}, {transport[i].DepartureTime}, {transport[i].NumberSeats}");
        flag++;
    }
if (flag == 0) Console.WriteLine("В указанное время и указанный пункт ни один транспорт не отходит");

Console.WriteLine(new string('-', 70));

Console.WriteLine("Введите дату, позднее которой вас интересует расписание");
DateTime userDateTime2;
userDateTime2 = Convert.ToDateTime(Console.ReadLine());

flag = 0;
foreach (var tran in transport)
    if (tran.DepartureTime > userDateTime2)
    {
        Console.WriteLine($"Ваш транспорт: {tran.Number}, {tran.Destination}, {tran.DepartureTime}, {tran.NumberSeats}");
        flag++;
    }
if (flag == 0) Console.WriteLine("В указанное время ни один транспорт не отходит");