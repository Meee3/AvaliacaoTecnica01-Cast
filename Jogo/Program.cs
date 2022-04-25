using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Objetivo: Um jogo de adivinhação (números) que consiga informar
             * ao usuário em quantas jogadas ele conseguiu acertar o número pensado pelo sistema.
             * As dificuldades extras como, quantidade de jogadas,
             * ou definir o limite de números mínimo e máximo podem ser definidas. - OK
PLUS
1.	Se a cada resposta errada o sistema informar uma resposta diferenciada do tipo:
            errou tente de novo, xiii passou longe, tá frio muito frio, etc... ponto extra - OK

2.	SE o sistema continuar a funcionar em um loop até que alguma ação final seja alcançada:
            número de tentativas, acerto do jogador, ao final de cada tentativa perguntar se ele deseja continuar. - OK

3.	Se no final forem passadas informações diversas: número de tentativas,
            quantas vezes ele se aproximou ao número sorteado faltando um para mais ou para menos. - OK
*/

            Console.WriteLine("\t\tJogo da Advinhação!!!");
            Console.WriteLine("Regra: Neste jogo você terá 3 chances para acertar um número aleatório gerado!");
            Console.WriteLine("Regra: Acertou o número o programa será encerrado");
            Console.WriteLine();
            const int numeroTentativa = 3;
            Random random = new Random();
            int numeroFixo = random.Next(11);

            //Aqui Prof.
            //Console.WriteLine("Esté o número da sorte: " + numeroFixo);

            Console.WriteLine("Digite um número:");
            int numeroJogador = 0;

            int numeroProximos = 0;
            int acertouNaLata = 0;
          
            #region frases
            string[] frasesAumentativas = { "Olha...Se eu fosse você...Aumentaria este número ai....", "Ta quase lá",
                "Digamos que precise aumentar um pouco mais",
            "como meu velho amigo Leonidas falava: Um pouco mais", "Aumenta isso ai menino(a)", "autoIncrementa Isto aii","hummm, +1? talvez"};

            string[] frasesDecrementativas = {"Ae, chega mais... diminui isso na moral", "Papo reto, diminui isto",
            "nada contra, só tira alguns ai", "Olha, faz aquele negocio do a-- ou era --a?","Tá muito alto menino(a)","Abaixa esse valor!"};

            string[] frasesComResultado = {"Joga na Mega Sena que tuu Acertouuuuu", "Aeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee pohaaaa, opa desculpa Empolguei! Acertouu",
                "Como assim tu acertouuu???? Parabénssss!!!","Uma vez na vida e outra.... no teste, acertouuu!",
                "Tem uns caras que nasceram pra Lua... você é um deles!, Acertou!", "Cagado, acertou", "Parabénssss Acertouuuuuu"
            };
            #endregion

            #region loopTentativas
            for (int i = 0; i < numeroTentativa; i++)
            {
                numeroJogador = int.Parse(Console.ReadLine());

                if(numeroJogador == numeroFixo)
                {
                    
                    int respostaGerada = random.Next(6);
                    Console.WriteLine(frasesComResultado[respostaGerada]);
                    acertouNaLata++;
                    break;
                }else if(numeroJogador < numeroFixo)
                {
                    if (numeroJogador + 1 == numeroFixo)
                    {
                        numeroProximos++;
                    }
                    int respostaGerada = random.Next(7);
                    if(i + 1 == numeroTentativa)
                    {

                    }
                    else { 
                    Console.WriteLine(frasesAumentativas[respostaGerada]);
                    }
                    //Console.WriteLine("Olha...Se eu fosse você...Aumentaria este número ai....");
                }
                else
            {
                    if (numeroJogador - 1 == numeroFixo)
                    {
                        numeroProximos++;
                    }
                    int respostaGerada = random.Next(6);

                    if (i + 1 == numeroTentativa)
                    {

                    }
                    else
                    {
                        Console.WriteLine(frasesDecrementativas[respostaGerada]);
                    }
                }

            }

            if(acertouNaLata == 0)
            {
                Console.WriteLine("Infelizmente, não foi desta vez");
                //Console.WriteLine("Está a quantidade de vezes você esteve perto do número da sorte por 1");
                Console.WriteLine("A quantidade de vezes que esteve perto do número secreto foi: {0}", numeroProximos);
            }
            #endregion
        }
    }
}
