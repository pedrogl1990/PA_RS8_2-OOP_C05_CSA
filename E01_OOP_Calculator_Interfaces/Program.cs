using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            SimpleCalculator simpleCalculator= new SimpleCalculator();
            CientificCalculator cientificCalculator= new CientificCalculator();

            Utility.WriteTitle("Simple Calculator");
            simpleCalculator.MenuConstructor(simpleCalculator.Operations);
            int choosed = simpleCalculator.ReadOperation(simpleCalculator.Operations);
            simpleCalculator.Num1 = simpleCalculator.ReadNumbers();
            simpleCalculator.Num2 = simpleCalculator.ReadNumbers();
            simpleCalculator.Num3 = simpleCalculator.ReadNumbers();
            simpleCalculator.Result = simpleCalculator.OperatioChoosed(choosed, simpleCalculator.Num1, simpleCalculator.Num2, simpleCalculator.Num3);
            simpleCalculator.ReadResult(simpleCalculator.Result);

            Utility.TerminateConsole();

            Utility.WriteTitle("Cientific Calculator");
            cientificCalculator.MenuConstructor(cientificCalculator.Operations);
            int choosed2 = cientificCalculator.ReadOperation(cientificCalculator.Operations);
            cientificCalculator.Num1 = cientificCalculator.ReadNumbers();
            cientificCalculator.Num2 = cientificCalculator.ReadNumbers();
            cientificCalculator.Result = cientificCalculator.OperatioChoosed(choosed2, cientificCalculator.Num1, cientificCalculator.Num2);
            cientificCalculator.ReadResult(cientificCalculator.Result);


            Utility.TerminateConsole();
        }
    }
}
