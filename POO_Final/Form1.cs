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
        StreamReader arquivo;
        public Cliente[] vetorclientes;
        public Conta[] vetorcontas;
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
            
            string diretoriocliente = @"..\..\Dados\POOClientes.txt";
            string linha = null;
            string[] vetorcliente = new string[3];
            arquivo = new StreamReader(diretoriocliente);
            Cliente[] vetorc = new Cliente[0];

            if (File.Exists(diretoriocliente))
            {
                
                while ((linha = arquivo.ReadLine()) != null)
                {
                    vetorcliente = linha.Split(';');
                    if(Convert.ToInt32(vetorcliente[2]) == 1)
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
            arquivo.Close();
            return vetorc;
        }
        public Conta[] ImportarConta(Cliente[]clientes)
        {
            string diretorioconta = @"..\..\Dados\POOContas.txt";
            string linha = null;
            string[] vetorconta = new string[4];
            arquivo = new StreamReader(diretorioconta);
            Conta[] vetorc = new Conta[0];

            //Verifica se o arquivo existe
            if (File.Exists(diretorioconta))
            {
                while ((linha = arquivo.ReadLine()) != null)
                {
                    vetorconta = linha.Split(';');
                    if (Convert.ToInt32(vetorconta[1]) == 1)
                    {
                       
                        for (int i = 0; i < clientes.Length; i++)
                        {
                            if (vetorconta[2] == clientes[i].GetCpf())
                            {
                                ISacavel categoria = new ContaPoupanca(Convert.ToDouble(vetorconta[3]));
                                Conta c = new Conta(categoria, Convert.ToDouble(vetorconta[3]), Convert.ToInt32(vetorconta[0]));
                                clientes[i].AddConta(c);
                                Conta[] aux = new Conta[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                                vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                                aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                                vetorc = aux; //O vetor principal recebe o vetor auxiliar
                            }
                        }
                    }
                    else if (Convert.ToInt32(vetorconta[1]) == 2)
                    {

                        for (int i = 0; i < clientes.Length; i++)
                        {
                            if (vetorconta[2] == clientes[i].GetCpf())
                            {
                                ISacavel categoria = new ContaInvestimento(Convert.ToDouble(vetorconta[3]));
                                Conta c = new Conta(categoria, Convert.ToDouble(vetorconta[3]), Convert.ToInt32(vetorconta[0]));
                                clientes[i].AddConta(c);
                                Conta[] aux = new Conta[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                                vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                                aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                                vetorc = aux; //O vetor principal recebe o vetor auxiliar
                            }
                        }
                    }
                    else if (Convert.ToInt32(vetorconta[1]) == 3)
                    {

                        for (int i = 0; i < clientes.Length; i++)
                        {
                            if (vetorconta[2] == clientes[i].GetCpf())
                            {
                                ISacavel categoria = new ContaCorrente(Convert.ToDouble(vetorconta[3]));
                                Conta c = new Conta(categoria, Convert.ToDouble(vetorconta[3]), Convert.ToInt32(vetorconta[0]));
                                clientes[i].AddConta(c);
                                Conta[] aux = new Conta[vetorc.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                                vetorc.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                                aux[aux.Length - 1] = c; //O vetor auxiliar recebe a nova conta no ultimo índice
                                vetorc = aux; //O vetor principal recebe o vetor auxiliar
                            }
                        }
                    }

                }
            }
            arquivo.Close();
            return vetorc;

        }
        public void ImportarOperacao(Conta[]contas)
        {
            string diretoriooperacao = @"..\..\Dados\POOoperacoes.txt";
            
            string linha = null;
            string[] vetoroperacoes = new string[4];
            arquivo = new StreamReader(diretoriooperacao);

            if (File.Exists(diretoriooperacao))
            {
                while ((linha = arquivo.ReadLine()) != null)
                {
                    vetoroperacoes = linha.Split(';');        
                    if (Convert.ToInt32(vetoroperacoes[1]) == 1)
                    {
                        
                        for (int i = 0; i < contas.Length; i++)
                        {
                            if (vetoroperacoes[0] == contas[i].GetNumero().ToString())
                            {
                                Operacao o = new Saque(Convert.ToInt32(vetoroperacoes[2]), Convert.ToDateTime(vetoroperacoes[3]));
                                contas[i].AddOperacao(o);
                            }
                        }
                    }
                    else if (Convert.ToInt32(vetoroperacoes[1]) == 2)
                    {

                        for (int i = 0; i < contas.Length; i++)
                        {
                            if (vetoroperacoes[0] == contas[i].GetNumero().ToString())
                            {
                                Operacao o = new Deposito(Convert.ToInt32(vetoroperacoes[2]), Convert.ToDateTime(vetoroperacoes[3]));
                                contas[i].AddOperacao(o);
                            }
                        }
                    }
                    else if (Convert.ToInt32(vetoroperacoes[1]) == 3)
                    {

                        for (int i = 0; i < contas.Length; i++)
                        {
                            if (vetoroperacoes[0] == contas[i].GetNumero().ToString())
                            {
                                Operacao o = new Rendimento(Convert.ToInt32(vetoroperacoes[2]), Convert.ToDateTime(vetoroperacoes[3]));
                                contas[i].AddOperacao(o);
                            }
                        }
                    }
                }
            }
        
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
             
        }

        private void Impot_Client_Click(object sender, EventArgs e)
        {
            vetorclientes = ImportarCliente();
            vetorcontas = ImportarConta(vetorclientes);
            ImportarOperacao(vetorcontas);
            foreach (Cliente cliente in vetorclientes)
            {
                listBoxC.Items.Add(cliente.ToString());
            }
            foreach (Conta conta in vetorcontas)
            {
                listBoxCO.Items.Add(conta.ToString());
            }
        }

        private void listBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerificarRend_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < vetorcontas.Length; i++)
                {
                    if (vetorcontas[i].GetNumero() == int.Parse(textBoxNumConta.Text))
                    {
                        
                        MessageBox.Show("A conta rendeu " + vetorcontas[i].rendimento());
                        AtualizarLista();
                        break;
                    }
                }
            }
            catch(FormatException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
        }

        private void textBoxRend_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(this);
            Hide();
            a.Show();
        }

        private void buttonAddConta_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3(this);
            Hide();
            a.Show();
        }

        public void AtualizarLista()
        {
            listBoxC.Items.Clear();
            listBoxCO.Items.Clear();
            if(vetorclientes != null)
            foreach (Cliente cliente in vetorclientes)
            {
                listBoxC.Items.Add(cliente.ToString());
            }
            if(vetorcontas != null)
            foreach (Conta conta in vetorcontas)
            {
                listBoxCO.Items.Add(conta.ToString());
            }
        }

        private void buttonDep_Click(object sender, EventArgs e)
        {

            bool aux = false;
            try
            {
                double valor = double.Parse(textBoxValor.Text);
                for (int i = 0; i < vetorcontas.Length; i++)
                {
                    if (vetorcontas[i].GetNumero() == int.Parse(textBoxNumConta.Text))
                    {
                        if (vetorcontas[i].deposito(valor))
                        {
                            MessageBox.Show("Foi Depositado '" + valor + "' reais da conta de numero '" + vetorcontas[i].GetNumero() + "'");
                            AtualizarLista();
                            aux = true;
                            break;
                        }
                        else
                        {
                            aux = false;

                        }

                    }
                }
                if (aux == false)
                {
                    MessageBox.Show("Não pode ser depositado o valor '" + valor + "' na conta '" + textBoxNumConta.Text + "'");

                }


            }
            catch (FormatException j)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
        }

        private void buttonSacar_Click(object sender, EventArgs e)
        {
            bool aux=false;
            try
            {
                double valor = double.Parse(textBoxValor.Text);
                for (int i = 0; i < vetorcontas.Length; i++)
                {
                    if (vetorcontas[i].GetNumero() == int.Parse(textBoxNumConta.Text))
                    {
                        if(vetorcontas[i].saque(valor))
                        {
                            
                            MessageBox.Show("Foi sacado '" + valor + "' reais da conta de numero '" + vetorcontas[i].GetNumero()+"'");
                            AtualizarLista();
                            aux = true;
                            break;
                        }
                        else
                        {
                            aux = false;
                            
                        }
                        
                    }
                }
                if(aux==false)
                {
                    MessageBox.Show("Não pode ser sacado o valor '" + valor + "' na conta '" + textBoxNumConta.Text+"'");
                   
                }
                
                
            }
            catch (FormatException j)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
        }

        private void buttonExtrato_Click(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < vetorcontas.Length; i++)
                {
                    if (vetorcontas[i].GetNumero() == int.Parse(textBoxNumConta.Text))
                    {
                        MessageBox.Show(vetorcontas[i].extrato());
                        break;
                    }
                }
               
            }
            catch (FormatException j)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
        }

        private void buttonCalcT_Click(object sender, EventArgs e)
        {

            bool aux2 = false;
            try
            {
                double aux = 0;
                double tarifa_final = 0;


                for (int i = 0; i < vetorclientes.Length; i++)
                {

                    Conta[] contas = vetorclientes[i].GetContas();
                    for (int j = 0; j < contas.Length; j++)
                    {

                        if (contas[j].GetNumero() == Convert.ToInt32(textBoxNumConta.Text))
                        {
                            aux = contas[j].tarifa();
                            tarifa_final = aux - vetorclientes[i].GetDesconto();
                            if(tarifa_final<0)
                            {
                                tarifa_final = 0;
                            }
                            aux2 = true;
                            MessageBox.Show("Valor da Tarifa para essa conta/cliente: " + tarifa_final.ToString());
                            break;
                        }


                    }

                }
                if(aux2 == false)
                {
                    MessageBox.Show("Conta não encontrada!");
                }

            }
            catch (FormatException j)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show("Dados invalidos, por favor insira os dados novamente e repita a ação!");
            }


        }
    }
}
