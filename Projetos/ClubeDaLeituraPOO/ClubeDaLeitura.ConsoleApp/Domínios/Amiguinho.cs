namespace ClubeDaLeitura.ConsoleApp.Domínios
{
    class Amiguinho : Registro<Amiguinho>
    {
        public string nome;
        public string nomeResponsavel;
        public string localizacao;
        public string numero;

        public Amiguinho(string nome, string nomeResponsavel, string localizacao, string numero)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.localizacao = localizacao;
            this.numero = numero;
        }
        public Amiguinho()
        {
            id = GeradorID.IdAmiguinho;
        }
    }
}
