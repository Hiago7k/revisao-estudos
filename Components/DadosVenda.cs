using System.ComponentModel;

namespace revisar_conceitos_basicos.Components;

    public class DadosVenda
    {
        public List<string> InfoUsuarios { get; set; } = new List<string>();
        
        public string stemGuardOnOff {get; set; }
        public string skinsSelecionadas {get; set; }
        public string tradeURl {get; set; }
        public string teleFone {get; set; }

        public DadosVenda(string stramguardonoff, string skinsselecionadas, string tradeurl, string telefone)
    {
        stemGuardOnOff = stramguardonoff;
        skinsSelecionadas = skinsselecionadas;
        tradeURl = tradeurl;
        teleFone = telefone;
    }


    public void SalvarDados()
    {
        Console.WriteLine(stemGuardOnOff);
        InfoUsuarios.Add(stemGuardOnOff);
        Console.WriteLine(skinsSelecionadas);
        InfoUsuarios.Add(skinsSelecionadas);
        Console.WriteLine(tradeURl);
        InfoUsuarios.Add(tradeURl);
        Console.WriteLine(teleFone);
        InfoUsuarios.Add(teleFone);
    }

}
