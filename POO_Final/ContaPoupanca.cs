using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class ContaPoupanca:ISacavel,IRentavel    
    {
        private double saldo;
        private static double rendimento = 0.01;

        public ContaPoupanca(double saldo)
        {
            this.saldo = saldo;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public bool sacar(double valor)
        {
            if(saldo - valor > 0 && valor > 0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool depositar(double valor)
        {
            if(valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }
        public double calcRendimento(double valor)
        {
            if (valor > 0)
            {
                return valor * rendimento;
            }
            else return 0;
        }
    }
}
