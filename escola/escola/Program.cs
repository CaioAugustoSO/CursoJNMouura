using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para ler três notas e o número de faltas de um aluno e escrever qual a sua situação
            //final:
            //Aprovado, Reprovado por Falta ou Reprovado por Média.A média para aprovação é 7,0 e o limite de faltas
            //é 25 %
            //do total de aulas.O número de aulas ministradas no semestre foi de 80.A reprovação por falta sobrepõe
            //a
            //reprovação por Média.


            int nota1, nota2, nota3, presenca;
            const int limitedefalta = 20;

            Console.Write("Digite sua nota 1: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("Digite sua nota 2: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("Digite sua nota 3: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("Digite sua presenca: ");
            presenca = int.Parse(Console.ReadLine());

            float media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7.0 && presenca > limitedefalta){
                Console.WriteLine("Aprovado");
            }
            else if (media <= 7.0 && presenca > limitedefalta){
                Console.WriteLine("Reprovado por média");
            }
            else{
                Console.WriteLine("Reprovado por falta");
            }

            Console.WriteLine("Digite enter para terminar o programa");
            Console.ReadLine();

        }
    }
}
