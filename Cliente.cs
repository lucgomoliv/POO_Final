using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Cliente
    {
        //teste
        public string nome;
        public string cpf;
        protected Conta[] contas;

        public Cliente(string n, string cp, Conta[]c)
        {
            n = nome;
            cpf = cp;
            if(c!=null)
            {
                contas = c;
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

        public abstract double tarifa(int numConta);


        public abstract double rendimento(int numConta);


    }
}
