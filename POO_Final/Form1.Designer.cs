namespace POO_Final
{
    partial class Form1
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
            this.ImportClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImportClientes
            // 
            this.ImportClientes.Location = new System.Drawing.Point(867, 391);
            this.ImportClientes.Name = "ImportClientes";
            this.ImportClientes.Size = new System.Drawing.Size(109, 23);
            this.ImportClientes.TabIndex = 1;
            this.ImportClientes.Text = "Importar Arquivo";
            this.ImportClientes.UseVisualStyleBackColor = true;
            this.ImportClientes.Click += new System.EventHandler(this.ImportClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 511);
            this.Controls.Add(this.ImportClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ImportClientes;
    }
}

