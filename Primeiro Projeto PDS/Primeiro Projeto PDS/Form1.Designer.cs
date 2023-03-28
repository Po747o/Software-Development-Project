namespace Primeiro_Projeto_PDS
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCadastrarContato = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btApresentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarContato
            // 
            this.btCadastrarContato.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarContato.Location = new System.Drawing.Point(74, 211);
            this.btCadastrarContato.Name = "btCadastrarContato";
            this.btCadastrarContato.Size = new System.Drawing.Size(241, 51);
            this.btCadastrarContato.TabIndex = 0;
            this.btCadastrarContato.Text = "CADASTRAR CONTATO";
            this.btCadastrarContato.UseVisualStyleBackColor = true;
            this.btCadastrarContato.Click += new System.EventHandler(this.btCadastrarContato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // btApresentar
            // 
            this.btApresentar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApresentar.Location = new System.Drawing.Point(427, 211);
            this.btApresentar.Name = "btApresentar";
            this.btApresentar.Size = new System.Drawing.Size(241, 51);
            this.btApresentar.TabIndex = 2;
            this.btApresentar.Text = "APRESENTAR CONTATO";
            this.btApresentar.UseVisualStyleBackColor = true;
            this.btApresentar.Click += new System.EventHandler(this.btApresentar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btApresentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCadastrarContato);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarContato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btApresentar;
    }
}

