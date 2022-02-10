using ClubeDaLeitura.ConsoleApp.Domínios;

namespace ClubeDaLeitura.ConsoleApp.Controladores
{
    class ControladorEmprestimo : ControladorBase<Emprestimo>
    {
        public ControladorEmprestimo(int capacidade) : base(capacidade) { }
        
        public override void Registrar(int id, Emprestimo registro)
        {
            Emprestimo emprestimo = null;
            Emprestimo emprestimoAux = null;
            emprestimoAux = registro;
            if (id == 0)
                emprestimo = new Emprestimo();

            emprestimo.Amiguinho = emprestimoAux.Amiguinho;
            emprestimo.Revista = emprestimoAux.Revista;
            emprestimo.DataEmprestimo = emprestimoAux.DataEmprestimo;
            emprestimo.DataDevolucao = emprestimoAux.DataDevolucao;

            Registros.Add(emprestimo);
        }

    }
}
