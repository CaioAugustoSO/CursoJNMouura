using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool conseguiuConverter = false;
            int pesomaximo = 0;
            int pessoas = 0;
            double peso = 0;
            double pesoTotal = 0;

            Console.Write("Digite o peso maximo: ");
            pesomaximo = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de pessoas: ");
            pessoas = int.Parse(Console.ReadLine());


            for (int i = 1; i <pessoas+1; i++){
                do{
                    Console.Write($"Digite o peso da {i}º pessoa em kg: ");
                    conseguiuConverter = double.TryParse(Console.ReadLine(), out peso);
                } while (!conseguiuConverter || peso <= 0);
                pesoTotal += peso;
            }

            if(pesoTotal > pesomaximo){
                Console.WriteLine("Não poderá entrar em funcionamento");
            }
            else {
                Console.WriteLine("Poderá entrar em funcionamento");
            }

            Console.WriteLine("Digite ENTER para sair do programa");
            Console.ReadLine();

        }
    }
}
