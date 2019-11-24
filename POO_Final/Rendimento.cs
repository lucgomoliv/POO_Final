using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Rendimento : Operacao
    {
        string descricao;
        public Rendimento(double valor, DateTime data) : base(valor, data) {

            descricao = "R";
        }

        /// <summary>
        /// Retorna o Rendimento da Conta 
        /// </summary>
        /// <param Conta que será calculado o Rendimento="conta"></param>
        /// <returns>(true) = rendimento Calculado (false) = não possui rendimento ou saldo da conta inválido</returns>
        public override bool atualizar(Conta conta)
        {
            try
            {
                if (data.Day == 1)
                {
                    IRentavel aux = (IRentavel)conta.GetCategoria();
                    conta.SetSaldo(aux.calcRendimento(conta.GetSaldo()) + conta.GetSaldo());
                    return true;
                }
                else return false;
            }
            catch (InvalidCastException e)
            {
                return false;
            }
        }
        public override string GetOperacao()
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine("|Rendimento| - Valor: +" + valor + " Data: " + data.ToString());
            return aux.ToString();

        }
    }
}
