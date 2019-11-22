using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Premium : Cliente
    {
        private double desconto;

        public Premium(string nome, string cpf, Conta[] conta, double desconto) : base(nome, cpf, conta)
        {
            if (desconto > 0)
            {
                this.desconto = desconto;
            }
        }
        public override double rendimento(int numConta)
        {
            double rendimento;
           
            for (int i = 0; i < this.contas.Length; i++)
            {
                if(contas[i].GetNumero()==numConta)
                {
                    rendimento = this.contas[i].rendimento();
                    return rendimento;
                }
            }
          
            return 0;
        }

        public override double tarifa(int numConta)
        {
            double aux = 0;
            double totaltarifa = 0;
            if (numConta > 0)
            {
                aux = this.contas[numConta].tarifa();
                totaltarifa = aux - desconto;
            }
            for (int i = 0; i < this.contas.Length; i++)
            {
                if (contas[i].GetNumero() == numConta)
                {
                    aux = this.contas[i].tarifa();
                    totaltarifa = aux - desconto;
                    return totaltarifa;
                }
            }
            return 0;
        }
    }
}
