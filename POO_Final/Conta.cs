using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Final
{
    public class Conta
    {
        private static int[] numerodascontasBD;
        private static int proximaconta = 0;
        private int numero;
        private Operacao[] operacoes;
        private double saldo = 0;
        private ISacavel categoria;

        public int GetNumero()
        {
            return numero;
        }

        public ISacavel GetCategoria()
        {
            return categoria;
        }

        public double GetSaldo()
        {
            return saldo;
        }

        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        //Construtor 1
        public Conta(int categoria, double saldo, int numero)
        {
            if (AddConta(numero))
            {
                numero = proximaconta;
                proximaconta++;
            }
            Operacao[] operacoes = new Operacao[0];
            ImplementarCategoria(categoria);
            if (saldo > 0)
            {
                this.saldo = saldo;
            }
            else
            {
                saldo = 0;
            }
        }

        //Construtor 2 
        public Conta(int categoria, double saldo)
        {
            numero = proximaconta;
            if (AddConta(numero))
            {

                proximaconta++;
            }
            Operacao[] operacoes = new Operacao[0];
            if (saldo > 0)
            {
                this.saldo = saldo;
            }
            else
            {
                saldo = 0;
            }
            ImplementarCategoria(categoria);
        }

        public Conta(ISacavel categoria, double saldo, int numero)
        {
            this.numero = numero;
            Operacao[] operacoes = new Operacao[0];
            if (categoria != null)
            {
                this.categoria = categoria;
            }

            if (saldo > 0)
            {
                this.saldo = saldo;
            }
            else
            {
                saldo = 0;
            }
        }
        
        /// <summary>
        /// Adiciona uma operacao para o vetor de operacoes da conta
        /// </summary>
        /// <param Operacao="Operacao"></param>
        /// <returns></returns>
        public void AddOperacao(Operacao operacao)
        {
            Operacao[] aux = new Operacao[operacoes.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
            operacoes.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
            aux[aux.Length - 1] = operacao; //O vetor auxiliar recebe a nova operacao no ultimo índice
            operacoes = aux; //O vetor principal recebe o vetor auxiliar
        }

        /// <summary>
        /// Adiciona um numero de conta para o vetor de numeros de conta
        /// </summary>
        /// <param Conta="Conta"></param>
        /// <returns></returns>
        private bool AddConta(int numConta)
        {
            //Validação se houver conta repitida
            foreach(int i in numerodascontasBD)
            {
                if(i==numConta)
                {
                    return false;
                }
                else
                {
                    int[] aux = new int[numerodascontasBD.Length + 1]; //Cria um vetor com mais uma posição referente ao vetor principal
                    numerodascontasBD.CopyTo(aux, 0); //Copia os dados do vetor principal pro vetor auxiliar
                    aux[aux.Length - 1] = numConta; //O vetor auxiliar recebe o novo numero no ultimo índice
                    numerodascontasBD = aux; //O vetor principal recebe o vetor auxiliar
                    
                }
            }
            return true;
        }

        /// <summary>
        /// Implementação de categorias
        /// </summary>
        /// <param inteiro da categoria="categoria"></param>
        public void ImplementarCategoria(int categoria)
        {
            switch (categoria)
            {
                case 1:
                    this.categoria = new ContaCorrente(saldo);
                    break;

                case 2:
                    this.categoria = new ContaInvestimento(saldo);
                    break;

                case 3:
                    this.categoria = new ContaPoupanca(saldo);
                    break;
                default:
                    this.categoria = new ContaPoupanca(saldo);
                    break;
            }
        }

        /// <summary>
        /// Retorna o extrato
        /// </summary>
        /// <returns></returns>
        public string extrato()
        {
            string extrato = string.Empty;
            foreach (var item in this.operacoes)
            {
                extrato += item.GetOperacao() + " \n";
            }
            return extrato;
        }  

        public bool saque(double valor)
        {
            Operacao aux = new Saque(valor, DateTime.UtcNow);
            if (aux.atualizar(this))
            {
                AddOperacao(aux);
                return true;
            }
            return false;
        }

        public bool deposito(double valor)
        {
            Operacao aux = new Deposito(valor, DateTime.UtcNow);
            if (aux.atualizar(this))
            {
                AddOperacao(aux);
                return true;
            }
            return false;
        }

        public double rendimento()
        {
            double saldoAnterior = saldo;
            Operacao aux = new Rendimento(0, DateTime.UtcNow);
            if (aux.atualizar(this)) AddOperacao(aux);
            return saldo - saldoAnterior;
        }
        
        public double tarifa()
        {
            try
            {
                ITarifavel aux = (ITarifavel)categoria;
                return aux.calcTarifa(saldo);
            }
            catch(InvalidCastException e)
            {
                return 0;
            }
        }
    }
}
