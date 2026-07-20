using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio10;
class Exercicio10
{
    public static void Executar()
    {
        int n1 , n2;

        Console.WriteLine("--- RELACIONAMENTO ENTRE DOIS NÚMEROS ---");

        Console.WriteLine("Digite o primeiro núemro: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo núemro: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n--- RESULTADOS: ---");
        Console.WriteLine($"Igual? :{n1 == n2}");
        Console.WriteLine($"Diferente? :{n1 != n2}");
        Console.WriteLine($"Maior? :{n1 > n2}");
        Console.WriteLine($"Menor? :{n1 < n2}");
        Console.WriteLine($"Maior ou igual? :{n1 >= n2}");
        Console.WriteLine($"Menor ou igual? :{n1 <= n2}");

    }
}