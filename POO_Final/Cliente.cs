﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    public abstract class Cliente
    {
        public string nome;
        public string cpf;
        protected Conta[] contas=new Conta[0];

        //Construtor 1 
        public Cliente(string nome, string cpf, Conta conta)
        {
            this.nome = nome;
            this.cpf = cpf;
            AddConta(conta);
        }

        //Construtor 2 
        public Cliente(string nome, string cpf, Conta[] contas)
        {
            this.nome = nome;
            this.cpf = cpf;
            if(contas != null)
            {
                this.contas = contas;
            }
        }
        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        /// <summary>
        /// Extrato da conta especificada
        /// </summary>
        /// <param Número da conta="numConta"></param>
        /// <returns>extrato da conta</returns>
        public string extrato(int numConta)
        {
            //Busca no vetor de contas, caso seja o número que o usuário passou retorna o extrato dela
            for (int i = 0; i < this.contas.Length; i++)
            {
                if (contas[i].GetNumero() == numConta)
                {                
                    return this.contas[i].extrato();
                }
            }
            return null;
        }

        /// <summary>
        /// Adiciona uma conta para o vetor de contas do cliente
        /// </summary>
        /// <param Conta="Conta"></param>
        /// <returns></returns>
        public void AddConta(Conta conta)
        {
            Conta[] aux = new Conta[contas.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
            contas.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
            aux[aux.Length - 1] = conta; //O vetor auxiliar recebe a nova conta no ultimo índice
            contas = aux; //O vetor principal recebe o vetor auxiliar
        }

        public abstract double tarifa(int numConta);
        
        /// <summary>
        /// Retorna o rendimento da conta especificada
        /// </summary>
        /// <param Número da conta="numConta"></param>
        /// <returns>(valor>0) = rendimento (valor =-1) = não achou a conta</returns>
        public double rendimento(int numConta)
        {
            //Busca a conta e verifica o rendimento
            for (int i = 0; i < this.contas.Length; i++)
            {
                if (contas[i].GetNumero() == numConta)
                {
                    return this.contas[i].rendimento();
                }
            }
            return -1;
        }

        /// <summary>
        /// Retorna o CPF do Cliente
        /// </summary>
        /// <returns>cpf do cliente</returns>
        public string GetCpf()
        {
            return cpf;
        }

        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine("Nome: " + nome + " CPF: " + cpf + " Número de contas: " + contas.Length.ToString());
            return aux.ToString();
        }

        public Conta[] GetContas()
        {
            return contas;
        }
        public abstract double GetDesconto();
    }
}
