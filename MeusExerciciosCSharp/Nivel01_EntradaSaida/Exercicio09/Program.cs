using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio09;
class Exercicio09
{
    public static void Executar()
    {
        int anos, meses , dias;

        Console.WriteLine("--- IDADE EM DIAS ---");

        Console.WriteLine("Digite os anos: ");
        anos = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os meses: ");
        meses = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite os dias: ");
        dias = int.Parse(Console.ReadLine());

        int convertAnos = anos * 365;
        int converteMeses = meses * 30;

        int idadeEmDias = convertAnos + converteMeses + dias;

        Console.WriteLine($"Idade convertida em dias: {idadeEmDias}");
    }
}