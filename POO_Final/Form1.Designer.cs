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
            this.VerificarRend = new System.Windows.Forms.Button();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.buttonDep = new System.Windows.Forms.Button();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddConta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumConta = new System.Windows.Forms.TextBox();
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.buttonExtrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Impot_Client
            // 
            this.Impot_Client.Location = new System.Drawing.Point(320, 453);
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
            this.listBoxC.Location = new System.Drawing.Point(55, 39);
            this.listBoxC.Name = "listBoxC";
            this.listBoxC.Size = new System.Drawing.Size(725, 69);
            this.listBoxC.TabIndex = 1;
            this.listBoxC.SelectedIndexChanged += new System.EventHandler(this.listBoxC_SelectedIndexChanged);
            // 
            // listBoxCO
            // 
            this.listBoxCO.FormattingEnabled = true;
            this.listBoxCO.Location = new System.Drawing.Point(55, 143);
            this.listBoxCO.Name = "listBoxCO";
            this.listBoxCO.Size = new System.Drawing.Size(725, 82);
            this.listBoxCO.TabIndex = 2;
            this.listBoxCO.SelectedIndexChanged += new System.EventHandler(this.listBoxCO_SelectedIndexChanged);
            // 
            // VerificarRend
            // 
            this.VerificarRend.Location = new System.Drawing.Point(195, 278);
            this.VerificarRend.Name = "VerificarRend";
            this.VerificarRend.Size = new System.Drawing.Size(90, 37);
            this.VerificarRend.TabIndex = 3;
            this.VerificarRend.Text = "Verificar Rendimento";
            this.VerificarRend.UseVisualStyleBackColor = true;
            this.VerificarRend.Click += new System.EventHandler(this.VerificarRend_Click);
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(195, 381);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(90, 37);
            this.buttonSacar.TabIndex = 6;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            this.buttonSacar.Click += new System.EventHandler(this.buttonSacar_Click);
            // 
            // buttonDep
            // 
            this.buttonDep.Location = new System.Drawing.Point(195, 329);
            this.buttonDep.Name = "buttonDep";
            this.buttonDep.Size = new System.Drawing.Size(90, 37);
            this.buttonDep.TabIndex = 8;
            this.buttonDep.Text = "Deposito";
            this.buttonDep.UseVisualStyleBackColor = true;
            this.buttonDep.Click += new System.EventHandler(this.buttonDep_Click);
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(76, 314);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(90, 20);
            this.textBoxValor.TabIndex = 11;
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(106, 298);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(31, 13);
            this.labelV.TabIndex = 14;
            this.labelV.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Num.Conta";
            // 
            // buttonAddConta
            // 
            this.buttonAddConta.Location = new System.Drawing.Point(649, 329);
            this.buttonAddConta.Name = "buttonAddConta";
            this.buttonAddConta.Size = new System.Drawing.Size(82, 54);
            this.buttonAddConta.TabIndex = 18;
            this.buttonAddConta.Text = "Adicionar Conta";
            this.buttonAddConta.UseVisualStyleBackColor = true;
            this.buttonAddConta.Click += new System.EventHandler(this.buttonAddConta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lista de Clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lista de Contas";
            // 
            // textBoxNumConta
            // 
            this.textBoxNumConta.Location = new System.Drawing.Point(76, 363);
            this.textBoxNumConta.Name = "textBoxNumConta";
            this.textBoxNumConta.Size = new System.Drawing.Size(90, 20);
            this.textBoxNumConta.TabIndex = 22;
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.Location = new System.Drawing.Point(550, 329);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(82, 54);
            this.buttonAddCliente.TabIndex = 23;
            this.buttonAddCliente.Text = "Adicionar Cliente";
            this.buttonAddCliente.UseVisualStyleBackColor = true;
            this.buttonAddCliente.Click += new System.EventHandler(this.buttonAddCliente_Click);
            // 
            // buttonExtrato
            // 
            this.buttonExtrato.Location = new System.Drawing.Point(76, 429);
            this.buttonExtrato.Name = "buttonExtrato";
            this.buttonExtrato.Size = new System.Drawing.Size(90, 37);
            this.buttonExtrato.TabIndex = 24;
            this.buttonExtrato.Text = "Extrato";
            this.buttonExtrato.UseVisualStyleBackColor = true;
            this.buttonExtrato.Click += new System.EventHandler(this.buttonExtrato_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(847, 488);
            this.Controls.Add(this.buttonExtrato);
            this.Controls.Add(this.buttonAddCliente);
            this.Controls.Add(this.textBoxNumConta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.buttonDep);
            this.Controls.Add(this.buttonSacar);
            this.Controls.Add(this.VerificarRend);
            this.Controls.Add(this.listBoxCO);
            this.Controls.Add(this.listBoxC);
            this.Controls.Add(this.Impot_Client);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ImportClientes;
        private System.Windows.Forms.ListBox ListboxClientes;
        private System.Windows.Forms.Button Impot_Client;
        private System.Windows.Forms.ListBox listBoxC;
        private System.Windows.Forms.ListBox listBoxCO;
        private System.Windows.Forms.Button VerificarRend;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Button buttonDep;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumConta;
        private System.Windows.Forms.Button buttonAddCliente;
        private System.Windows.Forms.Button buttonExtrato;
    }
}

