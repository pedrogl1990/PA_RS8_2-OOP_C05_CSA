using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_CollectionsGeneric_IEnumerable
{
    internal class EvenNumber
    {


        #region Method IList<T>

        public IList<int> CreateEvenumberList(int quantity)
        {
            List<int> evenNumbersList = new List<int>(quantity);

            int currentNumber = 0;

            while (evenNumbersList.Count <= quantity)
            {
                if (++currentNumber % 2 == 0) // é par
                {
                    evenNumbersList.Add(currentNumber);
                }
            }


            return evenNumbersList;
        }

        #endregion

        #region IEnumerable<T>

        public IEnumerable<int> CreateEvenNumbersIEnumerable(int quantity) 
        {
            int currentNumber = 0;

            while (currentNumber <= quantity)
            {
                if(++currentNumber % 2 == 0)
                {
                    yield return currentNumber;
                }
            }
        
        
        
        }

        #endregion
    }
}
