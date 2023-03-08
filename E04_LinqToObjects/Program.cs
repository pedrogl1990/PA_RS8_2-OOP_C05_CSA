using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_LinqToObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Cliente.ClienteMethodSyntax(Cliente.CriarLista(), Cidade.CriarLista());

            Utility.TerminateConsole();
        }
    }
}
