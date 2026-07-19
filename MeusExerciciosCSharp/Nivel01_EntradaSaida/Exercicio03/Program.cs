using System;

namespace MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio03;
class Exercicio03
{
    public static void Executar()
    {
        string vendedor;
        int codPeca;
        decimal precoUnitario;
        int quantidadeVendida;
        decimal valorTotalVenda;
        decimal comissaoVendedor; ;

        const decimal comissaoVenda = 0.05m;


        Console.WriteLine("Digite o nome do vendedor: ");
        vendedor = Console.ReadLine();

        Console.WriteLine("Digite o código da peça: ");
        codPeca = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o preço unitário da peça: ");
        precoUnitario = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade vendida: ");
        quantidadeVendida = int.Parse(Console.ReadLine());

        valorTotalVenda = precoUnitario * quantidadeVendida;

        comissaoVendedor = valorTotalVenda * comissaoVenda;

        // F2 é usado para formatar decimal para apenas duas casas
        Console.WriteLine($"O vendedor {vendedor} vendeu a peça {codPeca} e receberá uma comissão de R$ {comissaoVendedor:F2}");

    }
}