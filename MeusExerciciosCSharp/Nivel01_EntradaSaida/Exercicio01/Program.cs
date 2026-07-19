using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio01;
class Exercicio01
{
    public static void Executar()
    {
        double quantMinima;
        double quantMaxima;
        double estoqueMedia;

        Console.WriteLine("Digite a quantidade mínima do estoque: ");
        quantMinima = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade máxima do estoque: ");
        quantMaxima = double.Parse(Console.ReadLine());

        estoqueMedia = (quantMinima + quantMaxima) / 2;

        Console.WriteLine("Estoque médio: " + estoqueMedia);

    }
}