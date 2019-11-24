using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Deposito : Operacao
    {
        string descricao;
        public Deposito(double valor, DateTime d) : base(valor, d) {
            descricao = "D";
        }

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

        public override string GetOperacao()
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine("|Depósito| - Valor: +" + valor + " Data: " + data.ToString());
            return aux.ToString();

        }
    }
}
