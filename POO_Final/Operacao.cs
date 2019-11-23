using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    public abstract class Operacao
    {
        protected double valor;
        protected DateTime data;

        //Construtor
        public Operacao(double valor, DateTime data)
        {
            if (valor > 0)
            {
                this.valor = valor;
            }
            else
            {
                this.valor = 0;
            }
            this.data = data;
        }

        public abstract bool atualizar(Conta conta);

        public string GetOperacao()
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
