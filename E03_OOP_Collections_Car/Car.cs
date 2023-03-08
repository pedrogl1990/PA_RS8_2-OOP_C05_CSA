using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E03_OOP_Collections_Car
{
    internal class Car
    {

        public enum EnumMarcas
        {
            Bólide,
            Ford,
            Fiat,
        }

        public enum EnumModelos
        {
            Fiesta,
            Punto,
            Focus,
            NovoBólide,
            Fiat500,
            Mustang
        }

        public enum EnumCores
        {
            Branco,
            Cinza,
            Preto,
            Azul,
            Vermelho,
            Laranja
        }

        public EnumMarcas Marca { get; set; }
        public EnumModelos Modelo { get; set; }
        public EnumCores? Cor { get; set; }
        public string Matricula { get; set; }
        public int Cilindrada { get; set; }
        public int Velocidade { get; set; }
        public DateTime DataDeRegisto { get; set; }



        public Car()
        {
            Marca = default(EnumMarcas);
            Modelo = default(EnumModelos);
            Cor = null;
            Matricula = "";
            Cilindrada = 0;
            Velocidade = 0;
            DataDeRegisto = DateTime.MinValue;
        }

        public Car(EnumMarcas marca, EnumModelos modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }



        public void ReadValues(out EnumMarcas enumMarca, out EnumModelos enumModelos, out int cilindrada)
        {
            bool cilValida;
            bool marValida;
            bool modValido;

            do
            {
                Console.Write("Por favor introduza a marca pretendida: ");
                marValida = Enum.TryParse(Console.ReadLine(), out enumMarca);
            } while (!marValida);
            do
            {
                Console.Write("Por favor introduza o modelo pretendido: ");
                modValido = Enum.TryParse(Console.ReadLine(), out enumModelos);
            } while (!modValido);
            do
            {
                Console.Write("Por favor introduza a cilindrada pretendida: ");
                cilValida = int.TryParse(Console.ReadLine(), out cilindrada);
                if (!cilValida)
                {
                    Console.WriteLine("Valor inválido");
                }

            } while (!cilValida);
           
        }

        public void Parar(int vel)
        {
            vel = 0;
        }

        public void Acelerar(int vel)
        {
            vel += 10;
        }

        public void Desacelarar(int vel)
        {
            vel -= 10;
        }
    }

}
