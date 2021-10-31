using System;
using System.Linq;

/*
На стандартный вход подается строка. Нужно написать функцию, которая на вход принимает строку, а на выходе мы получаем строку, состоящую из цифр, 
которые соответствуют правилу: Если текущий символ ни разу еще не встречался, то пишем 1, 
если он уже встречался ранее, то записываем сколько раз он уже встречался Вывести на стандартный вывод
Примеры Входные данные: Привет мир!
Выходные данные: 11111111221
 */
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите строку: ");
            string InputLine = Console.ReadLine();
            var charInNumber = InputLine
                .ToCharArray()
                .Distinct()
                .ToDictionary(word => word, word => 1);
            string numbers=null;
            foreach (var s in InputLine)
            {
                numbers += charInNumber[s];
                charInNumber[s]++;
            }
            Console.WriteLine(numbers);
        }
    }
}