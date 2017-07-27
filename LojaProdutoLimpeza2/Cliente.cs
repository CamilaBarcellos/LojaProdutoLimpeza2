using LojaProdutoLimpeza2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    class Cliente : Pessoa
    {
        

        public int IdCliente { get; set; }
        public string Filiacao { get; set; }
        public double LimiteCredito { get; set; }

        public Status Status { get; set; }


        

        public void CadastrarCliente()
        {

        }

        public void ListarCliente()
        {

        }

        public void RemoverCliente()
        {

        }

        public void AtribuirStatus()
        {

        }

    }
}
