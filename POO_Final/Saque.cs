using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Saque : Operacao
    {
        //Construtor 
        public Saque(double valor, DateTime data) : base(valor, data) { }

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
