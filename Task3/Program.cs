using System;

namespace Task3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new IP(255, 255, 255, 255);
            var p2 = new IP(255, 255, 254, 254);
            Console.WriteLine($"difference: {p1-p2}");
        }
    }
}