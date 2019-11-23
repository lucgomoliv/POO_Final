﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Deposito : Operacao
    {
        public Deposito(double valor, DateTime d) : base(valor, d) { }

        public override bool atualizar(Conta conta)
        {
            bool aux = conta.GetCategoria().depositar(valor);
            if (aux) conta.SetSaldo(conta.GetSaldo + valor);
            return aux;
        }
    }
}
