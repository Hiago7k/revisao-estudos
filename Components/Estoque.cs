using System.ComponentModel;
namespace revisar_conceitos_basicos.Components;

public class Estoque
{
    public decimal Saldo = 1000;

    private Dictionary<string, int> EstoqueDeSkins = new Dictionary<string, int>
       {
        {"AkReadLine", 70},
        {"AwpRedLine", 130},
        {"DesertEaglePrintStream", 230},
        {"GlockFade", 5000}
      };

    public void ExibirEstoque()
    {
        foreach (var estoque in EstoqueDeSkins)
        {
            Console.Clear();
            Console.WriteLine("*************************************************");
            Console.WriteLine($"Estoque atualizado... ");
            Console.WriteLine("*************************************************");

            foreach (var valor in EstoqueDeSkins)
            {
                Console.WriteLine($"Skins disponiveil no estoque{valor}");
                Console.WriteLine("--------------------------------------");
            }
        }
    }

    public void MostrarSaldo()
    {
        Console.Clear();
        Console.WriteLine("****************************");
        Console.WriteLine($"Seu saldo e de: {Saldo}");
        Console.WriteLine("****************************");
    }

    public void Executar()
    {
        var SkinEscolhidaQueDesejaComprar = new Dictionary<string, int>(EstoqueDeSkins);
        string skinCompradaPeloUsuario = Console.ReadLine()!;

        if (SkinEscolhidaQueDesejaComprar.ContainsKey(skinCompradaPeloUsuario))
        {
            int skinGet = SkinEscolhidaQueDesejaComprar[skinCompradaPeloUsuario];

            if (skinGet >= Saldo)
            {
                Console.WriteLine($"Voce nao tem saldo suficiente para comprar essa skin {skinGet}");
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("------------------------------------------------------");
                Console.WriteLine($"Sucesso voce comprou a skin {skinCompradaPeloUsuario} pelo valor de R$ {skinGet}");
                System.Console.WriteLine("------------------------------------------------------");
            }
        }
        else
        {
            Console.WriteLine("Algo falhou, por gentileza tente novamente!");
        }
    }
}
