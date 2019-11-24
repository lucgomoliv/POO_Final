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
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            form.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!AddCliente(textBoxNome.Text, textBoxCPF.Text, comboBoxTipo.Text))
                MessageBox.Show("Não foi possível adicionar o cliente! Por favor verifique os dados inseridos");
            else MessageBox.Show("Cliente adicionado com sucesso!");
        }

        private bool AddCliente(string nome, string cpf, string categoria)
        {
            try
            {
                double.Parse(cpf);
                if (form.vetorclientes == null) form.vetorclientes = new Cliente[0];

                if (form.vetorclientes != null)
                {
                    foreach (Cliente cliente in form.vetorclientes)
                    {
                        if (cliente.cpf == cpf) return false;
                    }
                }

                if (categoria == "Qualificado" || categoria == "Regular" || categoria == "Premium")
                {
                    Cliente[] aux = new Cliente[form.vetorclientes.Length + 1];
                    form.vetorclientes.CopyTo(aux, 0);

                    switch (categoria)
                    {
                        case "Qualificado": aux[aux.Length - 1] = new Qualificado(nome, cpf); break;
                        case "Regular": aux[aux.Length - 1] = new Regular(nome, cpf); break;
                        case "Premium": aux[aux.Length - 1] = new Premium(nome, cpf); break;
                        default: return false;
                    }

                    form.vetorclientes = aux;
                }
                else return false;
                Limpar();
                form.AtualizarLista();
                return true;
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

        public void Limpar()
        {
            textBoxNome.Text = "";
            textBoxCPF.Text = "";
            comboBoxTipo.SelectedIndex = -1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
