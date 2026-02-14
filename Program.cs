using Microsoft.VisualBasic;
using revisar_conceitos_basicos.Components;
using revisar_conceitos_basicos.Componentsp;

Console.WriteLine("Seja bem vindo a loja de skins de cs 2");
Console.WriteLine("Oque voce busca hoje?");
Console.WriteLine("1. Ver nosso estoque de skins: ");
Console.WriteLine("2. vender skins: ");
Console.WriteLine("3. Comprar skins: ");
int escolha = Convert.ToInt32(Console.ReadLine()!);

var Saldo = new SaldoNaLoja(1000);

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
        Console.WriteLine("Seu valor disponivel para gastar e de!");
        Saldo.MostrarSaldo();
        Console.WriteLine("Por gentileza digite a skin que deseja comprar: ");
        Console.WriteLine("\nAtualmente essas sao nossas skins disponiveis para compra");
        EstoqueSkins.ExibirEstoque();
        string skinCompradaPeloUsuario = Console.ReadLine()!;

        // Beleza sabemos qual SKIN o usuario quer comprar! okay
        // armazenar essa informacao em uma variavel 
        // ou podemos criar um dicionario com a escolha do usuario, e ver se ela esta em Estoque
        // Agora temos que validar se ela esta no estoque
        // usando um if skin esta no estoque
        // se sim vamos exibir, skins em estoque deseja confirmar a compra?
        // sim ou nao
        // se for sim, ele vai comprar, e remover a skin do estoque, e tambem reduzir o seu saldo
       
      

        

        break;
    default:
        Console.WriteLine("Opcao invalida por gentileza escolha uma opcao valida!");
        break;
}
