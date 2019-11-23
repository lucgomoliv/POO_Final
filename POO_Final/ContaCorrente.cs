using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ContaCorrente:ISacavel,ITarifavel
    {
        private double saldo;
        private double rendimento;

        private double limitesaque;

        public ContaCorrente(double saldo)
        {
            this.saldo = saldo;
        }
        

        public double calcTarifa(double valor)
        {
           
        }

        public bool depositar(double valor)
        {
          
        }

        public bool sacar(double valor)
        {
            
        }
    }
}
