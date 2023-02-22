using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0 ;
            int[] numeros = new int[8];
            numeros[0] = 10;
            for(int i = 1; i < numeros.Length; i++){
                numeros[i] = numeros[i - 1] * 2;
                soma += numeros[i];
            }
                Console.WriteLine($"{numeros[7]}");
            Console.WriteLine($"{soma}");
            Console.WriteLine($"ENTER");
            Console.ReadLine();
        }
    }
}
