using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            #region IList<T>

            EvenNumber evenListNumbers01= new EvenNumber();

            IList<int> listNumbers01 = evenListNumbers01.CreateEvenumberList(4); //preenche a lista com 5 numeros pares (começa em 0)

            Utility.WriteTitle("IList<T>");

            foreach (int item in listNumbers01)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region IEnumerable<T>

            Utility.WriteTitle("IEnumerable<T>");

            EvenNumber evenListNumbers02= new EvenNumber();

            IEnumerable<int> listNumbers02 = evenListNumbers02.CreateEvenNumbersIEnumerable(4);

            foreach (int item in listNumbers02)
            {
                Console.WriteLine(item);
            }
            #endregion

            Utility.TerminateConsole();
        }
    }
}
