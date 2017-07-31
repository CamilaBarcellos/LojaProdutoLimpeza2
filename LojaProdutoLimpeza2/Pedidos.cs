using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    public class Pedidos
    {
        Produto produto = new Produto();

        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public double ValorTotal { get; set; }


        public List<Produto> ListaDeProdutos = new List<Produto>();


        public void IncluirItemDePedido()
        {

        }

        public void RemoverItemDePedido()
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
