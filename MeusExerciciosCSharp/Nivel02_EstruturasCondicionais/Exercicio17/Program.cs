using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio17;

class Exercicio17
{
    public static void Executar()
    {
        int n;

        Console.WriteLine("--- VALIDAÇÃO POR FAIXA ---");

        Console.WriteLine("Digite o número: ");
        n = int.Parse(Console.ReadLine());

        if (n >= 0 && n <= 9)
        {
            Console.WriteLine("Valor válido! O número está na faixa de 0 a 9");
        }
        else 
        {
            Console.WriteLine("Valor inválido! O número não está na faixa de 0 a 9"); 
        }
       
    }
}