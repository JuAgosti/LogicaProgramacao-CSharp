using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio20;

class Exercicio20
{
    public static void Executar()
    {
        int[] n = new int[3];
        int maior, menor;

        Console.WriteLine("--- MENOR E MAIOR VALOR ---");
        
        for(int i = 0; i < n.Length; i++)
        {
            bool validador = false;
            while (!validador) {
                Console.WriteLine($"Digite o {i + 1} valor: ");
                int validarValor = int.Parse(Console.ReadLine());

                if (validarValor <= 0)
                {
                    Console.WriteLine("O valor não pode ser menor que zero!");
                }
                else
                {
                    n[i] = validarValor;
                    validador = true;
                }
            }
        }

            if (n[0] >= n[1] && n[0] >= n[2])
            {
                maior = n[0];
                if (n[1] >= n[2])
                {
                    menor = n[2];
                }
                else
                {
                    menor = n[1];
                }
            }
            else if (n[1] >= n[2] && n[1] >= n[2])
            {
                maior = n[1];
            if (n[0] >= n[2])
            {
                menor = n[2];
            }
            else
            {
                menor = n[0];
                }
            }
            else
            {
                maior = n[2];
                if (n[1] >= n[1])
                {
                    menor = n[1];
                }
                else
                {
                    menor = n[0];
                }
            }

            int multiplicaMenor = menor * maior;
            double divideMaior = (double)maior / menor;

            Console.WriteLine($"O valor do {menor} multiplicado por {maior}: {multiplicaMenor}");
            Console.WriteLine($"O valor do {maior} divido por {menor}: {divideMaior}");
    } 

}
