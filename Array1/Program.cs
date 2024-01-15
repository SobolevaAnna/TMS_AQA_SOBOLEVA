using Microsoft.VisualBasic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(@"
        Выберите номер задачи:
            1 - Проверить, входит ли заданное число в массив или нет
            2 - Удалить всех вхождения числа в массив
            3 - Max, min и avg массива случайных чисел случайной длины
            4 - Сравнение avg двух массивов
            5 - Вывести все задачи");

        int f = Convert.ToInt32(Console.ReadLine());

        if (f > 5 || f < 1)
        {
            Console.WriteLine("Вы ввели некорректный номер, такая задача отсутствует");
        }
        else
        {
            switch (f)
            {
                case 1: Search(); break;
                case 2: Delete(); break;
                case 3: MaxMin(); break;
                case 4: AvgAvg(); break;
                case 5: Search(); Delete(); MaxMin(); AvgAvg(); break;
            }
        }

        //Задание 1.
        static void Search()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 1. 
Проверить, входит ли заданное число в массив или нет");
            Console.WriteLine("--------------------------------------------------\n");

            int[] array = new int[27];
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(100);
            }
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine("Введите число, которое хотите проверить");
           
            string num = Console.ReadLine();
            int num0 = Convert.ToInt32(num);
            int index = Array.IndexOf(array, num0);
            
            if (index != -1)
            {
                Console.WriteLine($"Число {num0} входит в массив под индексом {index}");
            }
            else
            {
                Console.WriteLine($"Число {num0} не входит в массив");
            }
        }

        //Задание 2.
        static void Delete()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 2. 
Удалить всех вхождения числа в массив");
            Console.WriteLine("--------------------------------------------------\n");

            int[] array = new int[10];
            int j = 0;
            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(5);
            }
            Console.WriteLine($"Исходный массив: {string.Join(" ", array)}");

            Console.WriteLine("Введите число, которое хотите удалить");
            string num = Console.ReadLine();
            int num0 = Convert.ToInt32(num);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != num0)
                {
                    if (j != i)
                    {
                        array[j] = array[i];
                    }
                    j++;
                }
            }

            if (j == 10)
            {
                Console.WriteLine("Такого числа нет в массиве");
            }

            Array.Resize(ref array, j);

            Console.WriteLine($"Итоговый массив: {string.Join(" ", array)}");
        }

        //Задание 3.
        static void MaxMin()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 3. 
Max, min и avg массива случайных чисел случайной длины");
            Console.WriteLine("--------------------------------------------------\n");

            Console.WriteLine("Введите размерность массива");
            string r0 = Console.ReadLine();
            int r = Convert.ToInt32(r0);
            float sum = 0;
            int[] array = new int[r];
            Random randNum = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(10);
            }

            Array.Sort(array);
            Console.WriteLine($"Итоговый массив: {string.Join(" ", array)}");

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            int minimum = array[0];
            Console.WriteLine($" Минимум массива: {minimum}");
            int maximum = array[array.Length - 1];
            Console.WriteLine($" Максимум массива: {maximum}");
            float avg = (float)Math.Round(sum / array.Length, 2);
            Console.WriteLine($" Среднее арифметическое массива: {avg}");
        }

        //Задание 4.
        static void AvgAvg()
        {
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine(@"Задание 4. 
Сравнение avg двух массивов");
            Console.WriteLine("--------------------------------------------------\n");

            int[] array1 = new int[5];
            int[] array2 = new int[5];
            Random randNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                array1[i] = randNum.Next(10);
                array2[i] = randNum.Next(10);
            }
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));

            float sum1 = 0;
            float sum2 = 0;

            for (int i = 0; i < 5; i++)
            {
                sum1 += array1[i];
                sum2 += array2[i];
            }

            if (((float)Math.Round(sum1 / 5, 2)) > ((float)Math.Round(sum2 / 5, 2)))
            {
                Console.WriteLine($"Среднее арифметическое первого массива больше и равняется {(float)Math.Round(sum1 / 5, 2)}");
            }
            else if (((float)Math.Round(sum1 / 5, 2)) < ((float)Math.Round(sum2 / 5, 2)))
            {
                Console.WriteLine($"Среднее арифметическое второго массива больше и равняется {(float)Math.Round(sum2 / 5, 2)}");
            }
            else
            {
                Console.WriteLine($"Среднее арифметическое обеих массивов одинаковое и равняется {(float)Math.Round(sum2 / 5, 2)}");
            }
        }
    }
}