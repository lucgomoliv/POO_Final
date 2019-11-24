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

        /// <summary>
        /// Retorna o Valor e Data da Operação
        /// </summary>
        /// <returns>Valor e Data da Operação</returns>
        public abstract string GetOperacao();


        /// <summary>
        /// Retorna o Valor da Opreação
        /// </summary>
        /// <returns>Valor da Operação</returns>
        public double GetValor()
        {
            return valor;
        }
    }
}
