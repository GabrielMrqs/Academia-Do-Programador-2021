using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using AgendaJP.WindowsApp.Telas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AgendaJP.WindowsApp.Contatos
{
    public partial class TelaContato : Form, ICrud
    {
        private ControladorContato controladorContato;
        private ControladorCompromisso controladorCompromisso;
        Contato contatoSelecionado;
        public TelaContato(ControladorContato controladorContato, ControladorCompromisso controladorCompromisso)
        {
            this.controladorContato = controladorContato;
            this.controladorCompromisso = controladorCompromisso;
            InitializeComponent();
            CarregarTodosOsRegistros();
        }

        public void AdicionarRegistro()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mskTelefone.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);
            if (contato.Validar() == "")
            {
                controladorContato.InserirRegistro(contato);
                MessageBox.Show("Registro adicionado com sucesso", "Registro adicionado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(contato.Validar(), "Não foi possível adicionar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void EditarRegistro()
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string telefone = mskTelefone.Text;
            string empresa = txtEmpresa.Text;
            string cargo = txtCargo.Text;

            Contato contatoEditado = new Contato(nome, email, telefone, empresa, cargo);
            if (contatoEditado.Validar() == "")
            {
                controladorContato.EditarRegistro(contatoEditado, contatoSelecionado.Id);
                MessageBox.Show("Registro editado com sucesso", "Registro editado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(contatoEditado.Validar(), "Não foi possível editar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ExcluirRegistro()
        {
            controladorContato.ExcluirRegistro(contatoSelecionado.Id);
            MessageBox.Show("Registro excluído com sucesso", "Registro excluído com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CarregarTodosOsRegistros()
        {
            DataTable linhasContatos = new DataTable();

            linhasContatos.Columns.Add("ID");
            linhasContatos.Columns.Add("Nome");
            linhasContatos.Columns.Add("Telefone");
            linhasContatos.Columns.Add("E-Mail");
            linhasContatos.Columns.Add("Empresa");
            linhasContatos.Columns.Add("Cargo");

            List<Contato> listaContatos = controladorContato.Visualizar(controladorContato.SqlSelecaoTodos);

            foreach (var contato in listaContatos)
            {
                var linha = linhasContatos.NewRow();

                linha["ID"] = contato.Id;
                linha["Nome"] = contato.Nome;
                linha["Telefone"] = contato.Telefone;
                linha["E-Mail"] = contato.Email;
                linha["Empresa"] = contato.Empresa;
                linha["Cargo"] = contato.Cargo;

                linhasContatos.Rows.Add(linha);
            }
            dgvContatos.DataSource = linhasContatos;
        }
        public void PegarDadosDaTabela(int id)
        {
            contatoSelecionado = controladorContato.GetById(id);

            txtNome.Text = contatoSelecionado.Nome;
            txtEmail.Text = contatoSelecionado.Email;
            mskTelefone.Text = contatoSelecionado.Telefone;
            txtEmpresa.Text = contatoSelecionado.Empresa;
            txtCargo.Text = contatoSelecionado.Cargo;
        }
        public void ApagarCampos()
        {
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }
        public void ConcluirAcao()
        {
            btnAdicionarContato.Enabled = true;
            btnEditarContato.Enabled = false;
            btnExcluirContato.Enabled = false;
            btnCancelar.Enabled = false;
            ApagarCampos();
            CarregarTodosOsRegistros();
        }
        private bool ValidarContatoExistenteEmCompromisso()
        {
            return controladorCompromisso.Visualizar($"SELECT * FROM TBCOMPROMISSO WHERE ID_CONTATO = {contatoSelecionado.Id}").Count != 0 ? false : true;
        }

        #region Eventos
        private void dgvContatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvContatos.CurrentRow.Cells[0].Value);
            PegarDadosDaTabela(id);
            btnAdicionarContato.Enabled = false;
            btnEditarContato.Enabled = true;
            btnExcluirContato.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void btnAdicionarContato_Click(object sender, EventArgs e)
        {
            AdicionarRegistro();
            ConcluirAcao();
        }
        private void btnEditarContato_Click(object sender, EventArgs e)
        {
            EditarRegistro();
            ConcluirAcao();
        }
        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            if (ValidarContatoExistenteEmCompromisso())
                ExcluirRegistro();
            else
                MessageBox.Show("Por favor, exclua o compromisso onde o contato está sendo utilizado, para conseguir excluir o contato determinado", "Contato cadastrado em compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ConcluirAcao();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConcluirAcao();
        }
        #endregion
    }
}
