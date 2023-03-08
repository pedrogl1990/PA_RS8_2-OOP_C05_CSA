using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_OOP_Interfaces_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane(1, "white airplane", "airbus", "super gasoleo");
            Submarine submarine = new Submarine(2, "portuguese submarine", "invisible submarine", true);
            Car car = new Car(3, "desportivo", "mercedes-benz", "white");

            Console.WriteLine("Airplane:");
            airplane.Register();
            airplane.Terminate();
            airplane.Fly();
            Console.WriteLine();

            Console.WriteLine("Submarine:");
            submarine.Register();
            submarine.Terminate();
            submarine.Dive();
            Console.WriteLine();

            Console.WriteLine("Car:");
            car.Register();
            car.Terminate();
            car.Drive();
            Console.ReadLine();
        }
    }
}
