using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio11;

class Exercicio11
{
    public static void Executar()
    {
        int a ,b, auxiliar = 0;

        Console.WriteLine("--- TROCA DE VALORES ---");

        Console.WriteLine("Digite o valor de A: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());

        auxiliar = a;
        a = b;
        b = auxiliar;

        // Truque do C# para inverter os valores sem precisar de variável auxiliar!
        // (a,b) = (b,a);

        Console.WriteLine($"O valor de A é: {a}");
        Console.WriteLine($"O valor de B é: {b}");

    }
}