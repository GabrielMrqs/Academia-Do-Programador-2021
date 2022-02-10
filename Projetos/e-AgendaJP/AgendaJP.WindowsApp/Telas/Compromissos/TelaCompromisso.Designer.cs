namespace AgendaJP.WindowsApp.Compromissos
{
    partial class TelaCompromisso
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
            this.tbCompromisso = new System.Windows.Forms.TabControl();
            this.tbCompromissoPassado = new System.Windows.Forms.TabPage();
            this.dgvCompromissoPassado = new System.Windows.Forms.DataGridView();
            this.tbCompromissoFuturo = new System.Windows.Forms.TabPage();
            this.dgvCompromissoFuturo = new System.Windows.Forms.DataGridView();
            this.dtDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblPercentual = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnAdicionarCompromisso = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cbContato = new System.Windows.Forms.ComboBox();
            this.mskHoraTermino = new System.Windows.Forms.MaskedTextBox();
            this.mskHoraInicio = new System.Windows.Forms.MaskedTextBox();
            this.dtInicioFiltro = new System.Windows.Forms.DateTimePicker();
            this.dtFinalFiltro = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCompromisso.SuspendLayout();
            this.tbCompromissoPassado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissoPassado)).BeginInit();
            this.tbCompromissoFuturo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissoFuturo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCompromisso
            // 
            this.tbCompromisso.Controls.Add(this.tbCompromissoPassado);
            this.tbCompromisso.Controls.Add(this.tbCompromissoFuturo);
            this.tbCompromisso.Location = new System.Drawing.Point(12, 282);
            this.tbCompromisso.Name = "tbCompromisso";
            this.tbCompromisso.SelectedIndex = 0;
            this.tbCompromisso.Size = new System.Drawing.Size(760, 256);
            this.tbCompromisso.TabIndex = 32;
            // 
            // tbCompromissoPassado
            // 
            this.tbCompromissoPassado.Controls.Add(this.dgvCompromissoPassado);
            this.tbCompromissoPassado.Location = new System.Drawing.Point(4, 22);
            this.tbCompromissoPassado.Name = "tbCompromissoPassado";
            this.tbCompromissoPassado.Padding = new System.Windows.Forms.Padding(3);
            this.tbCompromissoPassado.Size = new System.Drawing.Size(752, 230);
            this.tbCompromissoPassado.TabIndex = 0;
            this.tbCompromissoPassado.Text = "Compromissos Passados";
            this.tbCompromissoPassado.UseVisualStyleBackColor = true;
            // 
            // dgvCompromissoPassado
            // 
            this.dgvCompromissoPassado.AllowUserToAddRows = false;
            this.dgvCompromissoPassado.AllowUserToDeleteRows = false;
            this.dgvCompromissoPassado.AllowUserToResizeColumns = false;
            this.dgvCompromissoPassado.AllowUserToResizeRows = false;
            this.dgvCompromissoPassado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompromissoPassado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromissoPassado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompromissoPassado.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvCompromissoPassado.Location = new System.Drawing.Point(3, 3);
            this.dgvCompromissoPassado.Name = "dgvCompromissoPassado";
            this.dgvCompromissoPassado.ReadOnly = true;
            this.dgvCompromissoPassado.RowHeadersVisible = false;
            this.dgvCompromissoPassado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCompromissoPassado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompromissoPassado.Size = new System.Drawing.Size(746, 224);
            this.dgvCompromissoPassado.TabIndex = 18;
            this.dgvCompromissoPassado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromissoPassado_CellDoubleClick);
            // 
            // tbCompromissoFuturo
            // 
            this.tbCompromissoFuturo.Controls.Add(this.dgvCompromissoFuturo);
            this.tbCompromissoFuturo.Location = new System.Drawing.Point(4, 22);
            this.tbCompromissoFuturo.Name = "tbCompromissoFuturo";
            this.tbCompromissoFuturo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCompromissoFuturo.Size = new System.Drawing.Size(752, 230);
            this.tbCompromissoFuturo.TabIndex = 1;
            this.tbCompromissoFuturo.Text = "Compromissos Futuros";
            this.tbCompromissoFuturo.UseVisualStyleBackColor = true;
            // 
            // dgvCompromissoFuturo
            // 
            this.dgvCompromissoFuturo.AllowUserToAddRows = false;
            this.dgvCompromissoFuturo.AllowUserToDeleteRows = false;
            this.dgvCompromissoFuturo.AllowUserToResizeColumns = false;
            this.dgvCompromissoFuturo.AllowUserToResizeRows = false;
            this.dgvCompromissoFuturo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompromissoFuturo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompromissoFuturo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompromissoFuturo.Location = new System.Drawing.Point(3, 3);
            this.dgvCompromissoFuturo.Name = "dgvCompromissoFuturo";
            this.dgvCompromissoFuturo.ReadOnly = true;
            this.dgvCompromissoFuturo.RowHeadersVisible = false;
            this.dgvCompromissoFuturo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvCompromissoFuturo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompromissoFuturo.Size = new System.Drawing.Size(746, 224);
            this.dgvCompromissoFuturo.TabIndex = 19;
            this.dgvCompromissoFuturo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompromissoFuturo_CellDoubleClick);
            // 
            // dtDataInicio
            // 
            this.dtDataInicio.Location = new System.Drawing.Point(15, 124);
            this.dtDataInicio.Name = "dtDataInicio";
            this.dtDataInicio.Size = new System.Drawing.Size(500, 20);
            this.dtDataInicio.TabIndex = 2;
            // 
            // lblPercentual
            // 
            this.lblPercentual.AutoSize = true;
            this.lblPercentual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentual.Location = new System.Drawing.Point(18, 193);
            this.lblPercentual.Name = "lblPercentual";
            this.lblPercentual.Size = new System.Drawing.Size(78, 20);
            this.lblPercentual.TabIndex = 27;
            this.lblPercentual.Text = "Contato:";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(18, 147);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(146, 20);
            this.lblInicio.TabIndex = 26;
            this.lblInicio.Text = "Horário de Início:";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(15, 101);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(191, 20);
            this.lblDataInicio.TabIndex = 25;
            this.lblDataInicio.Text = "Data do Compromisso:";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermino.Location = new System.Drawing.Point(274, 147);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(167, 20);
            this.lblTermino.TabIndex = 24;
            this.lblTermino.Text = "Horário de Término:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(15, 32);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(500, 20);
            this.txtAssunto.TabIndex = 0;
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(15, 9);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(80, 20);
            this.lblAssunto.TabIndex = 22;
            this.lblAssunto.Text = "Assunto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnExcluirCompromisso);
            this.groupBox1.Controls.Add(this.btnEditarCompromisso);
            this.groupBox1.Controls.Add(this.btnAdicionarCompromisso);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(539, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(3, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(227, 35);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluirCompromisso.Enabled = false;
            this.btnExcluirCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(3, 86);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(227, 35);
            this.btnExcluirCompromisso.TabIndex = 8;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = true;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditarCompromisso.Enabled = false;
            this.btnEditarCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCompromisso.Location = new System.Drawing.Point(3, 51);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(227, 35);
            this.btnEditarCompromisso.TabIndex = 7;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = true;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnAdicionarCompromisso
            // 
            this.btnAdicionarCompromisso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdicionarCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarCompromisso.Location = new System.Drawing.Point(3, 16);
            this.btnAdicionarCompromisso.Name = "btnAdicionarCompromisso";
            this.btnAdicionarCompromisso.Size = new System.Drawing.Size(227, 35);
            this.btnAdicionarCompromisso.TabIndex = 6;
            this.btnAdicionarCompromisso.Text = "Adicionar";
            this.btnAdicionarCompromisso.UseVisualStyleBackColor = true;
            this.btnAdicionarCompromisso.Click += new System.EventHandler(this.btnAdicionarCompromisso_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(15, 78);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(500, 20);
            this.txtLocal.TabIndex = 1;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(15, 55);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(57, 20);
            this.lblLocal.TabIndex = 33;
            this.lblLocal.Text = "Local:";
            // 
            // cbContato
            // 
            this.cbContato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContato.FormattingEnabled = true;
            this.cbContato.Location = new System.Drawing.Point(15, 217);
            this.cbContato.Name = "cbContato";
            this.cbContato.Size = new System.Drawing.Size(500, 21);
            this.cbContato.TabIndex = 5;
            // 
            // mskHoraTermino
            // 
            this.mskHoraTermino.Location = new System.Drawing.Point(277, 170);
            this.mskHoraTermino.Mask = "00:00";
            this.mskHoraTermino.Name = "mskHoraTermino";
            this.mskHoraTermino.Size = new System.Drawing.Size(238, 20);
            this.mskHoraTermino.TabIndex = 4;
            this.mskHoraTermino.Text = "0000";
            // 
            // mskHoraInicio
            // 
            this.mskHoraInicio.Location = new System.Drawing.Point(15, 170);
            this.mskHoraInicio.Mask = "00:00";
            this.mskHoraInicio.Name = "mskHoraInicio";
            this.mskHoraInicio.Size = new System.Drawing.Size(238, 20);
            this.mskHoraInicio.TabIndex = 3;
            this.mskHoraInicio.Text = "0000";
            // 
            // dtInicioFiltro
            // 
            this.dtInicioFiltro.Location = new System.Drawing.Point(6, 36);
            this.dtInicioFiltro.Name = "dtInicioFiltro";
            this.dtInicioFiltro.Size = new System.Drawing.Size(211, 20);
            this.dtInicioFiltro.TabIndex = 34;
            this.dtInicioFiltro.ValueChanged += new System.EventHandler(this.dtInicioFiltro_ValueChanged);
            // 
            // dtFinalFiltro
            // 
            this.dtFinalFiltro.Location = new System.Drawing.Point(6, 82);
            this.dtFinalFiltro.Name = "dtFinalFiltro";
            this.dtFinalFiltro.Size = new System.Drawing.Size(211, 20);
            this.dtFinalFiltro.TabIndex = 35;
            this.dtFinalFiltro.ValueChanged += new System.EventHandler(this.dtFinalFiltro_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtInicioFiltro);
            this.groupBox2.Controls.Add(this.dtFinalFiltro);
            this.groupBox2.Location = new System.Drawing.Point(542, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 111);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro Futuro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data de Término:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Data de Início:";
            // 
            // TelaCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mskHoraInicio);
            this.Controls.Add(this.mskHoraTermino);
            this.Controls.Add(this.cbContato);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.tbCompromisso);
            this.Controls.Add(this.dtDataInicio);
            this.Controls.Add(this.lblPercentual);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCompromisso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaCompromisso";
            this.tbCompromisso.ResumeLayout(false);
            this.tbCompromissoPassado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissoPassado)).EndInit();
            this.tbCompromissoFuturo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompromissoFuturo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbCompromisso;
        private System.Windows.Forms.TabPage tbCompromissoFuturo;
        private System.Windows.Forms.DataGridView dgvCompromissoFuturo;
        private System.Windows.Forms.DateTimePicker dtDataInicio;
        private System.Windows.Forms.Label lblPercentual;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarCompromisso;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cbContato;
        private System.Windows.Forms.TabPage tbCompromissoPassado;
        private System.Windows.Forms.DataGridView dgvCompromissoPassado;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.MaskedTextBox mskHoraTermino;
        private System.Windows.Forms.MaskedTextBox mskHoraInicio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtInicioFiltro;
        private System.Windows.Forms.DateTimePicker dtFinalFiltro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}