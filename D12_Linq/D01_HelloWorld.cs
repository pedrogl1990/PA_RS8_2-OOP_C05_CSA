using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_Linq
{
    internal class D01_HelloWorld
    {

        public void HelloWorldMethodSyntax()
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "woderful",
                "linq",
                "beautiful",
                "world"
            };

            var filteredWords = words
                .Where(w => w.Length == 5).OrderByDescending(w => w).Select(w => w.ToUpper()) ;

            foreach (var word in filteredWords)
            {
                Console.WriteLine($"{word}");
            }
        }

        public void HelloWorldQuerySyntax()
        {
            string[] words =
            {
                "t-sql",
                "hello",
                "woderful",
                "linq",
                "beautiful",
                "world"
            };

            var filteredWords =
                from word in words
                where word.Length == 5
                orderby word descending
                select word.ToUpper();

            foreach (var word in filteredWords)
            {
                Console.WriteLine($"{word}");
            }

        }

    }
}
