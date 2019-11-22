using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Conta
    {
        private static int proximaconta;
        private int numero;
        private Operacao[] operacoes;
        private int opindex;
        private double saldo;
        private ISacavel categoria;
        

        public Conta(int categoria)
        {
            ImplementarCategoria(categoria);
            opindex = 0;
        }

        public void ImplementarCategoria(int categoria)
        {
            switch (categoria)
            {
                case 1:
                    this.categoria = new ContaCorrente();
                    break;

                case 2:
                    this.categoria = new ContaInvestimento();
                    break;

                case 3:
                    this.categoria = new ContaPoupanca();
                    break;
                default:
                    this.categoria = new ContaPoupanca();
                    break;
            }

        }
        public string extrato()
        {

        }
        public double rendimento()
        {

        }
        public double tarifa()
        {

        }
        public bool saque(double valor)
        {
            if(categoria.sacar(valor))
            {
                operacoes[opindex] = new Saque(valor,DateTime.UtcNow);
               
                operacoes[opindex].atualizar(this);
                opindex++;
                return true;
            }
            return false;

        }
        public bool deposito(double valor)
        {
            if(valor>0)
            {
                operacoes[opindex] = new Deposito(valor, DateTime.UtcNow);

                operacoes[opindex].atualizar(this);
                opindex++;
                return true;
            }
            return false;

        }
        public int GetNumero()
        {
            return numero;
        }
        
        public bool SetSaldoSaque(double valor)
        {
            if(valor>0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public bool SetSaldoDeposito(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        
        
        
       
                

    }
}
