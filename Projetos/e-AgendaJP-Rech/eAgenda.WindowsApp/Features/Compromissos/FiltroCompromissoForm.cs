using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WindowsApp.Features.Compromissos
{
    public partial class FiltroCompromissoForm : Form
    {
        public FiltroCompromissoForm()
        {
            InitializeComponent();
        }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public FiltroCompromissoEnum TipoFiltro
        {
            get
            {
                if (rdbCompromissosFuturos.Checked)
                    return FiltroCompromissoEnum.CompromissosFuturos;

                else if (rdbCompromissosPassados.Checked)
                    return FiltroCompromissoEnum.CompromissosPassados;

                else
                    return FiltroCompromissoEnum.TodosCompromissos;
            }
        }

        private void dtInicio_ValueChanged(object sender, EventArgs e)
        {
            DataInicio = dtInicio.Value;
        }

        private void dtFim_ValueChanged(object sender, EventArgs e)
        {
            DataFim = dtFim.Value;
        }

        private void rdbCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            dtFim.Enabled = true;
            dtInicio.Enabled = true;
        }

        private void rdbCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            dtFim.Enabled = false;
            dtInicio.Enabled = false;
        }

        private void rdbTodosCompromissos_CheckedChanged(object sender, EventArgs e)
        {
            dtFim.Enabled = false;
            dtInicio.Enabled = false;
        }
    }
}
