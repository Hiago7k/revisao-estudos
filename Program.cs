
// Conceitos Basicos
// Variaveis -> utilizadas para armazenar dados na memoria do computador
// Tipos -> definir um tipo da variavel number string boolean int decimal
// Sintaxe ->  o jeito que escrevemos o codigo sempre respeitando a linguagem e utilizando ;
// operadores -> < = > ! true or false
// Condiceos -> definir se algo for verdadeiro executa se nao faz outra coisa if else
// Funcoes blocos de codigos que chamamos para executar codigos, o c# ja vem com algumas pronta

// 1 Solicitar ao usuario dizer o seu nome e sua idade e dizer ola nome do usuario voce tem idade do usuario

// Console.WriteLine("Ola qual o seu nome?");
// string nome = Console.ReadLine()!;

// Console.WriteLine($"Ola {nome}");

// Console.WriteLine("Qual sua idade?");
// int idade = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine($"{nome} voce tem {idade} anos!");

// if (idade >= 18)
// {
//     Console.WriteLine("Voce pode tirar sua CNH");
// }
// else
// {
//     Console.WriteLine("voce ainda e de menor");
// }


// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }


// Boolean interruptor = false; // faz a magica

// while(interruptor)
// {
//     for(int i = 0; i < 100; i++)
//     {
//         Console.WriteLine(i);
//     }
// }


Console.WriteLine("========Calculadora=======");
Console.WriteLine("Digite um Numero: ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Digite outro Numero: ");
int segundoNumero = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Escolha uma das opcoes abaixo!");
Console.WriteLine("1. Somar");
Console.WriteLine("2. Subtrair");
int resposta = Convert.ToInt32(Console.ReadLine()!);

switch(resposta)
{
    case 1:
        Console.WriteLine(primeiroNumero + segundoNumero);
    break;
    case 2:  
         Console.WriteLine(primeiroNumero - segundoNumero);
    break;   
    
    default:
        Console.WriteLine("Erro");
    break;
}