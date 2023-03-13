using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace E04_LinqToObjects
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public string Localidade { get; set; }

        public int Idade { get; set; }


        public Cliente()
        {
            Nome = string.Empty;
            Localidade = string.Empty;
            Idade = 0;
        }

        public Cliente(string nome, string localidade, int idade)
        {
            Nome = nome;
            Localidade = localidade;
            Idade = idade;
        }

        public static List<Cliente> CriarLista()
        {

            List<Cliente> clientes = new List<Cliente>()
            {
                 new Cliente("Amália", "Porto", 53),
                 new Cliente("John", "Londres", 35),
                 new Cliente("Charles", "Londres", 53),
                 new Cliente("Lucy", "Paris", 21),
                 new Cliente("Javi", "Madrid", 14)
            };

            return clientes;

        }

        public static void ClienteMethodSyntax(List<Cliente> clientes, List<Cidade> cidades)
        {
            var clientesLondres = clientes
                .Where(c => c.Localidade == "Londres");

            var clientesLisboaMadrid = clientes
                .Where(c2 => c2.Localidade == "Lisboa" || c2.Localidade == "Madrid");

            var clientesNomeIdade = clientes
                .Where(c => c.Idade > 18).OrderByDescending(c => c.Idade);

            var clientesNomePais = clientes.Join(
                cidades,
                c => c.Localidade,
                cd => cd.Localidade,
                (c, cd) => new { Cliente = c, Cidades = cd }
                ).Select (ccd => new
                {
                    clienteNome = ccd.Cliente.Nome,
                    clientePais = ccd.Cidades.Pais
                });

            var numeroClientesLondres = clientes
                .Where(c => c.Localidade == "Londres").Count();

            var idadeMinimaLondres = clientes
                .Where(c => c.Localidade == "Londres")
                .Min(c => c.Idade);

            var clienteMaisNovoLondres = clientes
                .Where(c => c.Localidade == "Londres" && c.Idade == idadeMinimaLondres).First();

            Console.WriteLine("Clientes com localidade em Londres:\n");
            foreach (var cliente in clientesLondres)
            {
                Console.WriteLine(cliente.Nome);
            }

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Clientes com localidade em Lisboa ou Madrid:\n");
            foreach (var cliente in clientesLisboaMadrid)
            {
                Console.WriteLine(cliente.Nome);
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Clientes com mais de 18 anos, ordenados por idade:\n");
            foreach (var cliente in clientesNomeIdade)
            {
                Console.WriteLine($"{cliente.Nome} - {cliente.Idade}");
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Seleção de clientes por país:\n");
            foreach (var cliente in clientesNomePais)
            {
                Console.WriteLine($"{cliente.clienteNome} - {cliente.clientePais}");
            }

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Número de clientes em Londres:\n{numeroClientesLondres}");

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Cliente mais novo em Londres:\n{clienteMaisNovoLondres.Nome}");

        }


    }

}

