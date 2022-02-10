
namespace AgendaJP.WindowsApp.Principal
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAbrirTarefa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAbrirCompromisso = new System.Windows.Forms.Button();
            this.btnAbrirContato = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(247, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(298, 46);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "e-Agenda 5.0";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbrirTarefa
            // 
            this.btnAbrirTarefa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(152)))), ((int)(((byte)(179)))));
            this.btnAbrirTarefa.Location = new System.Drawing.Point(30, 13);
            this.btnAbrirTarefa.Name = "btnAbrirTarefa";
            this.btnAbrirTarefa.Size = new System.Drawing.Size(204, 105);
            this.btnAbrirTarefa.TabIndex = 0;
            this.btnAbrirTarefa.Text = "Gerenciamento de Tarefas";
            this.btnAbrirTarefa.UseVisualStyleBackColor = false;
            this.btnAbrirTarefa.Click += new System.EventHandler(this.btnAbrirTarefa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnAbrirCompromisso);
            this.groupBox1.Controls.Add(this.btnAbrirContato);
            this.groupBox1.Controls.Add(this.btnAbrirTarefa);
            this.groupBox1.Location = new System.Drawing.Point(12, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciadores";
            // 
            // btnAbrirCompromisso
            // 
            this.btnAbrirCompromisso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbrirCompromisso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(152)))), ((int)(((byte)(179)))));
            this.btnAbrirCompromisso.Location = new System.Drawing.Point(526, 13);
            this.btnAbrirCompromisso.Name = "btnAbrirCompromisso";
            this.btnAbrirCompromisso.Size = new System.Drawing.Size(202, 105);
            this.btnAbrirCompromisso.TabIndex = 2;
            this.btnAbrirCompromisso.Text = "Gerenciamento de Compromissos";
            this.btnAbrirCompromisso.UseVisualStyleBackColor = false;
            this.btnAbrirCompromisso.Click += new System.EventHandler(this.btnAbrirCompromisso_Click);
            // 
            // btnAbrirContato
            // 
            this.btnAbrirContato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAbrirContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(152)))), ((int)(((byte)(179)))));
            this.btnAbrirContato.Location = new System.Drawing.Point(278, 13);
            this.btnAbrirContato.Name = "btnAbrirContato";
            this.btnAbrirContato.Size = new System.Drawing.Size(204, 105);
            this.btnAbrirContato.TabIndex = 1;
            this.btnAbrirContato.Text = "Gerenciamento de Contatos";
            this.btnAbrirContato.UseVisualStyleBackColor = false;
            this.btnAbrirContato.Click += new System.EventHandler(this.btnAbrirContato_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::AgendaJP.WindowsApp.Properties.Resources.homenzinho;
            this.pictureBox1.Location = new System.Drawing.Point(223, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cbCores
            // 
            this.cbCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCores.FormattingEnabled = true;
            this.cbCores.Items.AddRange(new object[] {
            "Azul do Futuro",
            "Vermelho Arrojado",
            "Brasil-sil-sil",
            "Padrão"});
            this.cbCores.Location = new System.Drawing.Point(67, 9);
            this.cbCores.Name = "cbCores";
            this.cbCores.Size = new System.Drawing.Size(135, 21);
            this.cbCores.TabIndex = 4;
            this.cbCores.SelectedIndexChanged += new System.EventHandler(this.cbCores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cores:";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCores);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-AgendaJP 5.0";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAbrirTarefa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAbrirContato;
        private System.Windows.Forms.Button btnAbrirCompromisso;
        private System.Windows.Forms.ComboBox cbCores;
        private System.Windows.Forms.Label label1;
    }
}

