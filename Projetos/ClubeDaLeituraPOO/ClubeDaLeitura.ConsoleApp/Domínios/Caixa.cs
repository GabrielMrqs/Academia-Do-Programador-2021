namespace ClubeDaLeitura.ConsoleApp.Domínios
{
    class Caixa : Registro<Caixa>
    {
        public string cor;
        public string etiqueta;
        public Caixa()
        {
            id = GeradorID.IdCaixa;
        }

        public Caixa(string cor, string etiqueta)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
        }
    }
}
