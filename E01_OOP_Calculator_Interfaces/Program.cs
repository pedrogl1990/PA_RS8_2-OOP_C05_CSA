using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            double resultSimple = simpleCalculator.OperatioChoosed(simpleCalculator.ReadOperation(simpleCalculator.Operations));
            simpleCalculator.ReadResult(resultSimple);
       
            Utility.TerminateConsole();

            Utility.WriteTitle("Cientific Calculator");

            cientificCalculator.MenuConstructor(cientificCalculator.Operations);
            double resultCientific = cientificCalculator.OperatioChoosed(cientificCalculator.ReadOperation(cientificCalculator.Operations));
            cientificCalculator.ReadResult(resultCientific);

            Utility.TerminateConsole();
        }
    }
}
