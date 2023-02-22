using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, z = 0;

            z = 1 + n++;

            Console.WriteLine($"Valor de z = {z++}");
            n = 0;

            z = 1 + ++n;

            Console.WriteLine($"Valor de z = {++z}");

            Console.ReadLine();
        }
    }
}
