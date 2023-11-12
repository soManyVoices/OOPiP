// Класс SquareMatrix представляет квадратную матрицу.
// Он содержит методы для ввода, вывода и обработки матрицы.
using System;


namespace MatrixLibrary
{
    
    public class SquareMatrix
    {
        
        private int[,] _matrix;
        
        public string Name { get; set; }
        
        /// <summary>
        /// Свойство Size возвращает размерность матрицы.
        /// </summary>
        public int Size
        {
            get { return _matrix.GetLength(0); }
        }
        /// <summary>
        /// Индексатор позволяет получить или задать значение элемента матрицы.
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public double this[int i, int j]
        {
            get { return _matrix[i, j]; }
            set { _matrix[i, j] = (int)value; }
        }

        /// <summary>
        /// Конструктор класса SquareMatrix.
        /// /// Принимает имя матрицы и размерность
        /// </summary>
        /// <param name="name"></param>
        /// <param name="size"></param>
   
        public SquareMatrix(string name, int size)
        {
            _matrix = new int[size, size];
            Name = name;
        }

        /// <summary>
        /// Метод InputSizeFromConsole запрашивает у пользователя размерность матрицы.
        /// </summary>
        public void InputSizeFromConsole()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            _matrix = new int[size, size];
        }

        /// <summary>
        /// Метод InputMatrix позволяет пользователю ввести элементы матрицы.
        /// </summary>
        public void InputMatrix()
        {
            
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"Введите элемент [{i}, {j}]: ");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        
        /// <summary>
        /// Метод OutputMatrix выводит матрицу на консоль.
        /// </summary>
        public void OutputMatrix()
        {
            
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{Convert.ToString(_matrix[i, j])} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод SumOfMainDiagonal возвращает сумму элементов главной диагонали.
        /// </summary>
        

        public double SumOfMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum += _matrix[i, i];
            }
            return sum;
        }

        /// <summary>
        /// Метод SumOfElementsAboveMainDiagonal возвращает сумму элементов выше главной диагонали.
        /// </summary>
        

        public double SumOfElementsAboveMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = i + 1; j < Size; j++)
                {
                    sum += _matrix[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Метод SumOfElementsBelowMainDiagonal возвращает сумму элементов ниже главной диагонали.
        /// </summary>
        
        public double SumOfElementsBelowMainDiagonal()
        {
            double sum = 0;
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    sum += _matrix[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Преобразует объект SquareMatrix в строковое представление.
        /// </summary>
        /// <param name="matrix">Объект SquareMatrix для преобразования.</param>
        /// <returns>Строковое представление объекта SquareMatrix.</returns>
        public static explicit operator string(SquareMatrix matrix)
        {
            /// Получаем максимальный и минимальный элементы матрицы
            double maxElement = matrix.GetMaxElement();
            double minElement = matrix.GetMinElement();

            /// Создаем строку описания матрицы
            string matrixString = $"Описание матрицы: {matrix.Name}:{Environment.NewLine}";
            matrixString += $"Размерность: {matrix.Size}x{matrix.Size}{Environment.NewLine}";
            matrixString += $"Максимальный элемент: {maxElement}{Environment.NewLine}";
            matrixString += $"Минимальный элемент: {minElement}{Environment.NewLine}";

            return matrixString;
        }

        /// <summary>
        ///  Метод GetMaxElement возвращает максимальный элемент матрицы.
        /// </summary>
        public double GetMaxElement()
        {
            double maxElement = _matrix[0, 0];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (_matrix[i, j] > maxElement)
                    {
                        maxElement = _matrix[i, j];
                    }
                }
            }
            return maxElement;
        }

        
        /// <summary>
        /// Метод GetMinElement возвращает минимальный элемент матрицы.
        /// </summary>
        
        public double GetMinElement()
        {
            double minElement = _matrix[0, 0];
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (_matrix[i, j] < minElement)
                    {
                        minElement = _matrix[i, j];
                    }
                }
            }
            return minElement;
        }

        /// <summary>
        /// Метод ProductOfDiagonals возвращает произведение элементов главной и двух соседних диагоналей.
        /// </summary>
        public double ProductOfDiagonals()
        {
            double product = 1;
            for (int i = 0; i < Size; i++)
            {
                product *= _matrix[i, i];

                if (i > 0)
                {
                    product *= _matrix[i, i - 1];
                }

                if (i < Size - 1)
                {
                    product *= _matrix[i, i + 1];
                }
            }
            return product;
        }

        /// <summary>
        /// Метод ProductOfAllDiagonals возвращает произведение элементов по  диагоналям.
        /// </summary>
        public double ProductOfAllDiagonals()
        {
            double product = 1;

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j || i + j == Size - 1)
                    {
                        product *= _matrix[i, j];
                    }
                }
            }
            return product;
        }
   
        /// <summary>
        /// Перегруженный оператор равенства для сравнения двух матриц.
        /// </summary>
        /// <param name="matrixA">Первая матрица для сравнения.</param>
        /// <param name="matrixB">Вторая матрица для сравнения.</param>
        public static bool operator ==(SquareMatrix matrixA, SquareMatrix matrixB)
        {
        
            /// Сравниваем размерность матриц
            if (matrixA.Size != matrixB.Size)
            {
                return false;
            }

            /// Сравниваем элементы матриц
            for (int i = 0; i < matrixA.Size; i++)
            {
                for (int j = 0; j < matrixA.Size; j++)
                {
                    if (matrixA[i, j] != matrixB[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Перегруженный оператор неравенства для сравнения двух матриц.
        /// </summary>
        /// <param name="matrixA">Первая матрица для сравнения.</param>
        /// <param name="matrixB">Вторая матрица для сравнения.</param>
        public static bool operator !=(SquareMatrix matrixA, SquareMatrix matrixB)
        {

            /// Сравниваем размерность матриц
            if (matrixA.Size != matrixB.Size)
            {
                return true;
            }

            /// Сравниваем элементы матриц
            for (int i = 0; i < matrixA.Size; i++)
            {
                for (int j = 0; j < matrixA.Size; j++)
                {
                    if (matrixA[i, j] != matrixB[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Метод IncreaseMatrixIfEqual удваивает положительные элементы главной диагонали
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        public void IncreaseMatrixIfEqual(SquareMatrix matrixA, SquareMatrix matrixB)
        {
            /// <summary>
            /// Увеличение матрицы в два раза
            /// </summary>
            for (int i = 0; i < matrixA.Size; i++)
            {
                matrixA[i, i] *= 2;
            }

            /// <summary>
            /// Увеличение матрицы в два раза
            /// </summary> 
            for (int i = 0; i < matrixB.Size; i++)
            {
                matrixB[i, i] *= 2;
            }
        }
    }
}