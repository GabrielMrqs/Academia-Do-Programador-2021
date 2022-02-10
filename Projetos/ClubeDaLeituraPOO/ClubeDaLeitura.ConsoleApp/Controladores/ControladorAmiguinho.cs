using ClubeDaLeitura.ConsoleApp.Domínios;

namespace ClubeDaLeitura.ConsoleApp.Controladores
{
    class ControladorAmiguinho : ControladorBase<Amiguinho>
    {
        public ControladorAmiguinho(int capacidade) : base(capacidade) { }

        public override void Registrar(int id, Amiguinho registro)
        {
            Amiguinho amiguinho = null;
            Amiguinho amiguinhoAux = null;
            amiguinhoAux = registro;

            if (id == 0)
                amiguinho = new Amiguinho();

            amiguinho.nome = amiguinhoAux.nome;
            amiguinho.nomeResponsavel = amiguinhoAux.nomeResponsavel;
            amiguinho.numero = amiguinhoAux.numero;
            amiguinho.localizacao = amiguinhoAux.localizacao;

            Registros.Add(amiguinho);
        }

    }
}
