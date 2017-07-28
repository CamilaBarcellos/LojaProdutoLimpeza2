using LojaProdutoLimpeza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LojaProdutoLimpezaUnitTest
{
    public class Teste
    {
        
        public void Cadastrar()
        {

            //Categorias

            Categoria detergente = new Categoria()
            {
                IdCategoria = "C01",
                Nome = "Detergente"
            };

            Categoria aguaSanitaria = new Categoria()
            {
                IdCategoria = "C02",
                Nome = "Água Sanitária"
            };

            Categoria amaciante = new Categoria()
            {
                IdCategoria = "C03",
                Nome = "Amaciante"
            };

            Categoria desinfetante = new Categoria()
            {
                IdCategoria = "C04",
                Nome = "Desinfetante"
            };



            //Produtos Detergente

            Produto detergenteYpe = new Produto()
            {
                IdProduto = "DT001",
                NomeProduto = "Detergente Ypê",
                DataFabricacao = new DateTime(2017, 04, 12),
                DataValidade = new DateTime(2020, 04, 12),
                Preco = 1.85,
                Categoria = detergente
            };

            Produto detergenteUau = new Produto()
            {
                IdProduto = "DT002",
                NomeProduto = "Detergente Uau",
                DataFabricacao = new DateTime(2017,03,05),
                DataValidade = new DateTime(2019,03,05),
                Preco = 1.29,
                Categoria = detergente
            };

            Produto detergenteLimpol = new Produto()
            {
                IdProduto = "DT003",
                NomeProduto = "Detergente Limpol",
                DataFabricacao = new DateTime(2016, 08, 25),
                DataValidade = new DateTime(2018, 08, 25),
                Preco = 1.45,
                Categoria = detergente
            };


            //Produtos Agua Sanitaria

            Produto aguaSanitariaSantaClara = new Produto()
            {
                IdProduto = "AS001",
                NomeProduto = "Água Sanitária Santa Clara",
                DataFabricacao = new DateTime(2017, 02, 20),
                DataValidade = new DateTime(2020, 02, 20),
                Preco = 2.99,
                Categoria = aguaSanitaria
            };

            Produto aguaSanitariaGlobo = new Produto()
            {
                IdProduto = "AS002",
                NomeProduto = "Água Sanitária Globo",
                DataFabricacao = new DateTime(2017, 05, 20),
                DataValidade = new DateTime(2020, 05, 20),
                Preco = 3.50,
                Categoria = aguaSanitaria
            };

            //Produtos Amaciante

            Produto amacianteComfort = new Produto()
            {
                IdProduto = "AM001",
                NomeProduto = "Amaciante Comfort",
                DataFabricacao = new DateTime(2016, 08, 30),
                DataValidade = new DateTime(2018, 08, 30),
                Preco = 5.99,
                Categoria = amaciante
            };

            Produto amacianteDowny = new Produto()
            {
                IdProduto = "AM002",
                NomeProduto = "Amaciante Downy",
                DataFabricacao = new DateTime(2017,03,20),
                DataValidade  = new DateTime(2020,03,20),
                Preco = 7.99,
                Categoria = amaciante
            };

            //Produtos Desinfetante

            Produto desinfetantePinhoSol = new Produto()
            {
                IdProduto = "DF001",
                NomeProduto = "Desinfetante",
                DataFabricacao = new DateTime(2017, 04, 15),
                DataValidade = new DateTime(2019, 04, 15),
                Preco = 3.40,
                Categoria = desinfetante
            };

            Produto desinfetanteVeja = new Produto()
            {
                IdProduto = "DF002",
                NomeProduto = "Desinfetante",
                DataFabricacao = new DateTime(2016, 05, 30),
                DataValidade = new DateTime(2018, 05, 30),
                Preco = 3.99,
                Categoria = desinfetante
            };







        }
    }
}
