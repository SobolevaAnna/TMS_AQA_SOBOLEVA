using AbstractClasses.Game;

Console.WriteLine(new string('-', 60));
Console.WriteLine("Задание 1\nРасчет периметра и площади геометрических фигур");
Console.WriteLine(new string('-', 60));

double Perimeter = 0;
double Area = 0;

Figure[] figures =
{
    new Triangle(3, 5, 4),
    new Quadrilateral(4, 5.5f),
    new Quadrilateral(10, 20),
    new Circle(7)
};

foreach (var figure in figures)
{
    figure.PrintInfo();
    Perimeter += figure.GetPerimeter();
    Area += figure.GetArea();
}

Console.WriteLine($"\nСуммарная площадь: {Math.Round(Area, 2)}\nСуммарный периметр: {Math.Round(Perimeter, 2)}");

Console.WriteLine();
Console.WriteLine(new string('-', 60));
Console.WriteLine("Задание 2\nВыявление просроченный продуктов");
Console.WriteLine(new string('-', 60));
Console.WriteLine();


Console.WriteLine("Продукты");

Product[] products =
{
    new Product("Овсяное печенье", 150, new DateOnly(2023, 05, 01), new DateOnly(2023, 09, 01)),
    new Product("Шоколадное печенье", 250, new DateOnly(2024, 01, 01), new DateOnly(2024, 04, 01)),
    new Product("Протеиновое печенье", 85, new DateOnly(2023, 11, 01), new DateOnly(2024, 02, 01)),
};

foreach (var item in products)
{
    item.PrintInfo();
}

Console.WriteLine("\nПросроченные товары:");
foreach (Product product in products)
    if (product.IsExpired())
        Console.WriteLine(product.Name);

Console.WriteLine();
Console.WriteLine(new string('-', 60));
Console.WriteLine("\nПартия товаров");

Batch[] batches =
{
    new Batch("Спагетти", 10, 300, new DateOnly(2023, 10, 01), new DateOnly(2024, 04, 01)),
    new Batch("Лапша", 20, 205, new DateOnly(2023, 06, 10), new DateOnly(2024, 01, 10))
};

foreach (var item in batches)
{
    item.PrintInfo();
}

Console.WriteLine("\nПросроченные товары:");
foreach (Batch batch in batches)
    if (batch.IsExpired())
        Console.WriteLine(batch.Name);

Console.WriteLine();
Console.WriteLine(new string('-', 60));
Console.WriteLine("\nКомплект товаров");

Product vegetables1 = new Product("Спаржа замороженная", 380, new DateOnly(2023, 08, 25), new DateOnly(2025, 08, 25));
Product vegetables2 = new Product("Горошек зеленый замороженный", 130, new DateOnly(2022, 03, 10), new DateOnly(2024, 03, 10));
Product vegetables3 = new Product("Брюссельская капуста замороженная", 150, new DateOnly(2023, 09, 09), new DateOnly(2024, 09, 09));
Product fruits1 = new Product("Облепиха замороженная", 180, new DateOnly(2022, 11, 01), new DateOnly(2025, 10, 01));
Product fruits2 = new Product("Клюква замороженная", 165, new DateOnly(2021, 05, 01), new DateOnly(2023, 07, 01));

Set[] sets =
{
    new Set("Замороженные овощи", 1300, new List<Product> {vegetables1,  vegetables2, vegetables3}),
    new Set("Замороженные фрукты", 150, new List<Product> { fruits1, fruits2})
};

foreach (var item in sets)
{
    item.PrintInfo();
}

Console.WriteLine();
Console.WriteLine("Просроченные товары:");
foreach (Set set in sets)
    if (set.IsExpired())
        Console.WriteLine(set.Name);