namespace revisar_conceitos_basicos.Componentsp;

    public class ComprarSkins
    {
        // Precisamos criar o Construtor, inicializador do nosso objeto com parametros
        // ao Estanciar esse objeto precisamos passar esse parametros que definimos aqui!
        public ComprarSkins(string nomedaskin, int valordaskin)
        {
            NomeDaSkin = nomedaskin;
            ValorDaSkin = valordaskin;
        }

     // public int MyProperty { get; set; } Estrutura de uma propriedade, get e set define oque o usuario pode fazer
        public string NomeDaSkin;
        public int ValorDaSkin;      
    }
