using System;

namespace _7._2___string_data_type
{
    class Program
    {

        static void Main(string[] args)
        {

            string source = "Всем привет я dead inside.";

            var replacement = source.Replace("Всем привет я", "***");
            Console.WriteLine($"Исходная строка: <{source}>");
            Console.WriteLine($"Обновленная строка: <{replacement}>");

        }
    }
}
