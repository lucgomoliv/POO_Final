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

        public ContaInvestimento(double saldo)
        {
            this.saldo = saldo;
        }

        public double calcRendimento(double valor)
        {
            
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
