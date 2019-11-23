using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Premium : Cliente
    {
        //Todas as contas tem o mesmo desconto
        private static double desconto = 10;

        //Construtor 1
        public Premium(string nome, string cpf, Conta[] conta) : base(nome, cpf, conta) { }

        public Premium(string nome, string cpf) : base(nome, cpf) { }

        //Construtor 2
        public Premium(string nome, string cpf, Conta conta) : base(nome, cpf, conta) { }
        
        /// <summary>
        /// Cáculo da Tarifa da conta com base no cliente 
        /// </summary>
        /// <param Número da conta="numConta"></param>
        /// <returns>(valor>0) = tarifa (valor =-1) = não achou a conta</returns>
        public override double tarifa(int numConta)
        {
            double aux = 0;
            double totaltarifa = 0;
            //Busca a conta que o cliente informou 
            for (int i = 0; i < this.contas.Length; i++)
            {
                if (contas[i].GetNumero() == numConta)
                {
                    //(Valor da tarifa da conta) - (desconto do tipo do cliente)
                    aux = this.contas[i].tarifa();
                    totaltarifa = aux - desconto;
                    //Caso o desconto for maior que a tarifa
                    if(totaltarifa < 0)
                    {
                        totaltarifa = 0;
                    }
                    return totaltarifa;
                }
            }
            return -1;
        }
    }
}
