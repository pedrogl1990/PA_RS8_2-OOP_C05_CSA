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

        public new double OperatioChoosed(int choosed, double num1, double num2)
        {
            switch (choosed)
            {
                case 1:
                    Result = Sum(num1, num2);
                    break;
                case 2:
                    Result = Sub(num1, num2);
                    break;
                case 3:
                    Result = Div(num1, num2);
                    break;
                case 4:
                    Result = Mult(num1, num2);
                    break;
                case 5:
                    Result = SqrRt(num1);
                    break;
            }
            return Result;
        }

        #endregion
    }
}
