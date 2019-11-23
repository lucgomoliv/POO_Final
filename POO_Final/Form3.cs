using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Final
{
    public partial class Form3 : Form
    {
        Form1 form;
        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            Close();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            maskedTextBoxSaldo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!AddConta(textBoxCPF.Text, comboBoxTipo.Text, maskedTextBoxSaldo.Text))
                MessageBox.Show("Não foi possível adicionar o cliente! Por favor verifique os dados inseridos");
            maskedTextBoxSaldo.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        public bool AddConta(string cpf, string categoria, string saldoInicial)
        {
            try
            {
                double saldo = double.Parse(saldoInicial);
                int.Parse(cpf);
                if (form.vetorcontas == null) form.vetorcontas = new Conta[0];
                if (categoria == "Poupança" || categoria == "Investimento" || categoria == "Corrente")
                {
                    Conta[] aux = new Conta[form.vetorcontas.Length + 1];
                    form.vetorcontas.CopyTo(aux, 0);
                    Conta conta;

                    switch (categoria)
                    {
                        case "Poupança": aux[aux.Length - 1] = conta = new Conta(1, saldo); break;
                        case "Investimento": aux[aux.Length - 1] = conta = new Conta(2, saldo); break;
                        case "Corrente": aux[aux.Length - 1] = conta = new Conta(3, saldo); break;
                        default: return false;
                    }

                    for (int i = 0; i < form.vetorclientes.Length; i++)
                    {
                        if (form.vetorclientes[i].cpf == cpf)
                        {
                            form.vetorclientes[i].AddConta(conta);
                            form.vetorcontas = aux;
                            form.AtualizarLista();
                            return true;
                        }
                    }
                    return false;
                }
                else return false;
            }
            catch(FormatException e)
            {
                return false;
            }
            catch (NullReferenceException x)
            {
                return false;
            }
        }
    }
}
