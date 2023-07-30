using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heranca_basico_01.Entities;

namespace Heranca_basico_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

         List<ContaBasica>  list= new List<ContaBasica>();

            list.Add(new ContaEmpresarial(1001,"Alex",500.0,0.01));//SavingsAccount (taxa de juros) empresarial
            list.Add (new ContaPoupanca(1002,"Maria",500.0,400.0));//businessAccount (limite de emprestimo) 
            list.Add(new ContaEmpresarial(1003, "Jose", 500.0,0.01));//SavingsAccount(taxa de juros) empresarial
            list.Add(new ContaPoupanca(1004, "Joel", 500.0,500.0));//businessAccount (limite de emprestimo) 

            //vamos totalizar todas as listas
            //somente com superclass generica e possivel percorrer demais contas (empresarial e poupança)
            double soma = 0.0;

            foreach(ContaBasica acc in list)
            {
                soma += acc.Balance; //some todos os balanços percorridos na lista.
            
            }
            Console.WriteLine("Total balanço: "+ soma.ToString("F2",CultureInfo.InvariantCulture));//soma total de todo o saldo das contas no projeto
            
            foreach(ContaBasica acc in list)
            {
                acc.Sacar(10.0); //vamos sacar 10.00 de cada conta de usuario , respeitando taxa de saque e juros
            }

            foreach(ContaBasica acc in list)
            {//vamos mostrar o saldo atualizado de cada conta
                Console.WriteLine("Saldo atualizada para conta: " 
                    + acc.Number + " : " 
                    + acc.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
        }       

        }
    }

