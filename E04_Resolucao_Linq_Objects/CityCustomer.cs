using D00_Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Resolucao_Linq_Objects
{
    internal class CityCustomer
    {
        public static List<Cities> ListCities(List<Cities> cities)
        {
            cities.Add(new Cities {City = "Porto", Country = "Portugal"});
            cities.Add(new Cities {City = "Londres", Country = "Inglaterra"});
            cities.Add(new Cities {City = "Paris", Country = "França"});
            cities.Add(new Cities {City = "Madrid", Country = "Espanha"});

            return cities;
        }

        public static List<Customers> ListCustomers(List<Customers> customers, List<Cities> cities)
        {
            customers.Add(new Customers { Name = "Amália", City = cities.FirstOrDefault(c=> c.City == "Porto"), Age = 35});
            customers.Add(new Customers { Name = "John", City = cities.FirstOrDefault(c => c.City == "Londres"), Age = 35 });
            customers.Add(new Customers { Name = "Charles", City = cities.FirstOrDefault(c => c.City == "Londres"), Age = 53 });
            customers.Add(new Customers { Name = "Lucy", City = cities.FirstOrDefault(c => c.City == "Paris"), Age = 21 });
            customers.Add(new Customers { Name = "Javi", City = cities.FirstOrDefault(c => c.City == "Madrid"), Age = 14 });

            return customers;
        }

        public static void ListAnswers(IEnumerable filtered, string title, string separator = "\n\n")
        {
            Utility.BlockSeparator(separator);
            Utility.WriteTitle(title);

            foreach (var answer in filtered)
            {
                Console.WriteLine(answer);
            }
        }

        public static IEnumerable Answer1 (List<Customers> customers)
        {
            return customers.Where(c => c.City.City == "Londres").Select(c => c.Name).ToList();
        }

        public static IEnumerable Answer2(List<Customers> customers)
        {
            return customers.Where(c => c.City.City == "Londres" || c.City.City == "Madrid").Select(c => c.Name).ToList();
        }

        public static IEnumerable Answer3(List<Customers> customers)
        {
            return customers.Where(c => c.Age > 18).OrderByDescending(c=> c.Age).Select(c => $"{ c.Name} - {c.Age}").ToList();
        } 
        
        public static IEnumerable Answer4(List<Customers> customers)
        {
            return customers.Select(c => $"{ c.Name} - {c.City.Country}").ToList();
        }

        public static void Answer5(List<Customers> customers)
        {
            Utility.BlockSeparator("\n\n");
            Utility.WriteTitle("Número de clientes que vivem em Londres");

            int count = customers.Where(c => c.City.City == "Londres").Count();
            Console.WriteLine(count);
        }
    }
}
