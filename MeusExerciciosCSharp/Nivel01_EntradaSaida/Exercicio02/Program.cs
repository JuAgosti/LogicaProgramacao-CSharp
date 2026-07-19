using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio02;
class Exercicio02
{
    public static void Executar()
    {
        decimal cotacaoDolar;
        decimal valorDolar;
        decimal valorReal;

        Console.WriteLine("Digite a cotação do dolar: ");
        cotacaoDolar = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor em dolares: ");
        valorDolar = decimal.Parse(Console.ReadLine());

        valorReal = valorDolar * cotacaoDolar;

        Console.WriteLine("Valor em reais: " + valorReal);

    }
}