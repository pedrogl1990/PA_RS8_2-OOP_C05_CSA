using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D12_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            D01_HelloWorld d01_HelloWorld = new D01_HelloWorld();


            //d01_HelloWorld.HelloWorldMethodSyntax();
            //d01_HelloWorld.HelloWorldQuerySyntax();
            //D02_ShortNames.ListNames(D02_ShortNames.CreateShortNames());
            //D02_ShortNames.NamesMethodSyntax(D02_ShortNames.ShortName(D02_ShortNames.CreateShortNames()), D02_ShortNames.CreateShortNames());
            D02_ShortNames.NamesQuerySyntax(D02_ShortNames.CreateShortNames());
            
            //D03_RandomNumberList.NumbersMethodSyntax(D03_RandomNumberList.CreateList());

            Utility.TerminateConsole();
        }
    }
}
