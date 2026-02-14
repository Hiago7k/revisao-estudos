using System.ComponentModel;
namespace revisar_conceitos_basicos.Components;

public class Estoque
{
    private Dictionary<string, List<int>> EstoqueDeSkins = new Dictionary<string, List<int>>
       {
        {"Ak ReadLine", new List<int> {70}},
        {"Awp RedLine", new List<int> {130}},
        {"Desert Eagle PrintStream", new List<int> {230}},
        {"Glock Fade", new List<int> {8000}}
      };

    public void Executar()
    {
     var SkinEscolhidaQueDesejaComprar = new Dictionary<string, List<int>>(EstoqueDeSkins);
    

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
