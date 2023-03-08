using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal class Submarine : Vehicle
    {

        #region Properties

        public bool Tripulado { get; set; }

        #endregion

        #region Constructors

        public Submarine() : base()
        {
            Tripulado = true;
        }

        public Submarine(int vehicleId, string description, string model, bool tripulado) : base (vehicleId, description, model) 
        {
            Tripulado = tripulado;
        }

        #endregion

        #region Methods

        public void Dive()
        {
            Console.WriteLine($"Submarine - {Description} / {Tripulado}");
        }

        #endregion
    }
}
