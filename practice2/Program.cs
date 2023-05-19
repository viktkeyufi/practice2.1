using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("Задание 1");

                        Console.Clear();

                    Console.WriteLine("Введите число");
                    double num = double.Parse(Console.ReadLine());

                    if (num >= 0)
                    {
                        num += 5;
                    }
                    else
                    {
                        num -= 5;
                    }
                    Console.WriteLine($"Итог: {num}");
                    }
                    break;

                case ConsoleKey.D2:
                    {
                        Console.WriteLine("Здание 2");

                        Console.Write("Введите первое число: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double num2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        double num3 = double.Parse(Console.ReadLine());

                        if (num1 >= num2 && num1 >= num3)
                        {
                            Console.WriteLine($"Максимальное число: {num1}");
                        }
                        else if(num2 >= num1 && num2 >= num3)
                        {
                            Console.WriteLine($"Максимально число{num2}");
                        }
                        else
                        {
                            Console.WriteLine($"Максимальное число: {num3}");
                        }
                    }
                    break;

                case ConsoleKey.D3:
                    {
                        Console.WriteLine("Задание 3");

                        Console.Write("Введите первое число: ");
                        double number1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double number2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите третье число: ");
                        double number3 = double.Parse(Console.ReadLine());

                        double sum = 0;
                        if (number1 > 0)
                        {
                            sum += number1;
                        }
                        if(number2 > 0)
                        {
                            sum += number2;
                        }
                        if(number3 > 0)
                        {
                            sum += number3;
                        }
                        Console.WriteLine($"Сумма положительных чисел: {sum}");
                    }
                    break;

                case ConsoleKey.D4:
                    {
                        Console.WriteLine("Задание 4");

                        Console.WriteLine("Введите число х: ");
                        double x = double.Parse(Console.ReadLine());

                        if(x > 10)
                        {
                            x *= 2;
                        }
                    }
                    break;

                case ConsoleKey.D5:
                    {
                        Console.WriteLine("Задание 5");

                        Console.WriteLine("Введите число недели");
                        int choice = int.Parse(Console.ReadLine());
                        switch(choice)
                        {
                            case 1:
                                Console.WriteLine("Понедельнк");
                                break;
                            case 2:
                                Console.WriteLine("Вторник");
                                break;
                            case 3:
                                Console.WriteLine("Среда");
                                break;
                            case 4:
                                Console.WriteLine("Четверг");
                                break;
                            case 5:
                                Console.WriteLine("Пятница");
                                break;
                            case 6:
                                Console.WriteLine("Суббота");
                                break;
                            case 7:
                                Console.WriteLine("Воскресенье");
                                break;
                            default:
                                Console.WriteLine("Такого количества дней нет");
                                break;
                        }
                    }
                    break;

                case ConsoleKey.D6:
                    {
                        Console.WriteLine("Задание 6");

                        int numdel = 200;
                        while(numdel % 17 != 0)
                        {
                            numdel++;
                        }
                        Console.WriteLine($"Минимальное число, большее 200, которое делится на 17: {numdel}");
                    }
                    break;

                case ConsoleKey.D7:
                    {
                        Console.WriteLine("Задание 7");

                        double distante = 10;
                        int days = 1;

                        while(distante > 20)
                        {
                            distante += distante * 0.05;
                            days++;
                        }
                        Console.WriteLine($"Пробежит 20км на {days} день");

                        while (distante > 100)
                        {
                            distante += distante * 0.05;
                            days++;
                        }
                        Console.WriteLine($"Пробежит более 100км на {days} день");    
                    }
                    break;
                case ConsoleKey.D8:
                    {
                        Console.WriteLine("Задание 8");

                        Console.WriteLine("Введите число");
                        double numfactor = int.Parse(Console.ReadLine());

                        int factorial = 1;
                        for(int i = 1; i <= numfactor; i++)
                        {
                            factorial *= 1;
                        }
                        Console.WriteLine($"Факториал {numfactor} равен {factorial}");
                    }
                    break;

                case ConsoleKey.D9:
                    {
                        Console.WriteLine("Задание 9");

                        Console.WriteLine("Введите натуральное число");
                        int numnatur = int.Parse(Console.ReadLine());
                        int small = 0;

                        for(int i = 2;  i <= numnatur; i++)
                        {
                            if (numnatur % i == 0)
                            {
                                small = i;
                                break;
                            }
                        }
                        if (small > 0)
                        {
                            Console.WriteLine($"Наименьший делитель числа {numnatur} равен {small}");
                        }
                        else
                        {
                            Console.WriteLine($"Число {numnatur} простое");
                        }
                    }
                    break;

                    Console.ReadKey();
            }
        }
    }
}
