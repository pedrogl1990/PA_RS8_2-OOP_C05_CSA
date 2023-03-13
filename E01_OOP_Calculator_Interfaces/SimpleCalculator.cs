using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal class SimpleCalculator : Calculator
    {
        public double Num3 { get; set; }
        public override string[] Operations { get; set; }

        public SimpleCalculator() 
        { 
         Num3 = 0;
         Operations = new string[] { "Sum (2 numbers)", "Sum (3 numbers)", "Subtraction", "Division", "Multipliply" };
        }

        public SimpleCalculator(double num1, double num2, double result, string[] operations, double num3) : base(num1, num2, result, operations) 
        { 
            Num3= num3;
            Operations = operations;
        }

        public double Sum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public override double OperatioChoosed(int choosed)
        {
            double num1, num2, num3;
            switch (choosed)
            {
                case 1:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Sum(num1, num2);
                    break;
                case 2:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    num3 = ReadNumbers();
                    Result = Sum(num1, num2, num3);
                    break;
                case 3:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Sub(num1, num2);
                    break;
                case 4:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Div(num1, num2);
                    break;
                case 5:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Mult(num1, num2);
                    break;
            }
            return Result;
        }
    }
}
