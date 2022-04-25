using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoTecnica1
{
    internal class Vendas
    {
        public Vendas()
        {
        recomecaAi:
            bool novaVenda = false;
            int cont = 0;
            #region Introdução do Programa
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Seja bem vindo ao Sistema de Vendas");
            Console.Write("\nPor favor digite a quantidade de funcionarios: ");

            int quantidadeFuncionarios = int.Parse(Console.ReadLine());
            if (quantidadeFuncionarios <= 0)
            {
                Console.WriteLine("Está de sacanagem né, tenta novamente");
                goto recomecaAi;
            }
            int[] posicaoVendasFuncionarios = new int[quantidadeFuncionarios]; // Venda Acumulada por pessoal

            string[] vetorFuncionario = new string[quantidadeFuncionarios]; // Quadro do Pessoal


            Console.Write("\nAgora, informe a quantidade total de estoque do Produtos: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            int totalEstoque = quantidadeProdutos;

            string[] vetorProdutos = new string[quantidadeProdutos];

            Console.Write("\nAgora, informe o nome do Produto: ");
            string nomeProdutos = Console.ReadLine();
            //string[] vetorProdutos = new string[quantidadeProdutos];

            Console.Clear();
            Console.WriteLine("Vamos Cadastrar os Funcionarios");

            for (int i = 0; i < vetorFuncionario.Length; i++)
            {
                Console.Write("Digite o Nome do Funcionário: ");
                vetorFuncionario[i] = Console.ReadLine();
                //funcionario.NomeID[i] = Console.ReadLine();
            }

            //Console.WriteLine("Vamos Cadastrar os Produtos!");

            //for (int i = 0; i < vetorProdutos.Length; i++)
            //{
            //    Console.Write("Digite o Nome do Produto: ");
            //    vetorProdutos[i] = Console.ReadLine();

            //}

            Console.WriteLine("\nAté o momento temos cadastrados as seguintes informações!");
            Console.Clear();
            Console.Write("Funcionários: ");
            foreach (string item in vetorFuncionario)
            {
                Console.Write("[" + item + "] ");
            }
            Console.WriteLine();

            Console.WriteLine("Nome do Produtos: {0} e a Quantidades é: {1}", nomeProdutos, totalEstoque);
            //Console.Write("Produtos: ");
            //foreach (string item in vetorProdutos)
            //{
            //    Console.Write("[" + item + "] ");
            //}
            #endregion

            #region posição Vendedor e Qtd que foram vendidos
            int vendedorAtivo = 0;
            int produtosVendidos = 0;

            if (vetorFuncionario.Length > 1)
            {
                MudancaTela();
            }
            else
            {
                vendedorAtivo = 0;
            }



            novasVendas();


            #endregion

            #region Métodos

            void VendaProdutos(int valor)
            {
                if (valor > totalEstoque)
                {
                    Console.WriteLine("Não podemos realizar a Venda, não temos Estoque");
                    novaVenda = true;
                    Console.WriteLine("Deseja Continuar na venda? ou sair (s/n)");
                    char ContinuarVenda = char.Parse(Console.ReadLine());
                    if (ContinuarVenda == 's')
                    {
                        novasVendas();
                    }
                    else
                    {
                        MudancaTela();
                    }


                }
                else
                {
                    totalEstoque -= valor;
                    posicaoVendasFuncionarios[vendedorAtivo] = valor;


                }
                Console.WriteLine("Foram vendidos " + produtosVendidos);

            }

            void novasVendas()
            {
                cont++;
                Console.WriteLine("");
                Console.WriteLine("Digite quantos Produtos foram vendidos");
                produtosVendidos = int.Parse(Console.ReadLine());
                if (cont > 1)
                {
                    VendaProdutos(produtosVendidos);
                }


            }

            void MudancaTela()
            {
                Console.WriteLine("\nAgora Selecione uma das opções");
                Console.WriteLine("Escolha qual Vendedor irá trabalhar no Caixa agora (id)");
                for (int i = 0; i < vetorFuncionario.Length; i++)
                {
                    Console.WriteLine("ID Funcionario: " + i + " " + "Nome Funcionário: " + vetorFuncionario[i]);
                }

                int vendedorCaixa = int.Parse(Console.ReadLine());
                vendedorAtivo = vendedorCaixa; // Posição do Vendedor Ativo No Array Funcionarios
            }
            #region comissao()comentado
            //void comissao()
            //{
            //    for (int i = 0; i <= quantidadeFuncionarios-1; i++)
            //    {
            //        if (posicaoVendasFuncionarios[i] <= 5)
            //        {
            //            Console.WriteLine("O Funcionario : " + vetorFuncionario[posicaoVendasFuncionarios[i]]);
            //            Console.WriteLine("Tem direito de 0.4% de comissão");

            //        }
            //        else if (posicaoVendasFuncionarios[i] > 5 && posicaoVendasFuncionarios[i] <= 10)
            //        {
            //            Console.WriteLine("O Funcionario : " + vetorFuncionario[posicaoVendasFuncionarios[i]]);
            //            Console.WriteLine("Tem direito de 1.3 de comissão");


            //        }
            //        else if (posicaoVendasFuncionarios[i] > 10 && posicaoVendasFuncionarios[i - 1] <= 15)
            //        {
            //            Console.WriteLine("O Funcionario : " + vetorFuncionario[posicaoVendasFuncionarios[i]]);
            //            Console.WriteLine("Tem direito de 3% de comissão");


            //        }
            //        else
            //        {
            //            Console.WriteLine("O Funcionario : " + vetorFuncionario[posicaoVendasFuncionarios[i-1]]);
            //            Console.WriteLine("Tem direito de 5% de comissão");


            //        }
            //    }
            //}
            #endregion
            void comissao(int valor)
            {

                if (valor <= 5)
                {
                    Console.WriteLine("O Funcionario : " + vetorFuncionario[vendedorAtivo]);
                    Console.WriteLine("Tem direito de 0.4% de comissão");

                }
                else if (valor > 5 && valor <= 10)
                {
                    Console.WriteLine("O Funcionario : " + vetorFuncionario[vendedorAtivo]);
                    Console.WriteLine("Tem direito de 1.3 de comissão");


                }
                else if (valor > 10 && valor <= 15)
                {
                    Console.WriteLine("O Funcionario : " + vetorFuncionario[vendedorAtivo]);
                    Console.WriteLine("Tem direito de 3% de comissão");


                }
                else
                {
                    Console.WriteLine("O Funcionario : " + vetorFuncionario[vendedorAtivo]);
                    Console.WriteLine("Tem direito de 5% de comissão");


                }
            }
        
        //void plusVendas()
        //{
        //    comissao();
        //}


        #endregion

        VendaProdutos(produtosVendidos);



        Console.WriteLine();
            Console.WriteLine("Estoque: " + totalEstoque);

            Console.WriteLine("Até o momento, o Funcionario {0} vendeu {1}", vetorFuncionario[vendedorAtivo], posicaoVendasFuncionarios[vendedorAtivo]);

            comissao(posicaoVendasFuncionarios[vendedorAtivo]);
            Console.ReadLine();
            //plusVendas();
        }

    }
}



