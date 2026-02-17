using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using revisar_conceitos_basicos.Components;
using revisar_conceitos_basicos.Componentsp;

Console.WriteLine("==================================================");
Console.WriteLine("Seja bem vindo a loja de skins de cs 2");
Console.WriteLine("Digite uma tecla para continuar");
Console.WriteLine("==================================================");
Console.ReadKey();
Console.Clear();

Console.WriteLine("***************************************");
Console.WriteLine("Oque voce busca hoje");
Console.WriteLine("1. Ver nosso estoque de skins: ");
Console.WriteLine("2. vender skins: ");
Console.WriteLine("3. Comprar skins: ");
Console.WriteLine("4. Ver saldo");
Console.WriteLine("0 Sair da loja...");
Console.WriteLine("***************************************");
int escolha = Convert.ToInt32(Console.ReadLine()!);

var EstoqueSkins = new Estoque();

switch (escolha)
{
    case 1:
        Console.WriteLine("Atualmente essas sao nossas skins disponiveis para compra");
        EstoqueSkins.ExibirEstoque();
        break;

    case 2:
        Console.Clear();
        // Dados.SalvarDados();

        var DadosDaSkin = new DadosVenda("", "", "", "");
        DadosDaSkin.OpcaoVenda();

        break;

    case 3:
        Console.WriteLine("Por gentileza digite a skin que deseja comprar: ");

        EstoqueSkins.Executar();
        break;

    case 4:
        Console.WriteLine("Seu valor disponivel para gastar e de!");
        EstoqueSkins.MostrarSaldo();
        break;

    case 0:
        break;

    default:
        Console.WriteLine("Opcao invalida por gentileza escolha uma opcao valida!");
        break;
}
