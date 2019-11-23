using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Saque : Operacao
    {
        //Construtor 
        public Saque(double valor, DateTime data) : base(valor, data) { }

        public override bool atualizar(Conta conta)
        {
            if (conta.GetCategoria().sacar(valor))
            {
                conta.SetSaldo(conta.GetSaldo() - valor - conta.tarifa());
                return true;
            }
            else return false;
        }
    }
}
