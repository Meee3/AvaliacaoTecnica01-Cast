using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region introdução do programa
        novaBusca:

            Remedio remedios = new Remedio();
            Console.WriteLine("(Facilitar este são os remedios que temos)");

            var novaLista = new List<string>();
            
            novaLista.AddRange(remedios.Nomes);
            novaLista.Sort(); //Elementos Ordenados

            string[] novaListaMaiuscula = new string[novaLista.Count];


            foreach(var item in novaLista)
            {
                Console.Write("[" + item + "] ");
            }

            for(int i = 0; i < novaListaMaiuscula.Length; i++)
            {
                novaListaMaiuscula[i] += novaLista[i].ToUpper();

            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Digite um Remedio para buscar no estoque");

            string palavraChave = Console.ReadLine().ToUpper();

            #endregion
            #region Logica de busca
            //Lógica de busca
            bool encontrado = false;
            bool encontrado0 = false;
            for (int i = 0; i < novaListaMaiuscula.Length; i++)
            {
                if (novaListaMaiuscula[i] == palavraChave)
                {
                    encontrado0 = true;
                }else if( novaListaMaiuscula[i].Contains(palavraChave[palavraChave.Length - 1]))
                {
                     encontrado = true;

                }
            }

            if (encontrado0)
            {
                Console.WriteLine("Sim, Temos no estoque");
            }else if (encontrado)
            {
                Console.WriteLine("Encontramos no Estoque com uma busca aproximada");
            }
            else
            {
                Console.WriteLine("Não temos no estoque");
            }

            Console.WriteLine("Deseja fazer nova busca? (s/n)");

            
            char novaBusca = char.Parse(Console.ReadLine().ToLower());

            if(novaBusca == 's')
            {
                Console.Clear();
                goto novaBusca;
            }
            else
            {
                Console.WriteLine("O sistema será encerrado, Obrigado por utiliza-lo");
                Console.WriteLine("Pressione qualquer tecla para sair.");
                Environment.Exit(0);
            }


            #endregion

        }
    }
}
