using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

/*
 * Faça um programa que inverta uma determinada sequencia de números inteiros informada pelo usuário. Você deve utilizar as estrtuturas de fila e pilha em sua resolução.
 */

namespace ordem_inversa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantia de numero que você deseja: ");
            int contador2 = 0;
            int qnt = int.Parse(Console.ReadLine());
            Queue<int> numeros = new Queue<int>();
            int contador = 0;
            do
            {
                contador++;
                Console.Write($"Digite o {contador}º numero: ");
                int n = int.Parse(Console.ReadLine());
                numeros.Enqueue(n);
            } while (contador < qnt);

             Stack<int> numerosInvertidos = new Stack<int>(); ;

            foreach (int n in numeros)
            {
                do
                {
                    contador2++;

                    numerosInvertidos.Push(n);

                } while (contador2 < qnt);
            }

            int contadorInertido = 0;
            do
            {
                contadorInertido++;
                Console.WriteLine($"Invertendo a {contadorInertido}º posição: {numerosInvertidos.Pop()} ");
            } while (contadorInertido < qnt);

            Console.WriteLine("Digite ENTER para sair do programa: ");
            Console.ReadLine();

        }
    }
}
