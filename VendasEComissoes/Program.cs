using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasEComissoes.model;

namespace VendasEComissoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = null;
            List<string> listaFuncionario = new List<string>();

            Console.Write("Digite a quantidade de Funcionários: ");
            int quantidadeFuncionario = int.Parse(Console.ReadLine());
            
            for( int i = 0; i < quantidadeFuncionario; i++)
            {
                Console.Write("Cadastre o ID do {0} funcionario:", (i+1));
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o Nome do {0} funcionário: ", (i + 1));
                string nome = Console.ReadLine();

                listaFuncionario.Add(nome);
                Console.WriteLine();
               

            }

            Console.WriteLine("Funcionários: ");
            foreach(string item in listaFuncionario)
            {
                Console.Write("[" + item + "] ");
            }

            //Bom outrora continuo ;D
        
        
        }
    }
}
