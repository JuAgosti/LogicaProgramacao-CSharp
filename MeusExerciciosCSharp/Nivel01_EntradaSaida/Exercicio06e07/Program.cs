using System;
using System.Runtime.Intrinsics.X86;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio06e07;

class Exercicio06e07
{
    public static void Executar()
    {
        double fahrenheit;
        double celsius;
        int op = -1;

        while (op != 0) {
            Console.WriteLine("--- ESCOLHA QUAL VOCÊ SEJA CONVERTER ---");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("0 - Sair");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine());
                double celsiusParaFahrenheite = (9 * celsius + 160.0) / 5.0;
                Console.WriteLine($"Tempreratura em Fahrenheit: {celsiusParaFahrenheite}");
            }else if (op == 2)
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine());
                double fahrenheitParaCelsius = (fahrenheit - 32.0) * 5.0 / 9.0;
                Console.WriteLine($"Tempreratura em Celsius: {fahrenheitParaCelsius}");
            }
            else if (op == 0)
            {
                Console.WriteLine("Saindo...");
            }
            else
            {
                Console.WriteLine("Número inválido");
            }

        }
    }
}