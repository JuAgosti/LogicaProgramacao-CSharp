using System;

namespace MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio15;

class Exercicio15
{
    public static void Executar()
    {
        int n1, n2, n3, n4;
        double media;

        Console.WriteLine("--- MÉDIA ESCOLAR ---");

        Console.WriteLine("Digite a primeira nota: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        n4 = int.Parse(Console.ReadLine());

        media = (n1 + n2 + n3 + n4) / 4.0;

        if (media >= 7)
        {

            Console.WriteLine($"Aluno aprovado \nMédia: {media}");
        }
        else
        {
            double notaRecuperacao = 7 - media;
            Console.WriteLine($"Aluno em recuperação \n Média: {media} \n Nota de recuperação: {notaRecuperacao}");

            Console.WriteLine("Digite a nota da recuperação: ");
            notaRecuperacao = double.Parse(Console.ReadLine());

            double novaMedia = (media + notaRecuperacao);
            if (novaMedia >= 7)
            {
                Console.WriteLine($"Aprovado por recuperação \nNova média: {novaMedia}");
            }
            else
            {
                Console.WriteLine($"Aluno reprovado \nMédia: {media}");
            }

        }
    }
}