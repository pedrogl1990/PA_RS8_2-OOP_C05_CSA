// Queue --> Fila --> FIFO (First-in, First-Out)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D08_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Queue inteiros - (fila) - FIFO
            Queue<int> queueIntegers = new Queue<int>();

            for (int i = 0; i < 6; i++)
            {
                queueIntegers.Enqueue(i);
            }

            queueIntegers.Enqueue(10);
            queueIntegers.Enqueue(20);

            Console.WriteLine("Queue Integers");
            foreach (int item in queueIntegers)
            {
                Console.WriteLine($"{item}");
            }

            int count = queueIntegers.Count;

            Console.WriteLine("Dequeue Integers");

            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(queueIntegers.Dequeue());
            }


            
            #endregion

            Utility.TerminateConsole();
        }
    }
}
