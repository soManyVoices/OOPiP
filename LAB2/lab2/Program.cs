using System;
using ComplexLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            bool running = true;
            ComplexNumber c1 = null;
            ComplexNumber c2 = null;

            while (running)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Ввести первое комплексное число ");
                Console.WriteLine("2. Ввести второе комплексное число ");
                Console.WriteLine("3. Выполнить сложение");
                Console.WriteLine("4. Выполнить умножение");
                Console.WriteLine("0. Выйти");

                Console.Write("Выберите опцию: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Введите вещественную часть первого числа : ");
                        double real1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите мнимую часть первого числа : ");
                        double imaginary1 = double.Parse(Console.ReadLine());
                        c1 = new ComplexNumber(real1, imaginary1);
                        Console.WriteLine("Число 1 введено.");
                        break;

                    case "2":
                        Console.Write("Введите вещественную часть второго числа : ");
                        double real2 = double.Parse(Console.ReadLine());
                        Console.Write("Введите мнимую часть второго числа : ");
                        double imaginary2 = double.Parse(Console.ReadLine());
                        c2 = new ComplexNumber(real2, imaginary2);
                        Console.WriteLine("Число 2 введено.");
                        break;

                    case "3":
                        if (c1 != null && c2 != null)
                        {
                            ComplexNumber sum = c1 + c2;
                            Console.WriteLine($"Сумма: {sum.Real} + {sum.Imaginary}i");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите оба комплексных числа.");
                        }
                        break;

                    case "4":
                        if (c1 != null && c2 != null)
                        {
                            ComplexNumber product = c1 * c2;
                            Console.WriteLine($"Произведение: {product.Real} + {product.Imaginary}i");
                        }
                        else
                        {
                            Console.WriteLine("Пожалуйста, введите оба комплексных числа.");
                        }
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите опцию из меню.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}