using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaPoupanca:ISacavel,IRentavel    
    {
        private double saldo;
        private static double rendimento = 0.01;

        public ContaPoupanca(double saldo)
        {
            this.saldo = saldo;
        }

        /// <summary>
        /// Executa um Saque na Conta
        /// </summary>
        /// <param Valor do Saque="valor"></param>
        /// <returns>(true) = Saque Concluido (false) = Valor do Saque acima do Saldo da conta ou Valor do Saque inválido</returns>
        public bool sacar(double valor)
        {
            if(saldo - valor >= 0 && valor > 0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Executa um Depósito na Conta
        /// </summary>
        /// <param Valor do Depósito="valor"></param>
        /// <returns>(true) = Depósito Concluido (false) = Valor do Depósito inválido</returns>
        public bool depositar(double valor)
        {
            if(valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
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
        /// Retorna os Dados da Conta como String
        /// </summary>
        /// <returns>Dados da Conta</returns>
        public override string ToString()
        {
            return " Rendimento: " + rendimento.ToString() + " Tipo: Conta Poupança";
        }
    }
}
