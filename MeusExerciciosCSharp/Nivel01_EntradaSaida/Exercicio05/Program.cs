using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio05;

class Exercicio05
{
    public static void Executar()
    {
        double tempoGastoViagem;
        double velocidadeMedia;

        Console.WriteLine("Digite o tempo de viagem: ");
        tempoGastoViagem = double.Parse(Console.ReadLine());


        Console.WriteLine("Digite a velocidade média: ");
        velocidadeMedia = double.Parse(Console.ReadLine());

        double distancia = tempoGastoViagem * velocidadeMedia;
        double litros = distancia / 12.0;

        Console.WriteLine("--- Resumo Viagem ---");
        Console.WriteLine($"Velocidade méida: {velocidadeMedia:F2}\n Tempo gasto: {tempoGastoViagem:F2}\n Distância percorrida: {distancia:F2}\n Litros consumidos: {litros:F2}" );

    }
}