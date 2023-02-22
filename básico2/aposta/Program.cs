using System;


namespace aposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva a aposta da 1º pessoa: ");
            float aposta1 = float.Parse(Console.ReadLine()); 
            Console.Write("Escreva a aposta da 2º pessoa: ");
            float aposta2 = float.Parse(Console.ReadLine());            
            Console.Write("Escreva a aposta da 2º pessoa: ");
            float aposta3 = float.Parse(Console.ReadLine());
            Console.Write("Escreva o valor do prêmio: ");
            float premio = float.Parse(Console.ReadLine());

            float apostatotal = aposta1 + aposta2 + aposta3;

            Console.WriteLine($"Porcentagem do 1º apostador: {(aposta1*100)/apostatotal} %" );
            Console.WriteLine($"Porcentagem do 2º apostador: {(aposta2*100)/apostatotal} %" );
            Console.WriteLine($"Porcentagem do 3º apostador: {(aposta2*100)/apostatotal} %" );

            Console.WriteLine($"Premiação do 1º apostador: {premio*(aposta1/apostatotal):F2}" );
            Console.WriteLine($"Premiação do 2º apostador: {premio * (aposta2 / apostatotal):F2}" );
            Console.WriteLine($"Premiação do 3º apostador: {premio * (aposta3 / apostatotal):F2} " );
            Console.ReadLine();

        }
    }
}
