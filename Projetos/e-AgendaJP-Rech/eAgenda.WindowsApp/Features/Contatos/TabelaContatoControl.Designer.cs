
namespace eAgenda.WindowsApp.Features.Contatos
{
    partial class TabelaContatoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridContatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContatos
            // 
            this.gridContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContatos.Location = new System.Drawing.Point(0, 0);
            this.gridContatos.Name = "gridContatos";
            this.gridContatos.Size = new System.Drawing.Size(452, 386);
            this.gridContatos.TabIndex = 0;
            // 
            // TabelaContatoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridContatos);
            this.Name = "TabelaContatoControl";
            this.Size = new System.Drawing.Size(452, 386);
            ((System.ComponentModel.ISupportInitialize)(this.gridContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridContatos;
    }
}
