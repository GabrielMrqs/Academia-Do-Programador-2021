namespace GestaoEquipamentos.ConsoleApp
{
    public class TelaBase : ControladorBase
    {
        public string titulo = "";

        public virtual string Titulo
        {
            get => titulo;

        }

        public virtual string ObterOpcaoControle()
        {
            string s = "";
            return s;
        }

        public virtual void Editar() { }

        public virtual void Excluir() { }

        public virtual void Visualizar() { }

        public virtual void Registrar(int id) { }

    }
}
