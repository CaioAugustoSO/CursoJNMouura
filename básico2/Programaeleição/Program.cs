using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programaeleição
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu voto");
            int voto = int.Parse(Console.ReadLine());


            if(voto == 1 || voto == 2 || voto == 3 || voto == 4){
                Console.Write("voto contabilizado com sucesso");
            }else if(voto == 5){
                Console.Write("Voto nulo");
            }else if (voto == 6){
                Console.Write("Voto em Branco");
            }

            Console.WriteLine("Aperte enter pra finalizar o programa");
            Console.ReadLine();



        }
    }
}
