using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine(" ---------------------|  Welcome to the store  |--------------------");
            Console.ResetColor();
            System.Console.WriteLine();
            Laptop l = new Laptop();
            l.print();
        }
    }
}
