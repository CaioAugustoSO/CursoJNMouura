using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double valorLitroAlcool = 3.5;
            const double valorLitroGasolina = 5.0;
            int tipoCombusitvel;
            bool conseguiuConverter = false;
            

            do
            {
                Console.Write("Digite o tipo de combustivel 1(Álcool) 2(Gasolina): ");
                conseguiuConverter = int.TryParse(Console.ReadLine(), out tipoCombusitvel);
            } while (!conseguiuConverter || (tipoCombusitvel != 1 && tipoCombusitvel != 2));

            double litros = 0;

            do
            {
                Console.Write("Litros: ");
                conseguiuConverter = double.TryParse(Console.ReadLine(), out litros);
            } while (!conseguiuConverter || litros < 0);


            double descontoAlcool = 1 - ((litros <= 20) ? 0.02 : 0.05);
            double descontoGasolina = 1 - ((litros <= 20) ? 0.03 : 0.06);

            double valorLitro = (tipoCombusitvel == 1) ? valorLitroAlcool * descontoAlcool : valorLitroGasolina * descontoGasolina;


            double valorapagar = valorLitro * litros;

            Console.WriteLine($"Valor á pagar {valorapagar}");

            Console.WriteLine("Digite ENTER para sair do programa");
            Console.ReadLine();

        }
    }
}
