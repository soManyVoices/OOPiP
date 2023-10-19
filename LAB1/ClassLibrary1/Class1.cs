using System;

namespace ClassLibrary1
{ 
/// <summary>
/// Представляет точку с координатами X и Y на плоскости.
/// </summary>
public interface IPoint
{
    /// <summary>
    /// Получает координату X точки.
    /// </summary>
    double X { get; }

    /// <summary>
    /// Получает координату Y точки.
    /// </summary>
    double Y { get; }

    /// <summary>
    /// Вычисляет расстояние от текущей точки до указанной точки.
    /// </summary>
    /// <param name="other">Другая точка.</param>
    /// <returns>Расстояние между точками.</returns>
    double DistanceTo(IPoint other);
}

    /// <summary>
    /// Представляет точку с координатами X и Y на плоскости.
    /// </summary>
    public class Point : IPoint
    {
        /// <summary>
        /// Получает координату X точки.
        /// </summary>
        public double X { get; }

        /// <summary>
        /// Получает координату Y точки.
        /// </summary>
        public double Y { get; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Point с указанными координатами X и Y.
        /// </summary>
        /// <param name="x">Координата X точки.</param>
        /// <param name="y">Координата Y точки.</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Вычисляет расстояние от текущей точки до указанной точки.
        /// </summary>
        /// <param name="other">Другая точка.</param>
        /// <returns>Расстояние между точками.</returns>
        public double DistanceTo(IPoint other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}