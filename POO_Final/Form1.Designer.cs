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
            this.Impot_Client = new System.Windows.Forms.Button();
            this.listBoxC = new System.Windows.Forms.ListBox();
            this.listBoxCO = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Impot_Client
            // 
            this.Impot_Client.Location = new System.Drawing.Point(904, 376);
            this.Impot_Client.Name = "Impot_Client";
            this.Impot_Client.Size = new System.Drawing.Size(214, 23);
            this.Impot_Client.TabIndex = 0;
            this.Impot_Client.Text = "Importar Clientes";
            this.Impot_Client.UseVisualStyleBackColor = true;
            this.Impot_Client.Click += new System.EventHandler(this.Impot_Client_Click);
            // 
            // listBoxC
            // 
            this.listBoxC.FormattingEnabled = true;
            this.listBoxC.Location = new System.Drawing.Point(25, 12);
            this.listBoxC.Name = "listBoxC";
            this.listBoxC.Size = new System.Drawing.Size(1200, 69);
            this.listBoxC.TabIndex = 1;
            this.listBoxC.SelectedIndexChanged += new System.EventHandler(this.listBoxC_SelectedIndexChanged);
            // 
            // listBoxCO
            // 
            this.listBoxCO.FormattingEnabled = true;
            this.listBoxCO.Location = new System.Drawing.Point(25, 99);
            this.listBoxCO.Name = "listBoxCO";
            this.listBoxCO.Size = new System.Drawing.Size(1200, 82);
            this.listBoxCO.TabIndex = 2;
            this.listBoxCO.SelectedIndexChanged += new System.EventHandler(this.listBoxCO_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1289, 488);
            this.Controls.Add(this.listBoxCO);
            this.Controls.Add(this.listBoxC);
            this.Controls.Add(this.Impot_Client);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ImportClientes;
        private System.Windows.Forms.ListBox ListboxClientes;
        private System.Windows.Forms.Button Impot_Client;
        private System.Windows.Forms.ListBox listBoxC;
        private System.Windows.Forms.ListBox listBoxCO;
    }
}

