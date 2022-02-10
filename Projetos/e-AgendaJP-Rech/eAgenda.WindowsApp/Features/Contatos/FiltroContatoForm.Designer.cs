
namespace eAgenda.WindowsApp.Features.Contatos
{
    partial class FiltroContatoForm
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
            this.rdbContatosCargo = new System.Windows.Forms.RadioButton();
            this.rdbContatosEmpresa = new System.Windows.Forms.RadioButton();
            this.rdbTodosContatos = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbContatosCargo
            // 
            this.rdbContatosCargo.AutoSize = true;
            this.rdbContatosCargo.Location = new System.Drawing.Point(30, 103);
            this.rdbContatosCargo.Name = "rdbContatosCargo";
            this.rdbContatosCargo.Size = new System.Drawing.Size(215, 17);
            this.rdbContatosCargo.TabIndex = 11;
            this.rdbContatosCargo.TabStop = true;
            this.rdbContatosCargo.Text = "Visualizar Contatos agrupados por cargo";
            this.rdbContatosCargo.UseVisualStyleBackColor = true;
            // 
            // rdbContatosEmpresa
            // 
            this.rdbContatosEmpresa.AutoSize = true;
            this.rdbContatosEmpresa.Location = new System.Drawing.Point(30, 69);
            this.rdbContatosEmpresa.Name = "rdbContatosEmpresa";
            this.rdbContatosEmpresa.Size = new System.Drawing.Size(228, 17);
            this.rdbContatosEmpresa.TabIndex = 10;
            this.rdbContatosEmpresa.TabStop = true;
            this.rdbContatosEmpresa.Text = "Visualizar Contatos agrupados por empresa";
            this.rdbContatosEmpresa.UseVisualStyleBackColor = true;
            // 
            // rdbTodosContatos
            // 
            this.rdbTodosContatos.AutoSize = true;
            this.rdbTodosContatos.Location = new System.Drawing.Point(30, 35);
            this.rdbTodosContatos.Name = "rdbTodosContatos";
            this.rdbTodosContatos.Size = new System.Drawing.Size(201, 17);
            this.rdbTodosContatos.TabIndex = 9;
            this.rdbTodosContatos.TabStop = true;
            this.rdbTodosContatos.Text = "Visualizar Contatos sem agrupamento";
            this.rdbTodosContatos.UseVisualStyleBackColor = true;
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
            // FiltroContatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 234);
            this.Controls.Add(this.rdbContatosCargo);
            this.Controls.Add(this.rdbContatosEmpresa);
            this.Controls.Add(this.rdbTodosContatos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FiltroContatoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbContatosCargo;
        private System.Windows.Forms.RadioButton rdbContatosEmpresa;
        private System.Windows.Forms.RadioButton rdbTodosContatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
    }
}