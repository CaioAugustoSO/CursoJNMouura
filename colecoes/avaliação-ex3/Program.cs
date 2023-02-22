using System;
using System.Collections.Generic;

namespace Senhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("------Bem vindo ao programa de controle de senhas ------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");

            int opcao = 0;
            int contador = 0;
            List<int> comum = new List<int>();
            List<int> prioritario = new List<int>();
            List<int> senhas = new List<int>();
            List<int> listaSenhas = new List<int>();
            do
            {
                senhas.Add((contador+1));
                Console.WriteLine("1 - Gerar senha para atendimento comum.");
                Console.WriteLine("2 - Gerar senha para atendimento prioritário.");
                Console.WriteLine("3 - Chamada da senha para atendimento.");
                Console.WriteLine("4 - Encerramento do atendimento.");

                Console.Write("Informe uma opção:");
                opcao = int.Parse(Console.ReadLine());




                if (opcao == 1)
                {
                    comum.Add(senhas[contador]);

                    Console.WriteLine("Senha gerada para atendimento comum.");
                }
                else if (opcao == 2)
                {
                    //TODO: Insira seu código aqui.
                    prioritario.Add(senhas[contador]);
                    Console.WriteLine("Senha gerada para atendimento prioritário.");
                }
                else if (opcao == 3)
                {
                    int senhaChamada = 0;
                    int contadorPrioritario = 0;
                    int contadorComum = 0;

                    if (prioritario.Count != 0)
                    {
                        senhaChamada = prioritario[contadorPrioritario];
                        prioritario.Remove(senhaChamada);
                        contadorPrioritario++;
                    }
                    else if (comum.Count != 0)
                    {
                        senhaChamada = comum[contadorComum];
                        
                        comum.Remove(senhaChamada);
                        contadorComum++;
                    }
                    else
                    {
                        Console.WriteLine("Não há mais senhas na fila");
                    }


                    Console.WriteLine("Senha {0} chamada para atendimento.", senhaChamada);
                }
                else if (opcao == 4)
                {
                    //TODO: Insira seu código aqui.
                    break;

                }
                else
                {
                    Console.WriteLine("Opção inválida. Informe outra po favor.");
                }

                Console.WriteLine("Pressione ENTER para continuar.");
                Console.ReadLine();

                Console.Clear(); //Limpar a tela em cada LOOP.
                contador++;

            } while (true);

            Console.WriteLine("Atendimento Encerrado");

            Console.ReadLine();
        }
    }
}