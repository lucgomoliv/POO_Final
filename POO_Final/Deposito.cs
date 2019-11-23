 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Deposito : Operacao
    {
        public Deposito(double valor, DateTime d) : base(valor, d) { }

        public override bool atualizar(Conta conta)
        {
            if(conta.SetSaldoDeposito(valor))
            {
                return true;
            }
            return false;
        }
    }
}
