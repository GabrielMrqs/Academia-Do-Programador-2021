using AgendaJP.Controladores.Model;
using AgendaJP.Dominios.Model;
using AgendaJP.WindowsApp.Telas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AgendaJP.WindowsApp.Tarefas
{
    public partial class TelaTarefa : Form, ICrud
    {
        private ControladorTarefa controlador;
        Tarefa tarefaSelecionada;
        public TelaTarefa(ControladorTarefa controlador)
        {
            this.controlador = controlador;
            InitializeComponent();
            CarregarTodosOsRegistros();
        }

        public void AdicionarRegistro()
        {
            string prioridade = cbPrioridade.Text;
            string titulo = txtTitulo.Text;
            DateTime dataInicio = dtDataInicio.Value;
            DateTime dataFinal = dtDataFinal.Value;
            double percentual = Convert.ToDouble(txtPercentual.Text);

            Tarefa tarefa = new Tarefa(prioridade, titulo, dataInicio, dataFinal, percentual);
            if (tarefa.Validar() == "")
            {
                controlador.InserirRegistro(tarefa);
                MessageBox.Show("Registro adicionado com sucesso", "Registro adicionado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(tarefa.Validar(), "Não foi possível adicionar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void EditarRegistro()
        {
            string prioridade = cbPrioridade.Text;
            string titulo = txtTitulo.Text;
            DateTime dataInicio = dtDataInicio.Value;
            DateTime dataFinal = dtDataFinal.Value;
            double percentual = Convert.ToDouble(txtPercentual.Text);

            Tarefa tarefaEditada = new Tarefa(prioridade, titulo, dataInicio, dataFinal, percentual);
            if (tarefaEditada.Validar() == "")
            {
                controlador.EditarRegistro(tarefaEditada, tarefaSelecionada.Id);
                MessageBox.Show("Registro editado com sucesso", "Registro editado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(tarefaEditada.Validar(), "Não foi possível editar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ExcluirRegistro()
        {
            controlador.ExcluirRegistro(tarefaSelecionada.Id);
            MessageBox.Show("Registro excluído com sucesso", "Registro excluído com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void CarregarTodosOsRegistros()
        {
            List<Tarefa> listaTarefaPendente = controlador.VisualizarTarefasPendentes();
            List<Tarefa> listaTarefaConcluido = controlador.VisualizarTarefasFinalizadas();

            dgvTarefaPendente.DataSource = CarregarTarefas(listaTarefaPendente);
            dgvTarefaConcluida.DataSource = CarregarTarefas(listaTarefaConcluido);
        }
        public void PegarDadosDaTabela(int id)
        {
            tarefaSelecionada = controlador.GetById(id);

            txtTitulo.Text = tarefaSelecionada.Titulo;
            txtPercentual.Text = tarefaSelecionada.Percentual.ToString();
            dtDataInicio.Value = tarefaSelecionada.DataCriacao;
            dtDataFinal.Value = tarefaSelecionada.DataConclusao;
            cbPrioridade.Text = tarefaSelecionada.Prioridade;
        }
        public void ApagarCampos()
        {
            txtPercentual.Text = "0";
            txtTitulo.Text = string.Empty;
            cbPrioridade.SelectedItem = null;
            dtDataFinal.Value = DateTime.Now;
            dtDataInicio.Value = DateTime.Now;
        }
        public void ConcluirAcao()
        {
            btnAdicionarTarefa.Enabled = true;
            btnEditarTarefa.Enabled = false;
            btnExcluirTarefa.Enabled = false;
            btnCancelar.Enabled = false;
            dtDataInicio.Enabled = true;
            ApagarCampos();
            CarregarTodosOsRegistros();
        }
        private DataTable CarregarTarefas(List<Tarefa> lista)
        {
            DataTable linhaTarefaConcluida = new DataTable();

            linhaTarefaConcluida.Columns.Add("ID");
            linhaTarefaConcluida.Columns.Add("Titulo");
            linhaTarefaConcluida.Columns.Add("Prioridade");
            linhaTarefaConcluida.Columns.Add("Percentual");
            linhaTarefaConcluida.Columns.Add("Data Criação");
            linhaTarefaConcluida.Columns.Add("Data de Conclusão Estimada");

            foreach (var tarefa in lista)
            {
                var linha = linhaTarefaConcluida.NewRow();

                linha["ID"] = tarefa.Id;
                linha["Titulo"] = tarefa.Titulo;
                linha["Prioridade"] = tarefa.Prioridade;
                linha["Percentual"] = tarefa.Percentual + "%";
                linha["Data Criação"] = tarefa.DataCriacao.ToString("d");
                linha["Data de Conclusão Estimada"] = tarefa.DataConclusao.ToString("d");

                linhaTarefaConcluida.Rows.Add(linha);
            }
            return linhaTarefaConcluida;
        }

        #region Eventos
        private void dgvTarefaPendente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvTarefaPendente.CurrentRow.Cells[0].Value);
            PegarDadosDaTabela(id);
            btnAdicionarTarefa.Enabled = false;
            btnEditarTarefa.Enabled = true;
            btnExcluirTarefa.Enabled = true;
            btnCancelar.Enabled = true;
            dtDataInicio.Enabled = false;
        }
        private void dgvTarefaConcluida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgvTarefaConcluida.CurrentRow.Cells[0].Value);
            PegarDadosDaTabela(id);
            btnAdicionarTarefa.Enabled = false;
            btnEditarTarefa.Enabled = true;
            btnExcluirTarefa.Enabled = true;
            btnCancelar.Enabled = true;
            dtDataInicio.Enabled = false;
        }
        private void btnAdicionarTarefa_Click(object sender, EventArgs e)
        {
            AdicionarRegistro();
            ConcluirAcao();
        }
        private void btnEditarTarefa_Click(object sender, EventArgs e)
        {
            EditarRegistro();
            ConcluirAcao();
        }
        private void btnExcluirTarefa_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
            ConcluirAcao();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ConcluirAcao();
        }
        #endregion
    }
}