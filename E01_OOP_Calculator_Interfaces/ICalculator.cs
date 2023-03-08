using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal interface ICalculator
    {


        #region Properties
        double Num1 { get; }
        double Num2 { get; }
        double Result { get; }
        string[] Operations { get; }

        #endregion


        #region Methods

        void MenuConstructor(string[] operations);
        int ReadOperation(string[] operations);
        int ReadNumbers();
        double Sum(double num1, double num2);
        double Sub(double num1, double num2);
        double Div(double num1, double num2);
        double Mult(double num1, double num2);
        int OperatioChoosed(int choosed);
        void ReadResult(double result);

        #endregion
    }
}
