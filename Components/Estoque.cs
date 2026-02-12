using System.ComponentModel;

namespace revisar_conceitos_basicos.Components;

// Nosso estoque de skins precisar ter um Dicionario com Nome Da Skins e Valor da Skin

    public class Estoque
    {
       public Dictionary<string, List<int>> EstoqueDeSkins = new  Dictionary<string, List<int>>(); 

        public Estoque(string nomedaskin, int valordaskin)
        {
            NomeDaSkin = nomedaskin;
            ValorDaSkin = valordaskin;
        }

       public string NomeDaSkin;
       public int ValorDaSkin;
    }
