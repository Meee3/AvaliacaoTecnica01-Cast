using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasEComissoes.model
{
    public class Funcionario
    {

        public string Nome { get; set; }
        public int ID { get; set; }
        public int quantidadeProdutosVendidos { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, int id)
        {
            this.Nome = nome; 
            this.ID = id;
        }

    }
}
