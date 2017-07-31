using LojaProdutoLimpeza;
using LojaProdutoLimpeza2;
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

            //Endereco

            Endereco endereco1 = new Endereco()
            {
                Rua = "Silva Lobo",
                Numero = 1250,
                Sala = 1,
                Cidade = "Belo Horizonte",
                Cep = "32251-221",
                Uf = "MG"
            };

            Endereco endereco2 = new Endereco()
            {
                Rua = "Raja Gabaglia",
                Numero = 3950,
                Sala = 2,
                Cidade = "Belo Horizonte",
                Cep = "33252-522",
                Uf = "MG"
            };

            Endereco endereco3 = new Endereco()
            {
                Rua = "Campos de Ourique",
                Numero = 1220,
                Sala = 3,
                Cidade = "Betim",
                Cep = "32260-724",
                Uf = "MG"
            };

            //Fornecedores

            Fornecedor forYpe = new Fornecedor()
            {
                Nome = "Ype Comercio de Produtos Naturais Ltda",
                Telefone = "30302020",
                Endereco = endereco1,
                Cnpj = "31457212000124",
                NomeFantasia = "Ypê"
            };

            Fornecedor forUau = new Fornecedor()
            {
                Nome = "Uau Produtos de Limpeza Ltda",
                Telefone = "40204020",
                Endereco = endereco2,
                Cnpj = "52314568000141",
                NomeFantasia = "Uau"
            };

            Fornecedor forLimpol = new Fornecedor()
            {
                Nome = "Limpol Comercio Ltda",
                Telefone = "52413663",
                Endereco = endereco3,
                Cnpj = "43645879000123",
                NomeFantasia = "Limpol"
            };

            Fornecedor forSantaClara = new Fornecedor()
            {
                Nome = "Santa Clara Ltda",
                Telefone = "32365636",
                Endereco = endereco1,
                Cnpj = "41254789000124",
                NomeFantasia = "Santa Clara"
            };

            Fornecedor forGlobo = new Fornecedor()
            {
                Nome = "Globo Produtos Ltda",
                Telefone = "65897845",
                Endereco = endereco2,
                Cnpj = "45478520000125",
                NomeFantasia = "Globo"
            };

            Fornecedor forComfort = new Fornecedor()
            {
                Nome = "Comfort Ltda",
                Telefone = "69874587",
                Endereco = endereco3,
                Cnpj = "32457896000125",
                NomeFantasia = "Comfort"
            };

            Fornecedor forDowny = new Fornecedor()
            {
                Nome = "Downy Ltda",
                Telefone = "78459631",
                Endereco = endereco1,
                Cnpj = "47856932000125",
                NomeFantasia = "Downy"
            };

            Fornecedor forPinhoSol = new Fornecedor()
            {
                Nome = "Pinho Sol Ltda",
                Telefone = "78459632",
                Endereco = endereco2,
                Cnpj = "47896352000124",
                NomeFantasia = "Downy"
            };

            Fornecedor forVeja = new Fornecedor()
            {
                Nome = "Veja Ltda",
                Telefone = "78459633",
                Endereco = endereco3,
                Cnpj = "78549633000123",
                NomeFantasia = "Veja"
            };

            //Status Clientes

            Status stBom = new Status()
            {
                IdStatus = 1,
                Classificacao = "BOM"
            };

            Status stMedio = new Status()
            {
                IdStatus = 2,
                Classificacao = "MEDIO"
            };

            Status stRuim = new Status()
            {
                IdStatus = 3,
                Classificacao = "RUIM"
            };


            //Clientes
            
            Cliente cliCamila = new Cliente()
            {
                Nome = "Camila Barcellos",
                Telefone = "992493398",
                Endereco = endereco2,
                IdCliente = "Cli001",
                Filiacao = "Carmen Aranda Barcellos",
                LimiteCredito = 5.000,
                Status = stBom
            };

            Cliente cliEwerton = new Cliente()
            {
                Nome = "Ewerton Rodrigues",
                Telefone = "74589632",
                Endereco = endereco3,
                IdCliente = "cli002",
                Filiacao = "Ana Rodrigues",
                LimiteCredito = 3.000,
                Status = stMedio
            };

            Cliente cliJean = new Cliente()
            {
                Nome = "Jean Nonato",
                Telefone = "7854522",
                Endereco = endereco1,
                IdCliente = "cli003",
                Filiacao = "Maria Nonato",
                LimiteCredito = 0,
                Status = stRuim
            };

            Cliente cliWashington = new Cliente()
            {
                Nome = "Washington Caetano",
                Telefone = "78965412",
                Endereco = endereco2,
                IdCliente = "cli004",
                Filiacao = "Resonita Caetano",
                LimiteCredito = 2.000,
                Status = stBom
            };

            Cliente cliFelipe = new Cliente()
            {
                Nome = "Felipe Andrade",
                Telefone = "96587411",
                Endereco = endereco3,
                IdCliente = "cli005",
                Filiacao = "Cleide Andrade",
                LimiteCredito = 2.500,
                Status = stMedio
            };







        }
    }
}
