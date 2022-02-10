namespace ClubeDaLeitura.ConsoleApp.Domínios
{
    class Revista : Registro<Revista>
    {
        private int numeroEdicao;
        private Caixa caixa;
        private string nomeRevista;
        private int ano;

        public Revista()
        {
            id = GeradorID.IdRevista;
        }

        public Revista(string nomeRevista, int numeroEdicao, int ano, Caixa caixa)
        {
            this.nomeRevista = nomeRevista;
            this.numeroEdicao = numeroEdicao;
            this.ano = ano;
            this.caixa = caixa;
        }

        public int NumeroEdicao { get => numeroEdicao; set => numeroEdicao = value; }
        public Caixa Caixa { get => caixa; set => caixa = value; }
        public string NomeRevista { get => nomeRevista; set => nomeRevista = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
