using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SELECIONE O EXERCÍCIO QUE DESEJA TESTAR");
        Console.Write("Digite o número do exercício: ");
        string opcao = Console.ReadLine();

        Console.WriteLine("\n---------------------------------------------");

        switch (opcao)
        {
            case "1":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio01.Exercicio01.Executar();
                break;
            case "2":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio02.Exercicio02.Executar();
                break;
            case "3":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio03.Exercicio03.Executar();
                break;
            case "4":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio04.Exercicio04.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida ou exercício não encontrado.");
                break;
        }

        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nPrograma finalizado. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    
    }
}