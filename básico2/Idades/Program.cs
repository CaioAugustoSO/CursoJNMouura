using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idades21 = 0;
            int idades50 = 0;
            int idade;

            int media = 0;

            do
            {

                Console.Write("Digite uma idade: ");
                idade = int.Parse(Console.ReadLine());

                media += idade;
                if (idade == -1)
                    break;
                else if (idade < -1)
                {
                    Console.WriteLine("Digite uma idade maior que -1 para que seja coerente");
                    continue;
                }


                if(idade < 21)
                {
                    idades21++ ;
                }
                else if (idade > 50){
                    idades50++ ;
                }

            } while (true);


            Console.WriteLine($"Media: {media} ");
            Console.WriteLine($"Idades menores que 21: {idades21} ");
            Console.WriteLine($"Idades maiores que 50: {idades50} ");
            Console.WriteLine("Digite ENTER para finalizar o programa ");
            Console.ReadLine();
        }
    }
}
