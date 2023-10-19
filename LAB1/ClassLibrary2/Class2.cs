using System;
using ClassLibrary1;

namespace ClassLibrary2
{
    /// <summary>
    /// Представляет прямоугольник с вершинами vertex1, vertex2, vertex3 и vertex4.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Вершина прямоугольника.
        /// </summary>
        public Point vertex1;

        /// <summary>
        /// Вершина прямоугольника.
        /// </summary>
        public Point vertex2;

        /// <summary>
        /// Вершина прямоугольника.
        /// </summary>
        public Point vertex3;

        /// <summary>
        /// Вершина прямоугольника.
        /// </summary>
        public Point vertex4;

        /// <summary>
        /// Инициализирует новый экземпляр класса Rectangle с указанными вершинами.
        /// </summary>
        /// <param name="vertex1">Первая вершина прямоугольника.</param>
        /// <param name="vertex2">Вторая вершина прямоугольника.</param>
        /// <param name="vertex3">Третья вершина прямоугольника.</param>
        /// <param name="vertex4">Четвертая вершина прямоугольника.</param>
        public Rectangle(Point vertex1, Point vertex2, Point vertex3, Point vertex4)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
            this.vertex4 = vertex4;
        }

        /// <summary>
        /// Проверяет, является ли прямоугольник существующим.
        /// </summary>
        /// <returns>True, если прямоугольник существует. False в противном случае.</returns>
        public bool IsExist()
        {
            // Проверяем, что противоположные стороны прямоугольника равны
            double side1 = vertex1.DistanceTo(vertex2);
            double side2 = vertex2.DistanceTo(vertex3);
            double side3 = vertex3.DistanceTo(vertex4);
            double side4 = vertex4.DistanceTo(vertex1);

            return side1 == side3 && side2 == side4;
        }

        /// <summary>
        /// Вычисляет длину прямоугольника.
        /// </summary>
        /// <returns>Длина прямоугольника.</returns>
        public double CalculateLength()
        {
            // Вычисляем длину одной из сторон прямоугольника
            return vertex1.DistanceTo(vertex2);
        }

        /// <summary>
        /// Вычисляет ширину прямоугольника.
        /// </summary>
        /// <returns>Ширина прямоугольника.</returns>
        public double CalculateWidth()
        {
            // Вычисляем длину другой стороны прямоугольника
            return vertex2.DistanceTo(vertex3);
        }

        /// <summary>
        /// Вычисляет площадь прямоугольника.
        /// </summary>
        /// <returns>Площадь прямоугольника.</returns>
        public double CalculateArea()
        {
            // Вычисляем площадь прямоугольника
            return CalculateLength() * CalculateWidth();
        }

        /// <summary>
        /// Вычисляет периметр прямоугольника.
        /// </summary>
        /// <returns>Периметр прямоугольника.</returns>
        public double CalculatePerimeter()
        {
            // Вычисляем периметр прямоугольника
            return 2 * (CalculateLength() + CalculateWidth());
        }

        /// <summary>
        /// Проверяет, содержит ли прямоугольник указанную точку.
        /// </summary>
        /// <param name="point">Точка для проверки.</param>
        /// <returns>True, если точка находится внутри прямоугольника. False в противном случае.</returns>
        public bool ContainsPoint(Point point)
        {
            // Проверяем, что точка находится внутри прямоугольника
            double minX = Math.Min(vertex1.X, vertex3.X);
            double maxX = Math.Max(vertex1.X, vertex3.X);
            double minY = Math.Min(vertex1.Y, vertex3.Y);
            double maxY = Math.Max(vertex1.Y, vertex3.Y);

            return point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY;
        }

        /// <summary>
        /// Проверяет, лежит ли указанная точка на границе прямоугольника.
        /// </summary>
        /// <param name="point">Точка для проверки.</param>
        /// <returns>True, если точка лежит на границе прямоугольника. False в противном случае.</returns>
        public bool IsOnBoundary(Point point)
        {
            // Проверяем, что точка лежит на границе прямоугольника
            double minX = Math.Min(vertex1.X, vertex3.X);
            double maxX = Math.Max(vertex1.X, vertex3.X);
            double minY = Math.Min(vertex1.Y, vertex3.Y);
            double maxY = Math.Max(vertex1.Y, vertex3.Y);

            return point.X == minX || point.X == maxX || point.Y == minY || point.Y == maxY;
        }
    }
}