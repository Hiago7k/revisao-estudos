using Microsoft.VisualBasic;
using revisar_conceitos_basicos.Components;
using revisar_conceitos_basicos.Componentsp;

Console.WriteLine("Seja bem vindo a loja de skins de cs 2");
Console.WriteLine("Oque voce busca hoje?");
Console.WriteLine("1. Ver nosso estoque de skins: ");
Console.WriteLine("2. vender skins: ");
Console.WriteLine("3. Comprar skins: ");
int escolha = Convert.ToInt32(Console.ReadLine()!);

var EstoqueSkins = new Estoque();

switch (escolha)
{
    case 1:
            Console.WriteLine("Atualmente essas sao nossas skins disponiveis para compra");
            EstoqueSkins.ExibirEstoque();
        break;
    case 2:
        Console.WriteLine("Como vender suas skins");
        break;
    case 3:
        break;
    default:
        Console.WriteLine("Opcao invalida por gentileza escolha uma opcao valida!");
        break;
}
