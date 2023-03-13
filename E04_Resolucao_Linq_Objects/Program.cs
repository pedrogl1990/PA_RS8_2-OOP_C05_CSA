using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E04_Resolucao_Linq_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cities> cities = new List<Cities>();
            List<Customers> customers = new List<Customers>();
            IEnumerable filtered;

            cities = CityCustomer.ListCities(cities);
            customers = CityCustomer.ListCustomers(customers, cities);

            Utility.SetUnicodeConsole();

            filtered = CityCustomer.Answer1(customers);
            CityCustomer.ListAnswers(filtered, "Lista de clientes a viver em Londres:");

            filtered = CityCustomer.Answer2(customers);
            CityCustomer.ListAnswers(filtered, "Lista de clientes a viver em Londres ou Madrid:");


            filtered = CityCustomer.Answer3(customers);
            CityCustomer.ListAnswers(filtered, "Lista de clientes com mais de 18 anos ordenado por ordem descendente:");

            filtered = CityCustomer.Answer4(customers);
            CityCustomer.ListAnswers(filtered, "Lista de clientes com paises:");

            CityCustomer.Answer5(customers);

            Utility.TerminateConsole();
        }
    }
}
