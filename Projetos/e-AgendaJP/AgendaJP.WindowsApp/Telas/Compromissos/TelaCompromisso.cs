using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using AgendaJP.WindowsApp.Telas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AgendaJP.WindowsApp.Compromissos
{
    public partial class TelaCompromisso : Form, ICrud
    {
        private ControladorContato controladorContato;
        private ControladorCompromisso controladorCompromisso;
        Compromisso compromissoSelecionado;
        public TelaCompromisso(ControladorCompromisso controladorCompromisso, ControladorContato controladorContato)
        {
            this.controladorCompromisso = controladorCompromisso;
            this.controladorContato = controladorContato;
            InitializeComponent();
            CarregarTodosOsRegistros();
            CarregarComboboxContatos();
        }
       
        public void AdicionarRegistro()
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            DateTime dataInicio = Convert.ToDateTime(dtDataInicio.Value.ToString("d") + " " + mskHoraInicio.Text);
            DateTime dataFinal = Convert.ToDateTime(dtDataInicio.Value.ToString("d") + " " + mskHoraTermino.Text);
            Contato contato = cbContato.SelectedItem is Contato ? (Contato)cbContato.SelectedItem: null;
            Compromisso compromisso = new Compromisso(assunto, local, dataInicio, dataFinal, contato);
            if (compromisso.Validar() == "" && controladorCompromisso.ValidarDatas(compromisso) == "")
            {
                controladorCompromisso.InserirRegistro(compromisso);
                MessageBox.Show("Registro adicionado com sucesso", "Registro adicionado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(compromisso.Validar() + controladorCompromisso.ValidarDatas(compromisso), "Não foi possível adicionar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void EditarRegistro()
        {
            string assunto = txtAssunto.Text;
            string local = txtLocal.Text;
            DateTime dataInicio = Convert.ToDateTime(dtDataInicio.Value.ToString("d") + " " + mskHoraInicio.Text);
            DateTime dataFinal = Convert.ToDateTime(dtDataInicio.Value.ToString("d") + " " + mskHoraTermino.Text);
            Contato contato = cbContato.SelectedItem is Contato ? (Contato)cbContato.SelectedItem : null;

            Compromisso compromissoEditado = new Compromisso(assunto, local, dataInicio, dataFinal, contato);

            if (compromissoEditado.Validar() == "")
            {
                controladorCompromisso.EditarRegistro(compromissoEditado, compromissoSelecionado.Id);
                MessageBox.Show("Registro editado com sucesso", "Registro editado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(compromissoEditado.Validar(), "Não foi possível editar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ExcluirRegistro()
        {
            controladorCompromisso.ExcluirRegistro(compromissoSelecionado.Id);
            MessageBox.Show("Registro excluído com sucesso", "Registro excluído com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CarregarTodosOsRegistros()
        {
            var inicio = dtInicioFiltro.Value;
            var final = dtFinalFiltro.Value;
            List<Compromisso> listaCompromissoFuturo = controladorCompromisso.VisualizarCompromissosFuturos(inicio, final);
            List<Compromisso> listaCompromissoPassado = controladorCompromisso.VisualizarCompromissosPassados();

            dgvCompromissoPassado.DataSource = CarregarCompromisso(listaCompromissoPassado);
            dgvCompromissoFuturo.DataSource = CarregarCompromisso(listaCompromissoFuturo);
        }
        public void PegarDadosDaTabela(int id)
        {
            compromissoSelecionado = controladorCompromisso.GetById(id);

            txtAssunto.Text = compromissoSelecionado.Assunto;
            txtLocal.Text = compromissoSelecionado.Local;
            mskHoraInicio.Text = compromissoSelecionado.InicioDoCompromisso.ToString("HH:mm:ss");
            mskHoraTermino.Text = compromissoSelecionado.FimDoCompromisso.ToString("HH:mm:ss");
            dtDataInicio.Value = Convert.ToDateTime(compromissoSelecionado.InicioDoCompromisso.ToString("d"));
            cbContato.Text = compromissoSelecionado.Contato == null ? "Sem contato" : compromissoSelecionado.Contato.ToString();
        }
        public void ApagarCampos()
        {
            txtAssunto.Text = string.Empty;
            txtLocal.Text = string.Empty;
            dtDataInicio.Value = DateTime.Now;
            mskHoraInicio.Text = "0000";
            mskHoraTermino.Text = "0000";
            cbContato.SelectedItem = null;
        }
        public void ConcluirAcao()
        {
            btnAdicionarCompromisso.Enabled = true;
            btnEditarCompromisso.Enabled = false;
            btnExcluirCompromisso.Enabled = false;
            btnCancelar.Enabled = false;
            ApagarCampos();
            CarregarTodosOsRegistros();
        }
        private void CarregarComboboxContatos()
        {
            var listaContatos = controladorContato.Visualizar(controladorContato.SqlSelecaoTodos);
            foreach (var contato in listaContatos)
            {
                cbContato.Items.Add(contato);
            }
            cbContato.Items.Add("Sem contato");
        }
        private DataTable CarregarCompromisso(List<Compromisso> lista)
        {
            DataTable linhasTarefaConcluido = new DataTable();

            linhasTarefaConcluido.Columns.Add("ID");
            linhasTarefaConcluido.Columns.Add("Assunto");
            linhasTarefaConcluido.Columns.Add("Local");
            linhasTarefaConcluido.Columns.Add("Data de Início");
            linhasTarefaConcluido.Columns.Add("Data de Conclusão");
            linhasTarefaConcluido.Columns.Add("Contato");

            foreach (var compromisso in lista)
            {
                var linha = linhasTarefaConcluido.NewRow();

                linha["ID"] = compromisso.Id;
                linha["Assunto"] = compromisso.Assunto;
                linha["Local"] = compromisso.Local;
                linha["Data de Início"] = compromisso.InicioDoCompromisso;
                linha["Data de Conclusão"] = compromisso.FimDoCompromisso;
                linha["Contato"] = compromisso.Contato == null ? "Sem contato" : compromisso.Contato.Nome;

                linhasTarefaConcluido.Rows.Add(linha);
            }
            return linhasTarefaConcluido;
        }

        #region Eventos
        private void dgvCompromissoPassado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvCompromissoPassado.CurrentRow.Cells[0].Value);
            PegarDadosDaTabela(id);
            btnAdicionarCompromisso.Enabled = false;
            btnEditarCompromisso.Enabled = true;
            btnExcluirCompromisso.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void dgvCompromissoFuturo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvCompromissoFuturo.CurrentRow.Cells[0].Value);
            PegarDadosDaTabela(id);
            btnAdicionarCompromisso.Enabled = false;
            btnEditarCompromisso.Enabled = true;
            btnExcluirCompromisso.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void btnEditarCompromisso_Click(object sender, EventArgs e)
        {
            EditarRegistro();
            ConcluirAcao();
        }
        private void btnAdicionarCompromisso_Click(object sender, EventArgs e)
        {
            AdicionarRegistro();
            ConcluirAcao();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConcluirAcao();
        }
        private void btnExcluirCompromisso_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
            ConcluirAcao();
        }
        private void dtFinalFiltro_ValueChanged(object sender, EventArgs e)
        {
            CarregarTodosOsRegistros();
        }
        private void dtInicioFiltro_ValueChanged(object sender, EventArgs e)
        {
            CarregarTodosOsRegistros();
        }
        #endregion
    }
}
