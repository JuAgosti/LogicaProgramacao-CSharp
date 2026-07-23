using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio19;

class Exercicio19
{
    public static void Executar()
    {
        int[] lados = new int[3];

        Console.WriteLine("--- CLASSIFICAÇÃO DE TRIÂNGULO ---");
        
        for(int i = 0; i < lados.Length; i++)
        {
            Console.WriteLine($"Digite o lado {i + 1}: ");
            lados[i] = int.Parse(Console.ReadLine());
        }

        // Validação para verificar se é um triângulo
        if (lados[0] + lados[1] > lados[2] &&
            lados[0] + lados[2] > lados[1] &&
            lados[1] + lados[2] > lados[0]
            )
        {
            if (lados[0] == lados[1] && lados[1] == lados[2] && lados[0] == lados[2])
            {
                Console.WriteLine("Triângulo Equilátero!");
            }
            else if (lados[0] == lados[1] || lados[1] == lados[2] || lados[0] == lados[2])
            {
                Console.WriteLine("Triângulo Isósceles!");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno!");
            }
        }
        else
        {
            Console.WriteLine("Os valores não representam um triângulo.");
        }
    }
}