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
            string[] words = text.Split(" ");

            foreach (var word in words.OrderBy(or => or.Length))
            {
                Console.WriteLine(word);
            }
        }
    }
}
