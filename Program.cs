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
var Dados = new DadosVenda();


switch (escolha)
{
    case 1:
        Console.WriteLine("Atualmente essas sao nossas skins disponiveis para compra");
        EstoqueSkins.ExibirEstoque();
        break;

    case 2:
        Console.Clear();
        Console.WriteLine("----------------------------");
        Console.WriteLine("Como vender suas skins");
        Console.WriteLine("----------------------------");

        Console.WriteLine("\n Por gentileza preencha o formulario abaixo, para vender suas skins!");
        Console.WriteLine("Possui Steam Guard?");
        string stemGuardOnOff =  Console.ReadLine()!;
        InfoUsuarios.Add(stemGuardOnOff);
        Console.WriteLine("Quais Skins deseja vender, caso deseja vender o inventario todo, apenas diga sim?");
        string skinsSelecionadas = Console.ReadLine()!;
        Console.WriteLine("Por gentileza informe seu Trade URl!");
        string tradeURl = Console.ReadLine()!;
        Console.WriteLine("Por gentileza informe seu telefone com dd ()");
        string telefone = Console.ReadLine()!;
        //Console.WriteLine("Um atendente da nossa equipe, lhe retornar com um orcamento justo pelas suas skins! obrigado!");
        Console.WriteLine("Confirme abaixo se seus dados estao certos!");
        //
        Console.WriteLine("---------------------------------------------------------------------------------------------------");

        

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
