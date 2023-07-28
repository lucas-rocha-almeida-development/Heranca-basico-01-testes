using System;
using System.Collections.Generic;
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
           ContaBasica acc = new ContaBasica(1005,"Kayra Kock",0.0);
            ContaEmpresarial contemp = new ContaEmpresarial(1001, "VivoSa", 0.0, 500.0);

            //USCASTING // CONVERSÃO SUBCLASS PARA SUPERCLASS
            ContaBasica acc1 = contemp;
            ContaBasica acc2 = new ContaEmpresarial(2002, "Luan Almeida", 0.0, 200.0);
            ContaBasica acc3 = new ContaPoupanca(1526,"Guaracy",0.0,0.02);

            //DOWNCASTING // CONVERSÃO SUPERCLASS PARA SUBCLASS
            ContaEmpresarial acc4 = (ContaEmpresarial) acc2;//convertendo implicitamente casting
            acc4.Loan(100.0);
            //ContaEmpresarial acc5 = (ContaEmpresarial)acc3;//erro que o compilador não reconhece
            //somente na execução que ocorrera o erro ( downcasting por ser uma operação insegura)
            if(acc3 is ContaEmpresarial)
            {//acc3 seria uma instancia do contaempresarial

               // ContaEmpresarial acc5 = (ContaEmpresarial) acc3;
               //outra forma do castinng
               ContaEmpresarial acc5 = acc3 as ContaEmpresarial;
                acc5.Loan(500.00);
                Console.WriteLine("Emprestimo");
            }
            if(acc3 is ContaPoupanca) //acc3 seria uma instancia de ContaPoupança?
            {
                //ContaPoupanca acc5 = (ContaPoupanca) acc3;//downcasting
                ContaPoupanca acc5 = acc3 as ContaPoupanca;
                acc5.UpdateBalance();//atualizar update
                Console.WriteLine("Feito Atulização!!");
            }


        }
    }
}
