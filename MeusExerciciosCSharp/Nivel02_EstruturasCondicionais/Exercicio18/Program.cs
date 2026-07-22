using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio18;

class Exercicio18
{
    public static void Executar()
    {
        int n;

        Console.WriteLine("--- CÓDIGO POR EXTENSO ---");

        Console.WriteLine("Digite o número: ");
        n = int.Parse(Console.ReadLine());

        switch (n)
        {
            case 1:
                Console.WriteLine("Um");
                break;
            case 2:
                Console.WriteLine("Dois");
                break;
            case 3:
                Console.WriteLine("Três");
                break;
            default: 
                Console.WriteLine("Código inválido"); 
                break;
        }
       
    }
}