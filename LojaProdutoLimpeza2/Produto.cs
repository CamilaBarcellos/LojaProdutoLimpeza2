using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaProdutoLimpeza
{
    public class Produto
    {
        public string IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        public double Preco { get; set; }

        public Categoria Categoria { get; set; }

        public List<Produto> ListaDeProdutos = new List<Produto>();

        
        public void ListarProdutos()
        {

        }

        
        public void VerificarEstoque()
        {

        }

    }
}
