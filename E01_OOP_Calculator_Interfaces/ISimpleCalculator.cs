using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal interface ISimpleCalculator
    {

        #region Properties
        double Num3 { get; set; }

        #endregion

        #region Methods
        double Sum(double num1, double num2, double num3);
        #endregion
    }
}
