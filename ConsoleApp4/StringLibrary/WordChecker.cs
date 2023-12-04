using System;
namespace WordHelperLib
    {
        public static class WordHelper
        {
            // Метод для ввода двумерного массива букв с клавиатуры.
             
            public static char[,] EnterLettersArray()
            {
                Console.WriteLine("Введите размеры двумерного массива (через пробел):");
                string[] inputSize = Console.ReadLine().Split(' ');
                int rows = int.Parse(inputSize[0]);
                int columns = int.Parse(inputSize[1]);

                char[,] letters = new char[rows, columns];

                Console.WriteLine("Введите элементы массива (по одному элементу в строке):");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        letters[i, j] = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("Массив букв успешно введен.");

                return letters;
            }

            // Метод для вывода двумерного массива букв на консоль.
             
            public static void OutputLettersArray(char[,] letters)
            {
                Console.WriteLine("Введенный массив букв:");
                for (int i = 0; i < letters.GetLength(0); i++)
                {
                    for (int j = 0; j < letters.GetLength(1); j++)
                    {
                        Console.Write(letters[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            //Метод для проверки, можно ли составить заданное слово из букв массива.
             
            public static void CheckWord(char[,] letters)
            {
                Console.Write("Введите слово для проверки: ");
                string word = Console.ReadLine();

                bool canFormWord = CanFormWord(letters, word);

                if (canFormWord)
                {
                    Console.WriteLine($"Можно составить слово '{word}' из букв массива.");
                }
                else
                {
                    Console.WriteLine($"Невозможно составить слово '{word}' из букв массива.");
                }
            }

            // Метод для определения, можно ли составить заданное слово из букв массива.
             
            public static bool CanFormWord(char[,] letters, string word)
            {
                int rows = letters.GetLength(0);
                int columns = letters.GetLength(1);

                // Преобразуем двумерный массив в одномерный массив символов
                char[] allLetters = new char[rows * columns];
                int index = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        allLetters[index++] = letters[i, j];
                    }
                }

                // Преобразуем заданное слово в массив символов
                char[] wordLetters = word.ToCharArray();

                // Проверяем, можно ли из символов массива составить заданное слово
                foreach (char letter in wordLetters)
                {
                    int letterIndex = Array.IndexOf(allLetters, letter);
                    if (letterIndex == -1)
                    {
                        return false; // Символ не найден в массиве
                    }
                    allLetters[letterIndex] = '\0'; // Помечаем использованный символ как пустой
                }

                return true; // Все символы найдены
            }
        }
    }
    

   