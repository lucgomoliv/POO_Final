using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Operacao
    {

        
        protected double valor;
        protected DateTime data;

        public Operacao(double valor, DateTime d)
        {
            if (valor>0)
            {
                this.valor = valor;
            }
            else
            {
                this.valor = 0;
            }
            data = d;
        }

        public abstract bool atualizar(Conta conta);

        public  string GetOperacao()
        {
            StringBuilder aux = new StringBuilder();

            aux.AppendLine("Valor: " + valor + " Data: " + data.ToString());
            return aux.ToString();
        }
        public double GetValor()
        {
            return valor;
        }
        

    }
}
