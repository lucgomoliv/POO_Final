using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaCorrente:ISacavel,ITarifavel
    {
        private double saldo;
        private double rendimento;
        private double limitesaque;
        private static double tarifa = 5;

        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
        }
        

        public double calcTarifa(double valor)
        {
            return valor + tarifa;
        }

        public bool depositar(double valor)
        {
          
        }

        public bool sacar(double valor)
        {
            saldo -= valor;
            return true;
        }
    }
}
