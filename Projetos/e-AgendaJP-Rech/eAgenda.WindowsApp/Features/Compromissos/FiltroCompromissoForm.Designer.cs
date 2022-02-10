
namespace eAgenda.WindowsApp.Features.Compromissos
{
    partial class FiltroCompromissoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbCompromissosFuturos = new System.Windows.Forms.RadioButton();
            this.rdbCompromissosPassados = new System.Windows.Forms.RadioButton();
            this.rdbTodosCompromissos = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbCompromissosFuturos
            // 
            this.rdbCompromissosFuturos.AutoSize = true;
            this.rdbCompromissosFuturos.Location = new System.Drawing.Point(30, 103);
            this.rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            this.rdbCompromissosFuturos.Size = new System.Drawing.Size(220, 17);
            this.rdbCompromissosFuturos.TabIndex = 11;
            this.rdbCompromissosFuturos.TabStop = true;
            this.rdbCompromissosFuturos.Text = "Visualizar somente Compromissos Futuros";
            this.rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            this.rdbCompromissosFuturos.CheckedChanged += new System.EventHandler(this.rdbCompromissosFuturos_CheckedChanged);
            // 
            // rdbCompromissosPassados
            // 
            this.rdbCompromissosPassados.AutoSize = true;
            this.rdbCompromissosPassados.Location = new System.Drawing.Point(30, 69);
            this.rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            this.rdbCompromissosPassados.Size = new System.Drawing.Size(231, 17);
            this.rdbCompromissosPassados.TabIndex = 10;
            this.rdbCompromissosPassados.TabStop = true;
            this.rdbCompromissosPassados.Text = "Visualizar somente Compromissos Passados";
            this.rdbCompromissosPassados.UseVisualStyleBackColor = true;
            this.rdbCompromissosPassados.CheckedChanged += new System.EventHandler(this.rdbCompromissosPassados_CheckedChanged);
            // 
            // rdbTodosCompromissos
            // 
            this.rdbTodosCompromissos.AutoSize = true;
            this.rdbTodosCompromissos.Location = new System.Drawing.Point(30, 35);
            this.rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            this.rdbTodosCompromissos.Size = new System.Drawing.Size(182, 17);
            this.rdbTodosCompromissos.TabIndex = 9;
            this.rdbTodosCompromissos.TabStop = true;
            this.rdbTodosCompromissos.Text = "Visualizar todos os Compromissos";
            this.rdbTodosCompromissos.UseVisualStyleBackColor = true;
            this.rdbTodosCompromissos.CheckedChanged += new System.EventHandler(this.rdbTodosCompromissos_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(279, 199);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Location = new System.Drawing.Point(198, 199);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Filtrar";
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // dtInicio
            // 
            this.dtInicio.Enabled = false;
            this.dtInicio.Location = new System.Drawing.Point(72, 126);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(216, 20);
            this.dtInicio.TabIndex = 12;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Location = new System.Drawing.Point(72, 152);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(216, 20);
            this.dtFim.TabIndex = 13;
            this.dtFim.ValueChanged += new System.EventHandler(this.dtFim_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Final:";
            // 
            // FiltroCompromissoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.rdbCompromissosFuturos);
            this.Controls.Add(this.rdbCompromissosPassados);
            this.Controls.Add(this.rdbTodosCompromissos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroCompromissoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCompromissosFuturos;
        private System.Windows.Forms.RadioButton rdbCompromissosPassados;
        private System.Windows.Forms.RadioButton rdbTodosCompromissos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}