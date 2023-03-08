//stack --> pilha --> LIFO (Last-in, first-out)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D09_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Stack inteiros - Pilha (LIFO)

            Stack<int> stackIntegers = new Stack<int>();


            for (int i = 0; i < 6; i++)
            {
                stackIntegers.Push(i);
            }

            int count = stackIntegers.Count;

            Console.WriteLine($"count: {count}");
            Console.WriteLine();
            Console.WriteLine("Stack push");

            foreach (int item in stackIntegers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Stack pop");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(stackIntegers.Pop());
            }
            #endregion


            Utility.TerminateConsole();
        }
    }
}
