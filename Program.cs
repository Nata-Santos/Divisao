using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numerador, denominador, resultado;
            bool numValido, denValido;
        

            Console.WriteLine("--Cálculo de Divisão--");

            Console.Write("\nDigite o numerador....:");
            numValido = decimal.TryParse(Console.ReadLine(), out numerador);

            if(!numValido)
            {
                Console.WriteLine("\nDigite um numerador válido.");
                Environment.Exit(1);
            }

            Console.Write("Digite o denominador..:");
            denValido = decimal.TryParse(Console.ReadLine(), out denominador);

            
            if(!denValido)
            {
                Console.WriteLine("\nDigite um denominador válido.");
                Environment.Exit(1);
            }

            if (denominador == 0)
            {
                Console.WriteLine("\nNão é possivel dividir por 0");
            }
            else
            {
                resultado = numerador / denominador;
                Console.WriteLine($"\n{numerador} dividido por {denominador} é igual a {resultado}");
            }

        }
    }
}
