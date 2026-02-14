using System.ComponentModel;
namespace revisar_conceitos_basicos.Components;

public class Estoque
{
    private Dictionary<string, int> EstoqueDeSkins = new Dictionary<string, int>
       {
        {"Ak ReadLine", 70},
        {"Awp RedLine", 130},
        {"Desert Eagle PrintStream", 230},
        {"Glock Fade", 5000}
      };

    public void Executar()
    {
     var SkinEscolhidaQueDesejaComprar = new Dictionary<string, int> (EstoqueDeSkins);
    if(SkinEscolhidaQueDesejaComprar.ContainsKey(EstoqueDeSkins))
        {
            Console.WriteLine("Sucesso");
        }else
        {
            Console.WriteLine("Fracasso");
        }

    }


    public void ExibirEstoque()
    {
        foreach (var estoque in EstoqueDeSkins)
        {
            Console.WriteLine($"Skins disponiveis no estoque {estoque.Key}");

            foreach (var valor in estoque.Value)
            {
                Console.WriteLine($"Valor da skin {valor}");
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
