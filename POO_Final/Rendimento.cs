using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Rendimento : Operacao
    {
        public override bool atualizar(Conta conta)
        {
            if (data.Day == 1)
            {
                conta.rendimento();
            }
            else return false;
        }
     

    }
}
