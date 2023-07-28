using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_basico_01.Entities
{
    //Class Conta empresarial ira herdar atributos e metodos da class conta basica (extender)
    //utilizando : class ( tudo que estiver na outra conta sera herdado).
    internal class ContaEmpresarial :ContaBasica
    {
        public double LoadLimit { get; set; } // limita para emprestimo


        //construtores basicos abaixo
        public ContaEmpresarial() { 
        //construtor vazio
        //opção de criar o objeto sem passar os dados
        }
        public ContaEmpresarial(int number, string holder, double balance,double loadlimit) 
            :base(number,holder,balance)
        {
            LoadLimit= loadlimit;
        }
        
        public void Loan (double quantia)
        {
            if(quantia <= LoadLimit)
            {
                Balance += quantia;
            }
            
        }
            
           
        }

    }

