using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static E03_OOP_Collections_Car.Car;

namespace E03_OOP_Collections_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            List<Car> listaCarros = new List<Car>();
            Car car1 = new Car(Car.EnumMarcas.Bólide, Car.EnumModelos.NovoBólide, 1000);

            Utility.WriteTitle("Carro Default");
            Console.WriteLine($"Marca: {car1.Marca}\nModelo: {car1.Modelo}\nCilindrada: {car1.Cilindrada}");

            for (int i = 0; i < 5; i++)
            {
                EnumMarcas marca;
                EnumModelos modelo;
                int cilindrada;

                Car car = new Car();
                Console.WriteLine($"Introduza os valores para o Carro {i+1}\n");

                car.ReadValues(out marca, out modelo, out cilindrada);
                car.Marca = marca;
                car.Modelo = modelo;
                car.Cilindrada = cilindrada;

                listaCarros.Add(car);

                Console.Clear();
            }

            Utility.WriteTitle("Lista de Carros");
            foreach (Car car in listaCarros) 
            {
                Console.WriteLine($"Marca: {car.Marca}\nModelo: {car.Modelo}\nCilindrada: {car.Cilindrada}");
            }
           
    
            


     

            
            
            Utility.TerminateConsole();
        }
    }
}
