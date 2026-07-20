using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio08;
class Exercicio08
{
    public static void Executar()
    {
        double raio;
        double altura;

        Console.WriteLine("--- VOLUME DE UMA LATA ---");

        Console.WriteLine("Digite o raio: ");
        raio = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a altura: ");
        altura = double.Parse(Console.ReadLine());


        double volume = Math.PI * Math.Pow(raio,2) * altura;

        Console.WriteLine($"Volume da lata: {volume:F2} cm³");
    }
}