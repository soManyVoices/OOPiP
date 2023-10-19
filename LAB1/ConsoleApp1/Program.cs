using System;
using ClassLibrary1;
using ClassLibrary2;
class Program
{
    static void Main()
    {
        bool running = true;
        Rectangle rectangle = null;

        while (running)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Создать прямоугольник");
            Console.WriteLine("2. Проверить, существует ли прямоугольник");
            Console.WriteLine("3. Вычислить длину прямоугольника");
            Console.WriteLine("4. Вычислить ширину прямоугольника");
            Console.WriteLine("5. Вычислить площадь прямоугольника");
            Console.WriteLine("6. Вычислить периметр прямоугольника");
            Console.WriteLine("7. Проверить, содержит ли прямоугольник точку");
            Console.WriteLine("8. Проверить, лежит ли точка на границе прямоугольника");
            Console.WriteLine("0. Выход");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Введите координаты вершин прямоугольника (через запятую):");
                    string[] coordinates = Console.ReadLine().Split(',');
                    double x1 = double.Parse(coordinates[0]);
                    double y1 = double.Parse(coordinates[1]);
                    double x2 = double.Parse(coordinates[2]);
                    double y2 = double.Parse(coordinates[3]);
                    double x3 = double.Parse(coordinates[4]);
                    double y3 = double.Parse(coordinates[5]);
                    double x4 = double.Parse(coordinates[6]);
                    double y4 = double.Parse(coordinates[7]);

                    Point vertex1 = new Point(x1, y1);
                    Point vertex2 = new Point(x2, y2);
                    Point vertex3 = new Point(x3, y3);
                    Point vertex4 = new Point(x4, y4);

                    rectangle = new Rectangle(vertex1, vertex2, vertex3, vertex4);
                    Console.WriteLine("Прямоугольник создан.");
                    break;
                case "2":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine($"Прямоугольник существует: {rectangle.IsExist()}");
                    }
                    break;
                case "3":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine($"Длина прямоугольника: {rectangle.CalculateLength()}");
                    }
                    break;
                case "4":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine($"Ширина прямоугольника: {rectangle.CalculateWidth()}");
                    }
                    break;
                case "5":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
                    }
                    break;
                case "6":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine($"Периметр прямоугольника: {rectangle.CalculatePerimeter()}");
                    }
                    break;
                case "7":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine("Введите координаты точки (через запятую):");
                        string[] pointCoordinates = Console.ReadLine().Split(',');
                        double px = double.Parse(pointCoordinates[0]);
                        double py = double.Parse(pointCoordinates[1]);
                        Point point = new Point(px, py);
                        Console.WriteLine($"Прямоугольник содержит точку: {rectangle.ContainsPoint(point)}");
                    }
                    break;
                case "8":
                    if (rectangle == null)
                    {
                        Console.WriteLine("Прямоугольник не создан.");
                    }
                    else
                    {
                        Console.WriteLine("Введите координаты точки (через запятую):");
                        string[] pointCoordinates = Console.ReadLine().Split(',');
                        double px = double.Parse(pointCoordinates[0]);
                        double py = double.Parse(pointCoordinates[1]);
                        Point point = new Point(px, py);
                        Console.WriteLine($"Точка лежит на границе прямоугольника: {rectangle.IsOnBoundary(point)}");
                    }
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Неверная опция. Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }
}