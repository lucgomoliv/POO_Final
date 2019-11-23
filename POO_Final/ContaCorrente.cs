using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaCorrente : ISacavel, ITarifavel
    {
        private double saldo;
        private double limiteSaque = -1000;
        private static double tarifa = 5;

        //Construtor
        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
        }


        /// <summary>
        /// Retorna a tarifa da Conta
        /// </summary>
        /// <returns>tarifa</returns>
        public double calcTarifa(double valor)
        {
            return tarifa;
        }

        /// <summary>
        /// Executa um Depósito na Conta
        /// </summary>
        /// <param Valor do Depósito="valor"></param>
        /// <returns>(true) = Depósito Concluido (false) = Valor do Depósito inválido</returns>
        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Executa um Saque na Conta
        /// </summary>
        /// <param Valor do Saque="valor"></param>
        /// <returns>(true) = Saque Concluido (false) = Valor do Saque inválido</returns>
        public bool sacar(double valor)
        {
            if (valor > 0 && saldo > limiteSaque)
            {
                saldo -= valor;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Retorna os Dados da Conta como String
        /// </summary>
        /// <returns>Dados da Conta</returns>
        public override string ToString()
        {
            return " Limite Saque: " + limiteSaque.ToString() + " Tipo: Conta Corrente" + " Tarifa: " + tarifa.ToString();
        }

    }
}
