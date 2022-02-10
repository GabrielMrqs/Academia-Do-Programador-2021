namespace CalculadoraEmDupla
{
    public class Conta
    {
        private string conta;
        public Conta(string conta)
        {
            this.conta = conta;
        }

        public override string ToString()
        {
            return conta;
        }
    }
}
