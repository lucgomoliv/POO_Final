using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace POO_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 novoForms = new Form1();
            novoForms.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Cliente[] ImportarCliente()
        {
            
            string diretoriocliente = @"‪D:\Desktop\POOClientes.txt";
            string linha = null;
            string[] vetorcliente = new string[3];
            StreamReader arquivo = new StreamReader(diretoriocliente);
            Cliente[] vetorc = new Cliente[0];

            if (File.Exists(diretoriocliente))
            {
                
                while ((linha = arquivo.ReadLine()) != null)
                {
                    vetorcliente = linha.Split(';');
                    if(Convert.ToInt32(vetorcliente[2])==1)
                    {
                        Cliente c = new Regular(vetorcliente[1], vetorcliente[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }
                    else if(Convert.ToInt32(vetorcliente[2]) == 0)
                    {
                        Cliente c = new Qualificado(vetorcliente[1], vetorcliente[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }
                    else if(Convert.ToInt32(vetorcliente[2]) == 2)
                    {
                        Cliente c = new Premium(vetorcliente[1], vetorcliente[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }

                }
            }
            return vetorc;
        }
        public Conta[] ImportarConta()
        {
            string diretorioconta = @"‪D:\Desktop\POOContas.txt";
            string linha = null;
            string[] vetorconta = new string[4];
            StreamReader arquivo = new StreamReader(diretorioconta);
            Conta[] vetorc = new Conta[0];

            if (File.Exists(diretorioconta))
            {
                while ((linha = arquivo.ReadLine()) != null)
                {
                    vetorconta = linha.Split(';');
                    if (Convert.ToInt32(vetorconta[2]) == 1)
                    {
                        Conta c = new ContaPoupanca(vetorconta[1], vetorconta[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }
                    else if (Convert.ToInt32(vetorconta[2]) == 0)
                    {
                        Cliente c = new Qualificado(vetorconta[1], vetorconta[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }
                    else if (Convert.ToInt32(vetorconta[2]) == 2)
                    {
                        Cliente c = new Premium(vetorconta[1], vetorconta[0]);
                        Cliente[] aux = new Cliente[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                        vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                        aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                        vetorc = aux; //O vetor principal recebe o vetor auxiliar
                    }

                }
            }
            return vetorc;

        }
        public void ImportarOperacao()
        {
            string diretoriooperacao = @"‪D:\Desktop\POOoperacoes.txt";
        }

        private void ImportClientes_Click(object sender, EventArgs e)
        {

        }
    }
}
