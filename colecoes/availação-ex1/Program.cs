using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");
            int pontosPL = 0;
            int pontosPC = 0;
            int numeroJogador = 0;
            bool conseguiuConverter = false;
            string opcaoJogador;
            do
            {
            Console.Write("Você quer par (p) ou ímpar (i) (pressione x para parar)? ");
            opcaoJogador = Console.ReadLine();
                if (opcaoJogador == "x")
                    break;
                do
                {
                    Console.Write("Informe um número inteiro: ");
                    conseguiuConverter = int.TryParse(Console.ReadLine(), out numeroJogador);
                } while (!conseguiuConverter || numeroJogador > 10);

            Random roleta = new Random(); // Random -> Tipo que nos permite selecionar um número randômico (aleatório).
            int numeroComputador = roleta.Next(10); // seleciona um numero entre 0 e 99.
            Console.WriteLine($"Numero do computador:{numeroComputador}");


                if((numeroJogador + numeroComputador) % 2 == 0 && opcaoJogador == "p" || (numeroJogador + numeroComputador) % 2 != 0 && opcaoJogador == "i"){
                    pontosPL++;
                }else{
                    pontosPC++;
                }
            } while (opcaoJogador != "x") ;

            Console.WriteLine($"Computador:{pontosPC} x Jogador:{pontosPL}");

            if (pontosPC > pontosPL)
                Console.WriteLine("Computador Ganhou");
            else if(pontosPL > pontosPC)
                Console.WriteLine("Jogador Ganhou");
            else
                Console.WriteLine("Empate");

            Console.WriteLine("Digite ENTER para finalizar o programa");
            Console.ReadLine();

            //TODO: Insira seu código aqui.
        }
    }
}