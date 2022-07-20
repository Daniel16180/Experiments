using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQLearning
{
    class Text
    {
        public void Test1(string text) {
            //DATA SOURCE
            string[] words = text.Split(" ");

            //QUERY
            var query = words
                .OrderBy(or => or.Length);

            //EXECUTION
            foreach (var word in query)
            {
                Console.WriteLine(word);
            }
        }

        public void Test2(string text) {
            //It´s counting the . and , as part of the words.
            string[] words = text.Split(" ");

            foreach (var word in words.OrderByDescending(or => or.Length) )
            {
                Console.WriteLine(word);
            }
        }

        //Example with object array: https://docs.microsoft.com/es-es/dotnet/api/system.linq.enumerable.orderby?view=net-6.0
        //Interesting example with contains and ternary: https://docs.microsoft.com/es-es/dotnet/api/system.linq.enumerable.contains?view=net-6.0
        //Examples count, max, min: https://docs.microsoft.com/es-es/dotnet/api/system.linq.enumerable.groupby?view=net-6.0
    }
}
