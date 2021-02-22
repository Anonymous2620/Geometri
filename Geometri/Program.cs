using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squ = new Square(103);

            Console.WriteLine($"Omk: {squ.CPerimeter()}");

            Console.WriteLine($"Are: {squ.CArea()}");
        }
    }
}
