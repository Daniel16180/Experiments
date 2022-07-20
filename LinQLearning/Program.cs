using System;

namespace LinQLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First method");
            LazyDog lz = new LazyDog();
            lz.MethodSyntax();
            Console.WriteLine("Second method");
            lz.ExpressionSyntax();
        }
    }
}
