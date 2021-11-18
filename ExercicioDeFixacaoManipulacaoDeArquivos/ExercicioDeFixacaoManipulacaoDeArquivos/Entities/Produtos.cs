using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacaoManipulacaoDeArquivos.Entities
{
    class Produtos
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produtos()
        {
        }

        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return Nome + "," + SomaDosProdutos().ToString("f2", CultureInfo.InvariantCulture);
        }

        public double SomaDosProdutos()
        {
            return Preco * Quantidade;
        }
    }
}
