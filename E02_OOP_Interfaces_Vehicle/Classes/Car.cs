using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal class Car : Vehicle
    {

        #region Properties

        public string Color { get; set; }

        #endregion

        #region Constructors

        public Car() : base()
        {
            Color = "";
        }

        public Car(int vehicleId, string description, string model, string color) : base(vehicleId, description, model)
        {
            Color= color;
        }

        #endregion

        #region Methods

        public void Drive()
        {
            Console.WriteLine($"Car - {Description} / {Color}");
        }

        #endregion
    }
}
