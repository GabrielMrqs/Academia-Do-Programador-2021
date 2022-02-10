using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        private ControladorContato controlador;
        public TelaCompromissoForm()
        {
            controlador = new ControladorContato();
            InitializeComponent();
            PopularComboBox();
        }
        public Compromisso Compromisso
        {
            get { return compromisso; }

            set
            {
                compromisso = value;

                txtId.Text = compromisso.Id.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLink.Text = compromisso.Link;
                txtLocal.Text = compromisso.Local;
                dtData.Value = compromisso.Data;
                mskHoraInicio.Text = compromisso.HoraInicio.ToString();
                mskHoraFim.Text = compromisso.HoraTermino.ToString();
            }
        }

        private void PopularComboBox()
        {
            List<Contato> contatos = controlador.SelecionarTodos();

            foreach (Contato contato in contatos)
            {
                cbContatos.Items.Add(contato);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string assunto = txtAssunto.Text;
            string link = txtLink.Text;
            string local = txtLocal.Text;
            DateTime data = dtData.Value;
            TimeSpan horaInicio = TimeSpan.Parse(mskHoraInicio.Text);
            TimeSpan horaFinal = TimeSpan.Parse(mskHoraFim.Text);
            Contato contato = (Contato)cbContatos.SelectedItem;

            compromisso = new Compromisso(assunto, local, link, data, horaInicio, horaFinal, contato);

            string resultadoValidacao = compromisso.Validar();

            if (resultadoValidacao != "ESTA_VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCompromissoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocal.Enabled = true;
            txtLink.Enabled = false;
        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtLocal.Enabled = false;
            txtLink.Enabled = true;
        }
    }
}
