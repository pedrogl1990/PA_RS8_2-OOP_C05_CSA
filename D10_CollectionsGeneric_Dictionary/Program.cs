using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D10_CollectionsGeneric_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            #region Dictionary: criar e inserir os valores iniciais

            Dictionary<string, string> listCountries = new Dictionary<string, string>()
            {
                {"PT","Portugal"},
                {"ES","Espanha"},
                {"BR","Brasil"},
                {"VE","Venezuela"}
            };

            listCountries.Add("MZ","Moçambique");

            #endregion

            #region Dictionary: listar

            Utility.WriteTitle("Dictionary");

            ListDictionary(listCountries);
            #endregion

            #region Dictionary: pesquisar chave
            //1. Pesquisar

            string key = "AN";

            if (FindKey(listCountries, key)) {
                Console.WriteLine("Pais Duplicado", "\n\n", "\n\n");
            } else
            {
                //2. adicionar caso não encontre
                InsertInDictionary(listCountries, key);
                ListDictionary(listCountries) ;
            }

            #endregion

            Utility.TerminateConsole();
        }

        static void ListDictionary(Dictionary<string,string> listCountries)
        {
            foreach (KeyValuePair<string,string> item in listCountries)
            {
                Console.WriteLine($"Country: {item.Key} - {item.Value}");
            }
        }

        static bool FindKey(Dictionary<string, string> listCountries, string key)
        {
            bool found = listCountries.ContainsKey(key);

            return found;
 
        }

        static void InsertInDictionary(Dictionary<string, string> listCountries, string key)
        {
            string newValue = key.ToUpper() + "01";

            listCountries.Add(key, newValue);
        }
    }
}
