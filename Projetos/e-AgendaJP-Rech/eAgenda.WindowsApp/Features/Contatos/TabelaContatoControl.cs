using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using eAgenda.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Contatos
{
    public partial class TabelaContatoControl : UserControl
    {
        Subro.Controls.DataGridViewGrouper gridContatosAgrupados = new Subro.Controls.DataGridViewGrouper();
        private ControladorContato controladorContato = null;
        public TabelaContatoControl()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
            gridContatos.ConfigurarGridZebrado();
            gridContatos.ConfigurarGridSomenteLeitura();
            gridContatos.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
               {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "E-mail"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Cargo", HeaderText = "Cargo"}
               };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridContatos.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            var contatos = controladorContato.SelecionarTodos();

            CarregarTabela(contatos);
        }

        private void CarregarTabela(List<Contato> contatos)
        {
            gridContatos.DataSource = contatos;

            gridContatosAgrupados = new Subro.Controls.DataGridViewGrouper(gridContatos);
        }

        public void DesagruparContatos()
        {
            var campos = new string[] { "Cargo", "Empresa" };

            gridContatosAgrupados.RemoveGrouping();
            gridContatos.RowHeadersVisible = true;

            foreach (var campo in campos)
                foreach (DataGridViewColumn item in gridContatos.Columns)
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
        }

        public void AgruparContatosPor(string campo)
        {
            gridContatosAgrupados.RemoveGrouping();
            gridContatosAgrupados.SetGroupOn(campo);
            gridContatosAgrupados.Options.ShowGroupName = false;
            gridContatosAgrupados.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in gridContatos.Columns)
                if (item.DataPropertyName == campo)
                    item.Visible = false;

            gridContatos.RowHeadersVisible = false;
            gridContatos.ClearSelection();
        }
    }
}