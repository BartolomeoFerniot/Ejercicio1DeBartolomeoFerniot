using System;

namespace Ejercicio1DeBartolomeoFerniot
{
    class Program
    {
        static void Main(string[] args)
        {
            Double pesos, dolares, euros;
            Console.Write("Ingrese la cantidad de pesos que desea convertir a dólares y euros: ");
            pesos = Convert.ToDouble(Console.ReadLine());
            dolares = pesos / 230;
            euros = dolares / 1.17;
            Console.WriteLine($"La cantidad de dólares que puede comprar con {pesos} pesos son: {dolares} dólares");
            Console.WriteLine($"Y la cantidad de euros que puede comprar con la misma cantidad de pesos son: {euros} euros");

            Console.ReadLine();

        }
    }
}
