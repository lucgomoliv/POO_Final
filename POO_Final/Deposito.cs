using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Deposito : Operacao
    {
        public Deposito(double valor, DateTime d) : base(valor, d) { }

        /// <summary>
        /// Executa um Depósito na Conta
        /// </summary>
        /// <param Conta que será feito o Depoósito="conta"></param>
        /// <returns>(true) = Depósito Concluido (false) = Valor do Depósito inválido</returns>
        public override bool atualizar(Conta conta)
        {
            if (conta.GetCategoria().depositar(valor))
            {
                conta.SetSaldo(conta.GetSaldo() + valor);
                return true;
            }
            else return false;
        }
    }
}
