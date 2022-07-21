using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQLearning
{
    class Shuffle
    {
        public void ShuffleMethod()
        {
            //SOURCE
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var position = new Random();

            //QUERY
            var query = numbers.OrderBy(n => position.Next());

            //EXECUTION
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }
    }
}
