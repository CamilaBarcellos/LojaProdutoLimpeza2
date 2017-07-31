using LojaProdutoLimpeza2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    public class Cliente : Pessoa
    {
        

        public string IdCliente { get; set; }
        public string Filiacao { get; set; }
        public double LimiteCredito { get; set; }

        public Status Status { get; set; }

              

     
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
