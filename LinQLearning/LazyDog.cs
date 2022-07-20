using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQLearning
{
    class LazyDog
    {
        public void MethodSyntax()
        {
            //DATA SOURCE
            string sentence = "the quick brown fox jumps over the lazy dog";

            //split into a collection of words
            string[] words = sentence.Split(' ');

            //show words collection
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(" ");

            //QUERY
            var query = words
                /*
                 * Makes n groups of words by length.
                 * This case (3 groups) output:
                 * the, fox, the, dog
                 * over, lazy
                 * quick, brown, jumps
                 * Ignore , w => w.ToUpper() for the explanation. It can be deleted.
                 */
                .GroupBy(w => w.Length, w => w.ToUpper())
                /*
                 * Build a class with properties length and words.
                 * Creates as many objects as groups.
                 * In length stores the group length and in words the ones of such length for each group/object.
                 * So, words property is an array an one needs a foreach therfore.
                 * This case (3 objects with setted propperties Length and Words):
                 * Length: 3 | Words: the, fox, the, dog
                 * Length: 4 | Words: over, lazy
                 * Length: 5 | Words: quick, brown, jumps
                 * .Key is 3, 4 or 5 and means 
                 */
                .Select(group => new { Length = group.Key, Words = group })
                /*
                 * Just order the objects created by the select.
                 */
                .OrderBy(obj => obj.Length);

            //EXECUTE THE QUERY. OUTPUT ORDERED WORDS.
            foreach (var obj in query)
            {
                //Printing the lenght for every gruoup.
                Console.WriteLine("Words of length {0}:", obj.Length);
                //Printing the words for every group.
                foreach (var word in obj.Words)
                {
                    Console.WriteLine(word);
                }
            }
        }

        public void ExpressionSyntax()
        {
            //DATA SOURCE
            string sentence = "the quick brown fox jumps over the lazy dog";

            //split into a collection of words
            string[] words = sentence.Split(' ');

            //QUERY
            var query = from word in words
                        group word.ToUpper() by word.Length into gr
                        orderby gr.Key
                        select new { Length = gr.Key, Words = gr };

            //EXECUTION
            foreach (var obj in query) //obj is just a name, not the object itself. Same with gr above.
            {
                Console.WriteLine("Words of length {0}:", obj.Length);
                foreach (string word in obj.Words)
                    Console.WriteLine(word);
            }
        }

    }
}
