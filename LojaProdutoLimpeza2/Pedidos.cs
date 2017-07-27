using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    class Pedidos
    {
        Produto produto = new Produto();

        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public int QuantidadeDeProdutos { get; set; }
        public double ValorTotal { get; set; }


        public List<Produto> ListaDeProdutos = new List<Produto>();


        public void IncluirVenda()
        {

        }

        public void RemoverVenda()
        {

        }

        public void CriarPedido()
        {

        }

        public void CalcularValorDoPedido()
        {
            ValorTotal = produto.Preco;
        }

    }
}
