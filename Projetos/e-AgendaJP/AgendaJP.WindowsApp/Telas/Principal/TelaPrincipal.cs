using AgendaJP.Controladores.Model;
using AgendaJP.WindowsApp.Compromissos;
using AgendaJP.WindowsApp.Contatos;
using AgendaJP.WindowsApp.Tarefas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgendaJP.WindowsApp.Principal
{
    public partial class TelaPrincipal : Form
    {
        private ControladorTarefa controladorTarefa = new ControladorTarefa();
        private ControladorContato controladorContato = new ControladorContato();
        private ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirTarefa_Click(object sender, EventArgs e)
        {
            using (TelaTarefa tela = new TelaTarefa(controladorTarefa))
            {
                tela.ShowDialog();
            }
        }

        private void btnAbrirContato_Click(object sender, EventArgs e)
        {
            using (TelaContato tela = new TelaContato(controladorContato, controladorCompromisso))
            {
                tela.ShowDialog();
            }
        }

        private void btnAbrirCompromisso_Click(object sender, EventArgs e)
        {
            using (TelaCompromisso tela = new TelaCompromisso(controladorCompromisso, controladorContato))
            {
                tela.ShowDialog();
            }
        }

        private void cbCores_SelectedIndexChanged(object sender, EventArgs e)
        {
            EscolherCor();
        }

        private void EscolherCor()
        {
            switch (cbCores.Text)
            {
                case "Azul do Futuro":
                    BackColor = Color.CornflowerBlue;
                    btnAbrirCompromisso.BackColor = Color.LightBlue;
                    btnAbrirContato.BackColor = Color.LightBlue;
                    btnAbrirTarefa.BackColor = Color.LightBlue;
                    groupBox1.BackColor = Color.MediumSlateBlue;
                    break;
                case "Vermelho Arrojado":
                    BackColor = Color.IndianRed;
                    btnAbrirCompromisso.BackColor = Color.PaleVioletRed;
                    btnAbrirContato.BackColor = Color.PaleVioletRed;
                    btnAbrirTarefa.BackColor = Color.PaleVioletRed;
                    groupBox1.BackColor = Color.OrangeRed;
                    break;
                case "Brasil-sil-sil":
                    BackColor = Color.LightYellow;
                    btnAbrirCompromisso.BackColor = Color.LightGreen;
                    btnAbrirContato.BackColor = Color.LightGreen;
                    btnAbrirTarefa.BackColor = Color.LightGreen;
                    groupBox1.BackColor = Color.SkyBlue;
                    break;
                case "Padrão":
                    BackColor = SystemColors.GradientActiveCaption;
                    btnAbrirContato.BackColor = SystemColors.ControlLight;
                    btnAbrirTarefa.BackColor = SystemColors.ControlLight;
                    btnAbrirCompromisso.BackColor = SystemColors.ControlLight;
                    groupBox1.BackColor = SystemColors.GradientInactiveCaption;
                    break;
                default: 
                    break;
            }
        }

    }
}
