using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Endereco Endereco { get; set; }
    }
}
