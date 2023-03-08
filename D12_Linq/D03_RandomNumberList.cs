using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D12_Linq
{
    internal class D03_RandomNumberList
    {

        public static List<int> CreateList()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                numbers.Add(random.Next(0, 51));
            }

            return numbers;
        }

        public static void NumbersMethodSyntax(List<int> numbers)
        {
            var biggerThanTen = numbers
            .Where(n => n >= 10);

            Console.WriteLine("Numbers >= 10:");
            foreach (var number in biggerThanTen)
            {
               Console.WriteLine(number);
            }
        }

    }
}
