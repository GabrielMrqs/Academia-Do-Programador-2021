using ClubeDaLeitura.ConsoleApp.Domínios;

namespace ClubeDaLeitura.ConsoleApp.Controladores
{
    class ControladorRevista : ControladorBase<Revista>
    {
        public ControladorRevista(int capacidade) : base(capacidade) { }
        
        public override void Registrar(int id, Revista registro)
        {
            Revista revista = null;
            Revista revistaAux = null;
            revistaAux = registro;

            if (id == 0)
                revista = new Revista();

            revista.NomeRevista = revistaAux.NomeRevista;
            revista.NumeroEdicao = revistaAux.NumeroEdicao;
            revista.Ano = revistaAux.Ano;
            revista.Caixa = revistaAux.Caixa;

            Registros.Add(revista);
        }

    }
}
