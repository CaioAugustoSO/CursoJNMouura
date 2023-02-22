using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma senha: ");
            int senha = int.Parse(Console.ReadLine());
            if(senha == 904087){
                Console.WriteLine("Acesso permitido");
            }
            else{
                Console.WriteLine("Acesso negado");
            }
                Console.WriteLine("Aperte enter pra finalizar o programa");
                Console.ReadLine();
        }
    }
}
