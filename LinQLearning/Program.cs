using System;

namespace LinQLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //DOG
            //Console.WriteLine("First method");
            //LazyDog lz = new LazyDog();
            //lz.MethodSyntax();
            //Console.WriteLine("Second method");
            //lz.ExpressionSyntax();

            //TEXT
            string changingText = "A sorting operation orders the elements of a sequence based on one or more attributes. The first sort criterion performs a primary sort on the elements. By specifying a second sort criterion, you can sort the elements within each primary sort group.";
            Text t = new Text();
            // t.Test1(changingText);
            t.Test2(changingText);
        }
    }
}
