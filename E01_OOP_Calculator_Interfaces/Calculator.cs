using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_OOP_Calculator_Interfaces
{
    internal class Calculator
    {

        #region Properties

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public string[] Operations { get; set; }

        #endregion

        #region Constructors

        public Calculator()
        {
            Num1 = 0;
            Num2 = 0;
            Result = 0;
            Operations = new string[] { "Sum", "Subtraction", "Division", "Multipliply" };
        }
        public Calculator(double num1, double num2, double result, string[] operations)
        {
            Num1 = num1;
            Num2 = num2;
            Result = result;
            Operations = operations;
        }


        #endregion


        #region Methods

        public void MenuConstructor(string[] operations)
        {
            Console.WriteLine("Please choose an option:");
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {operations[i]}");
            }
        }

        public int ReadOperation(string[] operations)
        {
            bool valid;
            int choosed;
            Console.Write("\nYour option: ");
            valid = int.TryParse(Console.ReadLine(), out choosed);
            while (!valid || choosed > operations.Length || choosed <= 0)
            {
                Console.Clear();
                MenuConstructor(operations);
                Console.Write("\nYour option: ");
                valid = int.TryParse(Console.ReadLine(), out choosed);
            }
            return choosed;
        }

        public double ReadNumbers()
        {
            bool valid;
            double num;
            Console.Write("\nNumber: ");
            valid = double.TryParse(Console.ReadLine(), out num);
            while (!valid)
            {
                Console.Write("\nNumber: ");
                valid = double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        public double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Sub(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Div(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Mult(double num1, double num2)
        {
            return num1 * num2;
        }


        public double OperatioChoosed(int choosed, double num1, double num2)
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
            }
            return Result;
        }

        public void ReadResult(double result)
        {
            Console.WriteLine($"\nResult: {result}");
        }
        #endregion
    }
}
