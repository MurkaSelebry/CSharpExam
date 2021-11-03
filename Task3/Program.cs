using System;

namespace Task3
{
    
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите IP(в формате ip1.ip2.ip3.ip4):");
            var p1 = new IP(Console.ReadLine());
            var p2 = new IP(Console.ReadLine());
            Console.WriteLine($"difference: {p1-p2}");
            Main();
        }
    }
}