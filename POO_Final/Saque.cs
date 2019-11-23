using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    class Saque : Operacao
    {
        //Construtor 
        public Saque(double valor, DateTime data) : base(valor, data) { }

        public override bool atualizar(Conta conta)
        {
            ISacavel auxCat = conta.GetCategoria();
            try
            {
                ITarifavel aux = (ITarifavel)auxCat;
                if (aux.sacar(valor)) conta.SetSaldo(conta.GetSaldo + valor - aux.calcTarifa());
                return true;
            }
            catch(InvalidCastException e)
            {
                if (aux.sacar(valor)) conta.SetSaldo(valor);
                return true;
            }
            return false;
        }
    }
}
