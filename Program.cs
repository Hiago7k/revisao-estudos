using Microsoft.VisualBasic;
using revisar_conceitos_basicos.Components;
using revisar_conceitos_basicos.Componentsp;

Console.WriteLine("Seja bem vindo a loja de skins de cs 2");
Console.WriteLine("Oque voce busca hoje?");
Console.WriteLine("1. Ver nosso estoque de skins: ");
Console.WriteLine("2. vender skins: ");
Console.WriteLine("3. Comprar skins: ");
int escolha = Convert.ToInt32(Console.ReadLine()!);

var EstoqueSkins = new Estoque("EstoqueDeSkins", 2);



Dictionary<string, List<int>> EstoqueDeSkins = new  Dictionary<string, List<int>>
{
    {"Ak ReadLine", new List<int> {70}},
    {"Awp RedLine", new List<int> {130}},
    {"Desert Eagle PrintStream", new List<int> {230}},
    {"Glock Fade", new List<int> {8000}}
};

foreach (var estoque in EstoqueDeSkins)
{
    Console.WriteLine($"Skins disponiveis no estoque {estoque.Key}");

    foreach (var valor in estoque.Value)
    {
        Console.WriteLine($"Valor das skins {valor}");
        Console.WriteLine("--------------------------------------");
    }

}

switch(escolha)
{
    case 1:
         // Estoque de skins
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


