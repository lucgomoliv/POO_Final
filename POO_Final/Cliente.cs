using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Cliente
    {
        public string nome;
        public string cpf;
        protected Conta[] contas;

        public Cliente(string nome, string cpf, Conta conta)
        {
            this.nome = nome;
            this.cpf = cpf;
            AddConta(conta);
        }
        public Cliente(string nome, string cpf, Conta[] contas)
        {
            this.nome = nome;
            this.cpf = cpf;
            if(contas!=null)
            {
                this.contas = contas;
            }
            
        }

        public string extrato(int numConta)
        {
            string aux=null;

            for (int i = 0; i < this.contas.Length; i++)
            {
                if (contas[i].GetNumero() == numConta)
                {
                    aux = this.contas[i].extrato();
                    return aux;
                }
            }
            return null;
        }

        private void AddConta(Conta conta)
        {
            Conta[] aux = new Conta[contas.Length + 1];
            contas.CopyTo(aux, 0);
            aux[aux.Length - 1] = conta;
            contas = aux;
        }

        public abstract double tarifa(int numConta);


        public abstract double rendimento(int numConta);


    }
}
