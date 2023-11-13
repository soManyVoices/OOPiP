using MatrixLibrary;
using System;

namespace MatrixConsoleApp
{
    class Program
    {
        private static int[,] _matrix;
        private static int _size;
        static void Main(string[] args)
        {
            SquareMatrix matrixA = new SquareMatrix("Матрица A",0);
            SquareMatrix matrixB = new SquareMatrix("Матрица B",0);
            SquareMatrix matrixC = new SquareMatrix("Матрица C",0);

            bool IsExistmatrixA = false;
            bool IsExistmatrixB = false;
            bool IsExistmatrixC = false;

            bool running = true;
                                   
            while (running)

            {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1. Ввести матрицу A");
                    Console.WriteLine("2. Ввести матрицу B");
                    Console.WriteLine("3. Ввести матрицу C");
                    Console.WriteLine("4. Сумма элементов главной диагонали матриц");
                    Console.WriteLine("5. Сумма элементов выше главной диагонали матриц");
                    Console.WriteLine("6. Сумма элементов ниже главной диагонали матриц");
                    Console.WriteLine("7. Описание матриц");
                    Console.WriteLine("8. Произведение элементов главной и двух соседних диагоналей матрицы A, A-B ");
                    Console.WriteLine("9. Произведение элементов всех диагоналей матрицы C ");
                    Console.WriteLine("10. Проверка A = B и увеличение элементов главных диагоналей");
                    Console.WriteLine("11. Вывести матрицу A");
                    Console.WriteLine("12. Вывести матрицу B");
                    Console.WriteLine("13. Вывести матрицу C");
                    Console.WriteLine("0. Выход");

                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                        Console.Write($"Введите размерность квадратной матрицы A: ");
                        InputSizeFromConsole();
                        Console.WriteLine($"Введите элементы для матрицы  A:");
                        InputMatrix();
                        Console.WriteLine($"Матрица A:");
                        OutputMatrix();
                        IsExistmatrixA = true;
                        break;
                        case "2":
                        Console.Write($"Введите размерность квадратной матрицы B: ");
                        InputSizeFromConsole();
                        Console.WriteLine($"Введите элементы для  матрицы B:");
                        InputMatrix();
                        Console.WriteLine($"Матрица B:");
                        OutputMatrix();
                        IsExistmatrixB = true;
                        break;
                        case "3":
                        Console.Write($"Введите размерность квадратной матрицы C: ");
                        InputSizeFromConsole();
                        Console.WriteLine($"Введите элементы для матрицы C:");
                        InputMatrix();
                        Console.WriteLine($"Матрицв C:");
                        OutputMatrix();
                        IsExistmatrixC = true;
                        break;
                        case "4":
                        if (IsExistmatrixA == false || IsExistmatrixB == false || IsExistmatrixC == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        double sumMainDiagonalA = matrixA.SumOfMainDiagonal();
                        double sumMainDiagonalB = matrixB.SumOfMainDiagonal();
                        double sumMainDiagonalC = matrixC.SumOfMainDiagonal();
                        Console.WriteLine($"Сумма элементов главной диагонали матрицы A: {sumMainDiagonalA}");
                        Console.WriteLine($"Сумма элементов главной диагонали матрицы B: {sumMainDiagonalB}");
                        Console.WriteLine($"Сумма элементов главной диагонали матрицы C: {sumMainDiagonalC}");
                        break;
                        case "5":
                        if (IsExistmatrixA == false || IsExistmatrixB == false || IsExistmatrixC == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        double sumOfElementsAboveMainDiagonalA = matrixC.SumOfElementsAboveMainDiagonal();
                        double sumOfElementsAboveMainDiagonalB = matrixC.SumOfElementsAboveMainDiagonal();
                        double sumOfElementsAboveMainDiagonalC = matrixC.SumOfElementsAboveMainDiagonal();
                        Console.WriteLine($"Сумма элементов выше главной диагонали матрицы A: {sumOfElementsAboveMainDiagonalA}");
                        Console.WriteLine($"Сумма элементов выше главной диагонали матрицы B: {sumOfElementsAboveMainDiagonalB}");
                        Console.WriteLine($"Сумма элементов выше главной диагонали матрицы C: {sumOfElementsAboveMainDiagonalC}");
                                break;
                        case "6":
                        if (IsExistmatrixA == false || IsExistmatrixB == false || IsExistmatrixC == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        double sumOfElementsBelowMainDiagonalA = matrixC.SumOfElementsBelowMainDiagonal();
                        double sumOfElementsBelowMainDiagonalB = matrixC.SumOfElementsBelowMainDiagonal();
                        double sumOfElementsBelowMainDiagonalC = matrixC.SumOfElementsBelowMainDiagonal();
                        Console.WriteLine($"Сумма элементов ниже главной диагонали матрицы A: {sumOfElementsBelowMainDiagonalA}");
                        Console.WriteLine($"Сумма элементов ниже главной диагонали матрицы B: {sumOfElementsBelowMainDiagonalB}");
                        Console.WriteLine($"Сумма элементов ниже главной диагонали матрицы C: {sumOfElementsBelowMainDiagonalC}");
                                break;
                        case "7":
                        if (IsExistmatrixA == false || IsExistmatrixB == false || IsExistmatrixC == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        string matrixADescription = (string)matrixA;
                        string matrixBDescription = (string)matrixB;
                        string matrixCDescription = (string)matrixC;

                        Console.WriteLine(matrixADescription);
                        Console.WriteLine(matrixBDescription);
                        Console.WriteLine(matrixCDescription);

                        double maxElementA = matrixA.GetMaxElement();
                        double maxElementB = matrixB.GetMaxElement();
                        double maxElementC = matrixC.GetMaxElement();

                        double minElementA = matrixA.GetMinElement();
                        double minElementB = matrixB.GetMinElement();
                        double minElementC = matrixC.GetMinElement();

                        
                        break;
                        case "8":
                        if (IsExistmatrixA == false || IsExistmatrixB == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        double productDiagonalsA = matrixA.ProductOfDiagonals();
                        Console.WriteLine("Произведение главной и двух соседних диагоналей матрицы А:" + productDiagonalsA); ;
                        double productDiagonalsB = matrixB.ProductOfDiagonals();
                        Console.WriteLine("Произведение главной и двух соседних диагоналей матрицы А:" + productDiagonalsB);
                        double Difference = productDiagonalsA - productDiagonalsB;
                        Console.WriteLine("Разность произведений A и B: " + Difference);
                        break;
                        case "9":
                        if (IsExistmatrixC == false)
                        {
                            Console.WriteLine("Матрица С не была введена.");
                            break;
                        }
                        double productAllDiagonalsC = matrixC.ProductOfAllDiagonals();

                        Console.WriteLine($"Произведение элементов всех диагоналей матрицы C: {productAllDiagonalsC}");
                        break;
                        case "10":
                        if (IsExistmatrixA == false || IsExistmatrixB == false)
                        {
                            Console.WriteLine("Не все матрицы были введены.");
                            break;
                        }
                        if (matrixA == matrixB)
                        {
                            matrixA.IncreaseMatrixIfEqual(matrixA, matrixB);
                            Console.WriteLine("Элементы главной диагонали матриц были увеличены.");
                        }
                        else
                        {
                            Console.WriteLine("Матрицы не равны.");
                            break;
                        }
                        break;
                        case "11":
                        if (IsExistmatrixA == false)
                        {
                            Console.WriteLine("Матрица A не была введена.");
                            break;
                        }
                        Console.WriteLine("Матрица A: ");
                        OutputMatrix();
                        break;
                        case "12":
                        if (IsExistmatrixB == false)
                        {
                            Console.WriteLine("Матрица B не была введена.");
                            break;
                        }
                        Console.WriteLine("Матрица B: ");
                        OutputMatrix();
                        break;
                        case "13":
                        if (IsExistmatrixC == false)
                        {
                            Console.WriteLine("Матрица С не была введена.");
                            break;
                        }
                        Console.WriteLine("Матрица C: ");
                        OutputMatrix();
                        break;
                    case "0":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Неверная опция");
                            break;
                    }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод InputSizeFromConsole запрашивает у пользователя размерность матрицы.
        /// </summary>
        public static void InputSizeFromConsole()
        {           
            _size = Convert.ToInt32(Console.ReadLine());
            _matrix = new int[_size, _size];
        }

        /// <summary>
        /// Метод InputMatrix позволяет пользователю ввести элементы матрицы.
        /// </summary>
        public static void InputMatrix()
        {            
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.Write($"Введите элемент [{i}, {j}]: ");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        /// <summary>
        /// Метод OutputMatrix выводит матрицу на консоль.
        /// </summary>
        public static void OutputMatrix()
        {

            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.Write($"{Convert.ToString(_matrix[i, j])} ");
                }
                Console.WriteLine();
            }
        }
    }
}