using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio04;
class Exercicio04
{
    public static void Executar()
    {

        int[] numeros = new int[4];
        string[] letras = { "A", "B", "C", "D" };

        for(int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Digite o valor de {letras[i]}: ");
            numeros[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("\n--- RESULTADO DAS SOMAS ---");
        for(int i = 0; i < numeros.Length; i++)
        {
            for(int j = i; j < numeros.Length; j++)
            
            {
                int soma = numeros[i] + numeros[j];
                Console.WriteLine($"{letras[i]} + {letras[j]} ({numeros[i]} + {numeros[j]}) = {soma}");
            }
        }

        Console.WriteLine("\n--- RESULTADO DAS MULTIPLICAÇÃO ---");
        for (int i = 0; i < numeros.Length; i++)
        {
            for (int j = i; j < numeros.Length; j++)

            {
                int soma = numeros[i] * numeros[j];
                Console.WriteLine($"{letras[i]} * {letras[j]} ({numeros[i]} * {numeros[j]}) = {soma}");
            }
        }

    }
}