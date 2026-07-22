using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio16;

class Exercicio16
{
    public static void Executar()
    {
        int n1, n2;

        Console.WriteLine("--- MAIOR E MENOR NÚMERO ---");

        Console.WriteLine("Digite o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        if(n1 > n2)
        {
            Console.WriteLine("O maior número é: " + n1);
            Console.WriteLine("O menor número é: " + n2);
        }
        else if(n2 > n1)
        {
            Console.WriteLine("O maior número é: " + n2);
            Console.WriteLine("O menor número é: " + n1);
        }
        else
        {
            Console.WriteLine("Os dois números são iguais");
        }
       
    }
}