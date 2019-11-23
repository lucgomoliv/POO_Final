using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaInvestimento : ISacavel, IRentavel, ITarifavel
    {
        private double saldo;
        private static double tarifa = 5;
        private static double rendimento = 0.02;

        public ContaInvestimento(double saldo)
        {
            this.saldo = saldo;
        }

        public double calcRendimento(double valor)
        {
            if (valor > 0)
            {
                return valor * rendimento;
            }
            else return 0;
        }

        public double calcTarifa(double valor)
        {
            return tarifa;
        }   

        public bool depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool sacar(double valor)
        {
            if (valor > 0 && saldo - valor > 0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
