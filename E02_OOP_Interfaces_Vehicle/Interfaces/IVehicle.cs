using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal interface IVehicle
    {
        int VehicleId { get; }
        string Description { get; }
        string Model { get; }

        void Register();
        void Terminate();
    }
}
