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
            case "5":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio05.Exercicio05.Executar();
                break;
            case "6":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio06e07.Exercicio06e07.Executar();
                break;
            case "7":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio06e07.Exercicio06e07.Executar();
                break;
            case "8":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio08.Exercicio08.Executar();
                break;
            case "9":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio09.Exercicio09.Executar();
                break;
            case "10":
                MeusExerciciosCSharp.Nivel01_EntradaSaida.Exercicio10.Exercicio10.Executar();
                break;
            case "11":
                MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio11.Exercicio11.Executar();
                break;
            case "12":
                MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio12.Exercicio12.Executar();
                break;
            case "13":
                MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio13.Exercicio13.Executar();
                break;
            case "14":
                MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio14.Exercicio14.Executar();
                break;
            case "15":
                MeusExerciciosCSharp.Nivel02_EstruturasCondicionais.Exercicio15.Exercicio15.Executar();
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