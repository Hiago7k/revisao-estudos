namespace revisar_conceitos_basicos.Components;

    public class SaldoNaLoja
    {
        public SaldoNaLoja(int saldo)
        {
            Saldo = saldo;
        }

        public int Saldo { get; }




        public void MostrarSaldo()
    {
        Console.WriteLine($"Seu saldo atual e de {Saldo}");
    }
    }
