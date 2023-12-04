using System;
using System.Text;

namespace Html

{
    public static class HtmlHelper
    {
        public static void PrintLinesWithTags(string htmlCode, string tag, StringBuilder result)
        {
            // Разделяем HTML-код на строки
            string[] lines = htmlCode.Split('\n');

            foreach (string line in lines)
            {
                // Проверяем, содержит ли строка указанный тег (без учета регистра)
                if (line.IndexOf(tag, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.AppendLine(line);
                }
            }
        }
            public static StringBuilder CombineStringBuilders(StringBuilder html, StringBuilder form, StringBuilder h1)
            {
                StringBuilder combinedResult = new StringBuilder();
                combinedResult.Append(html.ToString());
                combinedResult.Append(form.ToString());
                combinedResult.Append(h1.ToString());
                return combinedResult;
            }
        }
    }

