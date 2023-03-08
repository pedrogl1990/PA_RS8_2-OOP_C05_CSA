using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace D12_Linq
{
    internal class D02_ShortNames
    {

        public static List<string> CreateShortNames()
        {

            List<string> names = new List<string>();

            names.Add("André");
            names.Add("Catarino");
            names.Add("Pedro");
            names.Add("Tiago");
            names.Add("Mariano");
            names.Add("Albertino");
            names.Add("Fábio");
            names.Add("Helder");
            names.Add("Cassamdro");
            names.Add("Guilherme");

            return names;
  
        }

        public static void ListNames(List <string> names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        public static int ShortName(List<string> names)
        {
            string shortName;
            int shortNameCharacters;

            shortName = names.OrderBy(name => name.Length).FirstOrDefault();
            shortNameCharacters = shortName.Count();
            return shortNameCharacters;
        }

        public static void NamesMethodSyntax(/*int shortNameCharacters*/ List<string> names)
        {
            //var shortNames = names
            //    .Where(n => n.Length == shortNameCharacters).Select(n => n);

            //Forma mais otimizada

            var filteredNames = names
            .Where(n => n.Length <= names.Min(x => x.Length)).ToList();


            Console.WriteLine("List of the shorttest names:");
            foreach (var sName in filteredNames)
            {
                Console.WriteLine($"{sName}");
            }
        }

        public static void NamesQuerySyntax(List<string> names)
        {
            // com lambda - menos correto
            //var filteredNames =
            //from name in names
            //where name.Length == names.Min(name2 => name2.Length)
            //select name


            // sem lambda - mais correto
            var filteredNames =
            from name in names
            where name.Length == (from name2 in names select name2.Length).Min()
            select name;

            Console.WriteLine("List of the shorttest names:");
            foreach (var sName in filteredNames)
            {
                Console.WriteLine($"{sName}");
            }
        }
    }
}
