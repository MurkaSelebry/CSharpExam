using System;
using System.Linq;
/*
Условие На стандартный вход подается строка, содержащая слова, разделенные пробелами. 
Необходимо сделать заглавной буквой начало каждого слова в строке. Вывести на стандартный вывод
Примеры Входные данные: hEllo world!
Выходные данные: Hello World!
*/
namespace Task1
{
    class Program
    {
        static string Capitalize(string s)
        {
            var arrayChar = s
                .ToLowerInvariant()
                .ToCharArray();
            arrayChar[0] = char.ToUpper(arrayChar[0]);
            return new string(arrayChar);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string InputLine = Console.ReadLine();
            var words = InputLine
                .Split(' ')
                .Where(word => !String.IsNullOrWhiteSpace(word))
                .Select(word => Capitalize(word))
                .ToArray();
            InputLine = null;
            foreach (var word in words)
            {
                InputLine += word + ' ';
            }

            Console.WriteLine(InputLine);
        }
    }
}