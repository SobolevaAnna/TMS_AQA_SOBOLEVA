using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Как к вам обращаться? Введите свое имя, а затем нажмите клавишу 'Enter'");
            string user = Console.ReadLine();
            Console.WriteLine($"Hello, {user}!");

        Console.WriteLine(@"
        Выберите номер задачи:
            1 - Консольный калькулятор
            2 - Определение интервала, в который попадет число
            3 - Англо-русский словарь погоды
            4 - Проверка четности числа, алгоритм 1
            5 - Проверка четности числа, алгоритм 2
            6 - Вывести все задачи");
        int f = Convert.ToInt32(Console.ReadLine());

        if (f >6 || f < 1)
        {
            Console.WriteLine("Вы ввели некорректный номер, такая задача отсутствует");
        }
        else
        {
            switch (f)
            {
                case 1: Calc(); break;
                case 2: BetweenNumbers(); break;
                case 3: DictioneryWeather(); break;
                case 4: ParityNumber1(); break;
                case 5: ParityNumber2(); break;
                case 6: Calc(); BetweenNumbers(); DictioneryWeather(); ParityNumber1(); ParityNumber2(); break;
            }
        }

        //Задание 1.
        static void Calc()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 1. 
Консольный калькулятор");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите первое число");
            string numone = Console.ReadLine();
            int num1 = Convert.ToInt32(numone);
            Console.WriteLine("Введите оператор");
            string oper = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string numtwo = Console.ReadLine();
            int num2 = Convert.ToInt32(numtwo);

            if (num2 == 0 && oper == "/")
            {
                Console.WriteLine("Деление на 0 невозможно");
            }

            switch (oper)
            {
                case "+":
                    Console.WriteLine($"Результат сложение = {num1 + num2}"); break;
                case "-":
                    Console.WriteLine($"Результат вычитания = {num1 - num2}"); break;
                case "*":
                    Console.WriteLine($"Результат умножения = {num1 * num2}"); break;
                case "/":
                    Console.WriteLine($"Результат деления = {num1 / num2}"); break;
                default:
                    Console.WriteLine("Оператор введен некорректно"); break;
            }
        }

        static void BetweenNumbers()
        {
            //Задание 2.
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 2. 
Определить диапазон, в который входит число");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите число от -50 до 50");
            string numfive = Console.ReadLine();
            int num0 = Convert.ToInt32(numfive);

            if (num0 < -50 && num0 > 50)
            {
                Console.WriteLine($"Число {num0} не входит в указанный диапазон");
            }
            else if (num0 >= -40 && num0 <= -10)
            {
                Console.WriteLine($"Число {num0} входит в промежуток [-40;-10]");
            }
            else if (num0 >= -9 && num0 <= 0)
            {
                Console.WriteLine($"Число {num0} входит в промежуток [-9;0]");
            }
            else if (num0 >= 1 && num0 <= 10)
            {
                Console.WriteLine($"Число {num0} входит в промежуток [1;10]");
            }
            else if (num0 >= 11 && num0 <= 40)
            {
                Console.WriteLine($"Число {num0} входит в промежуток [11;40]");
            }
            else
            {
                Console.WriteLine($"Число {num0} не входит ни в один промежуток");
            }
        }

        static void DictioneryWeather()
        {
            //Задание 3.
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 3. 
Англо-русский словарь терминов погоды");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите термин погоды со строчной буквы на русском языке");
            string weather = Console.ReadLine();

            switch (weather)
            {
                case "жарко":
                    Console.WriteLine("hot"); break;
                case "солнечно":
                    Console.WriteLine("sunny"); break;
                case "ветер":
                    Console.WriteLine("wind"); break;
                case "дождь":
                    Console.WriteLine("rain"); break;
                case "буря":
                    Console.WriteLine("whirlwind"); break;
                case "туман":
                    Console.WriteLine("fog"); break;
                case "пасмурно":
                    Console.WriteLine("overcast"); break;
                case "снегопад":
                    Console.WriteLine("snowfall"); break;
                case "облачно":
                    Console.WriteLine("cloudy"); break;
                case "ураган":
                    Console.WriteLine("hurricane"); break;
                default:
                    Console.WriteLine("Такого слова нет в словаре"); break;
            }
        }

        static void ParityNumber1()
        {
            //Задание 4.
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 4. 
Определение четности числа разными способами.
Способ 1");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите целое число");
            string num41 = Console.ReadLine();
            int numparity = Convert.ToInt32(num41);

            if (numparity % 2 == 0)
            {
                Console.WriteLine($"Число {numparity} четное");
            }
            else
            {
                Console.WriteLine($"Число {numparity} не четное");
            }
        }

        static void ParityNumber2()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Определение четности числа разными способами.
Способ 2");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите целое число");
            string num42 = Console.ReadLine();
            int numparity2 = Convert.ToInt32(num42);

            if (numparity2 % 10 == 0 || numparity2 % 10 == 2 || numparity2 % 10 == 4 || numparity2 % 10 == 6 || numparity2 % 10 == 8)
            {
                Console.WriteLine($"Число {numparity2} четное");
            }
            else
            {
                Console.WriteLine($"Число {numparity2} не четное");
            }
        }
        }
    }
