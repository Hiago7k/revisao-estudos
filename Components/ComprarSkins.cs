namespace revisar_conceitos_basicos.Componentsp;

    public class ComprarSkins
    {
        public ComprarSkins(string nomedaskin, int valordaskin)
        {
            NomeDaSkin = nomedaskin;
            ValorDaSkin = valordaskin;
        }

        public string NomeDaSkin;
        public int ValorDaSkin;      

      public void Executar()
    {
        Console.WriteLine("Parabens voce comprou a skins");
    }
        
    }
  