
namespace AgendaJP.WindowsApp.Tarefas
{
    partial class TelaTarefa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.btnAdicionarTarefa = new System.Windows.Forms.Button();
            this.tbTarefa = new System.Windows.Forms.TabControl();
            this.tbTarefaPendente = new System.Windows.Forms.TabPage();
            this.dgvTarefaPendente = new System.Windows.Forms.DataGridView();
            this.tbTarefaConcluida = new System.Windows.Forms.TabPage();
            this.dgvTarefaConcluida = new System.Windows.Forms.DataGridView();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.dtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tbTarefa.SuspendLayout();
            this.tbTarefaPendente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaPendente)).BeginInit();
            this.tbTarefaConcluida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaConcluida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnExcluirTarefa);
            this.groupBox1.Controls.Add(this.btnEditarTarefa);
            this.groupBox1.Controls.Add(this.btnAdicionarTarefa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(539, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirTarefa.Enabled = false;
            this.btnExcluirTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTarefa.Location = new System.Drawing.Point(3, 86);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(227, 35);
            this.btnExcluirTarefa.TabIndex = 7;
            this.btnExcluirTarefa.Text = "Excluir";
            this.btnExcluirTarefa.UseVisualStyleBackColor = true;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarTarefa.Enabled = false;
            this.btnEditarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarefa.Location = new System.Drawing.Point(3, 51);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(227, 35);
            this.btnEditarTarefa.TabIndex = 6;
            this.btnEditarTarefa.Text = "Editar";
            this.btnEditarTarefa.UseVisualStyleBackColor = true;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // btnAdicionarTarefa
            // 
            this.btnAdicionarTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTarefa.Location = new System.Drawing.Point(3, 16);
            this.btnAdicionarTarefa.Name = "btnAdicionarTarefa";
            this.btnAdicionarTarefa.Size = new System.Drawing.Size(227, 35);
            this.btnAdicionarTarefa.TabIndex = 5;
            this.btnAdicionarTarefa.Text = "Adicionar";
            this.btnAdicionarTarefa.UseVisualStyleBackColor = true;
            this.btnAdicionarTarefa.Click += new System.EventHandler(this.btnAdicionarTarefa_Click);
            // 
            // tbTarefa
            // 
            this.tbTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTarefa.Controls.Add(this.tbTarefaPendente);
            this.tbTarefa.Controls.Add(this.tbTarefaConcluida);
            this.tbTarefa.Location = new System.Drawing.Point(12, 194);
            this.tbTarefa.Name = "tbTarefa";
            this.tbTarefa.SelectedIndex = 0;
            this.tbTarefa.Size = new System.Drawing.Size(760, 344);
            this.tbTarefa.TabIndex = 20;
            // 
            // tbTarefaPendente
            // 
            this.tbTarefaPendente.Controls.Add(this.dgvTarefaPendente);
            this.tbTarefaPendente.Location = new System.Drawing.Point(4, 22);
            this.tbTarefaPendente.Name = "tbTarefaPendente";
            this.tbTarefaPendente.Padding = new System.Windows.Forms.Padding(3);
            this.tbTarefaPendente.Size = new System.Drawing.Size(752, 318);
            this.tbTarefaPendente.TabIndex = 0;
            this.tbTarefaPendente.Text = "Tarefas Pendentes";
            this.tbTarefaPendente.UseVisualStyleBackColor = true;
            // 
            // dgvTarefaPendente
            // 
            this.dgvTarefaPendente.AllowUserToAddRows = false;
            this.dgvTarefaPendente.AllowUserToDeleteRows = false;
            this.dgvTarefaPendente.AllowUserToResizeColumns = false;
            this.dgvTarefaPendente.AllowUserToResizeRows = false;
            this.dgvTarefaPendente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefaPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefaPendente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefaPendente.Location = new System.Drawing.Point(3, 3);
            this.dgvTarefaPendente.Name = "dgvTarefaPendente";
            this.dgvTarefaPendente.ReadOnly = true;
            this.dgvTarefaPendente.RowHeadersVisible = false;
            this.dgvTarefaPendente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvTarefaPendente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefaPendente.Size = new System.Drawing.Size(746, 312);
            this.dgvTarefaPendente.TabIndex = 18;
            this.dgvTarefaPendente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefaPendente_CellDoubleClick);
            // 
            // tbTarefaConcluida
            // 
            this.tbTarefaConcluida.Controls.Add(this.dgvTarefaConcluida);
            this.tbTarefaConcluida.Location = new System.Drawing.Point(4, 22);
            this.tbTarefaConcluida.Name = "tbTarefaConcluida";
            this.tbTarefaConcluida.Padding = new System.Windows.Forms.Padding(3);
            this.tbTarefaConcluida.Size = new System.Drawing.Size(752, 318);
            this.tbTarefaConcluida.TabIndex = 1;
            this.tbTarefaConcluida.Text = "Tarefas Concluídas";
            this.tbTarefaConcluida.UseVisualStyleBackColor = true;
            // 
            // dgvTarefaConcluida
            // 
            this.dgvTarefaConcluida.AllowUserToAddRows = false;
            this.dgvTarefaConcluida.AllowUserToDeleteRows = false;
            this.dgvTarefaConcluida.AllowUserToResizeColumns = false;
            this.dgvTarefaConcluida.AllowUserToResizeRows = false;
            this.dgvTarefaConcluida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTarefaConcluida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefaConcluida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTarefaConcluida.Location = new System.Drawing.Point(3, 3);
            this.dgvTarefaConcluida.Name = "dgvTarefaConcluida";
            this.dgvTarefaConcluida.ReadOnly = true;
            this.dgvTarefaConcluida.RowHeadersVisible = false;
            this.dgvTarefaConcluida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvTarefaConcluida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTarefaConcluida.Size = new System.Drawing.Size(746, 312);
            this.dgvTarefaConcluida.TabIndex = 19;
            this.dgvTarefaConcluida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTarefaConcluida_CellDoubleClick);
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.Location = new System.Drawing.Point(12, 115);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(100, 20);
            this.lblPercentual.TabIndex = 13;
            this.lblPercentual.Text = "Percentual:";
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFinal.Location = new System.Drawing.Point(271, 65);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(167, 20);
            this.lblDataFinal.TabIndex = 11;
            this.lblDataFinal.Text = "Data de Conclusão:\r\n";
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(12, 138);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(235, 20);
            this.txtPercentual.TabIndex = 3;
            this.txtPercentual.Text = "0";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(12, 65);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(126, 20);
            this.lblDataInicio.TabIndex = 9;
            this.lblDataInicio.Text = "Data de Início:";
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Location = new System.Drawing.Point(12, 88);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(235, 20);
            this.dtDataInicio.TabIndex = 1;
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(271, 115);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(95, 20);
            this.lblPrioridade.TabIndex = 7;
            this.lblPrioridade.Text = "Prioridade:";
            // 
            // dtDataFinal
            // 
            this.dtDataFinal.Location = new System.Drawing.Point(271, 88);
            this.dtDataFinal.Name = "dtDataFinal";
            this.dtDataFinal.Size = new System.Drawing.Size(241, 20);
            this.dtDataFinal.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 33);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(500, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(58, 20);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Título:";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Normal",
            "Baixa"});
            this.cbPrioridade.Location = new System.Drawing.Point(271, 138);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(241, 21);
            this.cbPrioridade.TabIndex = 4;
            // 
            // TelaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.tbTarefa);
            this.Controls.Add(this.dtDataFinal);
            this.Controls.Add(this.dtDataInicio);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Tarefas";
            this.groupBox1.ResumeLayout(false);
            this.tbTarefa.ResumeLayout(false);
            this.tbTarefaPendente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaPendente)).EndInit();
            this.tbTarefaConcluida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefaConcluida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbTarefa;
        private System.Windows.Forms.TabPage tbTarefaPendente;
        private System.Windows.Forms.TabPage tbTarefaConcluida;
        private System.Windows.Forms.DataGridView dgvTarefaPendente;
        private System.Windows.Forms.DataGridView dgvTarefaConcluida;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.Button btnAdicionarTarefa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.DateTimePicker dtDataFinal;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbPrioridade;
    }
}