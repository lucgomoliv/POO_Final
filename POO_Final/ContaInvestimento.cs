using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaInvestimento : ISacavel, IRentavel, ITarifavel
    {
        private double saldo;
        private static double tarifa = 5;
        private static double rendimento = 0.02;

        public ContaInvestimento(double saldo)
        {
            this.saldo = saldo;
        }


        /// <summary>
        /// Retorna o Rendimento da Conta 
        /// </summary>
        /// <param Saldo da Conta="valor"></param>
        /// <returns>(valor>0) = rendimento (valor =-1) = não possui rendimento ou saldo da conta inválido</returns>
        public double calcRendimento(double valor)
        {
            if (valor > 0)
            {
                return valor * rendimento;
            }
            else return 0;
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
            return false;
        }

        /// <summary>
        /// Executa um Saque na Conta
        /// </summary>
        /// <param Valor do Saque="valor"></param>
        /// <returns>(true) = Saque Concluido (false) = Valor do Saque inválido</returns>
        public bool sacar(double valor)
        {
            if (valor > 0 && saldo - valor > 0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna os Dados da Conta como String
        /// </summary>
        /// <returns>Dados da Conta</returns>
        public override string ToString()
        {
            return " Rendimento: " + rendimento.ToString() + " Tipo: Conta Investimento" + " Tarifa: " + tarifa.ToString() ;
        }
    }
}
