using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio14;

class Exercicio14
{
    public static void Executar()
    {
        int n1, n2;
        int diferenca;

        Console.WriteLine("--- DIFERENÇA ENTRE DOIS NÚMEROS ---");

        Console.WriteLine("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if(n1 >= n2)
        {
            diferenca = n1 - n2;
        }
        else
        {
            diferenca = n2 - n1;
        }
       

        Console.WriteLine($"\nDiferença: {diferenca}");
    }
}