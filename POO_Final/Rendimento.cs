using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Rendimento : Operacao
    {
        public Rendimento(double valor, DateTime data) : base(valor, data) { }

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
    }
}
