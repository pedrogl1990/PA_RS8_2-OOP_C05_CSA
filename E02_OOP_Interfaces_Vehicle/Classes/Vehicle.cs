using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal class Vehicle : IVehicle
    {

        #region Properties
        public int VehicleId { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }

        #endregion

        #region Constructors

        public Vehicle()
        {
            VehicleId = 0;
            Description = "";
            Model = "";
        }

        public Vehicle(int vehicleId, string description, string model)
        {
            VehicleId = vehicleId;
            Description = description;
            Model = model;
        }

        #endregion

        #region Methods
        public void Register()
        {
            Console.WriteLine($"Register - {VehicleId}, {Description}, {Model}");
        }
        public void Terminate()
        {
            Console.WriteLine($"Terminate - {Description}");
        }
    }

    #endregion

}
