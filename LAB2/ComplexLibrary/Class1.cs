namespace ComplexLibrary
{
    /// <summary>
    /// Представляет комплексное число в виде вещественной и мнимой частей.
    /// </summary>
    public class ComplexNumber
    {
        /// <summary>
        /// Возвращает вещественную часть комплексного числа.
        /// </summary>
        public double Real { get; }

        /// <summary>
        /// Возвращает мнимую часть комплексного числа.
        /// </summary>
        public double Imaginary { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса ComplexNumber с указанными вещественной и мнимой частями.
        /// </summary>
        /// <param name="real">Вещественная часть комплексного числа.</param>
        /// <param name="imaginary">Мнимая часть комплексного числа.</param>
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        /// <summary>
        /// Перегружает оператор сложения для комплексных чисел.
        /// </summary>
        /// <param name="c1">Первое комплексное число.</param>
        /// <param name="c2">Второе комплексное число.</param>
        /// <returns>Сумма двух комплексных чисел.</returns>
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        /// <summary>
        /// Перегружает оператор умножения для комплексных чисел.
        /// </summary>
        /// <param name="c1">Первое комплексное число.</param>
        /// <param name="c2">Второе комплексное число.</param>
        /// <returns>Произведение двух комплексных чисел.</returns>
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);
            return new ComplexNumber(real, imaginary);
        }
    }
}