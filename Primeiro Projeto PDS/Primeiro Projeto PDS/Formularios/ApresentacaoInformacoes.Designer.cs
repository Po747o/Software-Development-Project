namespace Primeiro_Projeto_PDS.Formularios
{
    partial class ApresentacaoInformacoes
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
            this.dgvContatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContatos
            // 
            this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatos.Location = new System.Drawing.Point(29, 29);
            this.dgvContatos.Name = "dgvContatos";
            this.dgvContatos.Size = new System.Drawing.Size(730, 393);
            this.dgvContatos.TabIndex = 2;
            // 
            // ApresentacaoInformacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContatos);
            this.Name = "ApresentacaoInformacoes";
            this.Text = "ApresentacaoInformacoes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvContatos;
    }
}