using System.ComponentModel;

namespace revisar_conceitos_basicos.Components;

public class DadosVenda
{
    public List<string> InfoUsuarios { get; set; } = new List<string>();
    public string stemGuardOnOff { get; set; } = string.Empty;
    public string skinsSelecionadas { get; set; } = string.Empty;
    public string tradeURl { get; set; } = string.Empty;
    public string teleFone { get; set; } = string.Empty;

    public DadosVenda(string stramguardonoff, string skinsselecionadas, string tradeurl, string telefone)
    {
        stemGuardOnOff = stramguardonoff;
        skinsSelecionadas = skinsselecionadas;
        tradeURl = tradeurl;
        teleFone = telefone;
    }


    // public void SalvarDados()
    // {
    //     Console.WriteLine(stemGuardOnOff);
    //     InfoUsuarios.Add(stemGuardOnOff);
    //     Console.WriteLine(skinsSelecionadas);
    //     InfoUsuarios.Add(skinsSelecionadas);
    //     Console.WriteLine(tradeURl);
    //     InfoUsuarios.Add(tradeURl);
    //     Console.WriteLine(teleFone);
    //     InfoUsuarios.Add(teleFone);
    // }
    
    public void OpcaoVenda()
    {
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("\nPor gentileza preencha o formulario abaixo, para vender suas skins!");
        Console.WriteLine("------------------------------------------------------------------------------");

        Console.WriteLine("Possui Steam Guard?");
        string stemGuardOnOff = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Quais Skins deseja vender, caso deseja vender o inventario todo, digita Todos");
        string skinsSelecionadas = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Por gentileza informe seu Trade URl!");
        string tradeURl = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Por gentileza informe seu telefone com dd ()");
        string telefone = Console.ReadLine()!;
        Console.Clear();
        Console.WriteLine("Confirme abaixo se seus dados estao certos!");

        Console.Clear();
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine("Suas Informacoes abaixo!");
        Console.WriteLine($"SteamGuard: {stemGuardOnOff}");
        Console.WriteLine($"Oque deseja vender: {skinsSelecionadas}");
        Console.WriteLine($"Seu trade Url: {tradeURl}");
        Console.WriteLine($"Seu telefone para contato:  {teleFone}");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine("Um atendente da nossa equipe, lhe retornar com um orcamento justo pelas suas skins! obrigado!");

    }



}
