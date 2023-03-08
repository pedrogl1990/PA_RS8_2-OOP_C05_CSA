using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal class SimpleCalculator : Calculator, ISimpleCalculator
    {
        #region Properties

        public double Num3 { get; set; }   

        #endregion

        #region Constructors

        public SimpleCalculator() 
        {
            Num3 = 0;
        }

        public SimpleCalculator(double num3)
        {
            Num3 = num3;
        }

        #endregion

        #region Methods
        public double Sum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        public double OperatioChoosed(int choosed, double num1, double num2, double num3)
        {
            switch (choosed)
            {
                case 1:
                    Result = Sum(num1, num2, num3);
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
            }
            return Result;
        }
        #endregion
    }
}
