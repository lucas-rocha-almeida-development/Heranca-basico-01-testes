using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_basico_01.Entities
{
    internal abstract class ContaBasica
    {
        public int Number { get; private set; }// numero da conta
        public string Holder { get;private set; }// titular da conta

        public double Balance { get;protected set; } // saldo da conta

        //criando construtores
        public ContaBasica()
        {
            //construtor vazio
        }

        public ContaBasica(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //METODOS SAQUE E DEPOSITO
        public void Saque(double quantia) // quantia sera retirada do saldo da conta
        {
            Balance -= quantia + 5.0; //saldo da conta - quantia
        }

        public void Deposito (double quantia)//quantia sera aplicada na conta
        {
            Balance += quantia; //saldo da conta + quantia( depositada)
        }
        public virtual void Sacar(double quantia)
        {
            Balance -= quantia + 5.0;
        }
    }
}
