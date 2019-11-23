using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaCorrente : ISacavel, ITarifavel
    {
        private double saldo;
        private double limitesaque;
        private static double tarifa = 5;

        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
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
            else return false;
        }

        public bool sacar(double valor)
        {
            if (valor > 0)
            {
                saldo -= valor;
                return true;
            }
            else return false;
        }
    }
}
