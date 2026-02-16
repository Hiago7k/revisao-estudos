namespace revisar_conceitos_basicos.Components;

    public class DadosVenda
    {
        
        public string stemGuardOnOff;
        public string skinsSelecionadas;
        public string tradeURl;
        public string telefone;

    public DadosVenda(string stemGuardOnOff, string skinsSelecionadas, string tradeURl, string telefone)
    {
        this.stemGuardOnOff = stemGuardOnOff;
        this.skinsSelecionadas = skinsSelecionadas;
        this.tradeURl = tradeURl;
        this.telefone = telefone;
    }


    public void ExibirDadosDoUsuario()
    {
        Console.WriteLine(stemGuardOnOff);
        Console.WriteLine(skinsSelecionadas);
        Console.WriteLine(tradeURl);
        Console.WriteLine(telefone);
    }

}
