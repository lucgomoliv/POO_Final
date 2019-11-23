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
        private Operacao[] operacoes = new Operacao[1];
        private double saldo = 0;
        private ISacavel categoria;

        /// <summary>
        /// Retorna o Número da Conta
        /// </summary>
        /// <returns>Número da Conta</returns>
        public int GetNumero()
        {
            return numero;
        }

        /// <summary>
        /// Retorna a Categoria da Conta
        /// </summary>
        /// <returns>Categoria da Conta</returns>
        public ISacavel GetCategoria()
        {
            return categoria;
        }

        /// <summary>
        /// Retorna o Saldo da Conta
        /// </summary>
        /// <returns>Saldo da Conta</returns>
        public double GetSaldo()
        {
            return saldo;
        }

        /// <summary>
        /// Insere o Saldo da Conta
        /// </summary>
        /// <param Saldo da Conta="saldo"></param>
        /// <returns></returns>
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

        //Construtor 3
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

        /// <summary>
        /// Executa um Saque na Conta
        /// </summary>
        /// <param Valor do Saque="valor"></param>
        /// <returns>(true) = Saque Concluido (false) = Valor do Saque acima do Saldo da conta ou Valor do Saque inválido</returns>
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

        /// <summary>
        /// Executa um Depósito na Conta
        /// </summary>
        /// <param Valor do Depósito="valor"></param>
        /// <returns>(true) = Depósito Concluido (false) = Valor do Depósito inválido</returns>
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

        /// <summary>
        /// Retorna o Rendimento da Conta 
        /// </summary>
        /// <returns>(valor>0) = rendimento (valor =-1) = não possui rendimento</returns>
        public double rendimento()
        {
            double saldoAnterior = saldo;
            Operacao aux = new Rendimento(0, DateTime.UtcNow);
            if (aux.atualizar(this)) AddOperacao(aux);
            return saldo - saldoAnterior;
        }

        /// <summary>
        /// Calcula a Tarifa da Conta 
        /// </summary>
        /// <returns>(valor>0) = tarifa (valor =-1) = não possui tarifa</returns>
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

        /// <summary>
        /// Retorna os Dados da Conta como String
        /// </summary>
        /// <returns>Dados da Conta</returns>
        public override string ToString()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine("Número da conta: " + numero.ToString() + " Número de operaçoes: " + operacoes.Length + " Saldo: " + saldo);
            aux.AppendLine(categoria.ToString());
            return aux.ToString();
       
        }
    }
}
