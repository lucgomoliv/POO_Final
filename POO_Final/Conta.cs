using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Conta
    {
        private static int[] numerodascontasBD;
        private static int proximaconta = 0;
        private int numero;
        private Operacao[] operacoes;
        private double saldo = 0;
        private ISacavel categoria;
        
        
        //Construtor 1
        public Conta(int categoria, double saldo, int numero)
        {
            if(AddConta(numero))
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
            if(saldo > 0)
            {
                this.saldo = saldo;
            }
            else
            {
                saldo = 0;
            }
            ImplementarCategoria(categoria);
        }

        /// <summary>
        /// Adiciona uma operacao para o vetor de operacoes da conta
        /// </summary>
        /// <param Operacao="Operacao"></param>
        /// <returns></returns>
        private void AddOperacao(Operacao operacao)
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
            if(categoria.sacar(valor))
            {
                Operacao aux = new Saque(valor, DateTime.UtcNow);
                AddOperacao(aux);
                aux.atualizar(this);
                return true;
            }
            return false;
        }
        public bool deposito(double valor)
        {
            if (categoria.depositar(valor))
            {
                Operacao aux = new Deposito(valor, DateTime.UtcNow);
                AddOperacao(aux);
                aux.atualizar(this);
                return true;
            }
            return false;
        }

        public double rendimento()
        {
            try
            {
                IRentavel aux = (IRentavel)categoria;
                saldo = aux.calcRendimento(saldo);
                return saldo;
            }
            catch (InvalidCastException e)
            {
                return saldo;
            }
        }

        public double tarifa()
        {

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
