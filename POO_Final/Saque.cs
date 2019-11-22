using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Saque : Operacao
    {

        public Saque(double valor, DateTime d):base(valor,d)
        {

        }

        public override bool atualizar(Conta conta)
        {
            if(conta.SetSaldoSaque(valor))
            {
                return true;
            }
            return false;
        }
    
    }
}
