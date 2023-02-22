using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Luta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string golpe;
            int chutes = 0;
            int socos = 0;
            int magias = 0;
            int pontos = 0;
            do
            {
                Console.Write("Digite um golpe(c-chute, s-scoco,m-magia: ");
                golpe = Console.ReadLine().ToLower();
                if(golpe == "c"){
                    pontos += 2;
                    chutes++;
                }else if(golpe == "s"){
                    pontos += 4;
                    socos++;
                }else if(golpe == "m"){
                    pontos += 10;
                    magias++;
                }
                else
                {
                    Console.WriteLine("Golpe inválido");
                }
            } while (golpe != "z");



            Console.WriteLine($"Quantidade de chutes: {chutes} ");
            Console.WriteLine($"Quantidade de socos: {socos} ");
            Console.WriteLine($"Quantidade de magias: {magias} ");
            Console.WriteLine($"Quantidade de pontos: {pontos} ");

            Console.WriteLine("Digite Enter para sair do programa");
            Console.ReadLine();


        }
    }
}
