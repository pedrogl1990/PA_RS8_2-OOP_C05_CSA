using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle.Interfaces
{
    internal interface IAirplane
    {
        string Fuel { get; }
        void Fly();
    }
}
