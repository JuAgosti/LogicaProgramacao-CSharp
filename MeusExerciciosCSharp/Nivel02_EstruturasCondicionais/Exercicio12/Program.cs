using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio12;

class Exercicio12
{
    public static void Executar()
    {
        int n1;

        Console.WriteLine("--- MÓDULO DE UM NÚMERO ---");

        Console.WriteLine("Digite um número: ");
        n1 = int.Parse(Console.ReadLine());

        if (n1 >= 0)
        {
            Console.WriteLine($"Módulo: {n1}");
        }
        else
        {
            // int modulo = Math.Abs(n1);
            Console.WriteLine($"Módulo: {n1 * (-1)}");
        }

    }
}