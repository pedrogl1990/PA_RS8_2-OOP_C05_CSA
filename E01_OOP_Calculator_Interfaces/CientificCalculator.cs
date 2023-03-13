using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal class CientificCalculator : Calculator, ICientificCalculator
    {


        #region Properties
        public override string[] Operations { get; set; }
        #endregion

        #region Constructors

        public CientificCalculator()
        {
            Operations = new string[] { "Sum", "Subtraction", "Division", "Multipliply", "Square Root" };
        }

        #endregion

        #region Methods

        public double SqrRt(double num1)
        {
            return Math.Sqrt(num1);
        }

        public override double OperatioChoosed(int choosed)
        {
            double num1, num2;
            switch (choosed)
            {
                case 1:
                    num1 = ReadNumbers();
                    num2= ReadNumbers();
                    Result = Sum(num1, num2);
                    break;
                case 2:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Sub(num1, num2);
                    break;
                case 3:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Div(num1, num2);
                    break;
                case 4:
                    num1 = ReadNumbers();
                    num2 = ReadNumbers();
                    Result = Mult(num1, num2);
                    break;
                case 5:
                    num1 = ReadNumbers();
                    Result = SqrRt(num1);
                    break;
            }
            return Result;
        }

        #endregion
    }
}
