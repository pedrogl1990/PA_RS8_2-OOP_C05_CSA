using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_LinqToObjects
{
    internal class Cidade
    {
        public string Localidade { get; set; }

        public string Pais { get; set; }


        public Cidade()
        {
            Localidade = string.Empty;
            Pais= string.Empty;
        }

        public Cidade(string localidade, string pais)
        {
            Localidade = localidade;
            Pais = pais;
        }

        public static List<Cidade> CriarLista()
        {

            List<Cidade> cidades = new List<Cidade>()
            {
                 new Cidade("Porto", "Portugal"),
                 new Cidade("Londres", "Inglaterra"),
                 new Cidade("Paris", "França"),
                 new Cidade("Madrid", "Espanha")
            };

            return cidades;

        }
    }
}
