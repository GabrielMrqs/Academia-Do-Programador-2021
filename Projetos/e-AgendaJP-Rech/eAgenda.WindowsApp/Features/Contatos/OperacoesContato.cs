using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public class OperacoesContato : ICadastravel
    {
        private readonly ControladorContato controlador = null;
        private readonly TabelaContatoControl tabelaContatos = null;

        public OperacoesContato(ControladorContato controlador)
        {
            this.controlador = controlador;
            tabelaContatos = new TabelaContatoControl();
        }

        public void InserirNovoRegistro()
        {
            TelaContatoForm tela = new TelaContatoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Contato);

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder editar!", "Edição de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            TelaContatoForm tela = new TelaContatoForm();

            tela.Contato = contatoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Contato);

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{tela.Contato.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaContatos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um contato para poder excluir!", "Exclusão de Contatos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Contato contatoSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o contato: [{contatoSelecionado.Nome}] ?",
                "Exclusão de Contatos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Contato> tarefas = controlador.SelecionarTodos();

                tabelaContatos.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Contato: [{contatoSelecionado.Nome}] removido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            tabelaContatos.AtualizarRegistros();

            return tabelaContatos;
        }

        public void FiltrarRegistros()
        {
            FiltroContatoForm telaFiltro = new FiltroContatoForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                switch (telaFiltro.TipoFiltro)
                {
                    case FiltroContatoEnum.AgruparPorEmpresa:
                        tabelaContatos.AgruparContatosPor("Empresa");
                        break;

                    case FiltroContatoEnum.AgruparPorCargo:
                        tabelaContatos.AgruparContatosPor("Cargo");
                        break;

                    case FiltroContatoEnum.NaoAgrupar:
                        tabelaContatos.DesagruparContatos();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
