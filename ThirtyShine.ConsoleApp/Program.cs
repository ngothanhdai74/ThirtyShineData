using System;

namespace ThirtyShine.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #if DEBUG
                Console.WriteLine("Mode=Debug");
            #else
                Console.WriteLine("Mode=Release"); 
            #endif
        }
    }
}
