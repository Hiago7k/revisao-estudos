using System.ComponentModel;
namespace revisar_conceitos_basicos.Components;

public class Estoque
{
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
            Console.WriteLine($"Skins disponiveis no estoque {estoque.Key}");

            foreach (var valor in estoque.Key)
            {
                Console.WriteLine($"Valor da skin {valor}");
                Console.WriteLine("--------------------------------------");
            }
      }
    }

    public void Executar()
    {
    var SkinEscolhidaQueDesejaComprar = new Dictionary<string, int> (EstoqueDeSkins);
    string skinCompradaPeloUsuario = Console.ReadLine()!;

      // EstoqueDeSkins[skinCompradaPeloUsuario] =  EstoqueDeSkins;

    if(SkinEscolhidaQueDesejaComprar.ContainsKey(skinCompradaPeloUsuario))
        {
            Console.WriteLine("Sucesso");
            Console.WriteLine($"Voce compru a skin {skinCompradaPeloUsuario}");
        }else
        {
            Console.WriteLine("Fracasso");
        }
    }
}
