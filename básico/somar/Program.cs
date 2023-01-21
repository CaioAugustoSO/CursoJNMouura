using System;
/* Faça uma calculadora que leia dois números e imprima a soma, subtração, multiplicação, divisão e o resto da 
 * divisão desses números. */
namespace somar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("Digite um numero:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo numero:");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
            Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
            Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
            Console.WriteLine($"{n1} / {n2} = {(double)n1 / n2}");
            Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
            Console.WriteLine("--Tecle \"Enter\" para sair do programa-- ");
            Console.ReadLine();
        }
    }
}
