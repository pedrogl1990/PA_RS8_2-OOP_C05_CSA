using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal class Airplane : Vehicle
    {
        public enum EnumFuel
        {
            Gasoline,
            Diesel,
            Biodiesel,
            Ethanol
        }

        #region Properties

        public EnumFuel Fuel { get; set; }

        #endregion

        #region Constructors

        public Airplane() : base()
        {
            Fuel = EnumFuel.Diesel;
        }

        public Airplane(int vehicleId, string description, string model, EnumFuel fuel) : base(vehicleId, description, model)
        {
            Fuel = fuel;
        }

        #endregion

        #region Methods

        public void Fly()
        {
            Console.WriteLine($"Airplane - {Description} / {Fuel}");
        }
        #endregion
    }
}
