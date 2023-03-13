using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E05_LinqMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            //Exercicio 3.1

            Random horasRandom = new Random();

            List<TimeSpan> listaTimeSpans = new List<TimeSpan>();   

            for (int i = 0;i < 10; i++)
            {
                listaTimeSpans.Add(TimeSpan.FromHours(horasRandom.Next(0, 25)));
            }

            Console.WriteLine("Lista de horas aleatórias\n");
            foreach (var item in listaTimeSpans)
            {
                Console.WriteLine($"{item.Hours}:{item.Minutes}{item.Minutes}");
            }
            Console.WriteLine("--------------------------------------------------------");

            //Exercicio 3.2
            var findAll = listaTimeSpans.FindAll(t => t.Hours < 12);

            Console.WriteLine("Lista de horas aleatórias < 12h\n");
            foreach (var horas in findAll)
            {
                Console.WriteLine($"{horas.Hours}:{horas.Minutes}{horas.Minutes}");
            }
            Console.WriteLine("--------------------------------------------------------");

            //Exercicio 3.3
            var exists = listaTimeSpans.Exists(t => t.ToString("%h").Contains("5"));
            if ( exists ) 
            {
                Console.WriteLine("Existem horas com 5\n");
            } else
            {
                Console.WriteLine("Não exitem horas com 5");
            }
            Console.WriteLine("--------------------------------------------------------");

            //Exercicio 3.4
            var trueForAll = listaTimeSpans.TrueForAll(t => t.Hours <= 24 && t.Hours >= 0);
            if (trueForAll)
            {
                Console.WriteLine("Horas obedecem aos critérios\n");
            }
            else
            {
                Console.WriteLine("Horas não obedecem aos critérios");
            }
            Console.WriteLine("--------------------------------------------------------");

 
            Utility.TerminateConsole();
    }
        }
}
