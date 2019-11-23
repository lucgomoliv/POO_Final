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
            this.textBoxRend = new System.Windows.Forms.TextBox();
            this.textBoxSacar = new System.Windows.Forms.TextBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.buttonDep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxVS = new System.Windows.Forms.TextBox();
            this.textBoxVD = new System.Windows.Forms.TextBox();
            this.NumConta = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // VerificarRend
            // 
            this.VerificarRend.Location = new System.Drawing.Point(293, 378);
            this.VerificarRend.Name = "VerificarRend";
            this.VerificarRend.Size = new System.Drawing.Size(208, 23);
            this.VerificarRend.TabIndex = 3;
            this.VerificarRend.Text = "Verificar Rendimento";
            this.VerificarRend.UseVisualStyleBackColor = true;
            this.VerificarRend.Click += new System.EventHandler(this.VerificarRend_Click);
            // 
            // textBoxRend
            // 
            this.textBoxRend.Location = new System.Drawing.Point(293, 352);
            this.textBoxRend.Name = "textBoxRend";
            this.textBoxRend.Size = new System.Drawing.Size(208, 20);
            this.textBoxRend.TabIndex = 4;
            this.textBoxRend.TextChanged += new System.EventHandler(this.textBoxRend_TextChanged);
            // 
            // textBoxSacar
            // 
            this.textBoxSacar.Location = new System.Drawing.Point(507, 351);
            this.textBoxSacar.Name = "textBoxSacar";
            this.textBoxSacar.Size = new System.Drawing.Size(90, 20);
            this.textBoxSacar.TabIndex = 5;
            // 
            // buttonSacar
            // 
            this.buttonSacar.Location = new System.Drawing.Point(507, 377);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(90, 23);
            this.buttonSacar.TabIndex = 6;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = true;
            // 
            // buttonDep
            // 
            this.buttonDep.Location = new System.Drawing.Point(603, 377);
            this.buttonDep.Name = "buttonDep";
            this.buttonDep.Size = new System.Drawing.Size(90, 23);
            this.buttonDep.TabIndex = 8;
            this.buttonDep.Text = "Deposito";
            this.buttonDep.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(603, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBoxVS
            // 
            this.textBoxVS.Location = new System.Drawing.Point(507, 312);
            this.textBoxVS.Name = "textBoxVS";
            this.textBoxVS.Size = new System.Drawing.Size(90, 20);
            this.textBoxVS.TabIndex = 11;
            // 
            // textBoxVD
            // 
            this.textBoxVD.Location = new System.Drawing.Point(603, 312);
            this.textBoxVD.Name = "textBoxVD";
            this.textBoxVD.Size = new System.Drawing.Size(90, 20);
            this.textBoxVD.TabIndex = 12;
            // 
            // NumConta
            // 
            this.NumConta.AutoSize = true;
            this.NumConta.Location = new System.Drawing.Point(522, 335);
            this.NumConta.Name = "NumConta";
            this.NumConta.Size = new System.Drawing.Size(60, 13);
            this.NumConta.TabIndex = 13;
            this.NumConta.Text = "Num.Conta";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(534, 296);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(31, 13);
            this.labelV.TabIndex = 14;
            this.labelV.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Num.Conta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Num.Conta";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1289, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelV);
            this.Controls.Add(this.NumConta);
            this.Controls.Add(this.textBoxVD);
            this.Controls.Add(this.textBoxVS);
            this.Controls.Add(this.buttonDep);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSacar);
            this.Controls.Add(this.textBoxSacar);
            this.Controls.Add(this.textBoxRend);
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
        private System.Windows.Forms.TextBox textBoxRend;
        private System.Windows.Forms.TextBox textBoxSacar;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Button buttonDep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxVS;
        private System.Windows.Forms.TextBox textBoxVD;
        private System.Windows.Forms.Label NumConta;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

