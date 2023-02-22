using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pesolimite = 50;
            double excessoKg = 0;
            const double multaporKg = 4;
            double multa = 0;
            Console.Write("Digite o peso pescado: ");
            int peso = int.Parse(Console.ReadLine());

            if(peso > pesolimite)
            {
               excessoKg = peso - pesolimite;
               multa = excessoKg * multaporKg;
            }

            Console.WriteLine($"Valor da multa a ser pago é de: {multa}");
            Console.WriteLine($"O excesso de peso é de:  {excessoKg}");
            Console.WriteLine("Aperte enter pra finalizar o programa");
            Console.ReadLine();

        }
    }
}
