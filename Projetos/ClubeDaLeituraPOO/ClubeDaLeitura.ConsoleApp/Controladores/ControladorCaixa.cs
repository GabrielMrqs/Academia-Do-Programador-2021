using ClubeDaLeitura.ConsoleApp.Domínios;

namespace ClubeDaLeitura.ConsoleApp.Controladores
{
    class ControladorCaixa : ControladorBase<Caixa>
    {
        public ControladorCaixa(int capacidade) : base(capacidade) { }

        public override void Registrar(int id, Caixa registro)
        {
            Caixa caixa = null;
            Caixa caixaAux = null;
            caixaAux = registro;

            if (id == 0)
                caixa = new Caixa();

            caixa.cor = caixaAux.cor;
            caixa.etiqueta = caixaAux.etiqueta;

            Registros.Add(caixa);
        }

    }
}
