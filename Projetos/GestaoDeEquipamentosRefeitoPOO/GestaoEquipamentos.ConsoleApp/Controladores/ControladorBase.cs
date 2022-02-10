using System;

namespace GestaoEquipamentos.ConsoleApp
{
    public class ControladorBase
    {

        public virtual string Registrar(int id, string nome, double preco, string numeroSerie, DateTime dataFabricacao, string fabricante)
        { string s = ""; return s; }

        public virtual string Registrar(int idChamadoSelecionado, int idEquipamentoChamado, string titulo, string descricao, DateTime dataAbertura, int idSolicitanteChamado)
        { string s = ""; return s; }

        public virtual string Registrar(int id, string nome, string email, long numeroTelefone)
        { string s = ""; return s; }

        public virtual bool Excluir(int idSelecionado)
        {
            bool b = false;
            return b;
        }

        public virtual object SelecionarPorId(int id)
        {
            object obj = null;
            return obj;
        }

        public virtual object[] SelecionarTudo()
        {
            object[] objAux = new object[0];
            return objAux;
        }

        public virtual int QtdCadastrados()
        {
            int numeroCadastrados = 0;
            return numeroCadastrados;
        }
    }
}
