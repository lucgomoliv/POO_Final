﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Rendimento : Operacao
    {
        public Rendimento(double valor, DateTime data) : base(valor, data) { }
        public override bool atualizar(Conta conta)
        {
            try
            {
                IRentavel aux = (IRentavel)conta.GetCategoria();
                conta.SetSaldo(aux.calcRendimento(conta.GetSaldo()) + conta.GetSaldo());
                return true;
            }
            catch(InvalidCastException e)
            {
                return false;
            }
        }
    }
}
