using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_basico_01.Entities
{
    internal  class ContaPoupanca : ContaBasica
    {
        public double InterestRate { get; set; }//TAXA DE JUROS

        //construtores
        public ContaPoupanca()
        {
            //construtor vazio
        }
        //Construtor com argumentos
        public ContaPoupanca(int number, string holder, double balance,double interestRate) 
            :base(number,holder,balance)
        {
            InterestRate = interestRate;
        }
        //metodo de atualizar saldo da conta
        public void UpdateBalance() // atualizar saldo
        {
            Balance += Balance * InterestRate; // saldo * taxa de juros 
        }
        public sealed override void Sacar(double quantia)
        //utilizando o sealed impede que essa operação seja subscrita novamente.
        {
            base.Sacar(quantia);
            Balance-= 2.0;
        }

    }
    
}
