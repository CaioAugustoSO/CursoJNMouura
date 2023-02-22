using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para retornar sua tabuada");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;
            
            Console.WriteLine("Usando Do While");
            do
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
                i++;
            } while (i<=10);
            Console.WriteLine("Usando While");
            i = 0;
            while (i <= 10)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
                i++;
            }
            Console.WriteLine("Usando For");
            for (i = 0;i <= 10; i++) {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
            Console.WriteLine("Digite Enter para sair do programa");
            Console.ReadLine();
        }
    }
}
