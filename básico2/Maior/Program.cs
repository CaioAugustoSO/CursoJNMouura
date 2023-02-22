using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int soma = 0;

            for(int i= 0; i < 5; i++){
                Console.Write("Digite um valor inteiro: ");
                int numero = int.Parse(Console.ReadLine());
                if(numero > maior)
                    maior = numero;

                soma += numero;
            }

            Console.WriteLine($"Soma dos numeros é: {soma}");
            Console.WriteLine($"O maior dos numeros é: {maior}");
            Console.WriteLine("para parar o prgorama digite ENTER ");
            Console.ReadLine();
        }
    }
}
