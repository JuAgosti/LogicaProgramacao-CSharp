using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio13;

class Exercicio13
{
    public static void Executar()
    {
        int n1,n2,n3;

        Console.WriteLine("--- ORDEM DECRESCENTE ---");

        Console.WriteLine("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número: ");
        n3 = int.Parse(Console.ReadLine());

        int maior, meio, menor;


        if (n1 >= n2 && n1 >= n3)
        {
            maior = n1;
            if (n2 >= n3)
            {
                meio = n2;
                menor = n3;
            }
            else
            {
                meio = n3;
                menor = n2;
            }
        }
        else if (n2 >= n1 && n2 >= n3)
        {
            maior = n2;
            if (n1 >= n3)
            {
                meio = n1;
                menor = n3;
            }
            else
            {
                meio = n3;
                menor = n1;
            }
        }
        else
        {
            maior = n3;
            if (n1 >= n2)
            {
                meio = n1;
                menor = n2;
            }
            else
            {
                meio = n2;
                menor = n1;
            }
        }

        Console.WriteLine($"\nMaior: {maior} \nMeio: {meio} \nMenor: {menor}");
    }
}