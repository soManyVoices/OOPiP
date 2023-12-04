using System;
using System.Text;
using Html;

public class Program
{
    public static void Main(string[] args)
    {
        // HTML-код для обработки
        string htmlCode = "<html>\n" +
                          "<body>\n" +
                          "<h1>Hello, World!</h1>\n" +
                          "<form>\"<p>Enter your name:</p>\n" +
                          "<input type=\"text\" name=\"name\">\n" +
                          "<input type=\"submit\" value=\"Submit\">\n" +
                          "</form>\n" +
                          "</body>\n" +
                          "</html>";

        StringBuilder h1Result = new StringBuilder();
        StringBuilder formResult = new StringBuilder();
        StringBuilder htmlResult = new StringBuilder();

        // Бесконечный цикл для выбора пунктов и обработки HTML-кода
        while (true)
        {
            // Выводим меню с пунктами выбора
            Console.WriteLine("Выберите пункт:");
            Console.WriteLine("1. Вывести все строки с тегом <html>");
            Console.WriteLine("2. Вывести все строки с тегом <form>");
            Console.WriteLine("3. Вывести все строки с тегом <h1>");
            Console.WriteLine("4. Вывести строки со всеми тремя тегами");
            Console.WriteLine("5. Выход");

            // Запрос ввода номера пункта
            Console.Write("Введите номер пункта: ");
            string input = Console.ReadLine();

            // Обработка выбранного пункта
            switch (input)
            {
                case "1":
                    HtmlHelper.PrintLinesWithTags(htmlCode, "html", htmlResult);
                    Console.WriteLine("Строки, содержащие тег <html>:");
                    Console.WriteLine(htmlResult.ToString());
                    break;
                case "2":
                    HtmlHelper.PrintLinesWithTags(htmlCode, "<form>", formResult);
                    Console.WriteLine("Строки, содержащие тег <form>:");
                    Console.WriteLine(formResult.ToString());
                    break;
                case "3":
                    HtmlHelper.PrintLinesWithTags(htmlCode, "<h1>", h1Result);
                    Console.WriteLine("Строки, содержащие тег <h1>:");
                    Console.WriteLine(h1Result.ToString());
                    break;
                case "4":
                    StringBuilder combinedResult = HtmlHelper.CombineStringBuilders(htmlResult, formResult, h1Result);
                    Console.WriteLine(combinedResult.ToString());
                    break;
                case "5":
                    Console.WriteLine("Вы выбрали выход. Программа завершается.");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите номер пункта из списка.");
                    break;
            }

            Console.WriteLine();
        }
    }
}