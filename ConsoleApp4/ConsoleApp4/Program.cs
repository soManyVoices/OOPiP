using System;
using WordHelperLib;

class Program
{
    static void Main()
    {
        bool exit = false;
        char[,] letters = null;

        // Бесконечный цикл для выбора действий и работы с массивом букв
        while (!exit)
        {
            // Выводим меню с пунктами выбора
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Ввести массив букв");
            Console.WriteLine("2. Ввести слово для проверки");
            Console.WriteLine("3. Выйти из приложения");
            Console.Write("Введите номер действия: ");
            string input = Console.ReadLine();

            // Обработка выбранного действия
            switch (input)
            {
                case "1":
                    letters = WordHelper.EnterLettersArray();
                    WordHelper.OutputLettersArray(letters);
                    break;
                case "2":
                    if (letters == null)
                    {
                        Console.WriteLine("Массив букв не был введен. Пожалуйста, введите массив букв.");
                    }
                    else
                    {
                        WordHelper.CheckWord(letters);
                    }
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }
}